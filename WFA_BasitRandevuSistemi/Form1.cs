using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BasitRandevuSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_doktorSecimi_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_hastaSoyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void buton1_kaydet_Click(object sender, EventArgs e)
        {
            string hastaAdi = textBox1_hastaAdi.Text;
            string hastaSoyadi = textBox2_hastaSoyadi.Text;
            string bolum = comboBox2_bolumSecimi.SelectedItem.ToString();
            string doktorSecimi = textBox3_doktorSecimi.Text;
            string tarih = dateTimePicker1.Value.ToShortDateString();
            string saat = comboBox1.SelectedItem.ToString();

            MessageBox.Show("Sayın " + hastaAdi + " " + hastaSoyadi + " " + bolum + " bölümüne " +
                doktorSecimi + " adlı doktordan " + tarih + " tarihine " + "saat " + saat + "'a randevunuz alınmıştır");
        }
    }
}
