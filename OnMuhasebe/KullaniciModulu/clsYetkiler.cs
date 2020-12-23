using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.KullaniciModulu
{

    public class clsYetkiler
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new Classlar.Veritabani();
        public DataTable Listele(string KullaniciId)
        {
            string sql = "select * from VWIZINLER WHERE KULLANICIID= " + KullaniciId;

            return Dbase.TabloCek(sql);
        }
        public void YetkileriKaydet(string KullaniciId, DataTable Liste, string UserId)
        {
            string YetkiId = "";
            Boolean Durum = false;
            for (int i = 0; i < Liste.Rows.Count; i++)
            {
                YetkiId = Liste.Rows[i]["ID"].ToString();
                Durum = Convert.ToBoolean(Liste.Rows[i]["SEC"]);
                string sql = "exec SP_KULLANICI_YETKI " + KullaniciId + "," + YetkiId + ",'" + Durum + "'," + UserId;
                Dbase.Isle(sql);
            }





        }



        public YetkiYapisiListesi YetkileriOku(string KullaniciId)//struct dönen metod
        {
            DataTable KullaniciYetkileri = Listele(KullaniciId);
            YetkiYapisiListesi Yetkiler = new YetkiYapisiListesi();//struct

            for (int i = 0; i < KullaniciYetkileri.Rows.Count; i++)
            {
                if (KullaniciYetkileri.Rows[i]["KISAAD"].ToString().Trim() == "STOKEKLE") { Yetkiler.STOKEKLE = Convert.ToBoolean(KullaniciYetkileri.Rows[i]["SEC"]); continue; }
                if (KullaniciYetkileri.Rows[i]["KISAAD"].ToString().Trim() == "STOKGUNCELLE") { Yetkiler.STOKGUNCELLE = Convert.ToBoolean(KullaniciYetkileri.Rows[i]["SEC"]); continue; }

                if (KullaniciYetkileri.Rows[i]["KISAAD"].ToString().Trim() == "STOKSIL") { Yetkiler.STOKSIL = Convert.ToBoolean(KullaniciYetkileri.Rows[i]["SEC"]); continue; }

                if (KullaniciYetkileri.Rows[i]["KISAAD"].ToString().Trim() == "STOKLISTE") { Yetkiler.STOKLISTE = Convert.ToBoolean(KullaniciYetkileri.Rows[i]["SEC"]); continue; }



                //geri kalanlarıda var ama ben yazmadım aynı yapıda zaten 
            }


            return Yetkiler;
        }
    }
}
