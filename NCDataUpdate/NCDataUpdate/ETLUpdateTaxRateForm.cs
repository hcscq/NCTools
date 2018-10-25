using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCDataUpdate.Models;
using System.Threading;
using NCTools.Common;
namespace NCDataUpdate
{
    public partial class ETLUpdateTaxRateForm : Form
    {
        delegate void ControlSet();

        private string[] visibleColumns ={
                                    "ORG",
                                    "GOODS_NO",
                                    "GOODS_CODE",
                                    "FULL_NAME",
                                    "COMMON_NAME",
                                    "OUTPUT_TAX",
                                    "SPACETIME_ONE_LEVEL_NAME",
                                    "SPACETIME_TWO_LEVEL_NAME",
                                    "SPACETIME_THREE_LEVEL_NAME",
                                    "UPDATE"
                                 };
        private ColumnHeader[] columnHeader = {
            new ColumnHeader() {Name= "ORG",Text="组织" },
            new ColumnHeader() {Name= "GOODS_NO",Text="商品编码" },
            new ColumnHeader() {Name= "GOODS_CODE",Text="商品编号" },
            new ColumnHeader() {Name= "FULL_NAME",Text="商品名称" },
            new ColumnHeader() {Name= "COMMON_NAME",Text="通用名" },
            new ColumnHeader() {Name= "OUTPUT_TAX",Text="税率" },
            new ColumnHeader() {Name= "SPACETIME_ONE_LEVEL_NAME",Text="一级分类名称" },
            new ColumnHeader() {Name= "SPACETIME_TWO_LEVEL_NAME",Text="二级分类名称" },
            new ColumnHeader() {Name= "SPACETIME_THREE_LEVEL_NAME",Text="三级分类名称" },
            new ColumnHeader() {Name= "UPDATE",Text="更新" }
                                             };
        private List<ColumnHeader> columnHeaderList;
        private string[] editableColumns = { "OUTPUT_TAX","UPDATE" };

        private object oldVal = null;
        public ETLUpdateTaxRateForm(string connectionString = "")
        {
            Context.ConnectionString = connectionString;
            InitializeComponent();
            
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            dgv_data.Dock = DockStyle.Fill;
            dgv_data.CellBeginEdit += Dgv_data_CellBeginEdit;
            dgv_data.CellEndEdit += Dgv_data_CellEndEdit;
            dgv_data.DataError += Dgv_data_DataError;
            dgv_data.DataBindingComplete += Dgv_data_DataBindingComplete;
            columnHeaderList = columnHeader.ToList();
            
            //dgv_data.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void Dgv_data_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            foreach (DataGridViewRow row in dgv_data.Rows) 
                dgv_data.Rows[row.Index].HeaderCell.Value = row.Index.ToString();

            foreach (DataGridViewColumn item in dgv_data.Columns)
            {
                if (item.Visible&& columnHeaderList.Exists(it=>it.Name.Trim()==item.Name.Trim()))
                    dgv_data.Columns[item.Name].HeaderText = columnHeaderList.First(it => it.Name.Trim() == item.Name.Trim()).Text;
            }
            tssl_resultRecodCount.Text = dgv_data.Rows.Count.ToString();
        }

