namespace LearningEn
{
    partial class Dictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dictionary));
            this.CbxSearch = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.CbxDictionary = new System.Windows.Forms.ComboBox();
            this.CmsDict = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmDictProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbx = new System.Windows.Forms.TextBox();
            this.BtnVoice = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.CmsDict.SuspendLayout();
            this.SuspendLayout();
            // 
            // CbxSearch
            // 
            this.CbxSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxSearch.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CbxSearch.FormattingEnabled = true;
            this.CbxSearch.Location = new System.Drawing.Point(64, 26);
            this.CbxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.CbxSearch.Name = "CbxSearch";
            this.CbxSearch.Size = new System.Drawing.Size(239, 33);
            this.CbxSearch.TabIndex = 0;
            this.CbxSearch.SelectedIndexChanged += new System.EventHandler(this.CbxSearch_SelectedIndexChanged);
            this.CbxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cbx_KeyDown);
            this.CbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbx_KeyPress);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSearch.Location = new System.Drawing.Point(312, 26);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(100, 35);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "查询";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // CbxDictionary
            // 
            this.CbxDictionary.BackColor = System.Drawing.SystemColors.Window;
            this.CbxDictionary.ContextMenuStrip = this.CmsDict;
            this.CbxDictionary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxDictionary.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CbxDictionary.FormattingEnabled = true;
            this.CbxDictionary.Location = new System.Drawing.Point(724, 29);
            this.CbxDictionary.Margin = new System.Windows.Forms.Padding(4);
            this.CbxDictionary.Name = "CbxDictionary";
            this.CbxDictionary.Size = new System.Drawing.Size(272, 33);
            this.CbxDictionary.TabIndex = 5;
            this.CbxDictionary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cbx_KeyDown);
            this.CbxDictionary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbx_KeyPress);
            this.CbxDictionary.MouseEnter += new System.EventHandler(this.CbxDictionary_MouseEnter);
            // 
            // CmsDict
            // 
            this.CmsDict.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsDict.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmDictProperties});
            this.CmsDict.Name = "CmsDict";
            this.CmsDict.Size = new System.Drawing.Size(109, 28);
            // 
            // TsmDictProperties
            // 
            this.TsmDictProperties.Name = "TsmDictProperties";
            this.TsmDictProperties.Size = new System.Drawing.Size(108, 24);
            this.TsmDictProperties.Text = "属性";
            // 
            // Tbx
            // 
            this.Tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbx.Font = new System.Drawing.Font("Arial", 15F);
            this.Tbx.Location = new System.Drawing.Point(64, 94);
            this.Tbx.Margin = new System.Windows.Forms.Padding(4);
            this.Tbx.Multiline = true;
            this.Tbx.Name = "Tbx";
            this.Tbx.ReadOnly = true;
            this.Tbx.Size = new System.Drawing.Size(933, 400);
            this.Tbx.TabIndex = 6;
            this.Tbx.TabStop = false;
            // 
            // BtnVoice
            // 
            this.BtnVoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnVoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnVoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoice.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnVoice.Image = ((System.Drawing.Image)(resources.GetObject("BtnVoice.Image")));
            this.BtnVoice.Location = new System.Drawing.Point(420, 26);
            this.BtnVoice.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVoice.Name = "BtnVoice";
            this.BtnVoice.Size = new System.Drawing.Size(37, 35);
            this.BtnVoice.TabIndex = 7;
            this.BtnVoice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVoice.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnVoice.UseVisualStyleBackColor = true;
            this.BtnVoice.Click += new System.EventHandler(this.BtnVoice_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnReturn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturn.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnReturn.Location = new System.Drawing.Point(465, 26);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(100, 35);
            this.BtnReturn.TabIndex = 8;
            this.BtnReturn.Text = "返回";
            this.BtnReturn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Visible = false;
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnVoice);
            this.Controls.Add(this.CbxSearch);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.CbxDictionary);
            this.Controls.Add(this.Tbx);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dictionary";
            this.Size = new System.Drawing.Size(1067, 530);
            this.Load += new System.EventHandler(this.Dictionary_Load);
            this.CmsDict.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ComboBox CbxDictionary;
        private System.Windows.Forms.TextBox Tbx;
        private System.Windows.Forms.ContextMenuStrip CmsDict;
        private System.Windows.Forms.ToolStripMenuItem TsmDictProperties;
        private System.Windows.Forms.Button BtnVoice;
        private System.Windows.Forms.Button BtnReturn;
    }
}
