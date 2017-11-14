using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCDataMatch.Models;
using System.Data.OleDb;
using System.Data.Entity;
using Utils;
using System.IO;
using NCDataMatch.Common;
using System.Threading;
using NCTools.Common;
namespace NCDataMatch
{
    public partial class NCDataMatchForm : Form
    {
        private int MaxOnceUpdateCount = 50;
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        Random rand = new Random((int)DateTime.Now.Ticks);
        public NCDataMatchForm(string connectionString="")
        {
            NCDataMatchContext.ConnectionString = connectionString;
            InitializeComponent();
            openFileDialog.Filter = "*.xls|*.xlsx";
            openFileDialog.FileOk += OpenFileDialog_FileOk;
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            groupBox2.Anchor= AnchorStyles.Bottom |  AnchorStyles.Right | AnchorStyles.Top;
            tc_excelSheet.Dock = DockStyle.Fill;
            tb_log.Dock = DockStyle.Fill;
        }
        private void UpdateData(List<ExcelModel> excelData)
        {
            if (excelData == null || excelData.Count <= 0) return;
            string ID = DateTime.Now.ToString("yyMMddmmss") + (100 + rand.Next() % 899);
            try
            {
                using (NCDataMatchContext dbContext = new NCDataMatchContext())
                {
                    List<string> goodsNo;
                    List<string> orderId;
                    List<ExcelModel> tmpData;
                    for (int i = 0; i <= excelData.Count / MaxOnceUpdateCount; i++)
                    {
                        tmpData = excelData.Skip(i * MaxOnceUpdateCount).Take(MaxOnceUpdateCount).ToList();
                        goodsNo = tmpData.Select(it => it.GoodsNo.Trim()).ToList();
                        orderId = tmpData.Select(it => it.OrderId.Trim()).ToList();

                        var query = (from q in dbContext.BD_MATERIAL
                                     join p in dbContext.IC_SALEOUT_B on q.PK_MATERIAL equals p.CMATERIALOID
                                     join s in dbContext.IC_SALEOUT_E on p.CGENERALBID equals s.CGENERALBID
                                     where p.DR == 0 && q.DR == 0 && orderId.Contains(p.VBDEF5) && goodsNo.Contains(q.CODE)//==r.OrderId
                                     select
                                     new
                                     {
                                         q.CODE,
                                         CMATERIALOID = p.CMATERIALOID,
                                         VBDEF5 = p.VBDEF5,
                                         VBDEF11 = "Y",
                                         s.NSIGNNUM,
                                         p.NNUM
                                     }).AsNoTracking().ToList();
                        foreach (var it in tmpData)
                        {
                            if (!query.Exists(item => item.CODE.Trim() == it.GoodsNo.Trim() && item.VBDEF5.Trim() == it.OrderId.Trim()))
                                WriteLog(it.OrderId + "/" + it.GoodsNo + "/" + "在NC中未找到匹配项.");
                        };
                        decimal  outVal;
                        var query1 = (from q in query
                                      join p in tmpData on new { OrderId = q.VBDEF5, GoodsNo = q.CODE } equals new { OrderId = p.OrderId, GoodsNo = p.GoodsNo }
                                      select new
                                      IC_SALEOUT_B
                                      {
                                          CMATERIALOID = q.CMATERIALOID,
                                          VBDEF5 = q.VBDEF5,
                                          VBDEF12 = p.GoodsAmount,//vbdef13=nvl(nnum,0)-nvl(nsignnum,0)-nvl(vbdef12,0)
                                          VBDEF13 = ((q.NNUM==null?0: q.NNUM) - (decimal.TryParse(p.GoodsAmount,out outVal)?decimal.Parse(p.GoodsAmount):0) - (q.NSIGNNUM==null?0: q.NSIGNNUM)).ToString()
                                      }).ToList();
                        
                        WriteLog("匹配NC编码.(第" + i * MaxOnceUpdateCount + "-" + ((i + 1) * MaxOnceUpdateCount >= excelData.Count ? excelData.Count : (i + 1) * MaxOnceUpdateCount) + "条数据)");
                        goodsNo = query1.Select(it => it.CMATERIALOID).ToList();

                        var query2 = from q in dbContext.IC_SALEOUT_B
                                     where goodsNo.Contains(q.CMATERIALOID) && orderId.Contains(q.VBDEF5)
                                     select q;
                        IC_SALEOUT_B locModel = null;
                       

                        foreach (var it in query2)
                        {
                            locModel = query1.Find(item => item.CMATERIALOID == it.CMATERIALOID && item.VBDEF5 == it.VBDEF5);
                            if (locModel != null)
                            {
                                it.VBDEF11 = ID;
                                it.VBDEF12 = locModel.VBDEF12;
                                it.VBDEF13 = locModel.VBDEF13;
                                locModel = null;
                            }
                        }
                        dbContext.SaveChanges();
                        WriteLog("第" + i * MaxOnceUpdateCount + "-" + ((i + 1) * MaxOnceUpdateCount >= excelData.Count ? excelData.Count : (i + 1) * MaxOnceUpdateCount) + "条数据,更新完成.");
                    }
                    WriteLog("更新结束.(单号:"+ID+")");
                }
            }
            catch (Exception e1)
            {
                WriteLog(e1.Message);
                ID = "异常";
            }
            this.Invoke(new ButtonSet(() => { btn_selFiles.Enabled = true; btn_updateStart.Enabled = true;tb_orderId.Text = ID; }));
        }
        private List<ExcelModel> GetExcelData(string excelPath, ExcelHelper.ExcelVerion excelVer= ExcelHelper.ExcelVerion.Excel2007)
        {
            OleDbConnection Con_Excel = null;
            List<string> sheetName = new List<string>();
            List<ExcelModel> list = new List<ExcelModel>();
            ExcelModel excelModel = null;
            try
            {
                Con_Excel = ExcelHelper.CreateConnection(excelPath, excelVer);
                Con_Excel.Open();
                foreach (DataRow drt in Con_Excel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" }).Rows)
                    sheetName.Add(drt["TABLE_NAME"].ToString());
                DataTable dt = null;
                foreach (var it in sheetName)
                {
                    if (it.Contains("_"))
                    {
                        WriteLog("检查文件" + it + "\r\n是否启用了筛选功能.");
                        continue;
                    }
                    dt = ExcelHelper.ExecuteDataTable(Con_Excel, @"select * from [" + it + "A:E] ", null);
                    if (dt.Rows.Count > 0) tc_excelSheet.TabPages.Add(new TabPageWithGridView(it,tc_excelSheet.Size,dt));
                    foreach (DataRow row in dt.Rows)
                    {
                        excelModel = new ExcelModel();
                        excelModel.GoodsAmount = row["数量"].ToString();
                        excelModel.GoodsNo = row["商品编号"].ToString();
                        excelModel.OrderId = row["相关单据编号"].ToString();
                        list.Add(excelModel);
                    }
                    WriteLog("工作表："+it+"读取成功.");
                }
            }
            catch (Exception e1)
            {
                WriteLog("Excel读取异常：" + e1.Message);
                MessageBox.Show("Excel读取异常：" + e1.Message, "错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return list;
        }

        private void btn_selFiles_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            tc_excelSheet.TabPages.Clear();
            tb_fileName.Text = openFileDialog.FileName;
            if (GetExcelData(tb_fileName.Text, rb_Excel2003.Checked ? ExcelHelper.ExcelVerion.Excel2003 : ExcelHelper.ExcelVerion.Excel2007).Count>0)
            {
                WriteLog(tb_fileName.Text+"加载完成.");
            }
        }

        private void btn_updateStart_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tb_fileName.Text.Trim()) || (!tb_fileName.Text.Trim().EndsWith(".xls") && !tb_fileName.Text.Trim().EndsWith(".xlsx")))
            {
                MessageBox.Show("文件不存在或不是xls或xlsx文件.");
                WriteLog("文件不存在或不是xls或xlsx文件.");
            }
            else
            {
                tc_excelSheet.TabPages.Clear();
                List<ExcelModel> list = GetExcelData(tb_fileName.Text.Trim(),rb_Excel2003.Checked?ExcelHelper.ExcelVerion.Excel2003:ExcelHelper.ExcelVerion.Excel2007);
                if (list.Count <= 0)
                {
                    WriteLog("Excel 解析结果为空.");
                    MessageBox.Show("Excel 解析结果为空.");
                    return;
                }
                //dgv_excelData.DataSource = list;
                Thread workThread = new Thread(new ThreadStart(()=>
                {
                    this.Invoke(new ButtonSet(() => { btn_selFiles.Enabled = false;btn_updateStart.Enabled = false;tb_orderId.Text = ""; }));
                    UpdateData(list);
                }));
                WriteLog("开始更新数据.请耐心等候...");
                workThread.Start();
            }
        }
        private void WriteLog(string log)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToLongTimeString());
            sb.Append(log).Append("\r\n");
            tb_log.Text += sb.ToString();
            Logger.WriteLog(sb.Remove(0,8).ToString(),true);

        }
        delegate void ButtonSet();

    }
}
