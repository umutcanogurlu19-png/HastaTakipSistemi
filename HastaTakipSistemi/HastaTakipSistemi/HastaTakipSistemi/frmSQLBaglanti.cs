using System.Data.SqlClient;
namespace HastaTakipSistemi
{
    internal class frmSQLBaglanti
    {
        string adres = @"Data Source=Umut\SQLEXPRESS;Initial Catalog=db_HastaneYonetim;Integrated Security=True;Encrypt=False;";
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(adres);
            baglanti.Open();
            return baglanti;
        }
    }
}
