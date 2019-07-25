namespace LearningEn
{
    partial class GenerateArticle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateArticle));
            this.Rtb = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbNew = new System.Windows.Forms.ToolStripButton();
            this.TsbTransform = new System.Windows.Forms.ToolStripButton();
            this.Tss = new System.Windows.Forms.ToolStripSeparator();
            this.TsbLbl = new System.Windows.Forms.ToolStripLabel();
            this.TsbTbx = new System.Windows.Forms.ToolStripTextBox();
            this.TsbBrowser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TsbFileName = new System.Windows.Forms.ToolStripTextBox();
            this.TsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Ste = new LearningEn.SyntaxEditor();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rtb
            // 
            this.Rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtb.Font = new System.Drawing.Font("宋体", 10.5F);
            this.Rtb.Location = new System.Drawing.Point(8, 28);
            this.Rtb.Name = "Rtb";
            this.Rtb.Size = new System.Drawing.Size(670, 406);
            this.Rtb.TabIndex = 10;
            this.Rtb.Text = "";
            this.Rtb.TextChanged += new System.EventHandler(this.Rtb_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbNew,
            this.TsbTransform,
            this.Tss,
            this.TsbLbl,
            this.TsbTbx,
            this.TsbBrowser,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.TsbFileName,
            this.TsbSave,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(694, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStrip1_Paint);
            // 
            // TsbNew
            // 
            this.TsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbNew.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.TsbNew.Image = global::LearningEn.Properties.Resources.newfile;
            this.TsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNew.Name = "TsbNew";
            this.TsbNew.Size = new System.Drawing.Size(23, 22);
            this.TsbNew.Text = "toolStripButton1";
            this.TsbNew.ToolTipText = "新建";
            this.TsbNew.Click += new System.EventHandler(this.TsbNew_Click);
            // 
            // TsbTransform
            // 
            this.TsbTransform.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbTransform.Image = global::LearningEn.Properties.Resources.transform;
            this.TsbTransform.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbTransform.Name = "TsbTransform";
            this.TsbTransform.Size = new System.Drawing.Size(23, 22);
            this.TsbTransform.Text = "TXT";
            this.TsbTransform.ToolTipText = "显示超文本视图";
            this.TsbTransform.Click += new System.EventHandler(this.TsbTransform_Click);
            this.TsbTransform.TextChanged += new System.EventHandler(this.TsbTransform_TextChanged);
            // 
            // Tss
            // 
            this.Tss.ForeColor = System.Drawing.Color.White;
            this.Tss.Name = "Tss";
            this.Tss.Size = new System.Drawing.Size(6, 25);
            // 
            // TsbLbl
            // 
            this.TsbLbl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsbLbl.Image = ((System.Drawing.Image)(resources.GetObject("TsbLbl.Image")));
            this.TsbLbl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbLbl.Name = "TsbLbl";
            this.TsbLbl.Size = new System.Drawing.Size(56, 22);
            this.TsbLbl.Text = "保存位置";
            // 
            // TsbTbx
            // 
            this.TsbTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TsbTbx.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.TsbTbx.Name = "TsbTbx";
            this.TsbTbx.Size = new System.Drawing.Size(150, 25);
            this.TsbTbx.ToolTipText = "保存路径";
            // 
            // TsbBrowser
            // 
            this.TsbBrowser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbBrowser.Image = global::LearningEn.Properties.Resources.browser;
            this.TsbBrowser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbBrowser.Name = "TsbBrowser";
            this.TsbBrowser.Size = new System.Drawing.Size(23, 22);
            this.TsbBrowser.ToolTipText = "浏览";
            this.TsbBrowser.Click += new System.EventHandler(this.TsbBrowser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel1.Text = "文件名";
            // 
            // TsbFileName
            // 
            this.TsbFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TsbFileName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.TsbFileName.Name = "TsbFileName";
            this.TsbFileName.Size = new System.Drawing.Size(100, 25);
            this.TsbFileName.ToolTipText = "文件名";
            // 
            // TsbSave
            // 
            this.TsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSave.Image = global::LearningEn.Properties.Resources.save;
            this.TsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSave.Name = "TsbSave";
            this.TsbSave.Size = new System.Drawing.Size(23, 22);
            this.TsbSave.Text = "toolStripButton2";
            this.TsbSave.ToolTipText = "保存";
            this.TsbSave.Click += new System.EventHandler(this.TsbSave_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton1.Text = "测试";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Ste
            // 
            this.Ste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ste.Font = new System.Drawing.Font("宋体", 10.5F);
            this.Ste.Language = LearningEn.SyntaxEditor.Languages.CSHARP;
            this.Ste.Location = new System.Drawing.Point(8, 28);
            this.Ste.Name = "Ste";
            this.Ste.Size = new System.Drawing.Size(670, 406);
            this.Ste.TabIndex = 12;
            this.Ste.Text = "";
            this.Ste.WordWrap = false;
            this.Ste.TextChanged += new System.EventHandler(this.Ste_TextChanged);
            // 
            // GenerateArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Rtb);
            this.Controls.Add(this.Ste);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GenerateArticle";
            this.Size = new System.Drawing.Size(694, 450);
            this.Load += new System.EventHandler(this.GenerateArticle_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Rtb;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbNew;
        private System.Windows.Forms.ToolStripButton TsbSave;
        private System.Windows.Forms.ToolStripTextBox TsbTbx;
        private System.Windows.Forms.ToolStripSeparator Tss;
        private System.Windows.Forms.ToolStripButton TsbBrowser;
        private System.Windows.Forms.ToolStripLabel TsbLbl;
        private System.Windows.Forms.ToolStripButton TsbTransform;
        private SyntaxEditor Ste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TsbFileName;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
