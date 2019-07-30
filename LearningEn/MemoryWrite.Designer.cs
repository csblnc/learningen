namespace LearningEn
{
    partial class MemoryWrite
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CbxWordbook = new System.Windows.Forms.ComboBox();
            this.LblLastPage = new System.Windows.Forms.Label();
            this.LblNextPage = new System.Windows.Forms.Label();
            this.Pnl = new System.Windows.Forms.Panel();
            this.TbxPage = new System.Windows.Forms.TextBox();
            this.LblPages = new System.Windows.Forms.Label();
            this.PnlWord = new System.Windows.Forms.Panel();
            this.Cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmPronunciation = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmGrasp = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmUngrasp = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAddToWordbook = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmWordInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.Pnl.SuspendLayout();
            this.Cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxWordbook
            // 
            this.CbxWordbook.BackColor = System.Drawing.SystemColors.Window;
            this.CbxWordbook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxWordbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxWordbook.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CbxWordbook.FormattingEnabled = true;
            this.CbxWordbook.Location = new System.Drawing.Point(48, 23);
            this.CbxWordbook.Margin = new System.Windows.Forms.Padding(48, 23, 3, 3);
            this.CbxWordbook.Name = "CbxWordbook";
            this.CbxWordbook.Size = new System.Drawing.Size(205, 28);
            this.CbxWordbook.TabIndex = 6;
            this.CbxWordbook.SelectedIndexChanged += new System.EventHandler(this.CbxWordbook_SelectedIndexChanged);
            this.CbxWordbook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            this.CbxWordbook.MouseEnter += new System.EventHandler(this.CbxWordbook_MouseEnter);
            // 
            // LblLastPage
            // 
            this.LblLastPage.AutoSize = true;
            this.LblLastPage.Font = new System.Drawing.Font("宋体", 15F);
            this.LblLastPage.Location = new System.Drawing.Point(493, 26);
            this.LblLastPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLastPage.Name = "LblLastPage";
            this.LblLastPage.Size = new System.Drawing.Size(69, 20);
            this.LblLastPage.TabIndex = 7;
            this.LblLastPage.Text = "上一页";
            this.LblLastPage.Click += new System.EventHandler(this.LblLastPage_Click);
            this.LblLastPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LblLastPage_MouseUp);
            // 
            // LblNextPage
            // 
            this.LblNextPage.AutoSize = true;
            this.LblNextPage.Font = new System.Drawing.Font("宋体", 15F);
            this.LblNextPage.Location = new System.Drawing.Point(682, 27);
            this.LblNextPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNextPage.Name = "LblNextPage";
            this.LblNextPage.Size = new System.Drawing.Size(69, 20);
            this.LblNextPage.TabIndex = 8;
            this.LblNextPage.Text = "下一页";
            this.LblNextPage.Click += new System.EventHandler(this.LblNextPage_Click);
            this.LblNextPage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LblNextPage_MouseUp);
            // 
            // Pnl
            // 
            this.Pnl.BackColor = System.Drawing.SystemColors.Window;
            this.Pnl.Controls.Add(this.TbxPage);
            this.Pnl.Location = new System.Drawing.Point(564, 23);
            this.Pnl.Name = "Pnl";
            this.Pnl.Size = new System.Drawing.Size(56, 28);
            this.Pnl.TabIndex = 9;
            // 
            // TbxPage
            // 
            this.TbxPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TbxPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxPage.Font = new System.Drawing.Font("宋体", 15F);
            this.TbxPage.Location = new System.Drawing.Point(0, 4);
            this.TbxPage.Name = "TbxPage";
            this.TbxPage.Size = new System.Drawing.Size(56, 23);
            this.TbxPage.TabIndex = 2;
            this.TbxPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbxPage.TextChanged += new System.EventHandler(this.TbxPage_TextChanged);
            this.TbxPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            this.TbxPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.All_KeyPress);
            // 
            // LblPages
            // 
            this.LblPages.AutoSize = true;
            this.LblPages.Font = new System.Drawing.Font("宋体", 15F);
            this.LblPages.Location = new System.Drawing.Point(625, 27);
            this.LblPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPages.Name = "LblPages";
            this.LblPages.Size = new System.Drawing.Size(19, 20);
            this.LblPages.TabIndex = 10;
            this.LblPages.Text = "/";
            // 
            // PnlWord
            // 
            this.PnlWord.Location = new System.Drawing.Point(0, 70);
            this.PnlWord.Name = "PnlWord";
            this.PnlWord.Size = new System.Drawing.Size(800, 357);
            this.PnlWord.TabIndex = 12;
            this.PnlWord.Click += new System.EventHandler(this.PnlWord_Click);
            this.PnlWord.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlWord_Paint);
            // 
            // Cms
            // 
            this.Cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmPronunciation,
            this.TsmGrasp,
            this.TsmUngrasp,
            this.TsmAddToWordbook,
            this.TsmWordInfo});
            this.Cms.Name = "Cms";
            this.Cms.Size = new System.Drawing.Size(209, 114);
            // 
            // TsmPronunciation
            // 
            this.TsmPronunciation.Name = "TsmPronunciation";
            this.TsmPronunciation.Size = new System.Drawing.Size(208, 22);
            this.TsmPronunciation.Text = "发音";
            this.TsmPronunciation.Click += new System.EventHandler(this.TsmPronunciation_Click);
            // 
            // TsmGrasp
            // 
            this.TsmGrasp.Name = "TsmGrasp";
            this.TsmGrasp.Size = new System.Drawing.Size(208, 22);
            this.TsmGrasp.Text = "标记为会";
            this.TsmGrasp.Click += new System.EventHandler(this.TsmGrasp_Click);
            // 
            // TsmUngrasp
            // 
            this.TsmUngrasp.Name = "TsmUngrasp";
            this.TsmUngrasp.Size = new System.Drawing.Size(208, 22);
            this.TsmUngrasp.Text = "标记为不会";
            this.TsmUngrasp.Click += new System.EventHandler(this.TsmUngrasp_Click);
            // 
            // TsmAddToWordbook
            // 
            this.TsmAddToWordbook.Name = "TsmAddToWordbook";
            this.TsmAddToWordbook.Size = new System.Drawing.Size(208, 22);
            this.TsmAddToWordbook.Text = "添加到单词本（未开放）";
            // 
            // TsmWordInfo
            // 
            this.TsmWordInfo.Name = "TsmWordInfo";
            this.TsmWordInfo.Size = new System.Drawing.Size(208, 22);
            this.TsmWordInfo.Text = "查看详细信息（未开放）";
            // 
            // Wordbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlWord);
            this.Controls.Add(this.LblPages);
            this.Controls.Add(this.Pnl);
            this.Controls.Add(this.LblNextPage);
            this.Controls.Add(this.LblLastPage);
            this.Controls.Add(this.CbxWordbook);
            this.Name = "Wordbook";
            this.Size = new System.Drawing.Size(800, 426);
            this.Load += new System.EventHandler(this.Wordbook_Load);
            this.Click += new System.EventHandler(this.Wordbook_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.All_KeyDown);
            this.Pnl.ResumeLayout(false);
            this.Pnl.PerformLayout();
            this.Cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CbxWordbook;
        private System.Windows.Forms.Label LblLastPage;
        private System.Windows.Forms.Label LblNextPage;
        private System.Windows.Forms.Panel Pnl;
        private System.Windows.Forms.TextBox TbxPage;
        private System.Windows.Forms.Label LblPages;
        private System.Windows.Forms.Panel PnlWord;
        private System.Windows.Forms.ContextMenuStrip Cms;
        private System.Windows.Forms.ToolStripMenuItem TsmGrasp;
        private System.Windows.Forms.ToolStripMenuItem TsmUngrasp;
        private System.Windows.Forms.ToolStripMenuItem TsmAddToWordbook;
        private System.Windows.Forms.ToolStripMenuItem TsmPronunciation;
        private System.Windows.Forms.ToolStripMenuItem TsmWordInfo;
    }
}
