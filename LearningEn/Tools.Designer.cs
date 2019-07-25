namespace LearningEn
{
    partial class Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tools));
            this.Gbx = new System.Windows.Forms.GroupBox();
            this.GenerateArticle = new System.Windows.Forms.Label();
            this.PnlDictSetting = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlDictSetting.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbx
            // 
            this.Gbx.Dock = System.Windows.Forms.DockStyle.Right;
            this.Gbx.Location = new System.Drawing.Point(106, 0);
            this.Gbx.Name = "Gbx";
            this.Gbx.Size = new System.Drawing.Size(694, 450);
            this.Gbx.TabIndex = 0;
            this.Gbx.TabStop = false;
            this.Gbx.Text = "groupBox1";
            // 
            // GenerateArticle
            // 
            this.GenerateArticle.AutoSize = true;
            this.GenerateArticle.Font = new System.Drawing.Font("宋体", 12F);
            this.GenerateArticle.Location = new System.Drawing.Point(10, 7);
            this.GenerateArticle.Name = "GenerateArticle";
            this.GenerateArticle.Size = new System.Drawing.Size(88, 16);
            this.GenerateArticle.TabIndex = 1;
            this.GenerateArticle.Text = "文章生成器";
            this.GenerateArticle.Click += new System.EventHandler(this.GenerateArticle_Click);
            // 
            // PnlDictSetting
            // 
            this.PnlDictSetting.Controls.Add(this.GenerateArticle);
            this.PnlDictSetting.Location = new System.Drawing.Point(0, 0);
            this.PnlDictSetting.Name = "PnlDictSetting";
            this.PnlDictSetting.Size = new System.Drawing.Size(107, 30);
            this.PnlDictSetting.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 30);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "添加单词本";
            // 
            // Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlDictSetting);
            this.Controls.Add(this.Gbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工具";
            this.PnlDictSetting.ResumeLayout(false);
            this.PnlDictSetting.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbx;
        private System.Windows.Forms.Label GenerateArticle;
        private System.Windows.Forms.Panel PnlDictSetting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}