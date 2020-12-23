using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.FaturaModulu.Classlar
{
    class clsSatisFaturasi
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();

        /*
        * Bu hatanın sebebi türkçe tarihi veritabanına gönderdiğimiz için.biz ise türkçe tarihi ingilizce tarihe çevirip öyle yollayacağız.Formatlar classında bu işlemi yaptık zaten
        Hata:An unhandled exception of type 'System.Data.SqlClient.SqlException' occurred in System.Data.dll

Additional information: Error converting data type varchar to datetime.
             
             
        */
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        StokModulu.Classlar.clsStokHareketleri StokHareketleri = new StokModulu.Classlar.clsStokHareketleri();
        public Boolean Ekle(string FaturaNo, string CariKodu, string Tarih, string VadeTarihi, string GenelToplam, string Turu, string Aciklama, DataTable Detaylar,string OdemeYeri,string OdemeYeriId)
        {
            try
            {
                string Tipi = "S";//satış 
                string sql = "EXECUTE SP_FATURA_EKLE '" + FaturaNo + "','" + CariKodu + "' ,'" + Formatlar.IngilizceTarihFormati(Tarih) + "','" + Formatlar.IngilizceTarihFormati(VadeTarihi) + "'," + GenelToplam.Replace(",", ".") + ",'" + Turu + "','" + Tipi + "','"+OdemeYeri+"','"+OdemeYeriId+"','" + Aciklama + "'," + frmAnaForm.UserId + "";
                /*GenelToplam.Replace yaparak sqlde virgül yerine nokta şeklinde ekleme yapmak için yoksa hata verir.*/
                Dbase.Isle(sql);

                //Bir Satış yapıyoruz.O Satışa ait fatura kesiyoruz ve StokHareketlerine de ekleme yapıyoruz.

                //G:Giriş //alış faturasında falan giriş işlemi olur.
                //C:Cıkış //satış faturası olduğu için Çıkış yaptık.
                StokHareketleri.Ekle(FaturaNo, "C", Detaylar, Formatlar.IngilizceTarihFormati(Tarih), Tipi);

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
                string Tipi = "S";//satış 

                string sql = "EXECUTE SP_FATURA_GUNCELLE " + Id + ",'" + FaturaNo + "','" + CariKodu + "' ,'" + Formatlar.IngilizceTarihFormati(Tarih) + "','" + Formatlar.IngilizceTarihFormati(VadeTarihi) + "'," + GenelToplam.Replace(",", ".") + ",'" + Turu + "','" + Tipi + "','"+OdemeYeri+"',"+OdemeYeriId+",'" + Aciklama + "'," + frmAnaForm.UserId + "";

                Dbase.Isle(sql);

                if (FaturaDetaylariniSil(FaturaNo) == true)
                {
                    StokHareketleri.Ekle(FaturaNo, "C", Detaylar, Formatlar.IngilizceTarihFormati(Tarih), Tipi);
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
            string sql = "SELECT * FROM VWFATURALAR where CARIKODU LIKE '%" + CariKodu + "%' AND CARIISIM LIKE '%" + CariAdi + "%' AND FATURANO LIKE '%" + FaturaNo + "%' AND TIPI='S'";//SATIŞ FATURASI OLDUĞU İÇİN

            return Dbase.TabloCek(sql);


        }

        public DataRow Ac(string FaturaNo)
        {
            string sql = "SELECT top 1* FROM VWFATURALAR where FATURANO='" + FaturaNo + "'";

            return Dbase.SatirCek(sql);
        }
        public DataTable KalemleriAc(string FaturaNo)
        {
            string sql = "SELECT * FROM VWSTOKHAR where  FATURANO='" + FaturaNo + "'";

            return Dbase.TabloCek(sql);
        }

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
