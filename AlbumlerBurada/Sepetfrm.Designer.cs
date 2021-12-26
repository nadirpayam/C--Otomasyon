
namespace AlbumlerBurada
{
    partial class Sepetfrm
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
            this.btnSiparis = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxVergi = new System.Windows.Forms.TextBox();
            this.textBoxToplamTutar = new System.Windows.Forms.TextBox();
            this.textBoxAdet = new System.Windows.Forms.TextBox();
            this.textBoxTutar = new System.Windows.Forms.TextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewSepet1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSepet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSiparis
            // 
            this.btnSiparis.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSiparis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparis.ForeColor = System.Drawing.Color.White;
            this.btnSiparis.Location = new System.Drawing.Point(907, 618);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(98, 93);
            this.btnSiparis.TabIndex = 76;
            this.btnSiparis.Text = "Sipariş Ver";
            this.btnSiparis.UseVisualStyleBackColor = false;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(557, 570);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 33);
            this.label9.TabIndex = 75;
            this.label9.Text = "Ödeme Yöntemi Seçiniz:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı",
            "Çek"});
            this.comboBox1.Location = new System.Drawing.Point(811, 578);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 24);
            this.comboBox1.TabIndex = 74;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(885, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 67);
            this.button2.TabIndex = 73;
            this.button2.Text = "Sepet Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxVergi
            // 
            this.textBoxVergi.Location = new System.Drawing.Point(811, 423);
            this.textBoxVergi.Multiline = true;
            this.textBoxVergi.Name = "textBoxVergi";
            this.textBoxVergi.Size = new System.Drawing.Size(136, 33);
            this.textBoxVergi.TabIndex = 72;
            // 
            // textBoxToplamTutar
            // 
            this.textBoxToplamTutar.Location = new System.Drawing.Point(811, 491);
            this.textBoxToplamTutar.Multiline = true;
            this.textBoxToplamTutar.Name = "textBoxToplamTutar";
            this.textBoxToplamTutar.Size = new System.Drawing.Size(136, 44);
            this.textBoxToplamTutar.TabIndex = 71;
            // 
            // textBoxAdet
            // 
            this.textBoxAdet.Location = new System.Drawing.Point(862, 151);
            this.textBoxAdet.Multiline = true;
            this.textBoxAdet.Name = "textBoxAdet";
            this.textBoxAdet.Size = new System.Drawing.Size(100, 41);
            this.textBoxAdet.TabIndex = 70;
            // 
            // textBoxTutar
            // 
            this.textBoxTutar.Location = new System.Drawing.Point(811, 362);
            this.textBoxTutar.Multiline = true;
            this.textBoxTutar.Name = "textBoxTutar";
            this.textBoxTutar.Size = new System.Drawing.Size(136, 40);
            this.textBoxTutar.TabIndex = 69;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(347, 407);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(142, 196);
            this.listBox3.TabIndex = 68;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(177, 407);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(142, 196);
            this.listBox2.TabIndex = 67;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 407);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 196);
            this.listBox1.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(742, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 33);
            this.label8.TabIndex = 65;
            this.label8.Text = "Adedi:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(656, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 33);
            this.label7.TabIndex = 64;
            this.label7.Text = "Vergi:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(633, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 33);
            this.label6.TabIndex = 63;
            this.label6.Text = "Toplam Tutar:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(656, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 33);
            this.label5.TabIndex = 62;
            this.label5.Text = "Tutar:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(375, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 33);
            this.label4.TabIndex = 61;
            this.label4.Text = "Tutar:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(205, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 33);
            this.label3.TabIndex = 60;
            this.label3.Text = "Adedi:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 33);
            this.label2.TabIndex = 59;
            this.label2.Text = "Albüm Adı:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-121, -112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 45);
            this.label1.TabIndex = 58;
            this.label1.Text = "Albüm Seçiniz:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(839, -135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 76);
            this.button1.TabIndex = 57;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewSepet1
            // 
            this.dataGridViewSepet1.AllowUserToAddRows = false;
            this.dataGridViewSepet1.AllowUserToDeleteRows = false;
            this.dataGridViewSepet1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSepet1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSepet1.Location = new System.Drawing.Point(12, 67);
            this.dataGridViewSepet1.Name = "dataGridViewSepet1";
            this.dataGridViewSepet1.ReadOnly = true;
            this.dataGridViewSepet1.RowHeadersWidth = 51;
            this.dataGridViewSepet1.RowTemplate.Height = 24;
            this.dataGridViewSepet1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSepet1.Size = new System.Drawing.Size(663, 232);
            this.dataGridViewSepet1.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 55);
            this.label10.TabIndex = 77;
            this.label10.Text = "Albüm seçiniz:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(952, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 76);
            this.button3.TabIndex = 78;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(12, 634);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 91);
            this.button4.TabIndex = 79;
            this.button4.Text = "Ana Sayfaya Dön";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Sepetfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlbumlerBurada.Properties.Resources.müşterigiriş;
            this.ClientSize = new System.Drawing.Size(1039, 737);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxVergi);
            this.Controls.Add(this.textBoxToplamTutar);
            this.Controls.Add(this.textBoxAdet);
            this.Controls.Add(this.textBoxTutar);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewSepet1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sepetfrm";
            this.Text = "Sepetfrm";
            this.Load += new System.EventHandler(this.Sepetfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSepet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxVergi;
        private System.Windows.Forms.TextBox textBoxToplamTutar;
        private System.Windows.Forms.TextBox textBoxAdet;
        private System.Windows.Forms.TextBox textBoxTutar;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewSepet1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}