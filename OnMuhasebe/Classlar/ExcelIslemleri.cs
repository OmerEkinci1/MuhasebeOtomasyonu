using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ekledik
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;//excel işlemleri için

namespace OnMuhasebe.Classlar
{
    public class ExcelIslemleri
    {
        public DataTable Veriler(string Yol)//dosya yoludur
        {

            //sql bağlantı kodları gibi yazımı var
            //excel için baglanti stringi
             //string BaglantiStringi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Yol+";Extended Properties='Excel 8.0;';" ;
             



            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Yol+"; Extended Properties='Excel 12.0 Xml;HDR=YES'");
           // OleDbConnection baglanti = new OleDbConnection(BaglantiStringi);
            baglanti.Open();

            //   OleDbDataAdapter Adapter = new OleDbDataAdapter("select * from [Sayfa1$A:Z]",baglanti);
            OleDbDataAdapter Adapter = new OleDbDataAdapter(" SELECT* FROM[YeniSayfa$]", baglanti);


           
            DataTable Veriler = new DataTable();
            Adapter.Fill(Veriler);

            return Veriler;




        

        }



    }
}
