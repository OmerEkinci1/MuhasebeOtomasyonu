using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.StokModulu.Classlar
{
    class clsStokTanitimKarti
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        public void Ekle(string stokKodu, string StokAdi, string IngIsim, string Kod1, string Kod2, string Kod3, string Kod4, string Kod5, string Birim, string Barkod, string AlisKdv, string SatisKdv, string AlisFiyat1, string AlisFiyat2, string SatisFiyat1, string SatisFiyat2, string UserId)
        {
            //Not:Sqlde , yerine . yapmalıyız AlisKdv.Replace(",",".").ToString() gibi.Çünkü decimal değerlerde , gelebilir bu yüzden . yaptık
            // Not:Decimal tiplerde '' yapmıyoruz.sildik bu yüzden tırnakları
            string sql = "EXECUTE SP_STOKEKLE '" + stokKodu + "','" + StokAdi + "','" + IngIsim + "','" + Kod1 + "','" + Kod2 + "','" + Kod3 + "','" + Kod4 + "','" + Kod5 + "','" + Birim + "','" + Barkod + "'," + AlisKdv.Replace(",", ".").ToString() + "," + SatisKdv.Replace(",", ".").ToString() + "," + AlisFiyat1.Replace(",", ".").ToString() + "," + AlisFiyat2.Replace(",", ".").ToString() + "," + SatisFiyat1.Replace(",", ".").ToString() + "," + SatisFiyat2.Replace(",", ".").ToString() + "," + UserId + "";
            Dbase.Isle(sql);//sorguyu çalıştırdık //procedürü çalıştırdık
        }

        public Boolean Guncelle(string Id, string stokKodu, string StokAdi, string IngIsim, string Kod1, string Kod2, string Kod3, string Kod4, string Kod5, string Birim, string Barkod, string AlisKdv, string SatisKdv, string AlisFiyat1, string AlisFiyat2, string SatisFiyat1, string SatisFiyat2, string UserId)
        {
            //YETKİSİ YOKSA
            if (frmAnaForm.KullaniciYetkileri.STOKGUNCELLE == false)
            {
                Mesajlar.Uyarı("Bu işlemi yapmaya yetkiniz yok.");
                return false;
            }


            //Not:Sqlde , yerine . yapmalıyız AlisKdv.Replace(",",".").ToString() gibi.Çünkü decimal değerlerde , gelebilir bu yüzden . yaptık
            // Not:Decimal tiplerde '' yapmıyoruz.sildik bu yüzden tırnakları
            string sql = "EXECUTE SP_STOKGUNCELLE " + Id + ",'" + stokKodu + "','" + StokAdi + "','" + IngIsim + "','" + Kod1 + "','" + Kod2 + "','" + Kod3 + "','" + Kod4 + "','" + Kod5 + "','" + Birim + "','" + Barkod + "'," + AlisKdv.Replace(",", ".").ToString() + "," + SatisKdv.Replace(",", ".").ToString() + "," + AlisFiyat1.Replace(",", ".").ToString() + "," + AlisFiyat2.Replace(",", ".").ToString() + "," + SatisFiyat1.Replace(",", ".").ToString() + "," + SatisFiyat2.Replace(",", ".").ToString() + "," + UserId + "";
            Dbase.Isle(sql);//sorguyu çalıştırdık //procedürü çalıştırdık
            return true;
        }
        public DataTable Listele(string StokKodu, string StokAdi, string Kod1, string Kod2, string Kod3, string Kod4, string Kod5)
        {
            //view'imizden sorguyu çektik.
            string sql = "select * from VWSTOKLAR where STOKKODU LIKE '%" + StokKodu + "%' AND STOKADI LIKE '%" + StokAdi + "%' AND KOD1 LIKE '%" + Kod1 + "%' AND KOD2 LIKE '%" + Kod2 + "%' AND KOD3 LIKE '%" + Kod3 + "%' AND KOD4 LIKE '%" + Kod4 + "%' AND KOD5 LIKE '%" + Kod5 + "%'";
            DataTable dt = Dbase.TabloCek(sql);
            return dt;
        }

        public DataRow Ac(string Id)
        {
            //view'i kullanıyoruz
            string sql = "select * from VWSTOKLAR where ID=" + Id;
            return Dbase.SatirCek(sql);

        }

        public bool Sil(string Id)
        {

            //YETKİSİ YOKSA
            if (frmAnaForm.KullaniciYetkileri.STOKSIL == false)
            {
                Mesajlar.Uyarı("Bu işlemi yapmaya yetkiniz yok.");
                return false;
            }


            //Bu kontrolleri yapmamızın amacı foreign key hatasının önüne geçmektir.Çünkü hareketi olan bir stoğu silmeye kalktığımızda başka tablolarla ilişkisi olduğundan foreign key hatası verir.

            if (StokHareketiVarMi(Id) == true)//stok hareketi varsa
            {
                Mesajlar.Uyarı("Hareket görmüş Stok Kartını Silemezsiniz .");
                return false;
            }
            else
            {
                //stok hareketi yoksa silebiliriz stoğu
                string sql = "execute SP_STOKSIL " + Id;
                Dbase.Isle(sql);
                return true;
            }



        }


        string StokKoduAl(string Id)
        {
            string sql = "select STOKKODU from TBLSTOKLAR WHERE ID=" + Id;
            return Dbase.SatirCek(sql)["STOKKODU"].ToString();
        }

        public Boolean StokHareketiVarMi(string Id)
        {
            string StokKodu = StokKoduAl(Id);
            string sql = "  SELECT COUNT(*) AS ADET FROM  dbo.TBLSTOKHAR WHERE STOKKODU = '" + StokKodu + "'";

            int Adet = Convert.ToInt32(Dbase.SatirCek(sql)["ADET"].ToString());

            if (Adet > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
