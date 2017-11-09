namespace NCDataUpdate
{
    partial class ETLUpdateTaxRate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.btn_loadData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stas = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_resultRecodCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_visibleChanges = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_categoryThree = new System.Windows.Forms.TextBox();
            this.tb_categoryTwo = new System.Windows.Forms.TextBox();
            this.tb_categoryOne = new System.Windows.Forms.TextBox();
            this.tb_commonName = new System.Windows.Forms.TextBox();
            this.tb_goodsCode = new System.Windows.Forms.TextBox();
            this.tb_goodsName = new System.Windows.Forms.TextBox();
            this.tb_companyNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_allData = new System.Windows.Forms.RadioButton();
            this.rb_olderData = new System.Windows.Forms.RadioButton();
            this.rb_newData = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.stas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(6, 20);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowTemplate.Height = 23;
            this.dgv_data.Size = new System.Drawing.Size(885, 635);
            this.dgv_data.TabIndex = 0;
            // 
            // btn_loadData
            // 
            this.btn_loadData.Location = new System.Drawing.Point(693, 51);
            this.btn_loadData.Name = "btn_loadData";
            this.btn_loadData.Size = new System.Drawing.Size(75, 23);
            this.btn_loadData.TabIndex = 1;
            this.btn_loadData.Text = "加载数据";
            this.btn_loadData.UseVisualStyleBackColor = true;
            this.btn_loadData.Click += new System.EventHandler(this.btn_loadData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stas);
            this.groupBox1.Controls.Add(this.dgv_data);
            this.groupBox1.Location = new System.Drawing.Point(13, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 683);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据";
            // 
            // stas
            // 
            this.stas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl_resultRecodCount});
            this.stas.Location = new System.Drawing.Point(3, 658);
            this.stas.Name = "stas";
            this.stas.Size = new System.Drawing.Size(891, 22);
            this.stas.TabIndex = 1;
            this.stas.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabel1.Text = "查询结果数:";
            // 
            // tssl_resultRecodCount
            // 
            this.tssl_resultRecodCount.Name = "tssl_resultRecodCount";
            this.tssl_resultRecodCount.Size = new System.Drawing.Size(15, 17);
            this.tssl_resultRecodCount.Text = "0";
            // 
            // btn_visibleChanges
            // 
            this.btn_visibleChanges.Location = new System.Drawing.Point(798, 51);
            this.btn_visibleChanges.Name = "btn_visibleChanges";
            this.btn_visibleChanges.Size = new System.Drawing.Size(75, 23);
            this.btn_visibleChanges.TabIndex = 3;
            this.btn_visibleChanges.Text = "保存更改";
            this.btn_visibleChanges.UseVisualStyleBackColor = true;
            this.btn_visibleChanges.Click += new System.EventHandler(this.btn_visibleChanges_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_categoryThree);
            this.groupBox2.Controls.Add(this.tb_categoryTwo);
            this.groupBox2.Controls.Add(this.tb_categoryOne);
            this.groupBox2.Controls.Add(this.tb_commonName);
            this.groupBox2.Controls.Add(this.tb_goodsCode);
            this.groupBox2.Controls.Add(this.tb_goodsName);
            this.groupBox2.Controls.Add(this.tb_companyNo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rb_allData);
            this.groupBox2.Controls.Add(this.rb_olderData);
            this.groupBox2.Controls.Add(this.rb_newData);
            this.groupBox2.Controls.Add(this.btn_visibleChanges);
            this.groupBox2.Controls.Add(this.btn_loadData);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(897, 79);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // tb_categoryThree
            // 
            this.tb_categoryThree.Location = new System.Drawing.Point(555, 49);
            this.tb_categoryThree.Name = "tb_categoryThree";
            this.tb_categoryThree.Size = new System.Drawing.Size(120, 21);
            this.tb_categoryThree.TabIndex = 20;
            // 
            // tb_categoryTwo
            // 
            this.tb_categoryTwo.Location = new System.Drawing.Point(757, 17);
            this.tb_categoryTwo.Name = "tb_categoryTwo";
            this.tb_categoryTwo.Size = new System.Drawing.Size(116, 21);
            this.tb_categoryTwo.TabIndex = 19;
            // 
            // tb_categoryOne
            // 
            this.tb_categoryOne.Location = new System.Drawing.Point(555, 18);
            this.tb_categoryOne.Name = "tb_categoryOne";
            this.tb_categoryOne.Size = new System.Drawing.Size(121, 21);
            this.tb_categoryOne.TabIndex = 18;
            // 
            // tb_commonName
            // 
            this.tb_commonName.Location = new System.Drawing.Point(327, 51);
            this.tb_commonName.Name = "tb_commonName";
            this.tb_commonName.Size = new System.Drawing.Size(147, 21);
            this.tb_commonName.TabIndex = 17;
            // 
            // tb_goodsCode
            // 
            this.tb_goodsCode.Location = new System.Drawing.Point(154, 52);
            this.tb_goodsCode.Name = "tb_goodsCode";
            this.tb_goodsCode.Size = new System.Drawing.Size(100, 21);
            this.tb_goodsCode.TabIndex = 16;
            // 
            // tb_goodsName
            // 
            this.tb_goodsName.Location = new System.Drawing.Point(327, 16);
            this.tb_goodsName.Name = "tb_goodsName";
            this.tb_goodsName.Size = new System.Drawing.Size(147, 21);
            this.tb_goodsName.TabIndex = 15;
            // 
            // tb_companyNo
            // 
            this.tb_companyNo.Location = new System.Drawing.Point(154, 16);
            this.tb_companyNo.Name = "tb_companyNo";
            this.tb_companyNo.Size = new System.Drawing.Size(100, 21);
            this.tb_companyNo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "三级分类:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(691, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "二级分类:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "一级分类:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "商品通用名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "商品编号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "商品名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "公司编号:";
            // 
            // rb_allData
            // 
            this.rb_allData.AutoSize = true;
            this.rb_allData.Location = new System.Drawing.Point(6, 57);
            this.rb_allData.Name = "rb_allData";
            this.rb_allData.Size = new System.Drawing.Size(71, 16);
            this.rb_allData.TabIndex = 6;
            this.rb_allData.Text = "全部数据";
            this.rb_allData.UseVisualStyleBackColor = true;
            // 
            // rb_olderData
            // 
            this.rb_olderData.AutoSize = true;
            this.rb_olderData.Location = new System.Drawing.Point(6, 36);
            this.rb_olderData.Name = "rb_olderData";
            this.rb_olderData.Size = new System.Drawing.Size(71, 16);
            this.rb_olderData.TabIndex = 5;
            this.rb_olderData.Text = "原有数据";
            this.rb_olderData.UseVisualStyleBackColor = true;
            // 
            // rb_newData
            // 
            this.rb_newData.AutoSize = true;
            this.rb_newData.Checked = true;
            this.rb_newData.Location = new System.Drawing.Point(7, 16);
            this.rb_newData.Name = "rb_newData";
            this.rb_newData.Size = new System.Drawing.Size(71, 16);
            this.rb_newData.TabIndex = 4;
            this.rb_newData.TabStop = true;
            this.rb_newData.Text = "新增数据";
            this.rb_newData.UseVisualStyleBackColor = true;
            // 
            // ETLUpdateTaxRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 792);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ETLUpdateTaxRate";
            this.Text = "ETL税率更新";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.stas.ResumeLayout(false);
            this.stas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Button btn_loadData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_visibleChanges;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_allData;
        private System.Windows.Forms.RadioButton rb_olderData;
        private System.Windows.Forms.RadioButton rb_newData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_commonName;
        private System.Windows.Forms.TextBox tb_goodsCode;
        private System.Windows.Forms.TextBox tb_goodsName;
        private System.Windows.Forms.TextBox tb_companyNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_categoryThree;
        private System.Windows.Forms.TextBox tb_categoryTwo;
        private System.Windows.Forms.TextBox tb_categoryOne;
        private System.Windows.Forms.StatusStrip stas;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_resultRecodCount;
    }
}

