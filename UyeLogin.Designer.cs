namespace EKAKozmetik
{
    partial class UyeLogin
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
            this.label6 = new System.Windows.Forms.Label();
            this.sifreGirisTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mailGirisTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.girisBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(35, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "ÜYE GİRİŞ";
            // 
            // sifreGirisTxt
            // 
            this.sifreGirisTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreGirisTxt.Location = new System.Drawing.Point(118, 111);
            this.sifreGirisTxt.Name = "sifreGirisTxt";
            this.sifreGirisTxt.PasswordChar = '*';
            this.sifreGirisTxt.Size = new System.Drawing.Size(196, 22);
            this.sifreGirisTxt.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Şifre";
            // 
            // mailGirisTxt
            // 
            this.mailGirisTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailGirisTxt.Location = new System.Drawing.Point(118, 83);
            this.mailGirisTxt.Name = "mailGirisTxt";
            this.mailGirisTxt.Size = new System.Drawing.Size(196, 22);
            this.mailGirisTxt.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "e-Mail";
            // 
            // girisBtn
            // 
            this.girisBtn.FlatAppearance.BorderSize = 0;
            this.girisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisBtn.ForeColor = System.Drawing.Color.White;
            this.girisBtn.Location = new System.Drawing.Point(118, 139);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(196, 29);
            this.girisBtn.TabIndex = 27;
            this.girisBtn.Text = "GİRİŞ";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // UyeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 215);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sifreGirisTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mailGirisTxt);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UyeLogin";
            this.Text = "ÜyeLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sifreGirisTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mailGirisTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button girisBtn;
    }
}