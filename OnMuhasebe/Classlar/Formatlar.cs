using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.Classlar
{
    public class Formatlar
    {

        /*
         * Bu hatanın sebebi türkçe tarihi veritabanına gönderdiğimiz için.biz ise türkçe tarihi ingilizce tarihe çevirip öyle yollayacağız.Formatlar classında bu işlemi yaptık zaten
         Hata:An unhandled exception of type 'System.Data.SqlClient.SqlException' occurred in System.Data.dll

Additional information: Error converting data type varchar to datetime.
             
             
         */


        //türkçede tarih gün ay yıl şeklindedir.ingilizcede ise ay gun yıl şeklindedir.
        //türkçe gelen tarihi ingilizce tarihe çevirip o şekilde veritabanına göndermek için
        public string IngilizceTarihFormati(string GelenTarih)
        {
            DateTime Tarih = Convert.ToDateTime(GelenTarih);

            string Gun, Ay, Yil, Saat, Dakika, Saniye;
            Gun = Tarih.Day.ToString();
            Ay = Tarih.Month.ToString();
            Yil = Tarih.Year.ToString();

            Saat = Tarih.Hour.ToString();
            Dakika = Tarih.Minute.ToString();
            Saniye = Tarih.Second.ToString();

            string YeniTarih = Ay + "." + Gun + "."  + Yil + " " + Saat + ":" + Dakika + ":"+ Saniye;

            return YeniTarih;
        }


    }
}
