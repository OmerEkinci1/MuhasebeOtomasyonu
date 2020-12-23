using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.Classlar
{
    public class GirisIslemi
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new Veritabani();
        public Boolean KullaniciGirisi(string KullaniciAdi, string Parola)
        {
            try
            {
                string sql = "select top 1 * from TBLKULLANICILAR WHERE KULLANICIADI='" + KullaniciAdi + "' AND PAROLA='" + Parola + "'";

                DataRow Satir = Dbase.SatirCek(sql);


                frmAnaForm.UserId = Satir["ID"].ToString();//STATİC DEĞİŞJENE DEĞER ATADIK
                frmAnaForm.UserName = KullaniciAdi;

                frmAnaForm.GirisDurumu = true;
                frmAnaForm.AdminMi = Satir["ADMIN"].ToString().Trim();
                return true;

            }
            catch (Exception ex)
            {

                frmAnaForm.UserId = "-1";
                frmAnaForm.UserName = "";

                frmAnaForm.GirisDurumu = false;

                return false;

            }


        }

        OnMuhasebe.Classlar.Mesajlar Mesajlar = new Mesajlar();
        public Boolean ParolaDegistir(string UserId, string EskiParola, string YeniParola)
        {
            try
            {
                string sql = "select * from TBLKULLANICILAR WHERE ID=" + UserId;
                DataRow Satir = Dbase.SatirCek(sql);
                string VtParola = Satir["PAROLA"].ToString().Trim();
                if (EskiParola == VtParola)
                {
                    return Dbase.Isle("update TBLKULLANICILAR SET PAROLA='" + YeniParola + "' WHERE ID=" + UserId);

                }
                else
                {
                    Mesajlar.Uyarı("Eski Parolanızı Yanlış Girdiniz!.Lütfen Tekrar Deneyiniz!");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Mesajlar.Hata();
                return false;
            }


            

        }


    }
}
