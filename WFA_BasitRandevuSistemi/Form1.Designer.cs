namespace WFA_BasitRandevuSistemi
{
    partial class Form1
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
            this.label1_hastaAdi = new System.Windows.Forms.Label();
            this.label2_hastaSoyadi = new System.Windows.Forms.Label();
            this.textBox1_hastaAdi = new System.Windows.Forms.TextBox();
            this.textBox2_hastaSoyadi = new System.Windows.Forms.TextBox();
            this.label3_doktorSecimi = new System.Windows.Forms.Label();
            this.textBox3_doktorSecimi = new System.Windows.Forms.TextBox();
            this.label4_tarih = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5_saat = new System.Windows.Forms.Label();
            this.buton1_kaydet = new System.Windows.Forms.Button();
            this.label6_bolumSecimi = new System.Windows.Forms.Label();
            this.comboBox2_bolumSecimi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_hastaAdi
            // 
            this.label1_hastaAdi.AutoSize = true;
            this.label1_hastaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1_hastaAdi.Location = new System.Drawing.Point(35, 85);
            this.label1_hastaAdi.Name = "label1_hastaAdi";
            this.label1_hastaAdi.Size = new System.Drawing.Size(92, 17);
            this.label1_hastaAdi.TabIndex = 0;
            this.label1_hastaAdi.Text = "Hasta adı : ";
            // 
            // label2_hastaSoyadi
            // 
            this.label2_hastaSoyadi.AutoSize = true;
            this.label2_hastaSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2_hastaSoyadi.Location = new System.Drawing.Point(35, 135);
            this.label2_hastaSoyadi.Name = "label2_hastaSoyadi";
            this.label2_hastaSoyadi.Size = new System.Drawing.Size(117, 17);
            this.label2_hastaSoyadi.TabIndex = 0;
            this.label2_hastaSoyadi.Text = "Hasta soyadı : ";
            // 
            // textBox1_hastaAdi
            // 
            this.textBox1_hastaAdi.Location = new System.Drawing.Point(208, 80);
            this.textBox1_hastaAdi.Name = "textBox1_hastaAdi";
            this.textBox1_hastaAdi.Size = new System.Drawing.Size(200, 22);
            this.textBox1_hastaAdi.TabIndex = 1;
            // 
            // textBox2_hastaSoyadi
            // 
            this.textBox2_hastaSoyadi.Location = new System.Drawing.Point(208, 130);
            this.textBox2_hastaSoyadi.Name = "textBox2_hastaSoyadi";
            this.textBox2_hastaSoyadi.Size = new System.Drawing.Size(200, 22);
            this.textBox2_hastaSoyadi.TabIndex = 1;
            this.textBox2_hastaSoyadi.TextChanged += new System.EventHandler(this.textBox2_hastaSoyadi_TextChanged);
            // 
            // label3_doktorSecimi
            // 
            this.label3_doktorSecimi.AutoSize = true;
            this.label3_doktorSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3_doktorSecimi.Location = new System.Drawing.Point(35, 241);
            this.label3_doktorSecimi.Name = "label3_doktorSecimi";
            this.label3_doktorSecimi.Size = new System.Drawing.Size(121, 17);
            this.label3_doktorSecimi.TabIndex = 0;
            this.label3_doktorSecimi.Text = "Doktor seçimi : ";
            this.label3_doktorSecimi.Click += new System.EventHandler(this.label3_doktorSecimi_Click);
            // 
            // textBox3_doktorSecimi
            // 
            this.textBox3_doktorSecimi.Location = new System.Drawing.Point(208, 241);
            this.textBox3_doktorSecimi.Name = "textBox3_doktorSecimi";
            this.textBox3_doktorSecimi.Size = new System.Drawing.Size(200, 22);
            this.textBox3_doktorSecimi.TabIndex = 1;
            // 
            // label4_tarih
            // 
            this.label4_tarih.AutoSize = true;
            this.label4_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4_tarih.Location = new System.Drawing.Point(35, 294);
            this.label4_tarih.Name = "label4_tarih";
            this.label4_tarih.Size = new System.Drawing.Size(61, 17);
            this.label4_tarih.TabIndex = 0;
            this.label4_tarih.Text = "Tarih : ";
            this.label4_tarih.Click += new System.EventHandler(this.label3_doktorSecimi_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 294);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "08.00",
            "08.10",
            "08.20",
            "08.30",
            "08.40",
            "08.50",
            "09.00",
            "09.10",
            "09.20",
            "09.30",
            "09.40",
            "09.50",
            "10.00",
            "10.10",
            "10.20",
            "10.30",
            "10.40",
            "10.50",
            "11.00",
            "11.10",
            "11.20",
            "11.30",
            "11.40",
            "11.50",
            "12.00",
            "13.30",
            "13.40",
            "13.50",
            "14.00"});
            this.comboBox1.Location = new System.Drawing.Point(208, 347);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label5_saat
            // 
            this.label5_saat.AutoSize = true;
            this.label5_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5_saat.Location = new System.Drawing.Point(40, 354);
            this.label5_saat.Name = "label5_saat";
            this.label5_saat.Size = new System.Drawing.Size(56, 17);
            this.label5_saat.TabIndex = 0;
            this.label5_saat.Text = "Saat : ";
            this.label5_saat.Click += new System.EventHandler(this.label3_doktorSecimi_Click);
            // 
            // buton1_kaydet
            // 
            this.buton1_kaydet.BackColor = System.Drawing.Color.SkyBlue;
            this.buton1_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton1_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buton1_kaydet.Location = new System.Drawing.Point(291, 399);
            this.buton1_kaydet.Name = "buton1_kaydet";
            this.buton1_kaydet.Size = new System.Drawing.Size(117, 54);
            this.buton1_kaydet.TabIndex = 4;
            this.buton1_kaydet.Text = "KAYDET";
            this.buton1_kaydet.UseVisualStyleBackColor = false;
            this.buton1_kaydet.Click += new System.EventHandler(this.buton1_kaydet_Click);
            // 
            // label6_bolumSecimi
            // 
            this.label6_bolumSecimi.AutoSize = true;
            this.label6_bolumSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6_bolumSecimi.Location = new System.Drawing.Point(35, 192);
            this.label6_bolumSecimi.Name = "label6_bolumSecimi";
            this.label6_bolumSecimi.Size = new System.Drawing.Size(112, 17);
            this.label6_bolumSecimi.TabIndex = 5;
            this.label6_bolumSecimi.Text = "Bölüm seçimi :";
            // 
            // comboBox2_bolumSecimi
            // 
            this.comboBox2_bolumSecimi.FormattingEnabled = true;
            this.comboBox2_bolumSecimi.Items.AddRange(new object[] {
            "Ortopedi ve travmatoloji",
            "Kalp ve damar cerrahi",
            "Genel cerrahi",
            "Aile hekimi",
            "Dahiliye",
            "Göz hastalıkları",
            "Pediatri"});
            this.comboBox2_bolumSecimi.Location = new System.Drawing.Point(208, 185);
            this.comboBox2_bolumSecimi.Name = "comboBox2_bolumSecimi";
            this.comboBox2_bolumSecimi.Size = new System.Drawing.Size(200, 24);
            this.comboBox2_bolumSecimi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(115, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Randevu Sistemi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(553, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2_bolumSecimi);
            this.Controls.Add(this.label6_bolumSecimi);
            this.Controls.Add(this.buton1_kaydet);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3_doktorSecimi);
            this.Controls.Add(this.textBox2_hastaSoyadi);
            this.Controls.Add(this.textBox1_hastaAdi);
            this.Controls.Add(this.label5_saat);
            this.Controls.Add(this.label4_tarih);
            this.Controls.Add(this.label3_doktorSecimi);
            this.Controls.Add(this.label2_hastaSoyadi);
            this.Controls.Add(this.label1_hastaAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_hastaAdi;
        private System.Windows.Forms.Label label2_hastaSoyadi;
        private System.Windows.Forms.TextBox textBox1_hastaAdi;
        private System.Windows.Forms.TextBox textBox2_hastaSoyadi;
        private System.Windows.Forms.Label label3_doktorSecimi;
        private System.Windows.Forms.TextBox textBox3_doktorSecimi;
        private System.Windows.Forms.Label label4_tarih;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5_saat;
        private System.Windows.Forms.Button buton1_kaydet;
        private System.Windows.Forms.Label label6_bolumSecimi;
        private System.Windows.Forms.ComboBox comboBox2_bolumSecimi;
        private System.Windows.Forms.Label label1;
    }
}

