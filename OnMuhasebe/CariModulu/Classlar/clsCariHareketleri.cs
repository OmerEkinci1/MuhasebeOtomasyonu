using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.CariModulu.Classlar
{
    class clsCariHareketleri
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();

        public DataTable Listele(string CariKodu)
        {
            string sql = "select * from VWCARIHAR WHERE CARIKODU='" + CariKodu + "'";//view kullandık
            return Dbase.TabloCek(sql);
        }

        //BelgeNo=Faturano

        //EKLEME
        public Boolean CariAcilisKarti(string CariKodu, string BelgeNo, decimal Borc, decimal Alacak, string Tarih, string Aciklama)
        {
            try
            {
                //BelgeNo=Faturano
                //EvraID=-1 olcak
                //EVRAKTURU=DEVIR OLUCAK (MUHASEBE SİSTEMLERİNDE AÇILIŞ KARTLARI DEVIR OLARAK GEÇER.)
                //EXECUTE SP_CARIHAR_EKLE @CARIKODU ,@FATURANO  ,@EVRAKID  ,@TARIH  ,@BORC  ,@ALACAK  ,@ACIKLAMA  ,@VADETARIHI  ,@TIPI  ,@SAVEUSER -->>procedür
                //Borc ve alacak da virgülü noktaya çevirip sql e gönderiyoruz .yoksa hata alırız.
                string sql = "EXECUTE SP_CARIHAR_EKLE '" + CariKodu + "' ,'" + BelgeNo + "'  ,-1,'DEVIR' , '" + Formatlar.IngilizceTarihFormati(Tarih) + "'  ,'" + Borc.ToString().Replace(",", ".") + "'  ,'" + Alacak.ToString().Replace(",", ".") + "'  ,'" + Aciklama + "'  ,'" + Formatlar.IngilizceTarihFormati(Tarih) + "'  ,'A'  ," + OnMuhasebe.frmAnaForm.UserId;


                Dbase.Isle(sql);


                return true;//doğru çalışırsa true dönder
            }
            catch (Exception ex)
            {
                return false;//hata olursa false dönder
            }
        }


        //GÜNCELLEME
        public Boolean CariAcilisKartiGuncelle(string Id, string CariKodu, string BelgeNo, decimal Borc, decimal Alacak, string Tarih, string Aciklama)
        {
            try
            {
                //BelgeNo=Faturano
                //EXECUTE SP_CARIHAR_EKLE @CARIKODU ,@FATURANO  ,@EVRAKID  ,@TARIH  ,@BORC  ,@ALACAK  ,@ACIKLAMA  ,@VADETARIHI  ,@TIPI  ,@SAVEUSER -->>procedür
                //Borc ve alacak da virgülü noktaya çevirip sql e gönderiyoruz .yoksa hata alırız.
                //BELGENO=FATURANO
                string sql = "EXECUTE SP_CARIHAR_GUNCELLE " + Id + ",'" + CariKodu + "' ,'" + BelgeNo + "' ,-1,'DEVIR','" + Formatlar.IngilizceTarihFormati(Tarih) + "'  ,'" + Borc.ToString().Replace(",", ".") + "'  ,'" + Alacak.ToString().Replace(",", ".") + "'  ,'" + Aciklama + "'  ,'" + Formatlar.IngilizceTarihFormati(Tarih) + "'  ,'A'  ," + OnMuhasebe.frmAnaForm.UserId;


                Dbase.Isle(sql);


                return true;//doğru çalışırsa true dönder
            }
            catch (Exception ex)
            {
                return false;//hata olursa false dönder
            }
        }



        public DataRow CariAcilisKartiAc(string id)
        {
            string sql = "select top 1 * from VWCARIHAR WHERE ID=" + id; //view i kullandık
            return Dbase.SatirCek(sql);
        }


        public Boolean CariAcilisKartiSil(string Id)
        {
            try
            {

                string sql = "exec SP_CARIHAR_SIL " + Id;
                Dbase.Isle(sql);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataRow CariBakiye(string CariKodu)
        {
            //view kullandık
            string sql = "select * from VWCARIBAKIYE WHERE CARIKODU ='" + CariKodu + "'";
            return Dbase.SatirCek(sql);
        }
    }
}
