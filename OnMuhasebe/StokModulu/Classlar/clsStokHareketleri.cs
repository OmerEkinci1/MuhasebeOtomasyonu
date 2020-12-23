using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OnMuhasebe.StokModulu.Classlar
{
    class clsStokHareketleri
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        public void Ekle(string FaturaNo, string GcKodu, DataTable Liste, string Tarih, string Tipi)
        {
            string StokKodu;
            int Miktar;
            decimal Fiyat, Isk1, Isk2, Kdv;

            for (int i = 0; i < Liste.Rows.Count; i++)
            {
                StokKodu = Liste.Rows[i]["STOKKODU"].ToString();
                Miktar = Convert.ToInt32(Liste.Rows[i]["MIKTAR"].ToString());
                Fiyat = Convert.ToDecimal(Liste.Rows[i]["BIRIMFIYAT"].ToString());
                Isk1 = Convert.ToDecimal(Liste.Rows[i]["ISK1"].ToString());
                Isk2 = Convert.ToDecimal(Liste.Rows[i]["ISK2"].ToString());
                Kdv = Convert.ToDecimal(Liste.Rows[i]["KDV"].ToString());


                //Not:Sayısal kolonlarda tek tırnak kullanılmaz(string ifadelerde tek tırnak şeklinde sql cümleciğini oluşturuyoruz.)
                //Not:decimal türlerde Fiyat gibi , (virgülü) .(noktaya) çeviriyoruz replace ile çünkü sqlde . nokta şeklinde çalışıyor

                //EXECUTE SP_STOKHAR_EKLE   @FATURANO  ,@STOKKODU  ,@GCKOD  ,@MIKTAR ,@BRUTFIYAT  ,@ISK1  ,@ISK2  ,@KDV  ,@TIPI  ,@TARIH  ,@SAVEUSER
                string sql = "EXECUTE SP_STOKHAR_EKLE '" + FaturaNo + "','" + StokKodu + "','" + GcKodu + "'," + Miktar + "," + Fiyat.ToString().Replace(",", ".") + "," + Isk1.ToString().Replace(",", ".") + "," + Isk2.ToString().Replace(",", ".") + "," + Kdv.ToString().Replace(",", ".") + ",'" + Tipi + "','" + Tarih + "'," + frmAnaForm.UserId + "";

                Dbase.Isle(sql);


            }


        }



        public DataTable Listele(string StokKodu)
        {
            string sql = "select * from VWSTOKHAR WHERE STOKKODU='" + StokKodu + "' order by TARIH ASC";//view kullandık
            return Dbase.TabloCek(sql);
        }


        public DataRow StokBakiye(string StokKodu)
        {
            //view
            string Sql = "select * from VWSTOKBAKIYE WHERE STOKKODU='" + StokKodu + "'";
            return Dbase.SatirCek(Sql);
        }

        public Boolean StokAcilisKarti(string BelgeNo, string StokKodu, string GCKodu, string Miktar, string Fiyat, string Kdv, string Tarih)
        {
            try
            {
                //BelgeNo=faturano
                //EXECUTE SP_STOKHAR_EKLE   @FATURANO  ,@STOKKODU  ,@GCKOD  ,@MIKTAR  ,@BRUTFIYAT  ,@ISK1  ,@ISK2  ,@KDV  ,@TIPI  ,@TARIH  ,@SAVEUSER
                string sql = "EXECUTE SP_STOKHAR_EKLE   '" + BelgeNo + "'  ,'" + StokKodu + "'  ,'" + GCKodu + "'  ," + Miktar + "  ," + Fiyat.Replace(",", ".").ToString() + "  , 0 ,0 ," + Kdv.Replace(",", ".").ToString() + "  ,'A'  ,'" + Formatlar.IngilizceTarihFormati(Tarih) + "'  ," + OnMuhasebe.frmAnaForm.UserId;
                Dbase.Isle(sql);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public Boolean StokAcilisKartiGuncelle(string Id, string BelgeNo, string StokKodu, string GCKodu, string Miktar, string Fiyat, string Kdv, string Tarih)
        {
            try
            {
                //BelgeNo=faturano
                //EXECUTE SP_STOKHAR_GUNCELLE    @ID,   @FATURANO  ,@STOKKODU  ,@GCKOD  ,@MIKTAR  ,@BRUTFIYAT  ,@ISK1  ,@ISK2  ,@KDV  ,@TIPI  ,@TARIH  ,@SAVEUSER
                string sql = "EXECUTE SP_STOKHAR_GUNCELLE " + Id + ", '" + BelgeNo + "'  ,'" + StokKodu + "'  ,'" + GCKodu + "'  ," + Miktar + "  ," + Fiyat.Replace(",", ".").ToString() + "  , 0 ,0 ," + Kdv.Replace(",", ".").ToString() + "  ,'A'  ,'" + Formatlar.IngilizceTarihFormati(Tarih) + "'  ," + OnMuhasebe.frmAnaForm.UserId;
                Dbase.Isle(sql);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }




        public DataRow StokAcilisKartiAc(string Id)
        {
            string sql = "select top 1 * from VWSTOKHAR WHERE ID=" + Id;
            return Dbase.SatirCek(sql);
        }

        public Boolean StokAcilisKartiSil(string Id)
        {
            try
            {
                string sql = "EXECUTE SP_STOKHAR_SIL " + Id;
                Dbase.Isle(sql);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
