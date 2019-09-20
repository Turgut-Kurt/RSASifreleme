namespace rsa
{
    partial class Anaform
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
            this.Txtmetin1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtsonuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtsonuc2 = new System.Windows.Forms.TextBox();
            this.BtnSifrecoz = new System.Windows.Forms.Button();
            this.Txtmetin2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSifrele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txtmetin1
            // 
            this.Txtmetin1.Location = new System.Drawing.Point(180, 81);
            this.Txtmetin1.Name = "Txtmetin1";
            this.Txtmetin1.Size = new System.Drawing.Size(204, 22);
            this.Txtmetin1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Şifrelenek Metini Giriniz ";
            // 
            // Txtsonuc
            // 
            this.Txtsonuc.Location = new System.Drawing.Point(180, 189);
            this.Txtsonuc.Multiline = true;
            this.Txtsonuc.Name = "Txtsonuc";
            this.Txtsonuc.Size = new System.Drawing.Size(204, 94);
            this.Txtsonuc.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Çözümlenmiş Metin";
            // 
            // Txtsonuc2
            // 
            this.Txtsonuc2.Location = new System.Drawing.Point(590, 189);
            this.Txtsonuc2.Multiline = true;
            this.Txtsonuc2.Name = "Txtsonuc2";
            this.Txtsonuc2.Size = new System.Drawing.Size(204, 94);
            this.Txtsonuc2.TabIndex = 26;
            // 
            // BtnSifrecoz
            // 
            this.BtnSifrecoz.Location = new System.Drawing.Point(635, 124);
            this.BtnSifrecoz.Name = "BtnSifrecoz";
            this.BtnSifrecoz.Size = new System.Drawing.Size(125, 41);
            this.BtnSifrecoz.TabIndex = 25;
            this.BtnSifrecoz.Text = "Decrypt";
            this.BtnSifrecoz.UseVisualStyleBackColor = true;
            this.BtnSifrecoz.Click += new System.EventHandler(this.BtnSifrecoz_Click);
            // 
            // Txtmetin2
            // 
            this.Txtmetin2.Location = new System.Drawing.Point(590, 76);
            this.Txtmetin2.Name = "Txtmetin2";
            this.Txtmetin2.Size = new System.Drawing.Size(204, 22);
            this.Txtmetin2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Şifrelenek Metini Giriniz ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Şifrelenmiş Metin";
            // 
            // BtnSifrele
            // 
            this.BtnSifrele.Location = new System.Drawing.Point(225, 124);
            this.BtnSifrele.Name = "BtnSifrele";
            this.BtnSifrele.Size = new System.Drawing.Size(125, 41);
            this.BtnSifrele.TabIndex = 21;
            this.BtnSifrele.Text = "Encrypt";
            this.BtnSifrele.UseVisualStyleBackColor = true;
            this.BtnSifrele.Click += new System.EventHandler(this.BtnSifrele_Click);
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 353);
            this.Controls.Add(this.Txtmetin1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtsonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txtsonuc2);
            this.Controls.Add(this.BtnSifrecoz);
            this.Controls.Add(this.Txtmetin2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSifrele);
            this.Name = "Anaform";
            this.Text = "RSA Şifreleme";
            this.Load += new System.EventHandler(this.Anaform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txtmetin1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtsonuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtsonuc2;
        private System.Windows.Forms.Button BtnSifrecoz;
        private System.Windows.Forms.TextBox Txtmetin2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSifrele;
    }
}

