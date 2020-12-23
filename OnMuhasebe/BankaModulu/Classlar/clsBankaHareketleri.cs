using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace OnMuhasebe.BankaModulu.Classlar
{
    public class clsBankaHareketleri
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        public Boolean BankaAcilisKarti(string BANKAID, string FISNO, string TARIH, string GCKODU, string TUTAR, string SAVEUSER)
        {

            try
            {
                //EXECUTE SP_BANKAHAR_EKLE   @BANKAID  ,@FISNO  ,@MAKBUZNO  ,@TARIH  ,@GCKODU  ,@TIPI  ,@TUTAR  ,@CARIKODU  ,@ACIKLAMA  ,@SAVEUSER
                //Tipi =A olcak çünkü açılış kartı
                //Cari kodunu boş vercez.çünkü açılış kartında cari ile ilgili bir işlem yapmıyoruz
                //Makbuz alanınıda boş veriyoruz
                string sql = "EXECUTE SP_BANKAHAR_EKLE   '" + BANKAID + "'  ,'" + FISNO + "'  ,''  ,'" + TARIH + "'  ,'" + GCKODU + "'  ,'A'  ,'" + TUTAR.Replace(",", ".") + "'  ,''  ,'BAnka Açılış Kartı'  ," + SAVEUSER;

                Dbase.Isle(sql);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }



        public Boolean BankaAcilisKartiGuncelle(string HareketId, string BANKAID, string FISNO, string TARIH, string GCKODU, string TUTAR, string SAVEUSER)
        {

            try
            {
                //EXECUTE SP_BANKAHAR_EKLE   @BANKAID  ,@FISNO  ,@MAKBUZNO  ,@TARIH  ,@GCKODU  ,@TIPI  ,@TUTAR  ,@CARIKODU  ,@ACIKLAMA  ,@SAVEUSER
                //Tipi =A olcak çünkü açılış kartı
                //Cari kodunu boş vercez.çünkü açılış kartında cari ile ilgili bir işlem yapmıyoruz
                //Makbuz alanınıda boş veriyoruz
                string sql = "EXECUTE SP_BANKAHAR_GUNCELLE   " + HareketId + ",'" + BANKAID + "'  ,'" + FISNO + "'  ,''  ,'" + TARIH + "'  ,'" + GCKODU + "'  ,'A'  ,'" + TUTAR.Replace(",", ".") + "'  ,''  ,'BAnka Açılış Kartı'  ," + SAVEUSER;

                Dbase.Isle(sql);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }





        public DataTable Listele(string BankaId)
        {
            //view kullandık
            string sql = "select * from VWBANKAHAR WHERE BANKAID=" + BankaId;

            return Dbase.TabloCek(sql);
        }

        public DataRow Bakiye(string BankaId)
        {
            //VİEW KULLANDIK
            string sql = "select * from VWBANKABAKIYE WHERE BANKAID=" + BankaId;
            return Dbase.SatirCek(sql);
        }


        public DataTable BakiyeListesi(string BankaId)
        {
            //VİEW KULLANDIK
            string sql = "select top 1* from VWBANKABAKIYE WHERE BANKAID=" + BankaId;//bir satır çekicek
            return Dbase.TabloCek(sql);
        }


        public DataRow Ac(string Id)
        {
            string sql = "select * from VWBANKAHAR WHERE HAREKETID=" + Id;//VİEW KULLANDIK

            return Dbase.SatirCek(sql);
        }

        public Boolean Sil(string Id)
        {
            try
            {
                string sql = "EXECUTE SP_BANKAHAR_SIL " + Id;
                Dbase.Isle(sql);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean Ekle(string BankaId, string FisNo, string Makbuzno, string Tarih, string GcKodu, string Tipi, string Tutar, string CariKodu, string Aciklama, string UserId)
        {

            try
            {
                //EXECUTE SP_BANKAHAR_EKLE  @BANKAID  ,@FISNO  ,@MAKBUZNO  ,@TARIH  ,@GCKODU  ,@TIPI  ,@TUTAR ,@CARIKODU  ,@ACIKLAMA  ,@SAVEUSER

                string sql = "EXECUTE SP_BANKAHAR_EKLE  '" + BankaId + "'  ,'" + FisNo + "'  ,'" + Makbuzno + "'  ,'" + Tarih + "'  ,'" + GcKodu + "'  ,'" + Tipi + "'  ," + Tutar.Replace(",", ".") + " ,'" + CariKodu + "'  ,'" + Aciklama + "'  ," + UserId;
                Dbase.Isle(sql);


                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }




        public Boolean Guncelle(string Id, string BankaId, string FisNo, string Makbuzno, string Tarih, string GcKodu, string Tipi, string Tutar, string CariKodu, string Aciklama, string UserId)
        {

            try
            {
                //EXECUTE SP_BANKAHAR_EKLE  @BANKAID  ,@FISNO  ,@MAKBUZNO  ,@TARIH  ,@GCKODU  ,@TIPI  ,@TUTAR ,@CARIKODU  ,@ACIKLAMA  ,@SAVEUSER

                string sql = "EXECUTE SP_BANKAHAR_GUNCELLE  " + Id + ",'" + BankaId + "'  ,'" + FisNo + "'  ,'" + Makbuzno + "'  ,'" + Tarih + "'  ,'" + GcKodu + "'  ,'" + Tipi + "'  ," + Tutar.Replace(",", ".") + " ,'" + CariKodu + "'  ,'" + Aciklama + "'  ," + UserId;
                Dbase.Isle(sql);


                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }


        public Boolean CekTahsilatGirisi(string BankaId, string FisNo, string Makbuzno, string Tarih, string GcKodu, string Tipi, string Tutar, string CariKodu, string Aciklama, string SaveUser,string EvrakTuru, string EvrakId)
        {


            try
            {
                //GCKODU =G OLCAK ÇÜNKÜ TAHSİLAT OLDUĞU İÇİN
                //TİPİ T OLCAK ÇÜNKÜ TAHSİLAT

                

                string sql = "EXECUTE SP_BANKAHAR_CEKTAHSILAT  '" + BankaId + "'  ,'" + FisNo + "'  ,'" + Makbuzno + "'  ,'" + Tarih + "'  ,'" + GcKodu + "'  ,'" + Tipi + "'  ," + Tutar.Replace(",", ".") + " ,'" + CariKodu + "'  ,'" + Aciklama + "'  ," + SaveUser + ",'" + EvrakTuru + "'," + EvrakId; 

                Dbase.Isle(sql);
                return true;
            }
            catch (Exception)
            {

                return false;
            }



        }



    }
}
