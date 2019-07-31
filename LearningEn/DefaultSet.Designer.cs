namespace LearningEn
{
    partial class DefaultSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultSet));
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.Lbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOK.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnOK.Location = new System.Drawing.Point(216, 36);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(61, 28);
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
            this.BtnCancel.Location = new System.Drawing.Point(216, 92);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(61, 28);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Lbx
            // 
            this.Lbx.BackColor = System.Drawing.SystemColors.Control;
            this.Lbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lbx.Font = new System.Drawing.Font("宋体", 10.5F);
            this.Lbx.FormattingEnabled = true;
            this.Lbx.ItemHeight = 14;
            this.Lbx.Location = new System.Drawing.Point(11, 11);
            this.Lbx.Margin = new System.Windows.Forms.Padding(2);
            this.Lbx.Name = "Lbx";
            this.Lbx.Size = new System.Drawing.Size(200, 154);
            this.Lbx.TabIndex = 21;
            // 
            // DefaultSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.Lbx);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefaultSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "单词编辑";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ListBox Lbx;
    }
}