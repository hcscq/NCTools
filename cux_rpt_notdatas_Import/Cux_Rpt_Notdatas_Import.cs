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
    public partial class Cux_Rpt_Notdatas_Import : Form
    {
        private int MaxOnceUpdateCount = 50;
        private bool Debug = true;
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        Random rand = new Random((int)DateTime.Now.Ticks);
        public Cux_Rpt_Notdatas_Import(string connectionString="")
        {
            NCDataImportContext.ConnectionString = connectionString;
            InitializeComponent();
            openFileDialog.Filter = "*.xls|*.xlsx";
            openFileDialog.FileOk += OpenFileDialog_FileOk;
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            groupBox2.Anchor= AnchorStyles.Bottom |  AnchorStyles.Right | AnchorStyles.Top;
            tc_excelSheet.Dock = DockStyle.Fill;
            tb_log.Dock = DockStyle.Fill;
            cb_debug.Visible = false;
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
                        excelModel.ITEMCODE = row[0].ToString();
                        excelModel.ORG = row[1].ToString();
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
                    this.Invoke(new ButtonSet(() => { btn_selFiles.Enabled = false;btn_updateStart.Enabled = false; cb_debug.Enabled = false; }));
                    Insert(list);
                    this.Invoke(new ButtonSet(() => { btn_selFiles.Enabled = true; btn_updateStart.Enabled = true; cb_debug.Enabled = true; }));
                }));
                WriteLog("开始更新数据.请耐心等候...");
                workThread.Start();
            }
        }
        private void Insert(List<ExcelModel> list)
        {
            int re = 0;
            try
            {
                using (NCDataImportContext dbContext = new NCDataImportContext())
                {
                    WriteLog("开始删除数据.");
                    re=dbContext.ExecuteNonQuery("delete from Cux_Rpt_Notdatas");
                    WriteLog("删除完成.共" + re + "条数据.");
                    //dbContext.Cux_Rpt_Notdatas
                    list = list.Where(it => !string.IsNullOrWhiteSpace(it.ITEMCODE) && !string.IsNullOrWhiteSpace(it.ORG)).ToList();
                    dbContext.Cux_Rpt_Notdatas.AddRange(list.Select(it => new Cux_Rpt_Notdatas { ITEMCODE = it.ITEMCODE, ORG = it.ORG }));
                    WriteLog("开始插入数据.");
                    re =dbContext.SaveChanges();
                    WriteLog("插入数据完成.共" + re + "条数据.");
                }
            }
            catch (Exception e1)
            {
                WriteLog("操作数据库异常：" + e1.Message);
                MessageBox.Show("操作数据库异常：" + e1.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void WriteLog(string log,bool debug=false)
        {
            if (debug == Debug||!debug)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(DateTime.Now.ToLongTimeString());
                sb.Append(log).Append("\r\n");
                tb_log.Text += sb.ToString();
                Logger.WriteLog(sb.Remove(0, 8).ToString(), true);
            }

        }
        delegate void ButtonSet();

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (sender != null)
                ((Button)sender).Enabled = false;
            int re = 0;
            try
            {
                using (NCDataImportContext dbContext = new NCDataImportContext())
                {
                    re=dbContext.ExecuteNonQuery("delete from Cux_Rpt_Notdatas");
                    dbContext.SaveChanges();
                    WriteLog("删除完成.共"+re+"条数据.");
                }
            }
            catch (Exception e1)
            {
                throw new Exception("删除数据出错."+e1.Message);
            }
            if (sender != null)
                ((Button)sender).Enabled = true;
        }
    }
}
