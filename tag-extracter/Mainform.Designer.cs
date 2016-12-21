namespace tag_extracter
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.lbl_scanDir = new System.Windows.Forms.Label();
            this.tb_scanDir = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_readFolders = new System.Windows.Forms.Button();
            this.dgv_results = new System.Windows.Forms.DataGridView();
            this.Crawl = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Folder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Files = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_results)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_scanDir
            // 
            this.lbl_scanDir.AutoSize = true;
            this.lbl_scanDir.Location = new System.Drawing.Point(12, 9);
            this.lbl_scanDir.Name = "lbl_scanDir";
            this.lbl_scanDir.Size = new System.Drawing.Size(75, 13);
            this.lbl_scanDir.TabIndex = 0;
            this.lbl_scanDir.Text = "Scan directory";
            // 
            // tb_scanDir
            // 
            this.tb_scanDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_scanDir.Location = new System.Drawing.Point(93, 6);
            this.tb_scanDir.Name = "tb_scanDir";
            this.tb_scanDir.ReadOnly = true;
            this.tb_scanDir.Size = new System.Drawing.Size(306, 20);
            this.tb_scanDir.TabIndex = 1;
            // 
            // btn_browse
            // 
            this.btn_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse.Location = new System.Drawing.Point(405, 4);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Browse...";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_readFolders
            // 
            this.btn_readFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_readFolders.Location = new System.Drawing.Point(405, 33);
            this.btn_readFolders.Name = "btn_readFolders";
            this.btn_readFolders.Size = new System.Drawing.Size(75, 23);
            this.btn_readFolders.TabIndex = 3;
            this.btn_readFolders.Text = "Read tags";
            this.btn_readFolders.UseVisualStyleBackColor = true;
            this.btn_readFolders.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_results
            // 
            this.dgv_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Crawl,
            this.Folder,
            this.Files});
            this.dgv_results.Location = new System.Drawing.Point(12, 33);
            this.dgv_results.Name = "dgv_results";
            this.dgv_results.RowHeadersVisible = false;
            this.dgv_results.Size = new System.Drawing.Size(387, 263);
            this.dgv_results.TabIndex = 4;
            // 
            // Crawl
            // 
            this.Crawl.HeaderText = "Tag";
            this.Crawl.Name = "Crawl";
            this.Crawl.Width = 44;
            // 
            // Folder
            // 
            this.Folder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Folder.DataPropertyName = "fullPath";
            this.Folder.HeaderText = "Folder";
            this.Folder.Name = "Folder";
            this.Folder.ReadOnly = true;
            // 
            // Files
            // 
            this.Files.DataPropertyName = "numberOfFiles";
            this.Files.HeaderText = "Number of files";
            this.Files.Name = "Files";
            this.Files.ReadOnly = true;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 308);
            this.Controls.Add(this.dgv_results);
            this.Controls.Add(this.btn_readFolders);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.tb_scanDir);
            this.Controls.Add(this.lbl_scanDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.Text = "Tag Extracter";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_scanDir;
        private System.Windows.Forms.TextBox tb_scanDir;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_readFolders;
        private System.Windows.Forms.DataGridView dgv_results;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Crawl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Files;
    }
}

