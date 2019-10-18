namespace EventLogViewer
{
    partial class EventLogViewer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DGEventLog = new System.Windows.Forms.DataGridView();
            this.LBLogtype = new System.Windows.Forms.Label();
            this.CBApplication = new System.Windows.Forms.CheckBox();
            this.CBSecurity = new System.Windows.Forms.CheckBox();
            this.CBSetup = new System.Windows.Forms.CheckBox();
            this.CBSystem = new System.Windows.Forms.CheckBox();
            this.CBForwarded_Events = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBServerName = new System.Windows.Forms.TextBox();
            this.LabelServerName = new System.Windows.Forms.Label();
            this.ButtonGet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBLocalPC = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LBresult = new System.Windows.Forms.Label();
            this.LBResultCount = new System.Windows.Forms.Label();
            this.TBResultCount = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.PBprogressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.DGEventLog)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGEventLog
            // 
            this.DGEventLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGEventLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGEventLog.Location = new System.Drawing.Point(16, 15);
            this.DGEventLog.Name = "DGEventLog";
            this.DGEventLog.RowTemplate.Height = 21;
            this.DGEventLog.Size = new System.Drawing.Size(984, 469);
            this.DGEventLog.TabIndex = 0;
            this.DGEventLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGEventLog.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGEventLog_CellContentDoubleClick);
            this.DGEventLog.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DGEventLog_DataError);
            // 
            // LBLogtype
            // 
            this.LBLogtype.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLogtype.AutoSize = true;
            this.LBLogtype.Location = new System.Drawing.Point(6, 6);
            this.LBLogtype.Name = "LBLogtype";
            this.LBLogtype.Size = new System.Drawing.Size(45, 12);
            this.LBLogtype.TabIndex = 1;
            this.LBLogtype.Text = "Logtype";
            // 
            // CBApplication
            // 
            this.CBApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBApplication.AutoSize = true;
            this.CBApplication.Checked = true;
            this.CBApplication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBApplication.Location = new System.Drawing.Point(16, 31);
            this.CBApplication.Name = "CBApplication";
            this.CBApplication.Size = new System.Drawing.Size(81, 16);
            this.CBApplication.TabIndex = 2;
            this.CBApplication.Text = "Application";
            this.CBApplication.UseVisualStyleBackColor = true;
            this.CBApplication.CheckedChanged += new System.EventHandler(this.CBApplication_CheckedChanged);
            // 
            // CBSecurity
            // 
            this.CBSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBSecurity.AutoSize = true;
            this.CBSecurity.Location = new System.Drawing.Point(16, 53);
            this.CBSecurity.Name = "CBSecurity";
            this.CBSecurity.Size = new System.Drawing.Size(66, 16);
            this.CBSecurity.TabIndex = 3;
            this.CBSecurity.Text = "Security";
            this.CBSecurity.UseVisualStyleBackColor = true;
            this.CBSecurity.CheckedChanged += new System.EventHandler(this.CBSecurity_CheckedChanged);
            // 
            // CBSetup
            // 
            this.CBSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBSetup.AutoSize = true;
            this.CBSetup.Location = new System.Drawing.Point(104, 30);
            this.CBSetup.Name = "CBSetup";
            this.CBSetup.Size = new System.Drawing.Size(53, 16);
            this.CBSetup.TabIndex = 4;
            this.CBSetup.Text = "Setup";
            this.CBSetup.UseVisualStyleBackColor = true;
            this.CBSetup.CheckedChanged += new System.EventHandler(this.CBSetup_CheckedChanged);
            // 
            // CBSystem
            // 
            this.CBSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBSystem.AutoSize = true;
            this.CBSystem.Location = new System.Drawing.Point(104, 53);
            this.CBSystem.Name = "CBSystem";
            this.CBSystem.Size = new System.Drawing.Size(62, 16);
            this.CBSystem.TabIndex = 5;
            this.CBSystem.Text = "System";
            this.CBSystem.UseVisualStyleBackColor = true;
            this.CBSystem.CheckedChanged += new System.EventHandler(this.CBSystem_CheckedChanged);
            // 
            // CBForwarded_Events
            // 
            this.CBForwarded_Events.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBForwarded_Events.AutoSize = true;
            this.CBForwarded_Events.Location = new System.Drawing.Point(173, 30);
            this.CBForwarded_Events.Name = "CBForwarded_Events";
            this.CBForwarded_Events.Size = new System.Drawing.Size(116, 16);
            this.CBForwarded_Events.TabIndex = 6;
            this.CBForwarded_Events.Text = "Forwarded Events";
            this.CBForwarded_Events.UseVisualStyleBackColor = true;
            this.CBForwarded_Events.CheckedChanged += new System.EventHandler(this.CBForwarded_Events_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.CBForwarded_Events);
            this.panel1.Controls.Add(this.CBSystem);
            this.panel1.Controls.Add(this.CBSetup);
            this.panel1.Controls.Add(this.CBSecurity);
            this.panel1.Controls.Add(this.CBApplication);
            this.panel1.Controls.Add(this.LBLogtype);
            this.panel1.Location = new System.Drawing.Point(12, 524);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 90);
            this.panel1.TabIndex = 7;
            // 
            // TBServerName
            // 
            this.TBServerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBServerName.Location = new System.Drawing.Point(87, 15);
            this.TBServerName.Name = "TBServerName";
            this.TBServerName.Size = new System.Drawing.Size(181, 19);
            this.TBServerName.TabIndex = 8;
            this.TBServerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TBServerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBServerName_KeyDown);
            // 
            // LabelServerName
            // 
            this.LabelServerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelServerName.AutoSize = true;
            this.LabelServerName.Location = new System.Drawing.Point(14, 18);
            this.LabelServerName.Name = "LabelServerName";
            this.LabelServerName.Size = new System.Drawing.Size(67, 12);
            this.LabelServerName.TabIndex = 9;
            this.LabelServerName.Text = "ServerName";
            // 
            // ButtonGet
            // 
            this.ButtonGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonGet.Location = new System.Drawing.Point(187, 40);
            this.ButtonGet.Name = "ButtonGet";
            this.ButtonGet.Size = new System.Drawing.Size(81, 37);
            this.ButtonGet.TabIndex = 10;
            this.ButtonGet.Text = "Get";
            this.ButtonGet.UseVisualStyleBackColor = true;
            this.ButtonGet.Click += new System.EventHandler(this.ButtonGet_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.CBLocalPC);
            this.panel2.Controls.Add(this.ButtonGet);
            this.panel2.Controls.Add(this.LabelServerName);
            this.panel2.Controls.Add(this.TBServerName);
            this.panel2.Location = new System.Drawing.Point(690, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 90);
            this.panel2.TabIndex = 11;
            // 
            // CBLocalPC
            // 
            this.CBLocalPC.AutoSize = true;
            this.CBLocalPC.Checked = true;
            this.CBLocalPC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBLocalPC.Location = new System.Drawing.Point(16, 52);
            this.CBLocalPC.Name = "CBLocalPC";
            this.CBLocalPC.Size = new System.Drawing.Size(70, 16);
            this.CBLocalPC.TabIndex = 11;
            this.CBLocalPC.Text = "Local PC";
            this.CBLocalPC.UseVisualStyleBackColor = true;
            this.CBLocalPC.CheckedChanged += new System.EventHandler(this.CBLocalPC_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.Controls.Add(this.LBresult);
            this.panel3.Controls.Add(this.LBResultCount);
            this.panel3.Controls.Add(this.TBResultCount);
            this.panel3.Controls.Add(this.Result);
            this.panel3.Location = new System.Drawing.Point(351, 524);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 90);
            this.panel3.TabIndex = 8;
            // 
            // LBresult
            // 
            this.LBresult.AutoSize = true;
            this.LBresult.Location = new System.Drawing.Point(212, 61);
            this.LBresult.Name = "LBresult";
            this.LBresult.Size = new System.Drawing.Size(0, 12);
            this.LBresult.TabIndex = 14;
            this.LBresult.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LBResultCount
            // 
            this.LBResultCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBResultCount.AutoSize = true;
            this.LBResultCount.Location = new System.Drawing.Point(6, 32);
            this.LBResultCount.Name = "LBResultCount";
            this.LBResultCount.Size = new System.Drawing.Size(98, 12);
            this.LBResultCount.TabIndex = 13;
            this.LBResultCount.Text = "Displayed Results";
            // 
            // TBResultCount
            // 
            this.TBResultCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBResultCount.Location = new System.Drawing.Point(110, 28);
            this.TBResultCount.Name = "TBResultCount";
            this.TBResultCount.Size = new System.Drawing.Size(171, 19);
            this.TBResultCount.TabIndex = 12;
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(6, 6);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(78, 12);
            this.Result.TabIndex = 1;
            this.Result.Text = "Result Setting";
            this.Result.Click += new System.EventHandler(this.label1_Click);
            // 
            // PBprogressBar
            // 
            this.PBprogressBar.Location = new System.Drawing.Point(690, 495);
            this.PBprogressBar.Maximum = 10;
            this.PBprogressBar.Name = "PBprogressBar";
            this.PBprogressBar.Size = new System.Drawing.Size(296, 23);
            this.PBprogressBar.TabIndex = 12;
            this.PBprogressBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // EventLogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 626);
            this.Controls.Add(this.PBprogressBar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGEventLog);
            this.MinimumSize = new System.Drawing.Size(1036, 664);
            this.Name = "EventLogViewer";
            this.Text = "EventLogViewer";
            this.Load += new System.EventHandler(this.EventLogViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGEventLog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGEventLog;
        private System.Windows.Forms.Label LBLogtype;
        private System.Windows.Forms.CheckBox CBApplication;
        private System.Windows.Forms.CheckBox CBSecurity;
        private System.Windows.Forms.CheckBox CBSetup;
        private System.Windows.Forms.CheckBox CBSystem;
        private System.Windows.Forms.CheckBox CBForwarded_Events;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBServerName;
        private System.Windows.Forms.Label LabelServerName;
        private System.Windows.Forms.Button ButtonGet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox CBLocalPC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label LBResultCount;
        private System.Windows.Forms.TextBox TBResultCount;
        private System.Windows.Forms.Label LBresult;
        private System.Windows.Forms.ProgressBar PBprogressBar;
    }
}

