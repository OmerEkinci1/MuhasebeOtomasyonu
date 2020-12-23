using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.CekSenetModulu.Senet.Classlar
{
   public class Senetler
    {


        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        public Boolean SenetGirisi(string BELGENO, string SenetNO, string TIPI, string ALINANCARI, string VERILENCARI, string VERILENBANKA, string ASILCIRO, string ASILBORCLU, string Tarih, string VADETARIHI, string BANKA, string SUBE, string HESAPNO, string TUTAR, string ACIKLAMA, string DURUMU, string TAHSILEDILDIMI, string BORDRONO, string SAVEUSER)
        {
            try
            {
                //EXECUTE SP_Senet_EKLE   @BELGENO  ,@SenetNO  ,@TIPI  ,@ALINANCARI  ,@VERILENCARI ,@VERILENBANKA  ,@ASILCIRO  ,@ASILBORCLU  ,@VADETARIHI  ,@BANKA  ,@SUBE  ,@HESAPNO  ,@TUTAR  ,@ACIKLAMA  ,@DURUMU  ,@TAHSILEDILDIMI  ,@BORDRONO  ,@SAVEUSER
                string sql = "EXECUTE SP_Senet_EKLE   '" + BELGENO + "'  ,'" + SenetNO + "'  ,'" + TIPI + "'  ,'" + ALINANCARI + "'  ,'" + VERILENCARI + "' ,'" + VERILENBANKA + "'  ,'" + ASILCIRO + "'  ,'" + ASILBORCLU + "' ,'" + Tarih + "' ,'" + VADETARIHI + "'  ,'" + BANKA + "'  ,'" + SUBE + "'  ,'" + HESAPNO + "'  ," + TUTAR.Replace(",", ".") + "  ,'" + ACIKLAMA + "'  ,'" + DURUMU + "'  ,'" + TAHSILEDILDIMI + "'  ,'" + BORDRONO + "'  ," + SAVEUSER;

                Dbase.Isle(sql);
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

        public Boolean SenetGuncelle(string Id, string BELGENO, string SenetNO, string TIPI, string ALINANCARI, string VERILENCARI, string VERILENBANKA, string ASILCIRO, string ASILBORCLU, string Tarih, string VADETARIHI, string BANKA, string SUBE, string HESAPNO, string TUTAR, string ACIKLAMA, string DURUMU, string TAHSILEDILDIMI, string BORDRONO, string SAVEUSER)
        {
            try
            {
                //EXECUTE SP_Senet_EKLE   @BELGENO  ,@SenetNO  ,@TIPI  ,@ALINANCARI  ,@VERILENCARI ,@VERILENBANKA  ,@ASILCIRO  ,@ASILBORCLU  ,@VADETARIHI  ,@BANKA  ,@SUBE  ,@HESAPNO  ,@TUTAR  ,@ACIKLAMA  ,@DURUMU  ,@TAHSILEDILDIMI  ,@BORDRONO  ,@SAVEUSER
                string sql = "EXECUTE SP_Senet_GUNCELLE " + Id + ",  '" + BELGENO + "'  ,'" + SenetNO + "'  ,'" + TIPI + "'  ,'" + ALINANCARI + "'  ,'" + VERILENCARI + "' ,'" + VERILENBANKA + "'  ,'" + ASILCIRO + "'  ,'" + ASILBORCLU + "' ,'" + Tarih + "' ,'" + VADETARIHI + "'  ,'" + BANKA + "'  ,'" + SUBE + "'  ,'" + HESAPNO + "'  ," + TUTAR.Replace(",", ".") + "  ,'" + ACIKLAMA + "'  ,'" + DURUMU + "'  ,'" + TAHSILEDILDIMI + "'  ,'" + BORDRONO + "'  ," + SAVEUSER;

                Dbase.Isle(sql);
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

        public Boolean Sil(string Id)
        {
            try
            {
                string sql = "execute SP_Senet_SIL " + Id;
                Dbase.Isle(sql);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public DataTable MusteriSenetListesi(string BelgeNo, string SenetNo, string CariKodu, string CariIsim, string Tarih, string VadeTarihi, string Aciklama, string Durum, Boolean Bankadakiler, Boolean Portfoydekiler, Boolean Cirodakiler)
        {
            string _Banka = "'*'", _Portfoy = "'*'", _Ciro = "'*'";
            string YerSorgusu = "";
            if (Bankadakiler == true)
            {
                _Banka = "'B'";
            }

            if (Cirodakiler == true)
            {
                _Ciro = "'C'";
            }

            if (Portfoydekiler == true)
            {
                _Portfoy = "'P'";
            }

            YerSorgusu = " and ( YERI IN (" + _Banka + "," + _Portfoy + "," + _Ciro + "))";

            try
            {
                string sql = "select * from VWMUSTERISenetLERI where BELGENO LIKE '%" + BelgeNo + "%' AND SenetNO LIKE '%" + SenetNo + "%' AND ALINANCARI LIKE '%" + CariKodu + "%' AND ALINANCARIISIM LIKE '%" + CariIsim + "%' AND TARIH LIKE '%" + Tarih + "%'  AND VADETARIHI LIKE '%" + VadeTarihi + "%' AND ACIKLAMA LIKE '%" + Aciklama + "%' AND DURUMU LIKE '%" + Durum + "%' " + YerSorgusu;


                return Dbase.TabloCek(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataRow Ac(string Id)
        {
            string sql = "select top 1 * from VWSenetLER WHERE ID= " + Id;//view

            return Dbase.SatirCek(sql);
        }

        public void SenetiBankayaVer(string Id, string BankaId, string Tarih, string BelgeNo)
        {

            //EXECUTE SP_SenetIBANKAYAVER   @ID  ,@BANKAID  ,@TARIH  ,@BELGENO
            string sql = "EXECUTE SP_SenetIBANKAYAVER   " + Id + "  ," + BankaId + "  ,'" + Tarih + "'  ,'" + BelgeNo + "'";

            Dbase.Isle(sql);

        }

        public void SenetiCariyeVer(string Id, string CariKodu, string Tarih, string BelgeNo)
        {


            string sql = "EXECUTE SP_SenetICARIYEVER   " + Id + "  ,'" + CariKodu + "'  ,'" + Tarih + "'  ,'" + BelgeNo + "'";

            Dbase.Isle(sql);

        }

        public Boolean SenetiBankadanIadeAl(string Id)
        {


            try
            {
                string sql = "    EXECUTE SP_SenetIBANKADANIADEAL   " + Id;

                Dbase.Isle(sql);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public Boolean SenetiCaridenIadeAl(string Id)
        {


            try
            {
                string sql = "   EXECUTE SP_SenetICARIDENIADEAL   " + Id;

                Dbase.Isle(sql);
                return true;





                /*
                 
                 --TEKRAR ÇEKİ PORTFÖYE DÜŞÜRECEZ.
                    ALTER PROCEDURE [dbo].[SP_SenetICARIDENIADEAL]
                    @ID INT 
                    AS
                    BEGIN
                    UPDATE TBLSenet SET VERILENCARI=NULL,
                    VER_CARI_BELGENO=NULL,VER_CARI_TARIH=NULL ,YERI='P'--PORTFÖY
	                    WHERE ID=@ID

                                //CARİ HAREKETİNİ SİLİYORUZ.
	                    DELETE  FROM TBLCARIHAR WHERE EVRAKTURU='Senet' AND EVRAKID=@ID



                    END

                 
                 
                 */


            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public Boolean SenetDurumu(string SenetId, string Durumu)
        {
            try
            {
                //EXECUTE SP_SenetINDURUMU   @ID  ,@DURUMU
                string sql = "EXECUTE SP_SenetINDURUMU   " + SenetId + " ,'" + Durumu + "'";
                Dbase.Isle(sql);

                return true;
            }
            catch (Exception EX)
            {

                return false;
            }
        }

        public string SenetTahsilatiYapilanKasa(string SenetId)
        {
            try
            {
                string sql = "select KASAKODU from TBLKASAHAR WHERE EVRAKTURU='Senet' AND EVRAKID=" + SenetId + "";
                DataRow Satir = Dbase.SatirCek(sql);
                string KasaKodu = Satir["KASAKODU"].ToString();

                return KasaKodu;
            }
            catch (Exception ex)
            {

                return "";
            }
        }

        public string SenetTahsilatiYapilanBanka(string SenetId)
        {
            try
            {
                string sql = "select BANKAID from TBLBANKAHAR WHERE EVRAKTURU='Senet' AND EVRAKID=" + SenetId + "";
                DataRow Satir = Dbase.SatirCek(sql);
                string BankaId = Satir["BANKAID"].ToString();

                return BankaId;
            }
            catch (Exception ex)
            {

                return "";
            }
        }



        public DataTable KendiSenetListesi(string BelgeNo, string SenetNo, string VerilenCari, string VerilenBanka, string Tarih, string VadeTarihi, string Aciklama, string Durum, Boolean Bankadakiler, Boolean Portfoydekiler, Boolean Cirodakiler)
        {
            string _Banka = "'*'", _Portfoy = "'*'", _Ciro = "'*'";
            string YerSorgusu = "";
            if (Bankadakiler == true)
            {
                _Banka = "'B'";
            }

            if (Cirodakiler == true)
            {
                _Ciro = "'C'";
            }

            if (Portfoydekiler == true)
            {
                _Portfoy = "'P'";
            }

            YerSorgusu = " and ( YERI IN (" + _Banka + "," + _Portfoy + "," + _Ciro + "))";

            try
            {
                string sql = "select * from VWKENDISenetLERI where BELGENO LIKE '%" + BelgeNo + "%' AND SenetNO LIKE '%" + SenetNo + "%' AND VERILENCARIISIM LIKE '%" + VerilenCari + "%' AND VERILENBANKAISIM LIKE '%" + VerilenBanka + "%' AND TARIH LIKE '%" + Tarih + "%'  AND VADETARIHI LIKE '%" + VadeTarihi + "%' AND ACIKLAMA LIKE '%" + Aciklama + "%' AND DURUMU LIKE '%" + Durum + "%' " + YerSorgusu;


                return Dbase.TabloCek(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
