using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace OnMuhasebe.StokModulu.Raporlar
{
    public class StokRaporlari
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();

        public DataTable StokHareketRaporu(string StokKodu, string StokAdi, string Kod1, string Kod2, string Kod3, string Kod4, string Kod5)
        {

            //VİEW KULLANDIK
            string sql = "select * from RPSTOKHAREKET WHERE STOKKODU LIKE '%" + StokKodu + "%' AND STOKADI LIKE '%" + StokAdi + "%' AND KOD1 LIKE '%" + Kod1 + "%' AND KOD2 LIKE '%" + Kod2 + "%' AND KOD3 LIKE '%" + Kod4 + "%' AND KOD4 LIKE '%" + Kod4 + "%' AND KOD5 LIKE '%" + Kod5 + "%'";

            return Dbase.TabloCek(sql);


        }

        public DataTable CariStokHareketRaporu(string StokKodu, string StokAdi, string Kod1, string Kod2, string Kod3, string Kod4, string Kod5, string CariKodu, string CariAdi)
        {

            //VİEW KULLANDIK
            string sql = "select * from RPCARISTOKHAREKET WHERE STOKKODU LIKE '%" + StokKodu + "%' AND STOKADI LIKE '%" + StokAdi + "%' AND KOD1 LIKE '%" + Kod1 + "%' AND KOD2 LIKE '%" + Kod2 + "%' AND KOD3 LIKE '%" + Kod4 + "%' AND KOD4 LIKE '%" + Kod4 + "%' AND KOD5 LIKE '%" + Kod5 + "%' and CARIKODU LIKE '%" + CariKodu + "%' AND CARIISIM LIKE '%" + CariAdi + "%'";

            return Dbase.TabloCek(sql);


        }

        public DataTable TarihAraligiStokHareketRaporu(string StokKodu, string StokAdi, string Kod1, string Kod2, string Kod3, string Kod4, string Kod5, string CariKodu, string CariAdi, string Ilk, string Son)
        {

            //VİEW KULLANDIK
            string sql = "select * from RPCARISTOKHAREKET WHERE STOKKODU LIKE '%" + StokKodu + "%' AND STOKADI LIKE '%" + StokAdi + "%' AND KOD1 LIKE '%" + Kod1 + "%' AND KOD2 LIKE '%" + Kod2 + "%' AND KOD3 LIKE '%" + Kod4 + "%' AND KOD4 LIKE '%" + Kod4 + "%' AND KOD5 LIKE '%" + Kod5 + "%' and CARIKODU LIKE '%" + CariKodu + "%' AND CARIISIM LIKE '%" + CariAdi + "%' AND TARIH BETWEEN '" + Ilk + "' AND '" + Son + "'";

            return Dbase.TabloCek(sql);


        }


    }
}
