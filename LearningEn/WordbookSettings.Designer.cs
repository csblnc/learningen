namespace LearningEn
{
    partial class WordbookSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.TbxReciteNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTip = new System.Windows.Forms.Label();
            this.CbxDefaultArticleDict = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CTBArticle = new LearningEn.CTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Gbx = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.Gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label1.Location = new System.Drawing.Point(10, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "单词复现阈值";
            // 
            // TbxReciteNumber
            // 
            this.TbxReciteNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TbxReciteNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxReciteNumber.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.TbxReciteNumber.Location = new System.Drawing.Point(0, 4);
            this.TbxReciteNumber.Name = "TbxReciteNumber";
            this.TbxReciteNumber.Size = new System.Drawing.Size(100, 19);
            this.TbxReciteNumber.TabIndex = 2;
            this.TbxReciteNumber.TextChanged += new System.EventHandler(this.TbxReciteNumber_TextChanged);
            this.TbxReciteNumber.Leave += new System.EventHandler(this.TbxReciteNumber_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.TbxReciteNumber);
            this.panel1.Location = new System.Drawing.Point(101, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 28);
            this.panel1.TabIndex = 3;
            // 
            // LblTip
            // 
            this.LblTip.AutoSize = true;
            this.LblTip.Font = new System.Drawing.Font("宋体", 10.5F);
            this.LblTip.Location = new System.Drawing.Point(207, 98);
            this.LblTip.Name = "LblTip";
            this.LblTip.Size = new System.Drawing.Size(105, 14);
            this.LblTip.TabIndex = 4;
            this.LblTip.Text = "取值范围：1-10";
            // 
            // CbxDefaultArticleDict
            // 
            this.CbxDefaultArticleDict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDefaultArticleDict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxDefaultArticleDict.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.CbxDefaultArticleDict.FormattingEnabled = true;
            this.CbxDefaultArticleDict.Location = new System.Drawing.Point(101, 52);
            this.CbxDefaultArticleDict.Name = "CbxDefaultArticleDict";
            this.CbxDefaultArticleDict.Size = new System.Drawing.Size(151, 28);
            this.CbxDefaultArticleDict.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label5.Location = new System.Drawing.Point(10, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "默认单词本";
            // 
            // CTBArticle
            // 
            this.CTBArticle.AllowMultiline = false;
            this.CTBArticle.Button = "浏览";
            this.CTBArticle.DispalyOpenButton = false;
            this.CTBArticle.Label = "label";
            this.CTBArticle.Location = new System.Drawing.Point(8, 8);
            this.CTBArticle.Margin = new System.Windows.Forms.Padding(4);
            this.CTBArticle.Name = "CTBArticle";
            this.CTBArticle.Size = new System.Drawing.Size(454, 32);
            this.CTBArticle.TabIndex = 5;
            this.CTBArticle.Value = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "（未开放）";
            // 
            // Gbx
            // 
            this.Gbx.Controls.Add(this.BtnSearch);
            this.Gbx.Controls.Add(this.label3);
            this.Gbx.Controls.Add(this.comboBox1);
            this.Gbx.Font = new System.Drawing.Font("宋体", 10.5F);
            this.Gbx.Location = new System.Drawing.Point(0, 205);
            this.Gbx.Name = "Gbx";
            this.Gbx.Size = new System.Drawing.Size(478, 156);
            this.Gbx.TabIndex = 18;
            this.Gbx.TabStop = false;
            this.Gbx.Text = "单词本乱序";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("宋体", 10.5F);
            this.BtnSearch.Location = new System.Drawing.Point(260, 22);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(52, 28);
            this.BtnSearch.TabIndex = 20;
            this.BtnSearch.Text = "生成";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label3.Location = new System.Drawing.Point(10, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 19;
            this.label3.Text = "选择单词本";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 19;
            // 
            // WordbookSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Gbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxDefaultArticleDict);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CTBArticle);
            this.Controls.Add(this.LblTip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "WordbookSettings";
            this.Size = new System.Drawing.Size(478, 361);
            this.Load += new System.EventHandler(this.ReciteSettings_Load);
            this.Click += new System.EventHandler(this.ReciteSettings_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Gbx.ResumeLayout(false);
            this.Gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxReciteNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTip;
        private CTextBox CTBArticle;
        private System.Windows.Forms.ComboBox CbxDefaultArticleDict;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Gbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnSearch;
    }
}
