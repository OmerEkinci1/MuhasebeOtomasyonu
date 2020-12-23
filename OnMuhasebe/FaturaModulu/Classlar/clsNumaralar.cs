using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.FaturaModulu.Classlar
{
    class clsNumaralar
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        Classlar.clsFaturaParametreleri Parametreler = new clsFaturaParametreleri();

        public string GetYeniSatisFaturasiNumarasi()
        {
            string Numara = SatisFaturasiNumarasi();//FT007 gibi

            int Yeni;
            /*
             FT000001 fatura numarasındaki 000001 li kısmı aldık yani
             */
            Numara = Numara.Substring(Parametreler.GetSatisFaturasiBaslangicKarakteri().Length, Numara.Length - Parametreler.GetSatisFaturasiBaslangicKarakteri().Length);

            Yeni = Convert.ToInt32(Numara);//000001  gibi


            string Sifirlar = "";
            int uz = Parametreler.GetSatisFaturasiUzunlugu();
            int bas_uzunluk = Parametreler.GetSatisFaturasiBaslangicKarakteri().Length;
            int yeni_uzunluk = Yeni.ToString().Length;

            int sayac = uz - bas_uzunluk - yeni_uzunluk;

            for (int i = 0; i < sayac; i++)
            {
                Sifirlar += "0";
            }


            Numara = Parametreler.SatisFaturasiBaslangicKarakteri + Sifirlar + (Yeni + 1);

            return Numara;//SF0000000002 gibi olcak mesela
        }







        public string GetYeniSatisIadeFaturasiNumarasi()
        {
            string Numara = SatisIadeFaturasiNumarasi();//FT007 gibi

            int Yeni;
            /*
             FT000001 fatura numarasındaki 000001 li kısmı aldık yani
             */
            Numara = Numara.Substring(Parametreler.GetSatisIadeFaturasiBaslangicKarakteri().Length, Numara.Length - Parametreler.GetSatisIadeFaturasiBaslangicKarakteri().Length);

            Yeni = Convert.ToInt32(Numara);//000001  gibi


            string Sifirlar = "";
            int uz = Parametreler.GetSatisIadeFaturasiUzunlugu();
            int bas_uzunluk = Parametreler.GetSatisIadeFaturasiBaslangicKarakteri().Length;
            int yeni_uzunluk = Yeni.ToString().Length;

            int sayac = uz - bas_uzunluk - yeni_uzunluk;

            for (int i = 0; i < sayac; i++)
            {
                Sifirlar += "0";
            }


            Numara = Parametreler.SatisIadeFaturasiBaslangicKarakteri + Sifirlar + (Yeni + 1);

            return Numara;//SF0000000002 gibi olcak mesela
        }

        public string GetYeniAlisFaturasiNumarasi()
        {
            string Numara =AlisFaturasiNumarasi();//FT007 gibi

            int Yeni;
            /*
             FT000001 fatura numarasındaki 000001 li kısmı aldık yani
             */
            Numara = Numara.Substring(Parametreler.GetAlisFaturasiBaslangicKarakteri().Length, Numara.Length - Parametreler.GetAlisFaturasiBaslangicKarakteri().Length);

            Yeni = Convert.ToInt32(Numara);//000001  gibi


            string Sifirlar = "";
            int uz = Parametreler.GetAlisFaturasiUzunlugu();
            int bas_uzunluk = Parametreler.GetAlisFaturasiBaslangicKarakteri().Length;
            int yeni_uzunluk = Yeni.ToString().Length;

            int sayac = uz - bas_uzunluk - yeni_uzunluk;

            for (int i = 0; i < sayac; i++)
            {
                Sifirlar += "0";
            }


            Numara = Parametreler.AlisFaturasiBaslangicKarakteri + Sifirlar + (Yeni + 1);

            return Numara;//SF0000000002 gibi olcak mesela
        }


        public string GetYeniAlisIadeFaturasiNumarasi()
        {
            string Numara = AlisIadeFaturasiNumarasi();//FT007 gibi

            int Yeni;
            /*
             FT000001 fatura numarasındaki 000001 li kısmı aldık yani
             */
            Numara = Numara.Substring(Parametreler.GetAlisIadeFaturasiBaslangicKarakteri().Length, Numara.Length - Parametreler.GetAlisIadeFaturasiBaslangicKarakteri().Length);

            Yeni = Convert.ToInt32(Numara);//000001  gibi


            string Sifirlar = "";
            int uz = Parametreler.GetAlisFaturasiUzunlugu();
            int bas_uzunluk = Parametreler.GetAlisIadeFaturasiBaslangicKarakteri().Length;
            int yeni_uzunluk = Yeni.ToString().Length;

            int sayac = uz - bas_uzunluk - yeni_uzunluk;

            for (int i = 0; i < sayac; i++)
            {
                Sifirlar += "0";
            }


            Numara = Parametreler.AlisIadeFaturasiBaslangicKarakteri + Sifirlar + (Yeni + 1);

            return Numara;//SF0000000002 gibi olcak mesela
        }

        string SatisFaturasiNumarasi()
        {
            //functionı parametre olarak tipi gönderiyoruz
            string sql = "select dbo.FN_FATURANUMARASI ('S') as NUMARA";//Satış faturası olduğu için S'yi gönderdik.

            string Numara = Dbase.SatirCek(sql)["NUMARA"].ToString();

            return Numara;
        }


        string SatisIadeFaturasiNumarasi()
        {
            string sql = "select dbo.FN_FATURANUMARASI ('SI') as NUMARA";//SatışıADE faturası olduğu için SI'yi gönderdik.

            string Numara = Dbase.SatirCek(sql)["NUMARA"].ToString();

            return Numara;
        }

        string AlisFaturasiNumarasi()
        {
            string sql = "select dbo.FN_FATURANUMARASI ('A') as NUMARA";//Alış faturası olduğu için A'yi gönderdik.

            string Numara = Dbase.SatirCek(sql)["NUMARA"].ToString();

            return Numara;
        }

        string AlisIadeFaturasiNumarasi()
        {
            string sql = "select dbo.FN_FATURANUMARASI ('AI') as NUMARA";//Alış faturası olduğu için AI'yi gönderdik.

            string Numara = Dbase.SatirCek(sql)["NUMARA"].ToString();

            return Numara;
        }
    }
}
