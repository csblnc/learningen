namespace LearningEn
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Gbx = new System.Windows.Forms.GroupBox();
            this.DictSetting = new System.Windows.Forms.Label();
            this.PnlDictSetting = new System.Windows.Forms.Panel();
            this.PnlReciteSetting = new System.Windows.Forms.Panel();
            this.ReciteSetting = new System.Windows.Forms.Label();
            this.PnlWordbookSetting = new System.Windows.Forms.Panel();
            this.WordbookSetting = new System.Windows.Forms.Label();
            this.PnlDictSetting.SuspendLayout();
            this.PnlReciteSetting.SuspendLayout();
            this.PnlWordbookSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbx
            // 
            this.Gbx.Dock = System.Windows.Forms.DockStyle.Right;
            this.Gbx.Location = new System.Drawing.Point(106, 0);
            this.Gbx.Name = "Gbx";
            this.Gbx.Size = new System.Drawing.Size(478, 361);
            this.Gbx.TabIndex = 0;
            this.Gbx.TabStop = false;
            this.Gbx.Text = "groupBox1";
            // 
            // DictSetting
            // 
            this.DictSetting.AutoSize = true;
            this.DictSetting.Font = new System.Drawing.Font("宋体", 12F);
            this.DictSetting.Location = new System.Drawing.Point(10, 7);
            this.DictSetting.Name = "DictSetting";
            this.DictSetting.Size = new System.Drawing.Size(72, 16);
            this.DictSetting.TabIndex = 1;
            this.DictSetting.Text = "词典设置";
            this.DictSetting.Click += new System.EventHandler(this.DictSetting_Click);
            // 
            // PnlDictSetting
            // 
            this.PnlDictSetting.Controls.Add(this.DictSetting);
            this.PnlDictSetting.Location = new System.Drawing.Point(0, 0);
            this.PnlDictSetting.Name = "PnlDictSetting";
            this.PnlDictSetting.Size = new System.Drawing.Size(107, 30);
            this.PnlDictSetting.TabIndex = 3;
            // 
            // PnlReciteSetting
            // 
            this.PnlReciteSetting.Controls.Add(this.ReciteSetting);
            this.PnlReciteSetting.Location = new System.Drawing.Point(0, 30);
            this.PnlReciteSetting.Name = "PnlReciteSetting";
            this.PnlReciteSetting.Size = new System.Drawing.Size(107, 30);
            this.PnlReciteSetting.TabIndex = 4;
            // 
            // ReciteSetting
            // 
            this.ReciteSetting.AutoSize = true;
            this.ReciteSetting.Font = new System.Drawing.Font("宋体", 12F);
            this.ReciteSetting.Location = new System.Drawing.Point(10, 7);
            this.ReciteSetting.Name = "ReciteSetting";
            this.ReciteSetting.Size = new System.Drawing.Size(72, 16);
            this.ReciteSetting.TabIndex = 1;
            this.ReciteSetting.Text = "背诵设置";
            this.ReciteSetting.Click += new System.EventHandler(this.ReciteSetting_Click);
            // 
            // PnlWordbookSetting
            // 
            this.PnlWordbookSetting.Controls.Add(this.WordbookSetting);
            this.PnlWordbookSetting.Location = new System.Drawing.Point(0, 60);
            this.PnlWordbookSetting.Name = "PnlWordbookSetting";
            this.PnlWordbookSetting.Size = new System.Drawing.Size(107, 30);
            this.PnlWordbookSetting.TabIndex = 5;
            // 
            // WordbookSetting
            // 
            this.WordbookSetting.AutoSize = true;
            this.WordbookSetting.Font = new System.Drawing.Font("宋体", 12F);
            this.WordbookSetting.Location = new System.Drawing.Point(10, 7);
            this.WordbookSetting.Name = "WordbookSetting";
            this.WordbookSetting.Size = new System.Drawing.Size(88, 16);
            this.WordbookSetting.TabIndex = 1;
            this.WordbookSetting.Text = "单词书设置";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.PnlWordbookSetting);
            this.Controls.Add(this.PnlReciteSetting);
            this.Controls.Add(this.PnlDictSetting);
            this.Controls.Add(this.Gbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.PnlDictSetting.ResumeLayout(false);
            this.PnlDictSetting.PerformLayout();
            this.PnlReciteSetting.ResumeLayout(false);
            this.PnlReciteSetting.PerformLayout();
            this.PnlWordbookSetting.ResumeLayout(false);
            this.PnlWordbookSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbx;
        private System.Windows.Forms.Label DictSetting;
        private System.Windows.Forms.Panel PnlDictSetting;
        private System.Windows.Forms.Panel PnlReciteSetting;
        private System.Windows.Forms.Label ReciteSetting;
        private System.Windows.Forms.Panel PnlWordbookSetting;
        private System.Windows.Forms.Label WordbookSetting;
    }
}