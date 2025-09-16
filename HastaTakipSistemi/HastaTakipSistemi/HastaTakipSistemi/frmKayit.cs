using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace HastaTakipSistemi
{
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }
        frmSQLBaglanti bgl = new frmSQLBaglanti();

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if(kuladi.Text != "" && txtsifre.Text != "" )
            {
                SqlCommand kayit = new SqlCommand("kayitol",bgl.baglan());
                kayit.CommandType = CommandType.StoredProcedure;
                kayit.Parameters.AddWithValue("@kulAdi", kuladi.Text);
                kayit.Parameters.AddWithValue("@sifre", txtsifre.Text);
                kayit.ExecuteNonQuery();
                MessageBox.Show("Kayıt işlemi başarılı", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Lütfen tüm alanları doldurun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kuladi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
