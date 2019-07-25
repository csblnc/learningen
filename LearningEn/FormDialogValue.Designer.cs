namespace LearningEn
{
    partial class FormDialogValue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDialogValue));
            this.TbxWord = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbxWord
            // 
            this.TbxWord.BackColor = System.Drawing.SystemColors.Window;
            this.TbxWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxWord.Font = new System.Drawing.Font("宋体", 15F);
            this.TbxWord.Location = new System.Drawing.Point(30, 40);
            this.TbxWord.Margin = new System.Windows.Forms.Padding(4);
            this.TbxWord.Name = "TbxWord";
            this.TbxWord.Size = new System.Drawing.Size(235, 29);
            this.TbxWord.TabIndex = 10;
            // 
            // BtnOK
            // 
            this.BtnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOK.Location = new System.Drawing.Point(30, 100);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(100, 35);
            this.BtnOK.TabIndex = 11;
            this.BtnOK.Text = "确定";
            this.BtnOK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCancel.Location = new System.Drawing.Point(165, 100);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 35);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FormDialogValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 168);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TbxWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDialogValue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "单词编辑";
            this.Load += new System.EventHandler(this.FormDialogValue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxWord;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
    }
}