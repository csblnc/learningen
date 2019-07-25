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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClbDictSetting = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClbWordbookSetting = new System.Windows.Forms.CheckedListBox();
            this.CbxDefaultDict = new System.Windows.Forms.ComboBox();
            this.CbxDefaultWordbook = new System.Windows.Forms.ComboBox();
            this.CTBDict = new LearningEn.CTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label1.Location = new System.Drawing.Point(10, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "默认词典";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F);
            this.label2.Location = new System.Drawing.Point(236, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "默认单词书";
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
            // CbxDefaultDict
            // 
            this.CbxDefaultDict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDefaultDict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxDefaultDict.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CbxDefaultDict.FormattingEnabled = true;
            this.CbxDefaultDict.Location = new System.Drawing.Point(75, 244);
            this.CbxDefaultDict.Name = "CbxDefaultDict";
            this.CbxDefaultDict.Size = new System.Drawing.Size(147, 28);
            this.CbxDefaultDict.TabIndex = 10;
            this.CbxDefaultDict.SelectedIndexChanged += new System.EventHandler(this.CbxDefaultDict_SelectedIndexChanged);
            this.CbxDefaultDict.MouseEnter += new System.EventHandler(this.CbxDefaultDict_MouseEnter);
            // 
            // CbxDefaultWordbook
            // 
            this.CbxDefaultWordbook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDefaultWordbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxDefaultWordbook.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.CbxDefaultWordbook.FormattingEnabled = true;
            this.CbxDefaultWordbook.Location = new System.Drawing.Point(315, 244);
            this.CbxDefaultWordbook.Name = "CbxDefaultWordbook";
            this.CbxDefaultWordbook.Size = new System.Drawing.Size(147, 28);
            this.CbxDefaultWordbook.TabIndex = 11;
            this.CbxDefaultWordbook.SelectedIndexChanged += new System.EventHandler(this.CbxDefaultWordbook_SelectedIndexChanged);
            this.CbxDefaultWordbook.MouseEnter += new System.EventHandler(this.CbxDefaultWordbook_MouseEnter);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "（未开放）";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "（未开放）";
            // 
            // DictSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbxDefaultWordbook);
            this.Controls.Add(this.CbxDefaultDict);
            this.Controls.Add(this.ClbWordbookSetting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClbDictSetting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CTBDict);
            this.Name = "DictSettings";
            this.Size = new System.Drawing.Size(478, 361);
            this.Load += new System.EventHandler(this.DictSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CTextBox CTBDict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ClbDictSetting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox ClbWordbookSetting;
        private System.Windows.Forms.ComboBox CbxDefaultDict;
        private System.Windows.Forms.ComboBox CbxDefaultWordbook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
