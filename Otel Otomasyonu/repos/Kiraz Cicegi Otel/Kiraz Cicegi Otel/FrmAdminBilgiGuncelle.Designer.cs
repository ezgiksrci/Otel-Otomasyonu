﻿namespace Kiraz_Cicegi_Otel
{
    partial class FrmAdminBilgiGuncelle
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
            this.TxtYeniKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TxtParola = new System.Windows.Forms.TextBox();
            this.TxtYParolaTekrar = new System.Windows.Forms.TextBox();
            this.TxtYParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtGuncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtYeniKullaniciAdi
            // 
            this.TxtYeniKullaniciAdi.Location = new System.Drawing.Point(133, 23);
            this.TxtYeniKullaniciAdi.Name = "TxtYeniKullaniciAdi";
            this.TxtYeniKullaniciAdi.Size = new System.Drawing.Size(164, 25);
            this.TxtYeniKullaniciAdi.TabIndex = 0;
            // 
            // TxtParola
            // 
            this.TxtParola.Location = new System.Drawing.Point(133, 54);
            this.TxtParola.Name = "TxtParola";
            this.TxtParola.PasswordChar = '*';
            this.TxtParola.Size = new System.Drawing.Size(164, 25);
            this.TxtParola.TabIndex = 1;
            this.TxtParola.UseSystemPasswordChar = true;
            // 
            // TxtYParolaTekrar
            // 
            this.TxtYParolaTekrar.Location = new System.Drawing.Point(133, 116);
            this.TxtYParolaTekrar.Name = "TxtYParolaTekrar";
            this.TxtYParolaTekrar.Size = new System.Drawing.Size(164, 25);
            this.TxtYParolaTekrar.TabIndex = 3;
            this.TxtYParolaTekrar.UseSystemPasswordChar = true;
            // 
            // TxtYParola
            // 
            this.TxtYParola.Location = new System.Drawing.Point(133, 85);
            this.TxtYParola.Name = "TxtYParola";
            this.TxtYParola.Size = new System.Drawing.Size(164, 25);
            this.TxtYParola.TabIndex = 2;
            this.TxtYParola.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yeni Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şu Anki Parola:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni Parola:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yeni Parola Tekrar:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.TxtGuncelle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtYeniKullaniciAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtParola);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtYParolaTekrar);
            this.groupBox1.Controls.Add(this.TxtYParola);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 207);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // TxtGuncelle
            // 
            this.TxtGuncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TxtGuncelle.BackColor = System.Drawing.Color.LightSlateGray;
            this.TxtGuncelle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.TxtGuncelle.ForeColor = System.Drawing.Color.Black;
            this.TxtGuncelle.Location = new System.Drawing.Point(133, 147);
            this.TxtGuncelle.Name = "TxtGuncelle";
            this.TxtGuncelle.Size = new System.Drawing.Size(164, 45);
            this.TxtGuncelle.TabIndex = 4;
            this.TxtGuncelle.Text = "Güncelle";
            this.TxtGuncelle.UseVisualStyleBackColor = false;
            this.TxtGuncelle.Click += new System.EventHandler(this.TxtGuncelle_Click);
            // 
            // FrmAdminBilgiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(337, 230);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminBilgiGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Bilgilerini Güncelle";
            this.Load += new System.EventHandler(this.FrmAdminBilgiGuncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtYeniKullaniciAdi;
        private System.Windows.Forms.TextBox TxtParola;
        private System.Windows.Forms.TextBox TxtYParolaTekrar;
        private System.Windows.Forms.TextBox TxtYParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TxtGuncelle;
    }
}