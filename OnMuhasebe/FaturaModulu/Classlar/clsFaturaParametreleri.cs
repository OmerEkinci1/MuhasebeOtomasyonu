using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.FaturaModulu.Classlar
{

    class clsFaturaParametreleri
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();

        public string SatisFaturasiBaslangicKarakteri, SatisFaturasiUzunlugu;
        public string SatisIadeFaturasiBaslangicKarakteri, SatisIadeFaturasiUzunlugu;
        public string AlisFaturasiBaslangicKarakteri, AlisFaturasiUzunlugu;
        public string AlisIadeFaturasiBaslangicKarakteri, AlisIadeFaturasiUzunlugu;



        public clsFaturaParametreleri()
        {
            string sql = "select * from TBLFATPARAMETRE ORDER BY ID DESC";

            DataRow Par = Dbase.SatirCek(sql);//veritabanındaki son satırı getircek.


            SatisFaturasiBaslangicKarakteri = Par["SF_BAS_KAR"].ToString();
            SatisFaturasiUzunlugu = Par["SF_UZN"].ToString();
            SatisIadeFaturasiBaslangicKarakteri = Par["SI_BAS_KAR"].ToString();
            SatisIadeFaturasiUzunlugu = Par["SI_UZN"].ToString();

            AlisFaturasiBaslangicKarakteri = Par["AF_BAS_KAR"].ToString();
            AlisFaturasiUzunlugu = Par["AF_UZN"].ToString();
            AlisIadeFaturasiBaslangicKarakteri = Par["AI_BAS_KAR"].ToString();
            AlisIadeFaturasiUzunlugu = Par["AI_UZN"].ToString();
        }

        public string GetSatisFaturasiBaslangicKarakteri()
        {
            return SatisFaturasiBaslangicKarakteri;
        }

        public int GetSatisFaturasiUzunlugu()
        {

            return Convert.ToInt32(SatisFaturasiUzunlugu);


        }

        public string GetSatisIadeFaturasiBaslangicKarakteri()
        {
            return SatisIadeFaturasiBaslangicKarakteri;
        }

        public int GetSatisIadeFaturasiUzunlugu()
        {
            return Convert.ToInt32(SatisIadeFaturasiUzunlugu);
        }

        public string GetAlisFaturasiBaslangicKarakteri()
        {
            return AlisFaturasiBaslangicKarakteri;
        }
        public int GetAlisFaturasiUzunlugu()
        {
            return Convert.ToInt32(AlisFaturasiUzunlugu);
        }

        public string GetAlisIadeFaturasiBaslangicKarakteri()
        {
            return AlisIadeFaturasiBaslangicKarakteri;
        }
        public int GetAlisIadeFaturasiUzunlugu()
        {
            return Convert.ToInt32(AlisIadeFaturasiUzunlugu);
        }
    }
}
