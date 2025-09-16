using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakipSistemi
{
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }
        frmSQLBaglanti bgl = new frmSQLBaglanti();

        private void frmistatistik_Load(object sender, EventArgs e)
        {
            toplamHasta();
            yasortalamasi();
            erkeksayi();
            kadinsayi();
            exsayi();
        }
        private void toplamHasta()
        {
            SqlCommand toplam = new SqlCommand("select count(*) from tbl_HastaBilgi",bgl.baglan());
            SqlDataReader dr = toplam.ExecuteReader();
            while (dr.Read())
               {

                label3.Text = dr[0].ToString();
               }
            
        }
        private void yasortalamasi()
        {
            SqlCommand ortalama = new SqlCommand("select avg(hYas) from tbl_HastaBilgi ", bgl.baglan());
            SqlDataReader dr = ortalama.ExecuteReader();
            while (dr.Read())
            {

                label5.Text = dr[0].ToString();
            }

        }
        private void erkeksayi()
        {
            SqlCommand erkeksayi = new SqlCommand("select count(*) from tbl_HastaBilgi where hCinsiyet = 'Erkek' ", bgl.baglan());
            SqlDataReader dr = erkeksayi.ExecuteReader();
            while (dr.Read())
            {

                label7.Text = dr[0].ToString();
            }

        }
        private void kadinsayi()
        {
            SqlCommand kadinsayi = new SqlCommand("select count(*) from tbl_HastaBilgi where hCinsiyet = 'Kadın'", bgl.baglan());
            SqlDataReader dr = kadinsayi.ExecuteReader();
            while (dr.Read())
            {

                label9.Text = dr[0].ToString();
            }

        }
        private void exsayi()
        {
            SqlCommand exsayi = new SqlCommand("select count(*) from tbl_HastaBilgi where hExMi = 1", bgl.baglan());
            SqlDataReader dr = exsayi.ExecuteReader();
            while (dr.Read())
            {

                label11.Text = dr[0].ToString();
            }

        }
    }
}
