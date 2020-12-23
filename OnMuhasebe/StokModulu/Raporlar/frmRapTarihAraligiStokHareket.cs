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

namespace OnMuhasebe.StokModulu.Raporlar
{
    public partial class frmRapTarihAraligiStokHareket: DevExpress.XtraEditors.XtraForm
    {
        public frmRapTarihAraligiStokHareket()
        {
            InitializeComponent();
        }

        StokRaporlari Rapor = new StokRaporlari();
        OnMuhasebe.Classlar.ExportIslemleri Export = new OnMuhasebe.Classlar.ExportIslemleri();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        OnMuhasebe.CariModulu.Classlar.clsCariTanitimKarti Cari = new CariModulu.Classlar.clsCariTanitimKarti();
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        void Raporla()
        {
            Liste.DataSource = Rapor.TarihAraligiStokHareketRaporu(txtStokKodu.Text, txtStokAdi.Text, txtKod1.Text, txtKod2.Text, txtKod3.Text, txtKod4.Text, txtKod5.Text, txtCariKodu.Text, txtCariAdi.Text,Formatlar.IngilizceTarihFormati(txtIlk.Text),Formatlar.IngilizceTarihFormati(txtSon.Text));
            

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
            txtKod1.Text = "";
            txtKod2.Text = "";
            txtKod3.Text = "";
            txtKod4.Text = "";
            txtKod5.Text = "";
            txtStokAdi.Text = "";
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
            Export.Excel2003("Stok_HareketRaporu", Liste);
        }

        private void SagExcel2007_Click(object sender, EventArgs e)
        {
            Export.Excel2007("Stok_HareketRaporu", Liste);
        }

        private void SagPdf_Click(object sender, EventArgs e)
        {
            Export.AcrobatReader("Stok_HareketRaporu", Liste);
        }

        private void SagHtml_Click(object sender, EventArgs e)
        {
            Export.Html("Stok_HareketRaporu", Liste);
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
        Classlar.clsStokTanitimKarti Stok = new Classlar.clsStokTanitimKarti();
        private void txtStokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string Id = Ekranlar.StokListesi(true);


            DataRow Satir = Stok.Ac(Id);
            txtStokKodu.Text = Satir["STOKKODU"].ToString();
            txtStokAdi.Text = Satir["STOKADI"].ToString();
        }

        private void txtKod1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Classlar.clsStokKod1 Kod1 = new Classlar.clsStokKod1();
            string Id = Ekranlar.StokKod1Ac(true);
            DataRow Satir = Kod1.Ac(Id);
            txtKod1.Text = Satir["KOD"].ToString();
        }

        private void txtKod2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Classlar.clsStokKod2 Kod2 = new Classlar.clsStokKod2();
            string Id = Ekranlar.StokKod2Ac(true);
            DataRow Satir = Kod2.Ac(Id);
            txtKod2.Text = Satir["KOD"].ToString();
        }

        private void txtKod3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Classlar.clsStokKod3 Kod3 = new Classlar.clsStokKod3();
            string Id = Ekranlar.StokKod3Ac(true);
            DataRow Satir = Kod3.Ac(Id);
            txtKod3.Text = Satir["KOD"].ToString();
        }

        private void txtKod4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Classlar.clsStokKod4 Kod4 = new Classlar.clsStokKod4();
            string Id = Ekranlar.StokKod4Ac(true);
            DataRow Satir = Kod4.Ac(Id);
            txtKod4.Text = Satir["KOD"].ToString();
        }

        private void txtKod5_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Classlar.clsStokKod5 Kod5 = new Classlar.clsStokKod5();
            string Id = Ekranlar.StokKod5Ac(true);
            DataRow Satir = Kod5.Ac(Id);
            txtKod5.Text = Satir["KOD"].ToString();
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