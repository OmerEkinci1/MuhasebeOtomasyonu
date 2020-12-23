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
    public partial class frmRapCariHareket: DevExpress.XtraEditors.XtraForm
    {
        public frmRapCariHareket()
        {
            InitializeComponent();
        }

        CariRaporlari Rapor = new CariRaporlari();
        OnMuhasebe.Classlar.ExportIslemleri Export = new OnMuhasebe.Classlar.ExportIslemleri();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        void Raporla()
        {
            Liste.DataSource = Rapor.CariHareket(txtCariKodu.Text, txtCariAdi.Text, txtIl.Text, txtIlce.Text, txtVergiDairesi.Text);
        }
        private void frmRapStokHareket_Load(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Raporla();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtIl.Text = "";
            txtIlce.Text = "";
            txtVergiDairesi.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtCariKodu.Focus();
        }

        private void barExcel2003_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Export.Excel2003("Cari_HareketRaporu", Liste);
        }

        private void barExcel2007_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Export.Excel2007("Cari_HareketRaporu", Liste);
        }

        private void barPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Export.AcrobatReader("Cari_HareketRaporu", Liste);
        }

        private void barHtml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Export.Html("Cari_HareketRaporu", Liste);
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
            Export.Excel2003("Cari_HareketRaporu", Liste);
        }

        private void SagExcel2007_Click(object sender, EventArgs e)
        {
            Export.Excel2007("Cari_HareketRaporu", Liste);
        }

        private void SagPdf_Click(object sender, EventArgs e)
        {
            Export.AcrobatReader("Cari_HareketRaporu", Liste);
        }

        private void SagHtml_Click(object sender, EventArgs e)
        {
            Export.Html("Cari_HareketRaporu", Liste);
        }
        string SecilenId = "-1";
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        private void SagHareketler_Click(object sender, EventArgs e)
        {
           ;
            Ekranlar.CariHareketKayitlari(true, Sec());
        }

        string Sec()
        {
            //griddeki seçili idyi aldık
            SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            return SecilenId;
        }
        OnMuhasebe.CariModulu.Classlar.clsCariTanitimKarti Cari = new Classlar.clsCariTanitimKarti();
  
        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string Id  = Ekranlar.CariListesiAc(true);
            DataRow Satir = Cari.Ac(Id);
            txtCariAdi.Text = Satir["CARIISIM"].ToString();
            txtCariKodu.Text = Satir["CARIKODU"].ToString();
        }
    }
}