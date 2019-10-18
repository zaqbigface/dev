namespace MoveFilefForAmazoness
{
    partial class MoveFIleForAmazoness
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
            this.FromFilePathLabel = new System.Windows.Forms.Label();
            this.ToFilePathLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ToFilePathTextBox = new System.Windows.Forms.TextBox();
            this.FromFilePathTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FromFileLoadButton = new System.Windows.Forms.Button();
            this.ToFileLoadButton = new System.Windows.Forms.Button();
            this.FileDiffLastWriteTimeButton = new System.Windows.Forms.Button();
            this.FromFileTimeLabel = new System.Windows.Forms.Label();
            this.ToFileTimeLabel = new System.Windows.Forms.Label();
            this.FromFileTime = new System.Windows.Forms.Label();
            this.ToFileTime = new System.Windows.Forms.Label();
            this.FromFileName = new System.Windows.Forms.Label();
            this.ToFileName = new System.Windows.Forms.Label();
            this.BackupOK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FromFilePathLabel
            // 
            this.FromFilePathLabel.AutoSize = true;
            this.FromFilePathLabel.Location = new System.Drawing.Point(46, 56);
            this.FromFilePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FromFilePathLabel.Name = "FromFilePathLabel";
            this.FromFilePathLabel.Size = new System.Drawing.Size(90, 15);
            this.FromFilePathLabel.TabIndex = 2;
            this.FromFilePathLabel.Text = "FromFilePath";
            this.FromFilePathLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ToFilePathLabel
            // 
            this.ToFilePathLabel.AutoSize = true;
            this.ToFilePathLabel.Location = new System.Drawing.Point(46, 130);
            this.ToFilePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ToFilePathLabel.Name = "ToFilePathLabel";
            this.ToFilePathLabel.Size = new System.Drawing.Size(75, 15);
            this.ToFilePathLabel.TabIndex = 3;
            this.ToFilePathLabel.Text = "ToFilePath";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 321);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 74);
            this.button1.TabIndex = 4;
            this.button1.Text = "GO!!!!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ToFilePathTextBox
            // 
            this.ToFilePathTextBox.Location = new System.Drawing.Point(154, 126);
            this.ToFilePathTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ToFilePathTextBox.Multiline = true;
            this.ToFilePathTextBox.Name = "ToFilePathTextBox";
            this.ToFilePathTextBox.Size = new System.Drawing.Size(513, 23);
            this.ToFilePathTextBox.TabIndex = 1;
            this.ToFilePathTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FromFilePathTextBox
            // 
            this.FromFilePathTextBox.Location = new System.Drawing.Point(154, 56);
            this.FromFilePathTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FromFilePathTextBox.Multiline = true;
            this.FromFilePathTextBox.Name = "FromFilePathTextBox";
            this.FromFilePathTextBox.Size = new System.Drawing.Size(513, 23);
            this.FromFilePathTextBox.TabIndex = 0;
            this.FromFilePathTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FromFileLoadButton
            // 
            this.FromFileLoadButton.Location = new System.Drawing.Point(694, 53);
            this.FromFileLoadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FromFileLoadButton.Name = "FromFileLoadButton";
            this.FromFileLoadButton.Size = new System.Drawing.Size(100, 29);
            this.FromFileLoadButton.TabIndex = 5;
            this.FromFileLoadButton.Text = "Load";
            this.FromFileLoadButton.UseVisualStyleBackColor = true;
            this.FromFileLoadButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ToFileLoadButton
            // 
            this.ToFileLoadButton.Location = new System.Drawing.Point(694, 123);
            this.ToFileLoadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ToFileLoadButton.Name = "ToFileLoadButton";
            this.ToFileLoadButton.Size = new System.Drawing.Size(100, 29);
            this.ToFileLoadButton.TabIndex = 6;
            this.ToFileLoadButton.Text = "Load";
            this.ToFileLoadButton.UseVisualStyleBackColor = true;
            this.ToFileLoadButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // FileDiffLastWriteTimeButton
            // 
            this.FileDiffLastWriteTimeButton.Location = new System.Drawing.Point(680, 219);
            this.FileDiffLastWriteTimeButton.Margin = new System.Windows.Forms.Padding(4);
            this.FileDiffLastWriteTimeButton.Name = "FileDiffLastWriteTimeButton";
            this.FileDiffLastWriteTimeButton.Size = new System.Drawing.Size(132, 74);
            this.FileDiffLastWriteTimeButton.TabIndex = 7;
            this.FileDiffLastWriteTimeButton.Text = "更新日の比較";
            this.FileDiffLastWriteTimeButton.UseVisualStyleBackColor = true;
            this.FileDiffLastWriteTimeButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FromFileTimeLabel
            // 
            this.FromFileTimeLabel.AutoSize = true;
            this.FromFileTimeLabel.Location = new System.Drawing.Point(49, 236);
            this.FromFileTimeLabel.Name = "FromFileTimeLabel";
            this.FromFileTimeLabel.Size = new System.Drawing.Size(92, 15);
            this.FromFileTimeLabel.TabIndex = 8;
            this.FromFileTimeLabel.Text = "FromFiieTime";
            // 
            // ToFileTimeLabel
            // 
            this.ToFileTimeLabel.AutoSize = true;
            this.ToFileTimeLabel.Location = new System.Drawing.Point(49, 328);
            this.ToFileTimeLabel.Name = "ToFileTimeLabel";
            this.ToFileTimeLabel.Size = new System.Drawing.Size(77, 15);
            this.ToFileTimeLabel.TabIndex = 9;
            this.ToFileTimeLabel.Text = "ToFileTime";
            // 
            // FromFileTime
            // 
            this.FromFileTime.AutoSize = true;
            this.FromFileTime.Location = new System.Drawing.Point(169, 236);
            this.FromFileTime.Name = "FromFileTime";
            this.FromFileTime.Size = new System.Drawing.Size(150, 15);
            this.FromFileTime.TabIndex = 10;
            this.FromFileTime.Text = "yyyy/mm/dd hh:mm:ss";
            this.FromFileTime.Visible = false;
            // 
            // ToFileTime
            // 
            this.ToFileTime.AutoSize = true;
            this.ToFileTime.Location = new System.Drawing.Point(169, 328);
            this.ToFileTime.Name = "ToFileTime";
            this.ToFileTime.Size = new System.Drawing.Size(150, 15);
            this.ToFileTime.TabIndex = 11;
            this.ToFileTime.Text = "yyyy/mm/dd hh:mm:ss";
            this.ToFileTime.Visible = false;
            // 
            // FromFileName
            // 
            this.FromFileName.AutoSize = true;
            this.FromFileName.Location = new System.Drawing.Point(49, 207);
            this.FromFileName.Name = "FromFileName";
            this.FromFileName.Size = new System.Drawing.Size(97, 15);
            this.FromFileName.TabIndex = 12;
            this.FromFileName.Text = "FromFileName";
            this.FromFileName.Visible = false;
            // 
            // ToFileName
            // 
            this.ToFileName.AutoSize = true;
            this.ToFileName.Location = new System.Drawing.Point(49, 297);
            this.ToFileName.Name = "ToFileName";
            this.ToFileName.Size = new System.Drawing.Size(82, 15);
            this.ToFileName.TabIndex = 13;
            this.ToFileName.Text = "ToFileName";
            this.ToFileName.Visible = false;
            // 
            // BackupOK
            // 
            this.BackupOK.AutoSize = true;
            this.BackupOK.Font = new System.Drawing.Font("MS UI Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BackupOK.Location = new System.Drawing.Point(680, 176);
            this.BackupOK.Name = "BackupOK";
            this.BackupOK.Size = new System.Drawing.Size(150, 17);
            this.BackupOK.TabIndex = 14;
            this.BackupOK.Text = "ToFileのバックアップを残す";
            this.BackupOK.UseVisualStyleBackColor = true;
            // 
            // MoveFIleForAmazoness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 419);
            this.Controls.Add(this.BackupOK);
            this.Controls.Add(this.ToFileName);
            this.Controls.Add(this.FromFileName);
            this.Controls.Add(this.ToFileTime);
            this.Controls.Add(this.FromFileTime);
            this.Controls.Add(this.ToFileTimeLabel);
            this.Controls.Add(this.FromFileTimeLabel);
            this.Controls.Add(this.FileDiffLastWriteTimeButton);
            this.Controls.Add(this.ToFileLoadButton);
            this.Controls.Add(this.FromFileLoadButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ToFilePathLabel);
            this.Controls.Add(this.FromFilePathLabel);
            this.Controls.Add(this.ToFilePathTextBox);
            this.Controls.Add(this.FromFilePathTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(873, 466);
            this.MinimumSize = new System.Drawing.Size(873, 466);
            this.Name = "MoveFIleForAmazoness";
            this.Text = "MoveFIleForAmazoness";
            this.Load += new System.EventHandler(this.MoveFIleForAmazoness_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FromFilePathLabel;
        private System.Windows.Forms.Label ToFilePathLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ToFilePathTextBox;
        private System.Windows.Forms.TextBox FromFilePathTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button FromFileLoadButton;
        private System.Windows.Forms.Button ToFileLoadButton;
        private System.Windows.Forms.Button FileDiffLastWriteTimeButton;
        private System.Windows.Forms.Label FromFileTimeLabel;
        private System.Windows.Forms.Label ToFileTimeLabel;
        private System.Windows.Forms.Label FromFileTime;
        private System.Windows.Forms.Label ToFileTime;
        private System.Windows.Forms.Label FromFileName;
        private System.Windows.Forms.Label ToFileName;
        private System.Windows.Forms.CheckBox BackupOK;
    }
}

