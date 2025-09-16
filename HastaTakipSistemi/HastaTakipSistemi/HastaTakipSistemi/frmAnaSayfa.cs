using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HastaTakipSistemi
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        frmSQLBaglanti bgl = new frmSQLBaglanti();

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            Listele();
            durumDoldur();
            BolumDoldur();
            ; }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            SqlCommand liste = new SqlCommand("listele", bgl.baglan());
            SqlDataAdapter da = new SqlDataAdapter(liste);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void durumDoldur()
        {
            SqlCommand durum = new SqlCommand("durumDoldur", bgl.baglan());
            SqlDataAdapter da = new SqlDataAdapter(durum);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtDurum.DataSource = dt;
            txtDurum.DisplayMember = "durumAd";
            txtDurum.ValueMember = "durumID";

        }
        private void BolumDoldur()
        {
            SqlCommand bolum = new SqlCommand("bolumDoldur", bgl.baglan());
            SqlDataAdapter da = new SqlDataAdapter(bolum);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtBolum.DataSource = dt;
            txtBolum.DisplayMember = "bolumAd";
            txtBolum.ValueMember = "bolumID";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtTc.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtTelefon.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtYas.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtCinsiyet.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txtTarih.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtDurum.SelectedValue = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtBolum.SelectedValue = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            lblEx.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();



        }

        private void rbEvet_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEvet.Checked == true)
            {
                lblEx.Text = "True";
            }
            else
            {
                lblEx.Text = "False";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblEx_TextChanged(object sender, EventArgs e)
        {
            if (lblEx.Text == "True")
            {
                rbEvet.Checked = true;
            }
            else
            {
                rbHayir.Checked = true;
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtBolum.Text != "" && txtCinsiyet.Text != "" && txtDurum.Text != "" && txtSikayet.Text != "" && txtSoyad.Text != "" && txtTc.Text != "" && txtTelefon.Text != "" && txtYas.Text != "")
            {
                kaydet();
            }
            else
            {
                MessageBox.Show("Lütfen ilgili tüm alanları doldurunuz!", "Kayıt Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void kaydet()
        {
            SqlCommand kaydet = new SqlCommand("kaydet", bgl.baglan());
            kaydet.CommandType = CommandType.StoredProcedure;
            kaydet.Parameters.AddWithValue("ad", txtAd.Text.ToString());
            kaydet.Parameters.AddWithValue("soyad", txtSoyad.Text.ToString());
            kaydet.Parameters.AddWithValue("tc", txtTc.Text.ToString());
            kaydet.Parameters.AddWithValue("tel", txtTelefon.Text.ToString());
            kaydet.Parameters.AddWithValue("yas", int.Parse(txtYas.Text.ToString()));
            kaydet.Parameters.AddWithValue("cins", txtCinsiyet.Text.ToString());
            kaydet.Parameters.AddWithValue("sikayet", txtSikayet.Text.ToString());
            kaydet.Parameters.AddWithValue("tarih", DateTime.Now);
            kaydet.Parameters.AddWithValue("durum", txtDurum.SelectedValue);
            kaydet.Parameters.AddWithValue("bolum", txtBolum.SelectedValue);
            if (lblEx.Text == "True")
            {
                kaydet.Parameters.AddWithValue("ex", 1);
            }
            else
            {
                kaydet.Parameters.AddWithValue("ex", 0);
            }
            kaydet.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarıyla eklendi", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sil();
        }
        private void sil()
        {
            DialogResult result = MessageBox.Show($"{txtID.Text}  numaralı kayıt silinecek.Onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("sil", bgl.baglan());
                sil.CommandType = CommandType.StoredProcedure;
                sil.Parameters.AddWithValue("id", int.Parse(txtID.Text));
                sil.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarıyla silindi", "Kayıt Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"{txtID.Text}  numaralı kayıt güncellenecek.Onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                guncelle();
            }

        }
        private void guncelle()

        {
            SqlCommand guncelle = new SqlCommand("guncelle", bgl.baglan());
            guncelle.CommandType = CommandType.StoredProcedure;
            guncelle.Parameters.AddWithValue("id", int.Parse(txtID.Text));
            guncelle.Parameters.AddWithValue("ad", txtAd.Text.ToString());
            guncelle.Parameters.AddWithValue("soyad", txtSoyad.Text.ToString());
            guncelle.Parameters.AddWithValue("tc", txtTc.Text.ToString());
            guncelle.Parameters.AddWithValue("tel", txtTelefon.Text.ToString());
            guncelle.Parameters.AddWithValue("yas", int.Parse(txtYas.Text.ToString()));
            guncelle.Parameters.AddWithValue("cins", txtCinsiyet.Text.ToString());
            guncelle.Parameters.AddWithValue("sikayet", txtSikayet.Text.ToString());
            guncelle.Parameters.AddWithValue("tarih", DateTime.Now);
            guncelle.Parameters.AddWithValue("durum", txtDurum.SelectedValue);
            guncelle.Parameters.AddWithValue("bolum", txtBolum.SelectedValue);
            if (lblEx.Text == "True")
            {
                guncelle.Parameters.AddWithValue("ex", 1);
            }
            else
            {
                guncelle.Parameters.AddWithValue("ex", 0);
            }
            guncelle.ExecuteNonQuery();
            MessageBox.Show("Güncelleme işlemi başarılı.", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            
            txtAd.Clear();
            txtSoyad.Clear();
            txtTc.Clear();
            txtTelefon.Clear();
            txtBolum.Text = "";
            txtCinsiyet.Clear();
            txtDurum.Text = "";
            txtSikayet.Clear();
            txtYas.Clear();
            txtTarih.Clear();
            rbEvet.Checked = false;
            rbHayir.Checked = false;
        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            frmistatistik fr = new frmistatistik();
            fr.Show();
        }
    }

}

