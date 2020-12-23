using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.FaturaModulu.Classlar
{
    class clsAlisFaturasi
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();

        /*
        * Bu hatanın sebebi türkçe tarihi veritabanına gönderdiğimiz için.biz ise türkçe tarihi ingilizce tarihe çevirip öyle yollayacağız.Formatlar classında bu işlemi yaptık zaten
        Hata:An unhandled exception of type 'System.Data.SqlClient.SqlException' occurred in System.Data.dll

Additional information: Error converting data type varchar to datetime.
             
             
        */


        //türkçede tarih gün ay yıl şeklindedir.ingilizcede ise ay gun yıl şeklindedir.
        //türkçe gelen tarihi ingilizce tarihe çevirip o şekilde veritabanına göndermek için
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        StokModulu.Classlar.clsStokHareketleri StokHareketleri = new StokModulu.Classlar.clsStokHareketleri();
        public Boolean Ekle(string FaturaNo, string CariKodu, string Tarih, string VadeTarihi, string GenelToplam, string Turu, string Aciklama, DataTable Detaylar, string OdemeYeri, string OdemeYeriId)
        {
            try
            {
                string Tipi = "A";//ALIŞ FATURASI
                string sql = "EXECUTE SP_FATURA_EKLE '" + FaturaNo + "','" + CariKodu + "' ,'" + Formatlar.IngilizceTarihFormati(Tarih) + "','" + Formatlar.IngilizceTarihFormati(VadeTarihi) + "'," + GenelToplam.Replace(",", ".") + ",'" + Turu + "','" + Tipi + "','" + OdemeYeri + "','" + OdemeYeriId + "','" + Aciklama + "'," + frmAnaForm.UserId + "";
                /*GenelToplam.Replace yaparak sqlde virgül yerine nokta şeklinde ekleme yapmak için yoksa hata verir.*/
                Dbase.Isle(sql);

                //Bir Satış yapıyoruz.O Satışa ait fatura kesiyoruz ve StokHareketlerine de ekleme yapıyoruz.

                //G:Giriş //SATIŞ İADE VE alış faturasında falan giriş işlemi olur.
                //C:Cıkış //satış faturasıNDA C OLUR
                StokHareketleri.Ekle(FaturaNo, "G", Detaylar, Formatlar.IngilizceTarihFormati(Tarih), Tipi);

                return true;
            }
            catch (Exception)
            {

                return false;
            }



        }

        public Boolean Guncelle(string Id, string FaturaNo, string CariKodu, string Tarih, string VadeTarihi, string GenelToplam, string Turu, string Aciklama, DataTable Detaylar, string OdemeYeri, string OdemeYeriId)
        {
            try
            {
                string Tipi = "A";//ALIŞ FATURASI

                string sql = "EXECUTE SP_FATURA_GUNCELLE " + Id + ",'" + FaturaNo + "','" + CariKodu + "' ,'" + Formatlar.IngilizceTarihFormati(Tarih) + "','" + Formatlar.IngilizceTarihFormati(VadeTarihi) + "'," + GenelToplam.Replace(",", ".") + ",'" + Turu + "','" + Tipi + "','" + OdemeYeri + "'," + OdemeYeriId + ",'" + Aciklama + "'," + frmAnaForm.UserId + "";

                Dbase.Isle(sql);

                if (FaturaDetaylariniSil(FaturaNo) == true)
                {

                    //G OLCAK ÇÜNKÜ SATIŞ İADE İŞLEMİ
                    StokHareketleri.Ekle(FaturaNo, "G", Detaylar, Formatlar.IngilizceTarihFormati(Tarih), Tipi);
                }

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }


        }

        public void Sil(string Id)
        {
            string sql = "exec SP_FATURA_SIL " + Id;
            Dbase.Isle(sql);
        }

        public DataTable Listele(string CariKodu, string CariAdi, string FaturaNo)
        {
            //oluşturduğumuz view'de arama yaptık.
            string sql = "SELECT * FROM VWFATURALAR where CARIKODU LIKE '%" + CariKodu + "%' AND CARIISIM LIKE '%" + CariAdi + "%' AND FATURANO LIKE '%" + FaturaNo + "%' AND TIPI='A'";//ALIŞ FATURASI

            return Dbase.TabloCek(sql);


        }

        public DataRow Ac(string FaturaNo)
        {
            //bir kayıt gelir.(view'den getirdik verileri)
            string sql = "SELECT top 1* FROM VWFATURALAR where FATURANO='" + FaturaNo + "' AND TIPI='A' ";//TİPİ=A yani alış faturası 

            return Dbase.SatirCek(sql);
        }

        //faturanın kalemlerini açıcaz.yani hangi stoktan ne kadar sattık gibi gibi .yani kısacası faturanın stok bilgileri 
        public DataTable KalemleriAc(string FaturaNo)
        {

            //oluşturduğumuz view'de arama yaptık.
            string sql = "SELECT * FROM VWSTOKHAR where  FATURANO='" + FaturaNo + "' ";

            return Dbase.TabloCek(sql);
        }

        //fatura kalemlerini sildik.yani faturanın stok hareket tablosundaki detaylarını sildik.
        public Boolean FaturaDetaylariniSil(string FaturaNo)
        {
            try
            {
                string sql = "EXECUTE SP_FATURAKALEMLERI_SIL '" + FaturaNo + "'";
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
