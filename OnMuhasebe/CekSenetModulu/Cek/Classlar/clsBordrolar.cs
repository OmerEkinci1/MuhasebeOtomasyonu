using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.CekSenetModulu.Cek.Classlar
{
    class clsBordrolar
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        Classlar.Cekler Cek = new Cekler();
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        public Boolean Ekle(string NUMARA, string CARIKODU, string TARIH, string ACIKLAMA, string SAVEUSER, MusteriCeki[] Cekler)
        {

            try
            {
                //EXECUTE SP_CEKBORDRO_EKLE   @NUMARA  ,@CARIKODU  ,@TARIH  ,@ACIKLAMA ,@SAVEUSER
                string sql = "EXECUTE SP_CEKBORDRO_EKLE   '" + NUMARA + "'  ,'" + CARIKODU + "'  ,'" + TARIH + "'  ,'" + ACIKLAMA + "' ," + SAVEUSER;
                Dbase.Isle(sql);

                //bordroya ait çekleri ekliyoruz.
                BordroCekleriEkle(NUMARA, CARIKODU, Cekler, SAVEUSER);



                return true;


            }
            catch (Exception)
            {

                return false;
            }



        }
        public Boolean Guncelle(string Id, string NUMARA, string CARIKODU, string TARIH, string ACIKLAMA, string SAVEUSER, MusteriCeki[] Cekler)
        {

            try
            {
                //EXECUTE SP_CEKBORDRO_EKLE   @NUMARA  ,@CARIKODU  ,@TARIH  ,@ACIKLAMA ,@SAVEUSER
                string sql = "EXECUTE SP_CEKBORDRO_GUNCELLE " + Id + ",   '" + NUMARA + "'  ,'" + CARIKODU + "'  ,'" + TARIH + "'  ,'" + ACIKLAMA + "' ," + SAVEUSER;
                Dbase.Isle(sql);


                //bordroya ait çekleri güncelliyoruz.
                //güncelleme yapmak için ilk önce bordroya ait çekleri silip.tekrar yenilerini ekliyoruz.
                if (BordroIcindekiCekleriSil(NUMARA)==true)
                {
                    BordroCekleriEkle(NUMARA, CARIKODU, Cekler, SAVEUSER);

                }
                
                return true;


            }
            catch (Exception)
            {

                return false;
            }



        }

        void BordroCekleriEkle(string Numara, string AlinanCari, MusteriCeki[] Cekler, string SaveUser)
        {
            string BelgeNo;
            string CekNo;
            string AsilCiro;
            string AsilBorclu;
            string VadeTarihi;
            string Tarih;
            
            string Banka;
            string Sube;
            string HesapNo;
            decimal Tutar;
            string Aciklama;
            bool EklemeBasariliMi;


            for (int i = 0; i < Cekler.Length; i++)
            {

                BelgeNo = Cekler[i].BelgeNo;
                CekNo = Cekler[i].CekNo;
                AsilCiro = Cekler[i].AsilCiro;
                AsilBorclu = Cekler[i].AsilBorclu;
                Tarih = Cekler[i].Tarih;
                VadeTarihi = Cekler[i].VadeTarihi;
                Banka = Cekler[i].Banka;
                Sube = Cekler[i].Sube;
                HesapNo = Cekler[i].HesapNo;
                Tutar = Cekler[i].Tutar;
                Aciklama = Cekler[i].Aciklama;
                EklemeBasariliMi = Cekler[i].EklemeBasariliMi;

                //M:MÜŞTERİ ÇEKİ
                Cek.CekGirisi(BelgeNo, CekNo, "M", AlinanCari, "", "", AsilCiro, AsilBorclu, Formatlar.IngilizceTarihFormati(Tarih), Formatlar.IngilizceTarihFormati(VadeTarihi), Banka, Sube, HesapNo, Tutar.ToString().Replace(",", "."), Aciklama, "B", "", Numara, SaveUser);


            }
        }

        public DataTable Listele(string Numara, string CariKodu, string CariAdi, string Tarih, string Aciklama)
        {

            string sql = "select * from VWCEKBORDRO WHERE NUMARA LIKE '%" + Numara + "%' AND CARIKODU LIKE '%" + CariKodu + "%' AND CARIISIM LIKE '%" + CariAdi + "%' AND TARIH LIKE '%" + Tarih + "%' AND ACIKLAMA LIKE '%" + Aciklama + "%' ";


            return Dbase.TabloCek(sql);

        }

        public DataRow Ac(string Id)
        {
            try
            {
                string sql = "select * from VWCEKBORDRO WHERE ID=" + Id;
                return Dbase.SatirCek(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable CekleriGetir(string BordroNo)//BordroNo ya göre çekleri getiriyoruz
        {
            //-1 AS DIZIID koymamızın sebebi.frmMusteriCekbordrosu formundaki CekleriAc metodundaki   gridView1.SetRowCellValue(i, "DIZIID", GirilenCekler.Length - 1); işleminde değer aktarabilmek için bunu yaptık.yoksa değer gridde gösterilmiyordu.
            string sql = "select *,-1 AS DIZIID from TBLCEK WHERE BORDRONO='" + BordroNo + "'";
            return Dbase.TabloCek(sql);
        }

        Boolean BordroIcindekiCekleriSil(string BordroNo)
        {
            try
            {
                string sql = "delete from TBLCEK WHERE BORDRONO='" + BordroNo + "'";
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
