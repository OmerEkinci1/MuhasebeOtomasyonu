using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace OnMuhasebe.CariModulu.Raporlar
{
    public class CariRaporlari
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();

        public DataTable CariHareket(string CariKodu, string CariAdi, string Il, string Ilce, string VergiDairesi)
        {
            string sql = "select * from RPCARIHAREKET WHERE CARIKODU LIKE '%" + CariKodu + "%' AND CARIISIM LIKE '%" + CariAdi + "%' AND IL LIKE '%" + Il + "%' AND ILCE LIKE '%" + Ilce + "%' AND VERGIDAIRESI LIKE  '%" + VergiDairesi + "%'  ";

            return Dbase.TabloCek(sql);

        }


        public DataTable OzelCariRaporu(string CariKodu, string CariAdi, string Il, string Ilce, string StokKodu, string StokAdi,string Ilk,string Son)
        {
            string sql = "select * from RPCARIOZELRAPOR WHERE CARIKODU LIKE '%" + CariKodu + "%' AND CARIISIM LIKE '%" + CariAdi + "%' AND IL LIKE '%" + Il + "%' AND ILCE LIKE '%" + Ilce + "%' AND STOKKODU LIKE  '%" + StokKodu + "%' and STOKADI LIKE '%" + StokAdi + "%' AND TARIH BETWEEN '" + Ilk + "' AND '" + Son + "'";

            return Dbase.TabloCek(sql);

        }

    }
}
