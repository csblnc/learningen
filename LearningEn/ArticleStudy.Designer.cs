namespace LearningEn
{
    partial class ArticleStudy
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
            this.BtnSearch = new System.Windows.Forms.Button();
            this.CbxDictionary = new System.Windows.Forms.ComboBox();
            this.Tbx = new System.Windows.Forms.TextBox();
            this.CmsTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加到单词列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TbxArticleContainer = new System.Windows.Forms.TextBox();
            this.TbxArticle = new System.Windows.Forms.TextBox();
            this.FbdSearch = new System.Windows.Forms.FolderBrowserDialog();
            this.CmsWordList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmPronunciation = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmGrasp = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmUnGrasp = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAddToWordbook = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmWordInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmRespellingWord = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAddWord = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnGrasp = new System.Windows.Forms.Button();
            this.BtnUngrasp = new System.Windows.Forms.Button();
            this.BtnSelectAll = new System.Windows.Forms.Button();
            this.Ttp = new System.Windows.Forms.ToolTip(this.components);
            this.BtnCool = new System.Windows.Forms.Button();
            this.LbxWord = new System.Windows.Forms.ListBox();
            this.MPB = new LearningEn.MyProgressBar();
            this.CmsTextBox.SuspendLayout();
            this.CmsWordList.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSearch.Location = new System.Drawing.Point(266, 21);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 28);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "浏览";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // CbxDictionary
            // 
            this.CbxDictionary.BackColor = System.Drawing.SystemColors.Window;
            this.CbxDictionary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxDictionary.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CbxDictionary.FormattingEnabled = true;
            this.CbxDictionary.Location = new System.Drawing.Point(543, 21);
            this.CbxDictionary.Name = "CbxDictionary";
            this.CbxDictionary.Size = new System.Drawing.Size(205, 28);
            this.CbxDictionary.TabIndex = 5;
            this.CbxDictionary.SelectedIndexChanged += new System.EventHandler(this.CbxDictionary_SelectedIndexChanged);
            this.CbxDictionary.MouseEnter += new System.EventHandler(this.CbxDictionary_MouseEnter);
            // 
            // Tbx
            // 
            this.Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbx.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx.Location = new System.Drawing.Point(48, 77);
            this.Tbx.Multiline = true;
            this.Tbx.Name = "Tbx";
            this.Tbx.ReadOnly = true;
            this.Tbx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Tbx.Size = new System.Drawing.Size(495, 320);
            this.Tbx.TabIndex = 6;
            this.Tbx.Click += new System.EventHandler(this.Tbx_Click);
            // 
            // CmsTextBox
            // 
            this.CmsTextBox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加到单词列表ToolStripMenuItem});
            this.CmsTextBox.Name = "CmsTextBox";
            this.CmsTextBox.Size = new System.Drawing.Size(161, 26);
            // 
            // 添加到单词列表ToolStripMenuItem
            // 
            this.添加到单词列表ToolStripMenuItem.Name = "添加到单词列表ToolStripMenuItem";
            this.添加到单词列表ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.添加到单词列表ToolStripMenuItem.Text = "添加到单词列表";
            // 
            // TbxArticleContainer
            // 
            this.TbxArticleContainer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxArticleContainer.Font = new System.Drawing.Font("宋体", 15F);
            this.TbxArticleContainer.Location = new System.Drawing.Point(48, 21);
            this.TbxArticleContainer.Name = "TbxArticleContainer";
            this.TbxArticleContainer.Size = new System.Drawing.Size(212, 23);
            this.TbxArticleContainer.TabIndex = 7;
            // 
            // TbxArticle
            // 
            this.TbxArticle.BackColor = System.Drawing.SystemColors.Window;
            this.TbxArticle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxArticle.Font = new System.Drawing.Font("宋体", 15F);
            this.TbxArticle.Location = new System.Drawing.Point(48, 23);
            this.TbxArticle.Name = "TbxArticle";
            this.TbxArticle.ReadOnly = true;
            this.TbxArticle.Size = new System.Drawing.Size(212, 23);
            this.TbxArticle.TabIndex = 9;
            // 
            // CmsWordList
            // 
            this.CmsWordList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsWordList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmPronunciation,
            this.TsmGrasp,
            this.TsmUnGrasp,
            this.TsmAddToWordbook,
            this.TsmWordInfo,
            this.TsmRespellingWord,
            this.TsmAddWord});
            this.CmsWordList.Name = "CmsWordList";
            this.CmsWordList.Size = new System.Drawing.Size(209, 158);
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
            // TsmUnGrasp
            // 
            this.TsmUnGrasp.Name = "TsmUnGrasp";
            this.TsmUnGrasp.Size = new System.Drawing.Size(208, 22);
            this.TsmUnGrasp.Text = "标记为不会";
            this.TsmUnGrasp.Click += new System.EventHandler(this.TsmUnGrasp_Click);
            // 
            // TsmAddToWordbook
            // 
            this.TsmAddToWordbook.Name = "TsmAddToWordbook";
            this.TsmAddToWordbook.Size = new System.Drawing.Size(208, 22);
            this.TsmAddToWordbook.Text = "添加到单词本（未开放）";
            this.TsmAddToWordbook.Click += new System.EventHandler(this.TsmAddToWordbook_Click);
            // 
            // TsmWordInfo
            // 
            this.TsmWordInfo.Name = "TsmWordInfo";
            this.TsmWordInfo.Size = new System.Drawing.Size(208, 22);
            this.TsmWordInfo.Text = "查看详细信息（未开放）";
            // 
            // TsmRespellingWord
            // 
            this.TsmRespellingWord.Name = "TsmRespellingWord";
            this.TsmRespellingWord.Size = new System.Drawing.Size(208, 22);
            this.TsmRespellingWord.Text = "修改单词";
            this.TsmRespellingWord.Click += new System.EventHandler(this.TsmRespellingWord_Click);
            // 
            // TsmAddWord
            // 
            this.TsmAddWord.Name = "TsmAddWord";
            this.TsmAddWord.Size = new System.Drawing.Size(208, 22);
            this.TsmAddWord.Text = "添加单词";
            this.TsmAddWord.Click += new System.EventHandler(this.TsmAddWord_Click);
            // 
            // BtnGrasp
            // 
            this.BtnGrasp.AutoSize = true;
            this.BtnGrasp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGrasp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnGrasp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrasp.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BtnGrasp.Location = new System.Drawing.Point(642, 371);
            this.BtnGrasp.Name = "BtnGrasp";
            this.BtnGrasp.Size = new System.Drawing.Size(50, 26);
            this.BtnGrasp.TabIndex = 15;
            this.BtnGrasp.Text = "会";
            this.BtnGrasp.UseVisualStyleBackColor = true;
            this.BtnGrasp.Click += new System.EventHandler(this.BtnGrasp_Click);
            // 
            // BtnUngrasp
            // 
            this.BtnUngrasp.AutoSize = true;
            this.BtnUngrasp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnUngrasp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnUngrasp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUngrasp.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BtnUngrasp.Location = new System.Drawing.Point(698, 371);
            this.BtnUngrasp.Name = "BtnUngrasp";
            this.BtnUngrasp.Size = new System.Drawing.Size(50, 26);
            this.BtnUngrasp.TabIndex = 16;
            this.BtnUngrasp.Text = "不会";
            this.BtnUngrasp.UseVisualStyleBackColor = true;
            this.BtnUngrasp.Click += new System.EventHandler(this.BtnUngrasp_Click);
            // 
            // BtnSelectAll
            // 
            this.BtnSelectAll.AutoSize = true;
            this.BtnSelectAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSelectAll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelectAll.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BtnSelectAll.Location = new System.Drawing.Point(543, 371);
            this.BtnSelectAll.Name = "BtnSelectAll";
            this.BtnSelectAll.Size = new System.Drawing.Size(50, 26);
            this.BtnSelectAll.TabIndex = 17;
            this.BtnSelectAll.Text = "全选";
            this.BtnSelectAll.UseVisualStyleBackColor = true;
            this.BtnSelectAll.Click += new System.EventHandler(this.BtnSelectAll_Click);
            // 
            // BtnCool
            // 
            this.BtnCool.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCool.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BtnCool.Location = new System.Drawing.Point(0, 0);
            this.BtnCool.Name = "BtnCool";
            this.BtnCool.Size = new System.Drawing.Size(5, 5);
            this.BtnCool.TabIndex = 18;
            this.BtnCool.Text = "一键全会";
            this.BtnCool.UseVisualStyleBackColor = true;
            this.BtnCool.Click += new System.EventHandler(this.BtnCool_Click);
            // 
            // LbxWord
            // 
            this.LbxWord.BackColor = System.Drawing.SystemColors.Control;
            this.LbxWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LbxWord.Font = new System.Drawing.Font("Arial", 12F);
            this.LbxWord.FormattingEnabled = true;
            this.LbxWord.ItemHeight = 18;
            this.LbxWord.Location = new System.Drawing.Point(543, 75);
            this.LbxWord.Margin = new System.Windows.Forms.Padding(2);
            this.LbxWord.Name = "LbxWord";
            this.LbxWord.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbxWord.Size = new System.Drawing.Size(204, 288);
            this.LbxWord.TabIndex = 19;
            this.LbxWord.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbxWord_MouseDoubleClick);
            this.LbxWord.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LbxWord_MouseUp);
            // 
            // MPB
            // 
            this.MPB.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MPB.Location = new System.Drawing.Point(348, 21);
            this.MPB.Margin = new System.Windows.Forms.Padding(4);
            this.MPB.Name = "MPB";
            this.MPB.Size = new System.Drawing.Size(188, 28);
            this.MPB.TabIndex = 12;
            this.MPB.Value = 1;
            // 
            // ArticleStudy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbxWord);
            this.Controls.Add(this.BtnCool);
            this.Controls.Add(this.BtnSelectAll);
            this.Controls.Add(this.BtnUngrasp);
            this.Controls.Add(this.BtnGrasp);
            this.Controls.Add(this.MPB);
            this.Controls.Add(this.TbxArticle);
            this.Controls.Add(this.TbxArticleContainer);
            this.Controls.Add(this.Tbx);
            this.Controls.Add(this.CbxDictionary);
            this.Controls.Add(this.BtnSearch);
            this.Name = "ArticleStudy";
            this.Size = new System.Drawing.Size(800, 426);
            this.CmsTextBox.ResumeLayout(false);
            this.CmsWordList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ComboBox CbxDictionary;
        private System.Windows.Forms.TextBox Tbx;
        private System.Windows.Forms.TextBox TbxArticleContainer;
        private System.Windows.Forms.TextBox TbxArticle;
        private System.Windows.Forms.FolderBrowserDialog FbdSearch;
        private MyProgressBar MPB;
        private System.Windows.Forms.ContextMenuStrip CmsWordList;
        private System.Windows.Forms.ToolStripMenuItem TsmGrasp;
        private System.Windows.Forms.ToolStripMenuItem TsmUnGrasp;
        private System.Windows.Forms.Button BtnGrasp;
        private System.Windows.Forms.Button BtnUngrasp;
        private System.Windows.Forms.Button BtnSelectAll;
        private System.Windows.Forms.ToolStripMenuItem TsmAddToWordbook;
        private System.Windows.Forms.ToolStripMenuItem TsmWordInfo;
        private System.Windows.Forms.ContextMenuStrip CmsTextBox;
        private System.Windows.Forms.ToolStripMenuItem 添加到单词列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmRespellingWord;
        private System.Windows.Forms.ToolStripMenuItem TsmAddWord;
        private System.Windows.Forms.ToolTip Ttp;
        private System.Windows.Forms.Button BtnCool;
        private System.Windows.Forms.ListBox LbxWord;
        private System.Windows.Forms.ToolStripMenuItem TsmPronunciation;
    }
}
