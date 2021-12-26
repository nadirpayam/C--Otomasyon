
namespace AlbumlerBurada
{
    partial class Müsteriler
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
            this.dataGridViewMusteriler = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.labelMüsteriler = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMusteriler
            // 
            this.dataGridViewMusteriler.AllowUserToAddRows = false;
            this.dataGridViewMusteriler.AllowUserToDeleteRows = false;
            this.dataGridViewMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteriler.Location = new System.Drawing.Point(12, 130);
            this.dataGridViewMusteriler.Name = "dataGridViewMusteriler";
            this.dataGridViewMusteriler.ReadOnly = true;
            this.dataGridViewMusteriler.RowHeadersWidth = 51;
            this.dataGridViewMusteriler.RowTemplate.Height = 24;
            this.dataGridViewMusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMusteriler.Size = new System.Drawing.Size(838, 172);
            this.dataGridViewMusteriler.TabIndex = 13;
            this.dataGridViewMusteriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMusteriler_CellContentClick);
            this.dataGridViewMusteriler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMusteriler_CellEnter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Constantia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(800, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 76);
            this.button1.TabIndex = 35;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.Location = new System.Drawing.Point(673, 516);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(124, 74);
            this.buttonEkle.TabIndex = 36;
            this.buttonEkle.Text = "Müşteriyi Sil";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // labelMüsteriler
            // 
            this.labelMüsteriler.BackColor = System.Drawing.Color.Transparent;
            this.labelMüsteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMüsteriler.ForeColor = System.Drawing.Color.White;
            this.labelMüsteriler.Location = new System.Drawing.Point(200, 23);
            this.labelMüsteriler.Name = "labelMüsteriler";
            this.labelMüsteriler.Size = new System.Drawing.Size(473, 104);
            this.labelMüsteriler.TabIndex = 37;
            this.labelMüsteriler.Text = "MÜŞTERİLER";
            this.labelMüsteriler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(12, 563);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 104);
            this.button3.TabIndex = 40;
            this.button3.Text = "Ana Sayfaya Dön";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Müsteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AlbumlerBurada.Properties.Resources.admin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 679);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelMüsteriler);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewMusteriler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Müsteriler";
            this.Text = "Müsteriler";
            this.Load += new System.EventHandler(this.Müsteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMusteriler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Label labelMüsteriler;
        private System.Windows.Forms.Button button3;
    }
}