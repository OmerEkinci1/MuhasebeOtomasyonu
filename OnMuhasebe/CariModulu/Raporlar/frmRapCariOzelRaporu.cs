using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OnMuhasebe.CariModulu.Raporlar
{
    public partial class frmRapCariOzelRaporu:DevExpress.XtraEditors.XtraForm
    {
        public frmRapCariOzelRaporu()
        {
            InitializeComponent();
        }

        CariRaporlari Rapor = new CariRaporlari();
        OnMuhasebe.Classlar.ExportIslemleri Export = new OnMuhasebe.Classlar.ExportIslemleri();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        OnMuhasebe.CariModulu.Classlar.clsCariTanitimKarti Cari = new CariModulu.Classlar.clsCariTanitimKarti();
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        void Raporla()
        {
            Liste.DataSource = Rapor.OzelCariRaporu(txtCariKodu.Text, txtCariAdi.Text, txtIl.Text, txtIlce.Text, txtStokKodu.Text, txtStokAdi.Text, Formatlar.IngilizceTarihFormati(txtIlk.Text), Formatlar.IngilizceTarihFormati(txtSon.Text));
            

            //NOT:Gruplama yapmak için optionsview kısmında ShowGroupPaneli true olarak seçiyoruz vede Grouplamak istediğimiz kolonu panelin üzerine sürüklüyoruz.

            /*
             * Grouppanele Kolonu sürükleyince arka planda Designer.cs dosyasına sanırım aşağıdaki kod ekleniyor.bundan dolayı gruplama işlemi yapılıyor.CARIKODUNA GÖRE GRUPLAMIŞTIK.
                 this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.CARIKODU, DevExpress.Data.ColumnSortOrder.Ascending)});
             
             
             */



            //GRUPLAMA
            gridView1.ExpandAllGroups();//grid dolarken grupların açılır bir şekilde olmasını sağlar.

        }
        private void frmRapStokHareket_Load(object sender, EventArgs e)
        {
            string IlkTarih = "01.01." + DateTime.Now.Year;
            DateTime _IlkTarih = Convert.ToDateTime(IlkTarih);
            txtIlk.EditValue = _IlkTarih.ToShortDateString();

            string SonTarih = "31.12." + DateTime.Now.Year;
            DateTime _SonTarih = Convert.ToDateTime(SonTarih);
            txtSon.EditValue = _SonTarih.ToShortDateString();




        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Raporla();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtStokKodu.Text = "";
            txtStokAdi.Text = "";
        
            txtIlce.Text = "";
            txtStokKodu.Text = "";

            txtCariKodu.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Focus();
        }

        private void barExcel2003_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Export.Excel2003("Stok_CariStokHareketRaporu", Liste);
        }

        private void barExcel2007_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Export.Excel2007("Stok_CariStokHareketRaporu", Liste);
        }

        private void barPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Export.AcrobatReader("Stok_CariStokHareketRaporu", Liste);
        }

        private void barHtml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Export.Html("Stok_CariStokHareketRaporu", Liste);
        }

        private void barCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();//frmRapStokHareket_FormClosing metoduna düşer.
        }

        private void barRaporla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Raporla();
        }

        private void frmRapStokHareket_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Mesajlar.Sor("Raporu kapatmak istediğinizden emin  misiniz?") == false)
            {
                e.Cancel = true;//işlemi iptal eder.
            }
        }

        private void SagExcel2003_Click(object sender, EventArgs e)
        {
            Export.Excel2003("CariOzel_HareketRaporu", Liste);
        }

        private void SagExcel2007_Click(object sender, EventArgs e)
        {
            Export.Excel2007("CariOzel_HareketRaporu", Liste);
        }

        private void SagPdf_Click(object sender, EventArgs e)
        {
            Export.AcrobatReader("CariOzel_HareketRaporu", Liste);
        }

        private void SagHtml_Click(object sender, EventArgs e)
        {
            Export.Html("CariOzel_HareketRaporu", Liste);
        }
        string SecilenId = "-1";
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        private void SagHareketler_Click(object sender, EventArgs e)
        {
            Sec();
            Ekranlar.StokHareketKayitlari(true, SecilenId);
        }

        void Sec()
        {
            //griddeki seçili idyi aldık
            SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
        }
        OnMuhasebe.StokModulu.Classlar.clsStokTanitimKarti Stok = new StokModulu.Classlar.clsStokTanitimKarti();
        private void txtStokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string Id = Ekranlar.StokListesi(true);


            DataRow Satir = Stok.Ac(Id);
            txtStokKodu.Text = Satir["STOKKODU"].ToString();
            txtIlce.Text = Satir["STOKADI"].ToString();
        }

      

       

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string Id = Ekranlar.CariListesiAc(true);
            DataRow Satir = Cari.Ac(Id);
            txtCariAdi.Text = Satir["CARIISIM"].ToString();
            txtCariKodu.Text = Satir["CARIKODU"].ToString();
        }
    }
}