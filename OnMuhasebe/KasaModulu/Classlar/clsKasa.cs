using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.KasaModulu.Classlar
{
    public class clsKasa
    {

        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        public Boolean Ekle(string Kodu, string Adi, string Aciklama, string SaveUser)
        {
            try
            {
                //EXECUTE SP_KASA_EKLE   @KODU  ,@ADI  ,@ACIKLAMA  ,@SAVEUSER
                string sql = "EXECUTE SP_KASA_EKLE   '" + Kodu + "'  ,'" + Adi + "'  ,'" + Aciklama + "'  ," + SaveUser;

                Dbase.Isle(sql);
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }


        public Boolean Guncelle(string ID, string Kodu, string Adi, string Aciklama, string SaveUser)
        {


            try
            {
                string sql = "EXECUTE SP_KASA_GUNCELLE  " + ID + ", '" + Kodu + "'  ,'" + Adi + "'  ,'" + Aciklama + "'  ," + SaveUser;


                Dbase.Isle(sql);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean Sil(string ID)
        {
            string sql = "EXECUTE SP_KASA_SIL " + ID;
            if (HareketiVarmi(KasaKoduAl(ID)) == true)
            {
                Mesajlar.Uyarı("Hareketi olan kasayı silemezsiniz!!!");
                return false;
            }

            try
            {
                Dbase.Isle(sql);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }



        public DataTable Listele(string KODU, string ADI, string ACIKLAMA)
        {
            string sql = "select * from TBLKASA WHERE KODU LIKE '%" + KODU + "%' AND ADI LIKE '%" + ADI + "%'  AND ACIKLAMA LIKE '%" + ACIKLAMA + "%' ORDER BY ADI";

            return Dbase.TabloCek(sql);


        }


        public string IdAl(string ADI)
        {
            try
            {
                string sql = "select top 1 ID from TBLKASA WHERE ADI ='" + ADI + "'";

                return Dbase.SatirCek(sql)["ID"].ToString();
            }
            catch (Exception ex)
            {

                return "-1";
            }
        }


        public string IdAl_Koduile(string KasaKodu)
        {
            try
            {
                string sql = "select top 1 ID from TBLKASA WHERE KODU ='" + KasaKodu + "'";

                return Dbase.SatirCek(sql)["ID"].ToString();
            }
            catch (Exception ex)
            {

                return "-1";
            }
        }


        public string KasaKoduAl(string Id)
        {
            try
            {
                string sql = "select top 1 KODU from TBLKASA WHERE ID ='" + Id + "'";

                return Dbase.SatirCek(sql)["KODU"].ToString();
            }
            catch (Exception ex)
            {

                return "-1";
            }
        }



      
        public DataRow Ac(string Id)
        {

            string sql = "select top 1 *from TBLKASA where ID=" + Id;
            return Dbase.SatirCek(sql);

        }

        Boolean HareketiVarmi(string KasaKodu)
        {
            string sql = "select count(*) as ADET FROM TBLKASAHAR WHERE KASAKODU='"+KasaKodu+"'";
            int adet = Convert.ToInt32(Dbase.SatirCek(sql)["ADET"]);


            if (adet>0)//demekki hareket var o zaman silemeyiz
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable KasaBakiye(string KasaKodu)
        {
            string sql = "select * from VWKASABAKIYE WHERE KASAKODU='" + KasaKodu + "'";//view kullandık

            return Dbase.TabloCek(sql);
        }

    }
}
