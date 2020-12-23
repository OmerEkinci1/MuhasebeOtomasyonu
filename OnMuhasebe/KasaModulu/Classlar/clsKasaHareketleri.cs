using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
namespace OnMuhasebe.KasaModulu.Classlar
{
    public class clsKasaHareketleri
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();

        public DataTable Listele(string KasaId)
        {
            string sql = "select * from VWKASAHAR WHERE KASAID=" + KasaId;//VİEW KULLANDIK

            return Dbase.TabloCek(sql);
        }

        public Boolean KasaAcilisKarti(string KasaKodu, string FisNo, string Tarih, string GcKodu, string Tipi, string Tutar, string CariKodu, string SaveUser)
        {

            try
            {
                //EXECUTE dbo].[SP_KASAHAR_EKLE   @KASAKODU  ,@FISNO  ,@TARIH  ,@GCKODU  ,@TIPI  ,@TUTAR  ,@CARIKODU  ,@SAVEUSER
                //Makbuz noyu boş gönderiyoruz .Açılış kartında makbuz no olmaz
                string sql = "EXECUTE SP_KASAHAR_EKLE   '" + KasaKodu + "'  ,'" + FisNo + "' ,'' ,'" + Tarih + "'  ,'" + GcKodu + "'  ,'" + Tipi + "'  ," + Tutar.Replace(",", ".") + "  ,'" + CariKodu + "' ,'KASA AÇILIŞ KARTI'," + SaveUser;

                return Dbase.Isle(sql);

            }
            catch (Exception)
            {

                return false;
            }

        }


        public Boolean KasaAcilisKartiGuncelle(string Id, string KasaKodu, string FisNo, string Tarih, string GcKodu, string Tipi, string Tutar, string CariKodu, string SaveUser)
        {

            try
            {
                //EXECUTE dbo].[SP_KASAHAR_EKLE   @KASAKODU  ,@FISNO  ,@TARIH  ,@GCKODU  ,@TIPI  ,@TUTAR  ,@CARIKODU  ,@SAVEUSER
                //Makbuz noyu boş gönderiyoruz .Açılış kartında makbuz no olmaz
                string sql = "EXECUTE SP_KASAHAR_GUNCELLE " + Id + "  , '" + KasaKodu + "'  ,'" + FisNo + "' ,'' ,'" + Tarih + "'  ,'" + GcKodu + "'  ,'" + Tipi + "'  ," + Tutar.Replace(",", ".") + "  ,'" + CariKodu + "','KASA AÇILIŞ KARTI' ," + SaveUser;

                return Dbase.Isle(sql);

            }
            catch (Exception)
            {

                return false;
            }

        }
        public DataRow Ac(string Id)
        {
            string sql = "select * from VWKASAHAR WHERE HAREKETID=" + Id;//VİEW KULLANDIK

            return Dbase.SatirCek(sql);
        }

        public Boolean Sil(string Id)
        {
            try
            {
                string sql = "exec SP_KASAHAR_SIL " + Id;
                Dbase.Isle(sql);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        //makbuz noyu ekliyoruz
        public Boolean TahsilatGirisi(string KasaKodu, string FisNo, string MakbuzNo, string Tarih, string Tutar, string CariKodu, string Aciklama, string SaveUser)
        {


            try
            {
                //GCKODU =G OLCAK ÇÜNKÜ TAHSİLAT OLDUĞU İÇİN
                //TİPİ T OLCAK ÇÜNKÜ TAHSİLAT

                string sql = "EXECUTE SP_KASAHAR_EKLE   '" + KasaKodu + "'  ,'" + FisNo + "' ,'" + MakbuzNo + "' ,'" + Tarih + "'  ,'G'  ,'T'  ," + Tutar.Replace(",", ".") + "  ,'" + CariKodu + "','" + Aciklama + "' ," + SaveUser;

                return Dbase.Isle(sql);

            }
            catch (Exception)
            {

                return false;
            }



        }

        public Boolean TahsilatGirisiGuncelle(string Id,string KasaKodu, string FisNo, string MakbuzNo, string Tarih, string Tutar, string CariKodu, string Aciklama, string SaveUser)
        {


            try
            {
                //GCKODU =G OLCAK ÇÜNKÜ TAHSİLAT OLDUĞU İÇİN
                //TİPİ T OLCAK ÇÜNKÜ TAHSİLAT

                string sql = "EXECUTE SP_KASAHAR_GUNCELLE  "+Id + ",'" + KasaKodu + "'  ,'" + FisNo + "' ,'" + MakbuzNo + "' ,'" + Tarih + "'  ,'G'  ,'T'  ," + Tutar.Replace(",", ".") + "  ,'" + CariKodu + "','" + Aciklama + "' ," + SaveUser;

                return Dbase.Isle(sql);

            }
            catch (Exception)
            {

                return false;
            }



        }

        //////

        public Boolean OdemeGirisi(string KasaKodu, string FisNo, string MakbuzNo, string Tarih, string Tutar, string CariKodu, string Aciklama, string SaveUser)
        {


            try
            {
                //GCKODU =C OLCAK ÇÜNKÜ ODEME OLDUĞU İÇİN
                //TİPİ T OLCAK ÇÜNKÜ TAHSİLAT

                string sql = "EXECUTE SP_KASAHAR_EKLE   '" + KasaKodu + "'  ,'" + FisNo + "' ,'" + MakbuzNo + "' ,'" + Tarih + "'  ,'C'  ,'T'  ," + Tutar.Replace(",", ".") + "  ,'" + CariKodu + "','" + Aciklama + "' ," + SaveUser;

                return Dbase.Isle(sql);

            }
            catch (Exception)
            {

                return false;
            }



        }

        public Boolean OdemeGirisiGuncelle(string Id, string KasaKodu, string FisNo, string MakbuzNo, string Tarih, string Tutar, string CariKodu, string Aciklama, string SaveUser)
        {


            try
            {
                //GCKODU =C OLCAK ÇÜNKÜ TAHSİLAT OLDUĞU İÇİN
                //TİPİ T OLCAK ÇÜNKÜ TAHSİLAT

                string sql = "EXECUTE SP_KASAHAR_GUNCELLE  " + Id + ",'" + KasaKodu + "'  ,'" + FisNo + "' ,'" + MakbuzNo + "' ,'" + Tarih + "'  ,'C'  ,'T'  ," + Tutar.Replace(",", ".") + "  ,'" + CariKodu + "','" + Aciklama + "' ," + SaveUser;

                return Dbase.Isle(sql);

            }
            catch (Exception)
            {

                return false;
            }



        }



        public Boolean CekTahsilatGirisi(string KasaKodu, string FisNo, string MakbuzNo, string Tarih, string Tutar, string CariKodu, string Aciklama, string SaveUser,string EvrakTuru,string EvrakId)
        {


            try
            {
                //GCKODU =G OLCAK ÇÜNKÜ TAHSİLAT OLDUĞU İÇİN
                //TİPİ T OLCAK ÇÜNKÜ TAHSİLAT

                string sql = "EXECUTE SP_KASAHAR_CEKTAHSILAT   '" + KasaKodu + "'  ,'" + FisNo + "' ,'" + MakbuzNo + "' ,'" + Tarih + "'  ,'G'  ,'T'  ," + Tutar.Replace(",", ".") + "  ,'" + CariKodu + "','" + Aciklama + "' ," + SaveUser+",'"+ EvrakTuru + "',"+EvrakId;

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
