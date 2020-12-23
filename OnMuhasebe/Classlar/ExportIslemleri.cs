using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars;
using System.Windows.Forms;
using DevExpress.XtraGrid;

using System.Diagnostics;
namespace OnMuhasebe.Classlar
{
    public class ExportIslemleri
    {
        SaveFileDialog Save = new SaveFileDialog();
        Mesajlar Mesajlar = new Mesajlar();

        public void Excel2003(string RaporAdi,GridControl Liste)
        {
            Save.Filter = "Excel 2003 | *.xls";
            Save.FileName = RaporAdi + "_" + DateTime.Now.ToShortDateString();
            if (Save.ShowDialog()==DialogResult.OK)
            {
                Liste.ExportToXls(Save.FileName);

                if (Mesajlar.Sor("Dosyayı açmak ister miniz?"))
                {
                    Process.Start(Save.FileName);//ilgili dosyayı açar.

                }
            }
        }


        public void Excel2007(string RaporAdi, GridControl Liste)
        {
            Save.Filter = "Excel 2007 | *.xlsx";
            Save.FileName = RaporAdi + "_" + DateTime.Now.ToShortDateString();
            if (Save.ShowDialog() == DialogResult.OK)
            {
                Liste.ExportToXlsx(Save.FileName);

                if (Mesajlar.Sor("Dosyayı açmak ister miniz?"))
                {
                    Process.Start(Save.FileName);//ilgili dosyayı açar.

                }
            }
        }

        public void AcrobatReader(string RaporAdi, GridControl Liste)
        {
            Save.Filter = "Acrobat Reader | *.pdf";
            Save.FileName = RaporAdi + "_" + DateTime.Now.ToShortDateString();
            if (Save.ShowDialog() == DialogResult.OK)
            {
                Liste.ExportToPdf(Save.FileName);

                if (Mesajlar.Sor("Dosyayı açmak ister miniz?"))
                {
                    Process.Start(Save.FileName);//ilgili dosyayı açar.

                }
            }
        }

        public void Html(string RaporAdi, GridControl Liste)
        {
            Save.Filter = "Html| *.html";
            Save.FileName = RaporAdi + "_" + DateTime.Now.ToShortDateString();
            if (Save.ShowDialog() == DialogResult.OK)
            {
                Liste.ExportToHtml(Save.FileName);

                if (Mesajlar.Sor("Dosyayı açmak ister miniz?"))
                {
                    Process.Start(Save.FileName);//ilgili dosyayı açar.

                }
            }
        }

    }
}
