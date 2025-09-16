using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaTakipSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        frmSQLBaglanti bgl = new frmSQLBaglanti();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kuladi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            frmKayit fr = new frmKayit();
            fr.Show();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (kuladi.Text != "" &&  txtsifre.Text != "")
            {
                SqlCommand giris = new SqlCommand("girisYap", bgl.baglan());
                giris.CommandType = CommandType.StoredProcedure;
                giris.Parameters.AddWithValue("kulAdi", kuladi.Text);
                giris.Parameters.AddWithValue("sifre", txtsifre.Text);
                SqlDataReader dr = giris.ExecuteReader();
                if(dr.Read())
                {
                    MessageBox.Show("Giriş işlemi başarılı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmAnaSayfa fr = new frmAnaSayfa();
                    this.Hide();
                    fr.Show();
                    
                }
                else
                {
                    MessageBox.Show("Giriş işlemi başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
