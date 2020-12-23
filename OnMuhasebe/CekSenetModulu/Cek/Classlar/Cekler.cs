using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.CekSenetModulu.Cek.Classlar
{
    class Cekler
    {


        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        public Boolean CekGirisi(string BELGENO, string CEKNO, string TIPI, string ALINANCARI, string VERILENCARI, string VERILENBANKA, string ASILCIRO, string ASILBORCLU, string Tarih, string VADETARIHI, string BANKA, string SUBE, string HESAPNO, string TUTAR, string ACIKLAMA, string DURUMU, string TAHSILEDILDIMI, string BORDRONO, string SAVEUSER)
        {
            try
            {
                //EXECUTE SP_CEK_EKLE   @BELGENO  ,@CEKNO  ,@TIPI  ,@ALINANCARI  ,@VERILENCARI ,@VERILENBANKA  ,@ASILCIRO  ,@ASILBORCLU  ,@VADETARIHI  ,@BANKA  ,@SUBE  ,@HESAPNO  ,@TUTAR  ,@ACIKLAMA  ,@DURUMU  ,@TAHSILEDILDIMI  ,@BORDRONO  ,@SAVEUSER
                string sql = "EXECUTE SP_CEK_EKLE   '" + BELGENO + "'  ,'" + CEKNO + "'  ,'" + TIPI + "'  ,'" + ALINANCARI + "'  ,'" + VERILENCARI + "' ,'" + VERILENBANKA + "'  ,'" + ASILCIRO + "'  ,'" + ASILBORCLU + "' ,'" + Tarih + "' ,'" + VADETARIHI + "'  ,'" + BANKA + "'  ,'" + SUBE + "'  ,'" + HESAPNO + "'  ," + TUTAR.Replace(",", ".") + "  ,'" + ACIKLAMA + "'  ,'" + DURUMU + "'  ,'" + TAHSILEDILDIMI + "'  ,'" + BORDRONO + "'  ," + SAVEUSER;

                Dbase.Isle(sql);
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

        public Boolean CekGuncelle(string Id, string BELGENO, string CEKNO, string TIPI, string ALINANCARI, string VERILENCARI, string VERILENBANKA, string ASILCIRO, string ASILBORCLU, string Tarih, string VADETARIHI, string BANKA, string SUBE, string HESAPNO, string TUTAR, string ACIKLAMA, string DURUMU, string TAHSILEDILDIMI, string BORDRONO, string SAVEUSER)
        {
            try
            {
                //EXECUTE SP_CEK_EKLE   @BELGENO  ,@CEKNO  ,@TIPI  ,@ALINANCARI  ,@VERILENCARI ,@VERILENBANKA  ,@ASILCIRO  ,@ASILBORCLU  ,@VADETARIHI  ,@BANKA  ,@SUBE  ,@HESAPNO  ,@TUTAR  ,@ACIKLAMA  ,@DURUMU  ,@TAHSILEDILDIMI  ,@BORDRONO  ,@SAVEUSER
                string sql = "EXECUTE SP_CEK_GUNCELLE " + Id + ",  '" + BELGENO + "'  ,'" + CEKNO + "'  ,'" + TIPI + "'  ,'" + ALINANCARI + "'  ,'" + VERILENCARI + "' ,'" + VERILENBANKA + "'  ,'" + ASILCIRO + "'  ,'" + ASILBORCLU + "' ,'" + Tarih + "' ,'" + VADETARIHI + "'  ,'" + BANKA + "'  ,'" + SUBE + "'  ,'" + HESAPNO + "'  ," + TUTAR.Replace(",", ".") + "  ,'" + ACIKLAMA + "'  ,'" + DURUMU + "'  ,'" + TAHSILEDILDIMI + "'  ,'" + BORDRONO + "'  ," + SAVEUSER;

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
                string sql = "execute SP_CEK_SIL " + Id;
                Dbase.Isle(sql);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public DataTable MusteriCekListesi(string BelgeNo, string CekNo, string CariKodu, string CariIsim, string Tarih, string VadeTarihi, string Aciklama, string Durum, Boolean Bankadakiler, Boolean Portfoydekiler, Boolean Cirodakiler)
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
                string sql = "select * from VWMUSTERICEKLERI where BELGENO LIKE '%" + BelgeNo + "%' AND CEKNO LIKE '%" + CekNo + "%' AND ALINANCARI LIKE '%" + CariKodu + "%' AND ALINANCARIISIM LIKE '%" + CariIsim + "%' AND TARIH LIKE '%" + Tarih + "%'  AND VADETARIHI LIKE '%" + VadeTarihi + "%' AND ACIKLAMA LIKE '%" + Aciklama + "%' AND DURUMU LIKE '%" + Durum + "%' " + YerSorgusu;


                return Dbase.TabloCek(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataRow Ac(string Id)
        {
            string sql = "select top 1 * from VWCEKLER WHERE ID= " + Id;//view

            return Dbase.SatirCek(sql);
        }

        public void CekiBankayaVer(string Id, string BankaId, string Tarih, string BelgeNo)
        {

            //EXECUTE SP_CEKIBANKAYAVER   @ID  ,@BANKAID  ,@TARIH  ,@BELGENO
            string sql = "EXECUTE SP_CEKIBANKAYAVER   " + Id + "  ," + BankaId + "  ,'" + Tarih + "'  ,'" + BelgeNo + "'";

            Dbase.Isle(sql);

        }

        public void CekiCariyeVer(string Id, string CariKodu, string Tarih, string BelgeNo)
        {


            string sql = "EXECUTE SP_CEKICARIYEVER   " + Id + "  ,'" + CariKodu + "'  ,'" + Tarih + "'  ,'" + BelgeNo + "'";

            Dbase.Isle(sql);

        }

        public Boolean CekiBankadanIadeAl(string Id)
        {


            try
            {
                string sql = "    EXECUTE SP_CEKIBANKADANIADEAL   " + Id;

                Dbase.Isle(sql);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public Boolean CekiCaridenIadeAl(string Id)
        {


            try
            {
                string sql = "   EXECUTE SP_CEKICARIDENIADEAL   " + Id;

                Dbase.Isle(sql);
                return true;





                /*
                 
                 --TEKRAR ÇEKİ PORTFÖYE DÜŞÜRECEZ.
                    ALTER PROCEDURE [dbo].[SP_CEKICARIDENIADEAL]
                    @ID INT 
                    AS
                    BEGIN
                    UPDATE TBLCEK SET VERILENCARI=NULL,
                    VER_CARI_BELGENO=NULL,VER_CARI_TARIH=NULL ,YERI='P'--PORTFÖY
	                    WHERE ID=@ID

                                //CARİ HAREKETİNİ SİLİYORUZ.
	                    DELETE  FROM TBLCARIHAR WHERE EVRAKTURU='CEK' AND EVRAKID=@ID



                    END

                 
                 
                 */


            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public Boolean CekDurumu(string CekId, string Durumu)
        {
            try
            {
                //EXECUTE SP_CEKINDURUMU   @ID  ,@DURUMU
                string sql = "EXECUTE SP_CEKINDURUMU   " + CekId + " ,'" + Durumu + "'";
                Dbase.Isle(sql);

                return true;
            }
            catch (Exception EX)
            {

                return false;
            }
        }

        public string CekTahsilatiYapilanKasa(string CekId)
        {
            try
            {
                string sql = "select KASAKODU from TBLKASAHAR WHERE EVRAKTURU='CEK' AND EVRAKID=" + CekId + "";
                DataRow Satir = Dbase.SatirCek(sql);
                string KasaKodu = Satir["KASAKODU"].ToString();

                return KasaKodu;
            }
            catch (Exception ex)
            {

                return "";
            }
        }

        public string CekTahsilatiYapilanBanka(string CekId)
        {
            try
            {
                string sql = "select BANKAID from TBLBANKAHAR WHERE EVRAKTURU='CEK' AND EVRAKID=" + CekId + "";
                DataRow Satir = Dbase.SatirCek(sql);
                string BankaId = Satir["BANKAID"].ToString();

                return BankaId;
            }
            catch (Exception ex)
            {

                return "";
            }
        }



        public DataTable KendiCekListesi(string BelgeNo, string CekNo, string VerilenCari, string VerilenBanka, string Tarih, string VadeTarihi, string Aciklama, string Durum, Boolean Bankadakiler, Boolean Portfoydekiler, Boolean Cirodakiler)
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
                string sql = "select * from VWKENDICEKLERI where BELGENO LIKE '%" + BelgeNo + "%' AND CEKNO LIKE '%" + CekNo + "%' AND VERILENCARIISIM LIKE '%" + VerilenCari + "%' AND VERILENBANKAISIM LIKE '%" + VerilenBanka + "%' AND TARIH LIKE '%" + Tarih + "%'  AND VADETARIHI LIKE '%" + VadeTarihi + "%' AND ACIKLAMA LIKE '%" + Aciklama + "%' AND DURUMU LIKE '%" + Durum + "%' " + YerSorgusu;


                return Dbase.TabloCek(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
