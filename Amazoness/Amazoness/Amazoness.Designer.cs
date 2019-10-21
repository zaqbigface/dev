namespace MoveFilefForAmazoness
{
    partial class Amazoness
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Amazoness));
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileMovePage = new System.Windows.Forms.TabPage();
            this.BackupOK = new System.Windows.Forms.CheckBox();
            this.FileMoveButton = new System.Windows.Forms.Button();
            this.ToFileName = new System.Windows.Forms.Label();
            this.FromFilePathTextBox = new System.Windows.Forms.TextBox();
            this.FromFileName = new System.Windows.Forms.Label();
            this.ToFilePathTextBox = new System.Windows.Forms.TextBox();
            this.ToFileTime = new System.Windows.Forms.Label();
            this.FromFilePathLabel = new System.Windows.Forms.Label();
            this.FromFileTime = new System.Windows.Forms.Label();
            this.ToFilePathLabel = new System.Windows.Forms.Label();
            this.ToFileTimeLabel = new System.Windows.Forms.Label();
            this.FromFileLoadButton = new System.Windows.Forms.Button();
            this.FromFileTimeLabel = new System.Windows.Forms.Label();
            this.ToFileLoadButton = new System.Windows.Forms.Button();
            this.FileDiffLastWriteTimeButton = new System.Windows.Forms.Button();
            this.AmazonessToolTab = new System.Windows.Forms.TabControl();
            this.SVNInfoPage = new System.Windows.Forms.TabPage();
            this.SVNTargetPathTextBox = new System.Windows.Forms.TextBox();
            this.SVNTargetPath = new System.Windows.Forms.Label();
            this.SVNTargetPathLoadButton = new System.Windows.Forms.Button();
            this.GetSVNInfoButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FileMovePage.SuspendLayout();
            this.AmazonessToolTab.SuspendLayout();
            this.SVNInfoPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // FileMovePage
            // 
            this.FileMovePage.Controls.Add(this.BackupOK);
            this.FileMovePage.Controls.Add(this.FileMoveButton);
            this.FileMovePage.Controls.Add(this.ToFileName);
            this.FileMovePage.Controls.Add(this.FromFilePathTextBox);
            this.FileMovePage.Controls.Add(this.FromFileName);
            this.FileMovePage.Controls.Add(this.ToFilePathTextBox);
            this.FileMovePage.Controls.Add(this.ToFileTime);
            this.FileMovePage.Controls.Add(this.FromFilePathLabel);
            this.FileMovePage.Controls.Add(this.FromFileTime);
            this.FileMovePage.Controls.Add(this.ToFilePathLabel);
            this.FileMovePage.Controls.Add(this.ToFileTimeLabel);
            this.FileMovePage.Controls.Add(this.FromFileLoadButton);
            this.FileMovePage.Controls.Add(this.FromFileTimeLabel);
            this.FileMovePage.Controls.Add(this.ToFileLoadButton);
            this.FileMovePage.Controls.Add(this.FileDiffLastWriteTimeButton);
            this.FileMovePage.Location = new System.Drawing.Point(4, 25);
            this.FileMovePage.Name = "FileMovePage";
            this.FileMovePage.Padding = new System.Windows.Forms.Padding(3);
            this.FileMovePage.Size = new System.Drawing.Size(822, 377);
            this.FileMovePage.TabIndex = 0;
            this.FileMovePage.Text = "FileMove";
            this.FileMovePage.UseVisualStyleBackColor = true;
            // 
            // BackupOK
            // 
            this.BackupOK.AutoSize = true;
            this.BackupOK.Font = new System.Drawing.Font("MS UI Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BackupOK.Location = new System.Drawing.Point(668, 143);
            this.BackupOK.Name = "BackupOK";
            this.BackupOK.Size = new System.Drawing.Size(150, 17);
            this.BackupOK.TabIndex = 14;
            this.BackupOK.Text = "ToFileのバックアップを残す";
            this.BackupOK.UseVisualStyleBackColor = true;
            // 
            // FileMoveButton
            // 
            this.FileMoveButton.Location = new System.Drawing.Point(668, 288);
            this.FileMoveButton.Margin = new System.Windows.Forms.Padding(4);
            this.FileMoveButton.Name = "FileMoveButton";
            this.FileMoveButton.Size = new System.Drawing.Size(132, 74);
            this.FileMoveButton.TabIndex = 4;
            this.FileMoveButton.Text = "GO!!!!!";
            this.FileMoveButton.UseVisualStyleBackColor = true;
            this.FileMoveButton.Click += new System.EventHandler(this.FileMoveButton_Click);
            // 
            // ToFileName
            // 
            this.ToFileName.AutoSize = true;
            this.ToFileName.Location = new System.Drawing.Point(37, 264);
            this.ToFileName.Name = "ToFileName";
            this.ToFileName.Size = new System.Drawing.Size(82, 15);
            this.ToFileName.TabIndex = 13;
            this.ToFileName.Text = "ToFileName";
            this.ToFileName.Visible = false;
            // 
            // FromFilePathTextBox
            // 
            this.FromFilePathTextBox.Location = new System.Drawing.Point(142, 23);
            this.FromFilePathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FromFilePathTextBox.Multiline = true;
            this.FromFilePathTextBox.Name = "FromFilePathTextBox";
            this.FromFilePathTextBox.Size = new System.Drawing.Size(513, 23);
            this.FromFilePathTextBox.TabIndex = 0;
            this.FromFilePathTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FromFileName
            // 
            this.FromFileName.AutoSize = true;
            this.FromFileName.Location = new System.Drawing.Point(37, 174);
            this.FromFileName.Name = "FromFileName";
            this.FromFileName.Size = new System.Drawing.Size(97, 15);
            this.FromFileName.TabIndex = 12;
            this.FromFileName.Text = "FromFileName";
            this.FromFileName.Visible = false;
            // 
            // ToFilePathTextBox
            // 
            this.ToFilePathTextBox.Location = new System.Drawing.Point(142, 93);
            this.ToFilePathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ToFilePathTextBox.Multiline = true;
            this.ToFilePathTextBox.Name = "ToFilePathTextBox";
            this.ToFilePathTextBox.Size = new System.Drawing.Size(513, 23);
            this.ToFilePathTextBox.TabIndex = 1;
            this.ToFilePathTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ToFileTime
            // 
            this.ToFileTime.AutoSize = true;
            this.ToFileTime.Location = new System.Drawing.Point(162, 295);
            this.ToFileTime.Name = "ToFileTime";
            this.ToFileTime.Size = new System.Drawing.Size(150, 15);
            this.ToFileTime.TabIndex = 11;
            this.ToFileTime.Text = "yyyy/mm/dd hh:mm:ss";
            this.ToFileTime.Visible = false;
            // 
            // FromFilePathLabel
            // 
            this.FromFilePathLabel.AutoSize = true;
            this.FromFilePathLabel.Location = new System.Drawing.Point(34, 23);
            this.FromFilePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FromFilePathLabel.Name = "FromFilePathLabel";
            this.FromFilePathLabel.Size = new System.Drawing.Size(90, 15);
            this.FromFilePathLabel.TabIndex = 2;
            this.FromFilePathLabel.Text = "FromFilePath";
            this.FromFilePathLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // FromFileTime
            // 
            this.FromFileTime.AutoSize = true;
            this.FromFileTime.Location = new System.Drawing.Point(157, 203);
            this.FromFileTime.Name = "FromFileTime";
            this.FromFileTime.Size = new System.Drawing.Size(150, 15);
            this.FromFileTime.TabIndex = 10;
            this.FromFileTime.Text = "yyyy/mm/dd hh:mm:ss";
            this.FromFileTime.Visible = false;
            // 
            // ToFilePathLabel
            // 
            this.ToFilePathLabel.AutoSize = true;
            this.ToFilePathLabel.Location = new System.Drawing.Point(34, 97);
            this.ToFilePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ToFilePathLabel.Name = "ToFilePathLabel";
            this.ToFilePathLabel.Size = new System.Drawing.Size(75, 15);
            this.ToFilePathLabel.TabIndex = 3;
            this.ToFilePathLabel.Text = "ToFilePath";
            // 
            // ToFileTimeLabel
            // 
            this.ToFileTimeLabel.AutoSize = true;
            this.ToFileTimeLabel.Location = new System.Drawing.Point(37, 295);
            this.ToFileTimeLabel.Name = "ToFileTimeLabel";
            this.ToFileTimeLabel.Size = new System.Drawing.Size(77, 15);
            this.ToFileTimeLabel.TabIndex = 9;
            this.ToFileTimeLabel.Text = "ToFileTime";
            // 
            // FromFileLoadButton
            // 
            this.FromFileLoadButton.Location = new System.Drawing.Point(682, 20);
            this.FromFileLoadButton.Margin = new System.Windows.Forms.Padding(4);
            this.FromFileLoadButton.Name = "FromFileLoadButton";
            this.FromFileLoadButton.Size = new System.Drawing.Size(100, 29);
            this.FromFileLoadButton.TabIndex = 5;
            this.FromFileLoadButton.Text = "Load";
            this.FromFileLoadButton.UseVisualStyleBackColor = true;
            this.FromFileLoadButton.Click += new System.EventHandler(this.FileDiffLastWriteTimeButton_Click);
            // 
            // FromFileTimeLabel
            // 
            this.FromFileTimeLabel.AutoSize = true;
            this.FromFileTimeLabel.Location = new System.Drawing.Point(37, 203);
            this.FromFileTimeLabel.Name = "FromFileTimeLabel";
            this.FromFileTimeLabel.Size = new System.Drawing.Size(92, 15);
            this.FromFileTimeLabel.TabIndex = 8;
            this.FromFileTimeLabel.Text = "FromFiieTime";
            // 
            // ToFileLoadButton
            // 
            this.ToFileLoadButton.Location = new System.Drawing.Point(682, 90);
            this.ToFileLoadButton.Margin = new System.Windows.Forms.Padding(4);
            this.ToFileLoadButton.Name = "ToFileLoadButton";
            this.ToFileLoadButton.Size = new System.Drawing.Size(100, 29);
            this.ToFileLoadButton.TabIndex = 6;
            this.ToFileLoadButton.Text = "Load";
            this.ToFileLoadButton.UseVisualStyleBackColor = true;
            this.ToFileLoadButton.Click += new System.EventHandler(this.ToFileLoadButton_Click);
            // 
            // FileDiffLastWriteTimeButton
            // 
            this.FileDiffLastWriteTimeButton.Location = new System.Drawing.Point(668, 186);
            this.FileDiffLastWriteTimeButton.Margin = new System.Windows.Forms.Padding(4);
            this.FileDiffLastWriteTimeButton.Name = "FileDiffLastWriteTimeButton";
            this.FileDiffLastWriteTimeButton.Size = new System.Drawing.Size(132, 74);
            this.FileDiffLastWriteTimeButton.TabIndex = 7;
            this.FileDiffLastWriteTimeButton.Text = "更新日の比較";
            this.FileDiffLastWriteTimeButton.UseVisualStyleBackColor = true;
            this.FileDiffLastWriteTimeButton.Click += new System.EventHandler(this.FileDiffLastWriteTimeButton_Click_1);
            // 
            // AmazonessToolTab
            // 
            this.AmazonessToolTab.Controls.Add(this.SVNInfoPage);
            this.AmazonessToolTab.Controls.Add(this.FileMovePage);
            this.AmazonessToolTab.Location = new System.Drawing.Point(13, 7);
            this.AmazonessToolTab.Name = "AmazonessToolTab";
            this.AmazonessToolTab.SelectedIndex = 0;
            this.AmazonessToolTab.Size = new System.Drawing.Size(830, 406);
            this.AmazonessToolTab.TabIndex = 15;
            // 
            // SVNInfoPage
            // 
            this.SVNInfoPage.Controls.Add(this.GetSVNInfoButton);
            this.SVNInfoPage.Controls.Add(this.SVNTargetPathTextBox);
            this.SVNInfoPage.Controls.Add(this.SVNTargetPath);
            this.SVNInfoPage.Controls.Add(this.SVNTargetPathLoadButton);
            this.SVNInfoPage.Location = new System.Drawing.Point(4, 25);
            this.SVNInfoPage.Name = "SVNInfoPage";
            this.SVNInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.SVNInfoPage.Size = new System.Drawing.Size(822, 377);
            this.SVNInfoPage.TabIndex = 1;
            this.SVNInfoPage.Text = "SVNInfo";
            this.SVNInfoPage.UseVisualStyleBackColor = true;
            // 
            // SVNTargetPathTextBox
            // 
            this.SVNTargetPathTextBox.Location = new System.Drawing.Point(139, 38);
            this.SVNTargetPathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SVNTargetPathTextBox.Multiline = true;
            this.SVNTargetPathTextBox.Name = "SVNTargetPathTextBox";
            this.SVNTargetPathTextBox.Size = new System.Drawing.Size(513, 23);
            this.SVNTargetPathTextBox.TabIndex = 7;
            // 
            // SVNTargetPath
            // 
            this.SVNTargetPath.AutoSize = true;
            this.SVNTargetPath.Location = new System.Drawing.Point(22, 41);
            this.SVNTargetPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SVNTargetPath.Name = "SVNTargetPath";
            this.SVNTargetPath.Size = new System.Drawing.Size(105, 15);
            this.SVNTargetPath.TabIndex = 9;
            this.SVNTargetPath.Text = "SVNTargetPath";
            // 
            // SVNTargetPathLoadButton
            // 
            this.SVNTargetPathLoadButton.Location = new System.Drawing.Point(674, 34);
            this.SVNTargetPathLoadButton.Margin = new System.Windows.Forms.Padding(4);
            this.SVNTargetPathLoadButton.Name = "SVNTargetPathLoadButton";
            this.SVNTargetPathLoadButton.Size = new System.Drawing.Size(100, 29);
            this.SVNTargetPathLoadButton.TabIndex = 11;
            this.SVNTargetPathLoadButton.Text = "Load";
            this.SVNTargetPathLoadButton.UseVisualStyleBackColor = true;
            this.SVNTargetPathLoadButton.Click += new System.EventHandler(this.SVNTargetPathLoadButton_Click_1);
            // 
            // GetSVNInfoButton
            // 
            this.GetSVNInfoButton.Location = new System.Drawing.Point(674, 86);
            this.GetSVNInfoButton.Name = "GetSVNInfoButton";
            this.GetSVNInfoButton.Size = new System.Drawing.Size(100, 34);
            this.GetSVNInfoButton.TabIndex = 12;
            this.GetSVNInfoButton.Text = "Get";
            this.GetSVNInfoButton.UseVisualStyleBackColor = true;
            this.GetSVNInfoButton.Click += new System.EventHandler(this.GetSVNInfoButton_Click);
            // 
            // Amazoness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 425);
            this.Controls.Add(this.AmazonessToolTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(873, 466);
            this.Name = "Amazoness";
            this.Text = "Amazoness";
            this.Load += new System.EventHandler(this.MoveFIleForAmazoness_Load);
            this.FileMovePage.ResumeLayout(false);
            this.FileMovePage.PerformLayout();
            this.AmazonessToolTab.ResumeLayout(false);
            this.SVNInfoPage.ResumeLayout(false);
            this.SVNInfoPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.TabPage FileMovePage;
        private System.Windows.Forms.TabControl AmazonessToolTab;
        private System.Windows.Forms.TabPage SVNInfoPage;
        private System.Windows.Forms.Button FromFileLoadButton;
        private System.Windows.Forms.Button ToFileLoadButton;
        private System.Windows.Forms.CheckBox BackupOK;
        private System.Windows.Forms.Button FileDiffLastWriteTimeButton;
        private System.Windows.Forms.Button FileMoveButton;
        private System.Windows.Forms.Label ToFileTime;
        private System.Windows.Forms.Label ToFileTimeLabel;
        private System.Windows.Forms.Label ToFileName;
        private System.Windows.Forms.Label FromFileTime;
        private System.Windows.Forms.Label FromFileTimeLabel;
        private System.Windows.Forms.Label FromFileName;
        private System.Windows.Forms.Label ToFilePathLabel;
        private System.Windows.Forms.TextBox ToFilePathTextBox;
        private System.Windows.Forms.TextBox FromFilePathTextBox;
        private System.Windows.Forms.Label FromFilePathLabel;
        private System.Windows.Forms.TextBox SVNTargetPathTextBox;
        private System.Windows.Forms.Label SVNTargetPath;
        private System.Windows.Forms.Button SVNTargetPathLoadButton;
        private System.Windows.Forms.Button GetSVNInfoButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

