using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.CariModulu.Classlar
{
    class clsCariTanitimKarti
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();

        //Arama İşlemi
        public DataTable Listele(string CariKodui,string CariAdi,string Il,string Ilce,string Tc,string Tipi)
        {
            //arama işlemini like ile yaptık.
            string sql = "select * from TBLCARILER where CARIKODU LIKE '%"+CariKodui+"%' AND CARIISIM LIKE'%"+CariAdi+"%' AND IL LIKE '%"+Il+"%' AND ILCE LIKE '%"+Ilce+"%' AND TC LIKE '%"+Tc+"%' AND TIPI LIKE '%"+Tipi+"%' ";
            DataTable tablo = Dbase.TabloCek(sql);
            return tablo;
        }

        public void Ekle(string CariKodu,string CariAdi,string Adres,string Il,string Ilce,string Ulke,string Telefon,string Fax,string VergiDairesi,string VergiNumarasi,string Tc,string PostaKodu,string Email,string Web,string Tipi,string UserId)
        {
            //procedure ü çalıştırdıl
            string sql = "EXECUTE SP_CARI_EKLE '"+CariKodu+"' ,'"+CariAdi+"' ,'"+Adres+"','"+Il+"','"+Ilce+"','"+Ulke+"','"+Telefon+"','"+Fax+"','"+Email+"','"+Web+"','"+Tc+"','"+PostaKodu+"','"+VergiDairesi+"','"+VergiNumarasi+"','"+Tipi+"',"+UserId+"";
            Dbase.Isle(sql);
        }

        public void Guncelle(string Id,string CariKodu, string CariAdi, string Adres, string Il, string Ilce, string Ulke, string Telefon, string Fax, string VergiDairesi, string VergiNumarasi, string Tc, string PostaKodu, string Email, string Web, string Tipi, string UserId)
        {
            //procedure ü çalıştırdık
            string sql = "EXECUTE SP_CARI_GUNCELLE "+Id+", '" + CariKodu + "' ,'" + CariAdi + "' ,'" + Adres + "','" + Il + "','" + Ilce + "','" + Ulke + "','" + Telefon + "','" + Fax + "','" + Email + "','" + Web + "','" + Tc + "','" + PostaKodu + "','" + VergiDairesi + "','" + VergiNumarasi + "','" + Tipi + "'," + UserId + "";
            Dbase.Isle(sql);
        }
        public DataRow Ac(string Id)
        {
            string sql = "select top 1 * from TBLCARILER WHERE ID=" + Id;//sadece bir kayıt döner.
            return Dbase.SatirCek(sql);

        }
        public void Sil(string Id)
        {
            //procedure ü çalıştırdıl
            string sql = "execute SP_CARI_SIL " + Id;
            Dbase.Isle(sql);
        }


        public string CariIdAl(string CariKodu)
        {
            string sql = "select top 1 * from TBLCARILER WHERE CARIKODU='"+CariKodu+"'";//sadece bir kayıt döner.
            return Dbase.SatirCek(sql)["ID"].ToString() ;
        }
    }
}