        private void Dgv_data_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "错误");
        }

        private void Dgv_data_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e == null || e.ColumnIndex.Equals(dgv_data.Columns["UPDATE"].Index))
                return;
            oldVal = dgv_data[e.ColumnIndex, e.RowIndex].Value;
        }

        private void Dgv_data_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e==null||e.ColumnIndex.Equals(dgv_data.Columns["UPDATE"].Index))
                return;
            if (oldVal == null)
            {
                if (dgv_data[e.ColumnIndex, e.RowIndex].Value != null)
                    dgv_data[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Gray;
            }
            else
            if (!oldVal.Equals(dgv_data[e.ColumnIndex, e.RowIndex].Value))
                dgv_data[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Gray;
            oldVal = null;
        }

        private void btn_loadData_Click(object sender, EventArgs e)
        {

            Thread thread_loadData = new Thread(new ThreadStart(() =>
            {
                Invoke(new ControlSet(() => { btn_loadData.Enabled = false; btn_loadData.Text = "数据加载中"; }));
                try
                {
                    using (Context dbContext = new Context())
                    {
                        var query = (from q in dbContext.DBASE_ITEM_MSG_ORG.AsNoTracking()
                                     select q);
                        #region set condition
                        if (rb_newData.Checked)
                            query = query.Where(it => it.SHBIT == 0);
                        else if (rb_olderData.Checked)
                            query = query.Where(it=>it.SHBIT!=0);
                        
                        if (!string.IsNullOrWhiteSpace(tb_goodsCode.Text))
                            query = query.Where(it=>it.GOODS_CODE.Equals(tb_goodsCode.Text.Trim()));

                        if (!string.IsNullOrWhiteSpace(tb_goodsName.Text))
                            query = query.Where(it => it.FULL_NAME.Contains(tb_goodsName.Text.Trim()));

                        if (!string.IsNullOrWhiteSpace(tb_commonName.Text))
                            query = query.Where(it => it.COMMON_NAME.Contains(tb_commonName.Text.Trim()));

                        if (!string.IsNullOrWhiteSpace(tb_companyNo.Text))
                            query = query.Where(it => it.ORG.Contains(tb_companyNo.Text.Trim()));

                        if (!string.IsNullOrWhiteSpace(tb_categoryOne.Text))
                            query = query.Where(it => it.SPACETIME_ONE_LEVEL_NAME.Contains(tb_categoryOne.Text.Trim()));

                        if (!string.IsNullOrWhiteSpace(tb_categoryTwo.Text))
                            query = query.Where(it => it.SPACETIME_TWO_LEVEL_NAME.Contains(tb_categoryTwo.Text.Trim()));

                        if (!string.IsNullOrWhiteSpace(tb_categoryThree.Text))
                            query = query.Where(it => it.SPACETIME_THREE_LEVEL_NAME.Contains(tb_categoryThree.Text.Trim()));

                        query = query.OrderBy(it=> new { it.ORG,it.SPACETIME_ONE_LEVEL_NAME,it.SPACETIME_TWO_LEVEL_NAME,it.SPACETIME_THREE_LEVEL_NAME });

                        
                        #endregion
                        #region select new
                        //new
                        //{
                        //    q.ORG,
                        //    q.GOODS_NO,
                        //    q.GOODS_CODE,
                        //    q.FULL_NAME,
                        //    q.COMMON_NAME,
                        //    q.OUTPUT_TAX,
                        //    q.SPACETIME_ONE_LEVEL_NAME,
                        //    q.SPACETIME_TWO_LEVEL_NAME,
                        //    q.SPACETIME_THREE_LEVEL_NAME
                        //}
                        #endregion
                        Invoke(new ControlSet(() =>
                        {
                            dgv_data.DataSource = query.ToList();
                           
                            foreach (DataGridViewColumn it in dgv_data.Columns)
                            {
                                if (!visibleColumns.Contains(it.Name))
                                    dgv_data.Columns[it.Name].Visible = false;
                                if (!editableColumns.Contains(it.Name))
                                    dgv_data.Columns[it.Name].ReadOnly = true;
                            }
                        }));
                    }
                }
                catch (Exception e1)
                {
                    WriteLog(e1.Message);
                    MessageBox.Show(e1.Message);
                }
                Invoke(new ControlSet(() =>
                {
                    btn_loadData.Enabled = true;
                    btn_loadData.Text = "加载数据";
                }));
            }));
            thread_loadData.Start();
        }

        private void btn_visibleChanges_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_data.Enabled = false;
                using (Context context = new Context())
                {
                    var data = ((List<DBASE_ITEM_MSG_ORG>)dgv_data.DataSource).Where(it=>it.UPDATE);
                    if (data.Count() > 0)
                    {
                        List<string> goodsCode = data.Select(it=>it.GOODS_CODE).Distinct().ToList();
                        List<string> company = data.Select(it => it.ORG).Distinct().ToList();

                        var query = (from q in context.DBASE_ITEM_MSG_ORG
                                      where goodsCode.Contains(q.GOODS_CODE)&& company.Contains(q.ORG)
                                      select q).ToList();
                        DBASE_ITEM_MSG_ORG tmpData=null;
                        foreach (var it in data)
                        {
                            tmpData = query.Find(item => item.ORG.Trim().Equals(it.ORG.Trim()) && item.GOODS_CODE.Trim().Equals(it.GOODS_CODE.Trim()));
                            if (tmpData != null)
                            {
                                WriteLog("将更改为.",tmpData);
                                WriteLog("          ", it);
                                tmpData.OUTPUT_TAX = it.OUTPUT_TAX;
                                tmpData.SHBIT = 1;
                                tmpData = null;
                            }
                            else {
                                WriteLog("数据库中未找到匹配项.",it);
                                MessageBox.Show(it.GOODS_CODE+"/"+it.ORG+"\r\n数据库中未找到匹配项.(是否已通过其它途径更改过数据?)", "错误");
                            }
                        }
                        int m=context.SaveChanges();
                        WriteLog("更新总数："+m);
                        dgv_data.DataSource = query;
                    }
                    else MessageBox.Show("没与选取任何数据.","提示");
                }
            }
            catch (Exception E1)
            {
                WriteLog(E1.Message);
                MessageBox.Show(E1.Message);
            }
            dgv_data.Enabled = true;
        }
        private void WriteLog(string message, DBASE_ITEM_MSG_ORG model=null)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.ToLongTimeString());
            if (model != null)
                sb.Append(model.GOODS_CODE).Append("/").Append(model.OUTPUT_TAX).Append("/").Append(model.ORG);
            sb.Append(message).Append("\r\n");
            //tb_log.Text += sb.ToString();
            Logger.WriteLog(sb.Remove(0, 8).ToString(), true);

        }

    }
}
