using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.BankaModulu.Classlar
{
    class clsBanka
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        public Boolean Ekle(string HESAPNO, string IBAN, string BANKAADI, string HESAPADI, string SUBE, string TEL, string ILGILI, string ADRES, string SAVEUSER)
        {
            try
            {
                //stored procedür ile ekleme
                //EXECUTE SP_BANKA_EKLE   @HESAPNO  ,@IBAN  ,@BANKAADI  ,@HESAPADI  ,@SUBE  ,@TEL  ,@ILGILI ,@ADRES  ,@SAVEUSER
                string sql = "EXECUTE SP_BANKA_EKLE   '" + HESAPNO + "'  ,'" + IBAN + "'  ,'" + BANKAADI + "'  ,'" + HESAPADI + "'  ,'" + SUBE + "'  ,'" + TEL + "'  ,'" + ILGILI + "' ,'" + ADRES + "'  ," + SAVEUSER;
                Dbase.Isle(sql);
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

        public Boolean Guncelle(string ID, string HESAPNO, string IBAN, string BANKAADI, string HESAPADI, string SUBE, string TEL, string ILGILI, string ADRES, string SAVEUSER)
        {
            try
            {
                //stored procedür ile güncelleme

                string sql = "EXECUTE SP_BANKA_GUNCELLE  " + ID + ", '" + HESAPNO + "'  ,'" + IBAN + "'  ,'" + BANKAADI + "'  ,'" + HESAPADI + "'  ,'" + SUBE + "'  ,'" + TEL + "'  ,'" + ILGILI + "' ,'" + ADRES + "'  ," + SAVEUSER;
                Dbase.Isle(sql);
                return true;
            }
            catch (Exception )
            {

                return false;
            }


        }

        public Boolean Sil(string ID)
        {
            try
            {
                //stored procedür ile silme

                string sql = "EXECUTE SP_BANKA_SIL " + ID;
                Dbase.Isle(sql);
                return true;
            }
            catch (Exception )
            {

                return false;
            }


        }


        public DataTable Listele(string HesapNo, string Iban, string BankaAdi, string HesapAdi, string Sube, string Ilgili)
        {


            string sql = "select * from TBLBANKA WHERE HESAPNO LIKE '%" + HesapNo + "%' AND IBAN LIKE '%" + BankaAdi + "%' AND BANKAADI LIKE '%" + HesapAdi + "%' AND HESAPADI LIKE '%" + HesapAdi + "%' AND SUBE LIKE '%" + Sube + "%' AND ILGILI LIKE '%" + Ilgili + "%' ORDER BY BANKAADI";

            return Dbase.TabloCek(sql);

        }


        public DataRow Ac(string Id)
        {
            string sql = "select top 1 * from TBLBANKA WHERE ID=" + Id;

            return Dbase.SatirCek(sql);
        }
    }
}
