using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace OnMuhasebe.KullaniciModulu
{
    public class clsKullanici
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new Classlar.Veritabani();
        public Boolean Ekle(string Adi, string Soyadi, string Unvani, string Email, string Tel, string KullaniciAdi, string Parola, string Admin, string Aciklama, string UserId)
        {
            string sql = "EXECUTE SP_KULLANICI_EKLE   '" + Adi + "'  ,'" + Soyadi + "'  ,'" + Unvani + "'  ,'" + Email + "'  ,'" + Tel + "'  ,'" + KullaniciAdi + "'  ,'" + Parola + "' ," + Admin + " ,'" + Aciklama + "'  ," + UserId;

            return Dbase.Isle(sql);
        }


        public Boolean Guncelle(string Id, string Adi, string Soyadi, string Unvani, string Email, string Tel, string KullaniciAdi, string Parola, string Admin, string Aciklama, string UserId)
        {
            string sql = "EXECUTE SP_KULLANICI_GUNCELLE   " + Id + ",'" + Adi + "'  ,'" + Soyadi + "'  ,'" + Unvani + "'  ,'" + Email + "'  ,'" + Tel + "'  ,'" + KullaniciAdi + "'  ,'" + Parola + "'  ," + Admin + ",'" + Aciklama + "'  ," + UserId;
            return Dbase.Isle(sql);
        }

        public Boolean Sil(string Id)
        {
            string sql = "EXECUTE SP_KULLANICI_SIL  " + Id;

            return Dbase.Isle(sql);
        }

        public DataTable Listele(string Adi, string Soyadi, string Unvan, string Email)
        {

            string sql = "select * from tblkullanicilar where ADI LIKE '%" + Adi + "%' AND SOYADI LIKE '%" + Soyadi + "%' AND UNVANI LIKE '%" + Unvan + "%' AND EMAIL LIKE '%" + Email + "%' ORDER BY ADI ASC";

            return Dbase.TabloCek(sql);



        }



        public DataRow Ac(string Id)
        {
            string sql = "select top 1 * from tblkullanicilar where  ID=" + Id;

            return Dbase.SatirCek(sql);
        }
    }
}
