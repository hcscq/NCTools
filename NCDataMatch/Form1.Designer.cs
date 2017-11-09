namespace NCDataMatch
{
    partial class Form1
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
            this.tb_fileName = new System.Windows.Forms.TextBox();
            this.btn_selFiles = new System.Windows.Forms.Button();
            this.btn_updateStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tc_excelSheet = new System.Windows.Forms.TabControl();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_orderId = new System.Windows.Forms.TextBox();
            this.rb_Excel2003 = new System.Windows.Forms.RadioButton();
            this.rb_Excel2007 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_fileName
            // 
            this.tb_fileName.Location = new System.Drawing.Point(112, 23);
            this.tb_fileName.Name = "tb_fileName";
            this.tb_fileName.Size = new System.Drawing.Size(268, 21);
            this.tb_fileName.TabIndex = 0;
            // 
            // btn_selFiles
            // 
            this.btn_selFiles.Location = new System.Drawing.Point(31, 21);
            this.btn_selFiles.Name = "btn_selFiles";
            this.btn_selFiles.Size = new System.Drawing.Size(75, 23);
            this.btn_selFiles.TabIndex = 1;
            this.btn_selFiles.Text = "选择文件";
            this.btn_selFiles.UseVisualStyleBackColor = true;
            this.btn_selFiles.Click += new System.EventHandler(this.btn_selFiles_Click);
            // 
            // btn_updateStart
            // 
            this.btn_updateStart.Location = new System.Drawing.Point(674, 23);
            this.btn_updateStart.Name = "btn_updateStart";
            this.btn_updateStart.Size = new System.Drawing.Size(75, 23);
            this.btn_updateStart.TabIndex = 2;
            this.btn_updateStart.Text = "开始更新";
            this.btn_updateStart.UseVisualStyleBackColor = true;
            this.btn_updateStart.Click += new System.EventHandler(this.btn_updateStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tc_excelSheet);
            this.groupBox1.Location = new System.Drawing.Point(31, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 600);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EXCEL数据";
            // 
            // tc_excelSheet
            // 
            this.tc_excelSheet.Location = new System.Drawing.Point(6, 20);
            this.tc_excelSheet.Name = "tc_excelSheet";
            this.tc_excelSheet.SelectedIndex = 0;
            this.tc_excelSheet.Size = new System.Drawing.Size(706, 574);
            this.tc_excelSheet.TabIndex = 5;
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(6, 20);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_log.Size = new System.Drawing.Size(293, 574);
            this.tb_log.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_log);
            this.groupBox2.Location = new System.Drawing.Point(756, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 600);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(760, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "匹配结果单号:";
            // 
            // tb_orderId
            // 
            this.tb_orderId.Location = new System.Drawing.Point(850, 22);
            this.tb_orderId.Name = "tb_orderId";
            this.tb_orderId.Size = new System.Drawing.Size(188, 21);
            this.tb_orderId.TabIndex = 8;
            // 
            // rb_Excel2003
            // 
            this.rb_Excel2003.AutoSize = true;
            this.rb_Excel2003.Location = new System.Drawing.Point(6, 20);
            this.rb_Excel2003.Name = "rb_Excel2003";
            this.rb_Excel2003.Size = new System.Drawing.Size(77, 16);
            this.rb_Excel2003.TabIndex = 9;
            this.rb_Excel2003.Text = "Excel2003";
            this.rb_Excel2003.UseVisualStyleBackColor = true;
            // 
            // rb_Excel2007
            // 
            this.rb_Excel2007.AutoSize = true;
            this.rb_Excel2007.Checked = true;
            this.rb_Excel2007.Location = new System.Drawing.Point(113, 20);
            this.rb_Excel2007.Name = "rb_Excel2007";
            this.rb_Excel2007.Size = new System.Drawing.Size(77, 16);
            this.rb_Excel2007.TabIndex = 10;
            this.rb_Excel2007.TabStop = true;
            this.rb_Excel2007.Text = "Excel2007";
            this.rb_Excel2007.UseVisualStyleBackColor = true;

            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_Excel2003);
            this.groupBox3.Controls.Add(this.rb_Excel2007);
            this.groupBox3.Location = new System.Drawing.Point(386, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 44);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Excel格式";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 664);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tb_orderId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_updateStart);
            this.Controls.Add(this.btn_selFiles);
            this.Controls.Add(this.tb_fileName);
            this.Name = "Form1";
            this.Text = "NCDataMatch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_fileName;
        private System.Windows.Forms.Button btn_selFiles;
        private System.Windows.Forms.Button btn_updateStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tc_excelSheet;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_orderId;
        private System.Windows.Forms.RadioButton rb_Excel2003;
        private System.Windows.Forms.RadioButton rb_Excel2007;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

