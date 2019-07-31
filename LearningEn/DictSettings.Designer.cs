namespace LearningEn
{
    partial class DictSettings
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
            this.ClbDictSetting = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClbWordbookSetting = new System.Windows.Forms.CheckedListBox();
            this.CTBDict = new LearningEn.CTextBox();
            this.CTBDefaultDict = new LearningEn.CTextBox();
            this.CTBDefaultWordbook = new LearningEn.CTextBox();
            this.SuspendLayout();
            // 
            // ClbDictSetting
            // 
            this.ClbDictSetting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClbDictSetting.CheckOnClick = true;
            this.ClbDictSetting.Font = new System.Drawing.Font("宋体", 10.5F);
            this.ClbDictSetting.FormattingEnabled = true;
            this.ClbDictSetting.Location = new System.Drawing.Point(75, 52);
            this.ClbDictSetting.Name = "ClbDictSetting";
            this.ClbDictSetting.Size = new System.Drawing.Size(146, 180);
            this.ClbDictSetting.TabIndex = 6;
            this.ClbDictSetting.SelectedIndexChanged += new System.EventHandler(this.ClbDictSetting_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "设置词典";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label4.Location = new System.Drawing.Point(236, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "设置单词书";
            // 
            // ClbWordbookSetting
            // 
            this.ClbWordbookSetting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClbWordbookSetting.CheckOnClick = true;
            this.ClbWordbookSetting.Font = new System.Drawing.Font("宋体", 10.5F);
            this.ClbWordbookSetting.FormattingEnabled = true;
            this.ClbWordbookSetting.Location = new System.Drawing.Point(315, 52);
            this.ClbWordbookSetting.Name = "ClbWordbookSetting";
            this.ClbWordbookSetting.Size = new System.Drawing.Size(146, 180);
            this.ClbWordbookSetting.TabIndex = 9;
            this.ClbWordbookSetting.SelectedValueChanged += new System.EventHandler(this.ClbWordbookSetting_SelectedIndexChanged);
            // 
            // CTBDict
            // 
            this.CTBDict.AllowMultiline = false;
            this.CTBDict.Button = "浏览";
            this.CTBDict.DispalyOpenButton = false;
            this.CTBDict.Label = "label";
            this.CTBDict.Location = new System.Drawing.Point(8, 8);
            this.CTBDict.Margin = new System.Windows.Forms.Padding(4);
            this.CTBDict.Name = "CTBDict";
            this.CTBDict.Size = new System.Drawing.Size(454, 32);
            this.CTBDict.TabIndex = 3;
            this.CTBDict.Value = "";
            // 
            // CTBDefaultDict
            // 
            this.CTBDefaultDict.AllowMultiline = false;
            this.CTBDefaultDict.Button = "button1";
            this.CTBDefaultDict.DispalyOpenButton = false;
            this.CTBDefaultDict.Label = "label";
            this.CTBDefaultDict.Location = new System.Drawing.Point(13, 245);
            this.CTBDefaultDict.Name = "CTBDefaultDict";
            this.CTBDefaultDict.Size = new System.Drawing.Size(448, 35);
            this.CTBDefaultDict.TabIndex = 20;
            this.CTBDefaultDict.Value = "";
            // 
            // CTBDefaultWordbook
            // 
            this.CTBDefaultWordbook.AllowMultiline = false;
            this.CTBDefaultWordbook.Button = "button1";
            this.CTBDefaultWordbook.DispalyOpenButton = false;
            this.CTBDefaultWordbook.Label = "label";
            this.CTBDefaultWordbook.Location = new System.Drawing.Point(13, 295);
            this.CTBDefaultWordbook.Name = "CTBDefaultWordbook";
            this.CTBDefaultWordbook.Size = new System.Drawing.Size(448, 35);
            this.CTBDefaultWordbook.TabIndex = 21;
            this.CTBDefaultWordbook.Value = "";
            // 
            // DictSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.CTBDefaultWordbook);
            this.Controls.Add(this.CTBDefaultDict);
            this.Controls.Add(this.ClbWordbookSetting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClbDictSetting);
            this.Controls.Add(this.CTBDict);
            this.Name = "DictSettings";
            this.Size = new System.Drawing.Size(478, 361);
            this.Load += new System.EventHandler(this.DictSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CTextBox CTBDict;
        private System.Windows.Forms.CheckedListBox ClbDictSetting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox ClbWordbookSetting;
        private CTextBox CTBDefaultDict;
        private CTextBox CTBDefaultWordbook;
    }
}
