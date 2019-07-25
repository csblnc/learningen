namespace LearningEn
{
    partial class Statistics
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
            this.CmsDict = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmDictProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbx = new System.Windows.Forms.TextBox();
            this.Pbx = new System.Windows.Forms.PictureBox();
            this.CmsDict.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx)).BeginInit();
            this.SuspendLayout();
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
            this.TsmDictProperties.Click += new System.EventHandler(this.TsmDictProperties_Click);
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
            // Pbx
            // 
            this.Pbx.Location = new System.Drawing.Point(78, 12);
            this.Pbx.Name = "Pbx";
            this.Pbx.Size = new System.Drawing.Size(900, 500);
            this.Pbx.TabIndex = 7;
            this.Pbx.TabStop = false;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pbx);
            this.Controls.Add(this.Tbx);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Statistics";
            this.Size = new System.Drawing.Size(1067, 530);
            this.Load += new System.EventHandler(this.Wordbook_Load);
            this.CmsDict.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Tbx;
        private System.Windows.Forms.ContextMenuStrip CmsDict;
        private System.Windows.Forms.ToolStripMenuItem TsmDictProperties;
        private System.Windows.Forms.PictureBox Pbx;
    }
}
