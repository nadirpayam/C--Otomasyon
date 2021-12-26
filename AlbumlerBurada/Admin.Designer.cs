
namespace AlbumlerBurada
{
    partial class Admin
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
            this.txtBoxAdminSifre = new System.Windows.Forms.TextBox();
            this.txtBoxAdmin = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmingiris = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxAdminSifre
            // 
            this.txtBoxAdminSifre.BackColor = System.Drawing.Color.Red;
            this.txtBoxAdminSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAdminSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAdminSifre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxAdminSifre.Location = new System.Drawing.Point(327, 286);
            this.txtBoxAdminSifre.Multiline = true;
            this.txtBoxAdminSifre.Name = "txtBoxAdminSifre";
            this.txtBoxAdminSifre.PasswordChar = '*';
            this.txtBoxAdminSifre.Size = new System.Drawing.Size(261, 44);
            this.txtBoxAdminSifre.TabIndex = 29;
            // 
            // txtBoxAdmin
            // 
            this.txtBoxAdmin.BackColor = System.Drawing.Color.Red;
            this.txtBoxAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxAdmin.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBoxAdmin.Location = new System.Drawing.Point(327, 220);
            this.txtBoxAdmin.Multiline = true;
            this.txtBoxAdmin.Name = "txtBoxAdmin";
            this.txtBoxAdmin.Size = new System.Drawing.Size(261, 44);
            this.txtBoxAdmin.TabIndex = 28;
            // 
            // lblSoyad
            // 
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.White;
            this.lblSoyad.Location = new System.Drawing.Point(59, 286);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(182, 44);
            this.lblSoyad.TabIndex = 31;
            this.lblSoyad.Text = "Şifre:";
            // 
            // lblAd
            // 
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.White;
            this.lblAd.Location = new System.Drawing.Point(59, 220);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(197, 44);
            this.lblAd.TabIndex = 30;
            this.lblAd.Text = "Kullanıcı Ad:";
            this.lblAd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 155);
            this.label1.TabIndex = 32;
            this.label1.Text = "ADMİN GİRİŞ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdmingiris
            // 
            this.btnAdmingiris.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdmingiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmingiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdmingiris.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdmingiris.Location = new System.Drawing.Point(442, 378);
            this.btnAdmingiris.Name = "btnAdmingiris";
            this.btnAdmingiris.Size = new System.Drawing.Size(146, 98);
            this.btnAdmingiris.TabIndex = 34;
            this.btnAdmingiris.Text = "Giriş Yap";
            this.btnAdmingiris.UseVisualStyleBackColor = false;
            this.btnAdmingiris.Click += new System.EventHandler(this.btnAdmingiris_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(714, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 76);
            this.button1.TabIndex = 35;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(0, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 125);
            this.button2.TabIndex = 38;
            this.button2.Text = "Ana Sayfaya Dön";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlbumlerBurada.Properties.Resources.admin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdmingiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtBoxAdminSifre);
            this.Controls.Add(this.txtBoxAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxAdminSifre;
        private System.Windows.Forms.TextBox txtBoxAdmin;
        private System.Windows.Forms.Label lblSoyad;
        internal System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdmingiris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}