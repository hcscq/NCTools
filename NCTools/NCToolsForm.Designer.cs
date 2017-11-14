namespace NCTools
{
    partial class NCToolsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NCToolsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_updateTaxRate = new System.Windows.Forms.Button();
            this.btn_dataMatch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_updateTaxRate);
            this.groupBox1.Controls.Add(this.btn_dataMatch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能选择";
            // 
            // btn_updateTaxRate
            // 
            this.btn_updateTaxRate.Location = new System.Drawing.Point(55, 103);
            this.btn_updateTaxRate.Name = "btn_updateTaxRate";
            this.btn_updateTaxRate.Size = new System.Drawing.Size(119, 38);
            this.btn_updateTaxRate.TabIndex = 1;
            this.btn_updateTaxRate.Text = "更新税率";
            this.btn_updateTaxRate.UseVisualStyleBackColor = true;
            this.btn_updateTaxRate.Click += new System.EventHandler(this.btn_updateTaxRate_Click);
            // 
            // btn_dataMatch
            // 
            this.btn_dataMatch.Location = new System.Drawing.Point(55, 59);
            this.btn_dataMatch.Name = "btn_dataMatch";
            this.btn_dataMatch.Size = new System.Drawing.Size(119, 38);
            this.btn_dataMatch.TabIndex = 0;
            this.btn_dataMatch.Text = "更新数据库";
            this.btn_dataMatch.UseVisualStyleBackColor = true;
            this.btn_dataMatch.Click += new System.EventHandler(this.btn_dataMatch_Click);
            // 
            // NCToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 261);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NCToolsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NCTools";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_updateTaxRate;
        private System.Windows.Forms.Button btn_dataMatch;
    }
}

