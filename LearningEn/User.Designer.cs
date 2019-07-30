namespace LearningEn
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.Mns = new System.Windows.Forms.MenuStrip();
            this.TsmRecite = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmWordBook = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmReadArticle = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmLoadDict = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmLoadWordbook = new System.Windows.Forms.ToolStripMenuItem();
            this.Tss = new System.Windows.Forms.ToolStripSeparator();
            this.TsmMoreSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmTools = new System.Windows.Forms.ToolStripMenuItem();
            this.测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Gbx = new System.Windows.Forms.GroupBox();
            this.Mns.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mns
            // 
            this.Mns.BackColor = System.Drawing.SystemColors.Control;
            this.Mns.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Mns.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Mns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmRecite,
            this.TsmSearch,
            this.TsmStatistic,
            this.TsmSetting,
            this.测试ToolStripMenuItem});
            this.Mns.Location = new System.Drawing.Point(0, 0);
            this.Mns.Name = "Mns";
            this.Mns.Size = new System.Drawing.Size(800, 29);
            this.Mns.TabIndex = 3;
            this.Mns.Text = "menuStrip1";
            // 
            // TsmRecite
            // 
            this.TsmRecite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmWordBook,
            this.TsmReadArticle});
            this.TsmRecite.Name = "TsmRecite";
            this.TsmRecite.Size = new System.Drawing.Size(70, 25);
            this.TsmRecite.Text = "背单词";
            this.TsmRecite.Click += new System.EventHandler(this.TsmRecite_Click);
            // 
            // TsmWordBook
            // 
            this.TsmWordBook.Name = "TsmWordBook";
            this.TsmWordBook.Size = new System.Drawing.Size(180, 26);
            this.TsmWordBook.Text = "单词书";
            this.TsmWordBook.Click += new System.EventHandler(this.TsmWordBook_Click);
            // 
            // TsmReadArticle
            // 
            this.TsmReadArticle.Name = "TsmReadArticle";
            this.TsmReadArticle.Size = new System.Drawing.Size(180, 26);
            this.TsmReadArticle.Text = "文章阅读";
            this.TsmReadArticle.Click += new System.EventHandler(this.TsmReadArticle_Click);
            // 
            // TsmSearch
            // 
            this.TsmSearch.Name = "TsmSearch";
            this.TsmSearch.Size = new System.Drawing.Size(70, 25);
            this.TsmSearch.Text = "查单词";
            this.TsmSearch.Click += new System.EventHandler(this.TsmSearch_Click);
            // 
            // TsmStatistic
            // 
            this.TsmStatistic.Name = "TsmStatistic";
            this.TsmStatistic.Size = new System.Drawing.Size(86, 25);
            this.TsmStatistic.Text = "统计视图";
            this.TsmStatistic.Click += new System.EventHandler(this.TsmStatistic_Click);
            // 
            // TsmSetting
            // 
            this.TsmSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmLoadDict,
            this.TsmLoadWordbook,
            this.Tss,
            this.TsmMoreSettings,
            this.TsmTools});
            this.TsmSetting.Name = "TsmSetting";
            this.TsmSetting.Size = new System.Drawing.Size(54, 25);
            this.TsmSetting.Text = "设置";
            // 
            // TsmLoadDict
            // 
            this.TsmLoadDict.Name = "TsmLoadDict";
            this.TsmLoadDict.Size = new System.Drawing.Size(240, 26);
            this.TsmLoadDict.Text = "加载词典";
            this.TsmLoadDict.Click += new System.EventHandler(this.TsmLoadDict_Click);
            // 
            // TsmLoadWordbook
            // 
            this.TsmLoadWordbook.Name = "TsmLoadWordbook";
            this.TsmLoadWordbook.Size = new System.Drawing.Size(240, 26);
            this.TsmLoadWordbook.Text = "加载单词书（未开放）";
            this.TsmLoadWordbook.Click += new System.EventHandler(this.TsmLoadWordbook_Click);
            // 
            // Tss
            // 
            this.Tss.Name = "Tss";
            this.Tss.Size = new System.Drawing.Size(237, 6);
            // 
            // TsmMoreSettings
            // 
            this.TsmMoreSettings.Name = "TsmMoreSettings";
            this.TsmMoreSettings.Size = new System.Drawing.Size(240, 26);
            this.TsmMoreSettings.Text = "更多设置";
            this.TsmMoreSettings.Click += new System.EventHandler(this.TsmMoreSettings_Click);
            // 
            // TsmTools
            // 
            this.TsmTools.Name = "TsmTools";
            this.TsmTools.Size = new System.Drawing.Size(240, 26);
            this.TsmTools.Text = "工具";
            this.TsmTools.Click += new System.EventHandler(this.TsmTools_Click);
            // 
            // 测试ToolStripMenuItem
            // 
            this.测试ToolStripMenuItem.Name = "测试ToolStripMenuItem";
            this.测试ToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.测试ToolStripMenuItem.Text = "测试";
            this.测试ToolStripMenuItem.Click += new System.EventHandler(this.测试ToolStripMenuItem_Click);
            // 
            // Gbx
            // 
            this.Gbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gbx.Location = new System.Drawing.Point(0, 32);
            this.Gbx.Name = "Gbx";
            this.Gbx.Size = new System.Drawing.Size(800, 418);
            this.Gbx.TabIndex = 4;
            this.Gbx.TabStop = false;
            this.Gbx.Paint += new System.Windows.Forms.PaintEventHandler(this.Gbx_Paint);
            this.Gbx.Resize += new System.EventHandler(this.User_Resize);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gbx);
            this.Controls.Add(this.Mns);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Mns;
            this.MinimumSize = new System.Drawing.Size(816, 487);
            this.Name = "User";
            this.Text = "V1.0.38 贝多芬究极无敌单词终结者限量版采用电脑大屏死记硬背法告别传统死记硬背不含转基因百年老字号妈妈再也不用担心我的英语单词是您背诵单词的好伴侣";
            this.Load += new System.EventHandler(this.User_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.User_KeyPress);
            this.Resize += new System.EventHandler(this.User_Resize);
            this.Mns.ResumeLayout(false);
            this.Mns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Mns;
        private System.Windows.Forms.ToolStripMenuItem TsmRecite;
        private System.Windows.Forms.ToolStripMenuItem TsmWordBook;
        private System.Windows.Forms.ToolStripMenuItem TsmSearch;
        private System.Windows.Forms.ToolStripMenuItem TsmStatistic;
        private System.Windows.Forms.GroupBox Gbx;
        private System.Windows.Forms.ToolStripMenuItem TsmSetting;
        private System.Windows.Forms.ToolStripMenuItem TsmLoadDict;
        private System.Windows.Forms.ToolStripMenuItem TsmLoadWordbook;
        private System.Windows.Forms.ToolStripMenuItem TsmReadArticle;
        private System.Windows.Forms.ToolStripMenuItem TsmMoreSettings;
        private System.Windows.Forms.ToolStripMenuItem 测试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmTools;
        private System.Windows.Forms.ToolStripSeparator Tss;
    }
}