using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.CekSenetModulu.Senet.Classlar
{
    class clsBordrolar
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();

        //Classlar.Senetler Senet = new Classlar.Senetler();
        OnMuhasebe.CekSenetModulu.Senet.Classlar.Senetler Senet = new CekSenetModulu.Senet.Classlar.Senetler();
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        public Boolean Ekle(string NUMARA, string CARIKODU, string TARIH, string ACIKLAMA, string SAVEUSER, MusteriSeneti[] Senetler)
        {

            try
            {
                //EXECUTE SP_SenetBORDRO_EKLE   @NUMARA  ,@CARIKODU  ,@TARIH  ,@ACIKLAMA ,@SAVEUSER
                string sql = "EXECUTE SP_SenetBORDRO_EKLE   '" + NUMARA + "'  ,'" + CARIKODU + "'  ,'" + TARIH + "'  ,'" + ACIKLAMA + "' ," + SAVEUSER;
                Dbase.Isle(sql);

                //bordroya ait çekleri ekliyoruz.
                BordroSenetleriEkle(NUMARA, CARIKODU, Senetler, SAVEUSER);



                return true;


            }
            catch (Exception)
            {

                return false;
            }



        }
        public Boolean Guncelle(string Id, string NUMARA, string CARIKODU, string TARIH, string ACIKLAMA, string SAVEUSER, MusteriSeneti[] Senetler)
        {

            try
            {
                //EXECUTE SP_SenetBORDRO_EKLE   @NUMARA  ,@CARIKODU  ,@TARIH  ,@ACIKLAMA ,@SAVEUSER
                string sql = "EXECUTE SP_SenetBORDRO_GUNCELLE " + Id + ",   '" + NUMARA + "'  ,'" + CARIKODU + "'  ,'" + TARIH + "'  ,'" + ACIKLAMA + "' ," + SAVEUSER;
                Dbase.Isle(sql);


                //bordroya ait çekleri güncelliyoruz.
                //güncelleme yapmak için ilk önce bordroya ait çekleri silip.tekrar yenilerini ekliyoruz.
                if (BordroIcindekiSenetleriSil(NUMARA)==true)
                {
                    BordroSenetleriEkle(NUMARA, CARIKODU, Senetler, SAVEUSER);

                }
                
                return true;


            }
            catch (Exception)
            {

                return false;
            }



        }

        void BordroSenetleriEkle(string Numara, string AlinanCari,MusteriSeneti[] Senetler, string SaveUser)
        {
            string BelgeNo;
            string SenetNo;
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


            for (int i = 0; i < Senetler.Length; i++)
            {

                BelgeNo = Senetler[i].BelgeNo;
                SenetNo = Senetler[i].SenetNo;
                AsilCiro = Senetler[i].AsilCiro;
                AsilBorclu = Senetler[i].AsilBorclu;
                Tarih = Senetler[i].Tarih;
                VadeTarihi = Senetler[i].VadeTarihi;
                Banka = Senetler[i].Banka;
                Sube = Senetler[i].Sube;
                HesapNo = Senetler[i].HesapNo;
                Tutar = Senetler[i].Tutar;
                Aciklama = Senetler[i].Aciklama;
                EklemeBasariliMi = Senetler[i].EklemeBasariliMi;

                //M:MÜŞTERİ ÇEKİ
                Senet.SenetGirisi(BelgeNo, SenetNo, "M", AlinanCari, "", "", AsilCiro, AsilBorclu, Formatlar.IngilizceTarihFormati(Tarih), Formatlar.IngilizceTarihFormati(VadeTarihi), Banka, Sube, HesapNo, Tutar.ToString().Replace(",", "."), Aciklama, "B", "", Numara, SaveUser);


            }
        }

        public DataTable Listele(string Numara, string CariKodu, string CariAdi, string Tarih, string Aciklama)
        {

            string sql = "select * from VWSenetBORDRO WHERE NUMARA LIKE '%" + Numara + "%' AND CARIKODU LIKE '%" + CariKodu + "%' AND CARIISIM LIKE '%" + CariAdi + "%' AND TARIH LIKE '%" + Tarih + "%' AND ACIKLAMA LIKE '%" + Aciklama + "%' ";


            return Dbase.TabloCek(sql);

        }

        public DataRow Ac(string Id)
        {
            try
            {
                string sql = "select * from VWSenetBORDRO WHERE ID=" + Id;
                return Dbase.SatirCek(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable SenetleriGetir(string BordroNo)//BordroNo ya göre çekleri getiriyoruz
        {
            //-1 AS DIZIID koymamızın sebebi.frmMusteriSenetbordrosu formundaki SenetleriAc metodundaki   gridView1.SetRowCellValue(i, "DIZIID", GirilenSenetler.Length - 1); işleminde değer aktarabilmek için bunu yaptık.yoksa değer gridde gösterilmiyordu.
            string sql = "select *,-1 AS DIZIID from TBLSenet WHERE BORDRONO='" + BordroNo + "'";
            return Dbase.TabloCek(sql);
        }

        Boolean BordroIcindekiSenetleriSil(string BordroNo)
        {
            try
            {
                string sql = "delete from TBLSenet WHERE BORDRONO='" + BordroNo + "'";
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
