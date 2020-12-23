using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace OnMuhasebe.Classlar
{
    class Veritabani
    {
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new Mesajlar();
        public SqlConnection Baglan()
        {
            try
            {
                // string provider = "Data Source=.;Initial Catalog=Kariyer2012;Integrated Security=true";
                //Projenin properties kısmına kaydettiğimiz değerleri burda okuyoruz.
                string provider = "Data Source=" + OnMuhasebe.Properties.Settings.Default.ServerIpAdress + ";Initial Catalog=" + OnMuhasebe.Properties.Settings.Default.Veritabani + ";User ID=" + OnMuhasebe.Properties.Settings.Default.VeritabaniKullaniciAdi + ";Password=" + OnMuhasebe.Properties.Settings.Default.VeritabaniSifresi + "";
                SqlConnection conn = new SqlConnection(provider);
                conn.Open();
                frmAnaForm.ErisimBilgisiHatasi = false;
                return conn;
            }
            catch (Exception ex)
            {

                Mesajlar.Uyarı("Server ile bağlantı kurulamadı .Lütfen erişim bilgilerini kontrol ediniz.!");
                return null;
              
               
            }
        }
        public DataTable TabloCek(string sql)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(sql, this.Baglan());
            adap.Fill(tb);

            return tb;
        }

        public DataRow SatirCek(string sql)
        {
            try
            {
                DataRow satir = TabloCek(sql).Rows[0];
                return satir;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Boolean Isle(string sql)
        {
            try
            {
                SqlCommand islem = new SqlCommand(sql, this.Baglan());
                islem.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

        public DataSet DataSetCek(string sql, string Tablo)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adap = new SqlDataAdapter(sql, this.Baglan());
            adap.Fill(ds, Tablo);

            return ds;
        }

    }
}
