namespace EventLogViewer
{
    partial class GridInformetion
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
            this.TBInfomation = new System.Windows.Forms.TabControl();
            this.Infomation = new System.Windows.Forms.TabPage();
            this.TxBInfomation = new System.Windows.Forms.TextBox();
            this.etc = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TBInfomation.SuspendLayout();
            this.Infomation.SuspendLayout();
            this.etc.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBInfomation
            // 
            this.TBInfomation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBInfomation.Controls.Add(this.Infomation);
            this.TBInfomation.Controls.Add(this.etc);
            this.TBInfomation.Location = new System.Drawing.Point(23, 22);
            this.TBInfomation.Name = "TBInfomation";
            this.TBInfomation.SelectedIndex = 0;
            this.TBInfomation.Size = new System.Drawing.Size(888, 445);
            this.TBInfomation.TabIndex = 0;
            this.TBInfomation.SelectedIndexChanged += new System.EventHandler(this.TBInfomation_SelectedIndexChanged);
            // 
            // Infomation
            // 
            this.Infomation.Controls.Add(this.TxBInfomation);
            this.Infomation.Location = new System.Drawing.Point(4, 22);
            this.Infomation.Name = "Infomation";
            this.Infomation.Padding = new System.Windows.Forms.Padding(3);
            this.Infomation.Size = new System.Drawing.Size(880, 419);
            this.Infomation.TabIndex = 0;
            this.Infomation.Text = "Infomation";
            this.Infomation.UseVisualStyleBackColor = true;
            this.Infomation.Click += new System.EventHandler(this.Infomation_Click);
            // 
            // TxBInfomation
            // 
            this.TxBInfomation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxBInfomation.Location = new System.Drawing.Point(6, 6);
            this.TxBInfomation.Multiline = true;
            this.TxBInfomation.Name = "TxBInfomation";
            this.TxBInfomation.Size = new System.Drawing.Size(868, 397);
            this.TxBInfomation.TabIndex = 0;
            this.TxBInfomation.TextChanged += new System.EventHandler(this.TxBInfomation_TextChanged);
            // 
            // etc
            // 
            this.etc.Controls.Add(this.textBox1);
            this.etc.Location = new System.Drawing.Point(4, 22);
            this.etc.Name = "etc";
            this.etc.Padding = new System.Windows.Forms.Padding(3);
            this.etc.Size = new System.Drawing.Size(880, 419);
            this.etc.TabIndex = 1;
            this.etc.Text = "etc";
            this.etc.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(868, 397);
            this.textBox1.TabIndex = 1;
            // 
            // GridInformetion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 645);
            this.Controls.Add(this.TBInfomation);
            this.MinimumSize = new System.Drawing.Size(963, 683);
            this.Name = "GridInformetion";
            this.Text = "GridInformetion";
            this.Load += new System.EventHandler(this.GridInformetion_Load);
            this.TBInfomation.ResumeLayout(false);
            this.Infomation.ResumeLayout(false);
            this.Infomation.PerformLayout();
            this.etc.ResumeLayout(false);
            this.etc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TBInfomation;
        private System.Windows.Forms.TabPage Infomation;
        private System.Windows.Forms.TabPage etc;
        private System.Windows.Forms.TextBox TxBInfomation;
        private System.Windows.Forms.TextBox textBox1;
    }
}