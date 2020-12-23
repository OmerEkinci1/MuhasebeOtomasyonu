using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.StokModulu.Classlar
{
    class clsStokKod1
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();

        public DataTable Listele()
        {
            string sql = "select * from TBLSTOKKOD1 ORDER BY KOD";
            DataTable tablo = Dbase.TabloCek(sql);
            return tablo;
        }

        public void Ekle(string Kod, string Aciklama, string UserId)
        {
            //procedure 'ü çalıştıracak kod
            string sql = "execute SP_STOKKOD1_EKLE '" + Kod + "','" + Aciklama + "'," + UserId;
            Dbase.Isle(sql);

        }
        public void Sil(string Id)
        {
            //procedure 'ü çalıştıracak kod
            string sql = "execute SP_STOKKOD1_SIL " + Id;
            Dbase.Isle(sql);

        }
        public void Guncelle(string Id, string Kod, string Aciklama, string UserId)
        {
            //procedure 'ü çalıştıracak kod
            string sql = "execute SP_STOKKOD1_GUNCELLE " + Id + ",'" + Kod + "','" + Aciklama + "'," + UserId;
            Dbase.Isle(sql);

        }
        public DataRow Ac(string Id)
        {
            return Dbase.SatirCek("Select * from TBLSTOKKOD1 WHERE ID=" + Id);
        }
        public string KoduAl(string Id)
        {
            return Ac(Id)["KOD"].ToString();
        }

        public string IdAl(string Kod, Boolean YoksaAcilsinMi = false, string UserId = "-1")
        {
            try
            {
                return Dbase.SatirCek("Select * from TBLSTOKKOD1 WHERE KOD='" + Kod + "'")["ID"].ToString();
            }
            catch (Exception)
            {


                if (YoksaAcilsinMi == true)
                {
                    Ekle(Kod, Kod, UserId);
                    return IdAl(Kod, false, UserId);


                }
                else
                {
                    return "-1";
                }


            }
        }
    }
}
