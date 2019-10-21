namespace MoveFilefForAmazoness
{
    partial class SVNInfoShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SVNInfoShow));
            this.SVNInfoView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SVNInfoView)).BeginInit();
            this.SuspendLayout();
            // 
            // SVNInfoView
            // 
            this.SVNInfoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SVNInfoView.Location = new System.Drawing.Point(13, 13);
            this.SVNInfoView.Name = "SVNInfoView";
            this.SVNInfoView.RowTemplate.Height = 24;
            this.SVNInfoView.Size = new System.Drawing.Size(1712, 734);
            this.SVNInfoView.TabIndex = 0;
            this.SVNInfoView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SVNInfoView_CellContentClick);
            // 
            // SVNInfoShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1737, 759);
            this.Controls.Add(this.SVNInfoView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SVNInfoShow";
            this.Text = "SVNInfoShow";
            this.Load += new System.EventHandler(this.SVNInfoShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SVNInfoView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SVNInfoView;
    }
}