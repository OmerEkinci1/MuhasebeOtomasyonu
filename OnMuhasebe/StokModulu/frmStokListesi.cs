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

namespace OnMuhasebe.StokModulu
{
    public partial class frmStokListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmStokListesi()
        {
            InitializeComponent();
        }
        Classlar.clsStokTanitimKarti Stoklar = new Classlar.clsStokTanitimKarti();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        Classlar.clsStokTanitimKarti Stok = new Classlar.clsStokTanitimKarti();
        string SecilenId = "-1";

        public Boolean SecimIcinAc = false;
        void Listele()
        {
            Liste.DataSource = Stoklar.Listele(txtStokKodu.Text, txtStokAdi.Text, txtKod1.Text, txtKod2.Text, txtKod3.Text, txtKod4.Text, txtKod5.Text);
        }

       

        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKod1.Text = "";
            txtKod2.Text = "";
            txtKod3.Text = "";
            txtKod4.Text = "";
            txtKod5.Text = "";
            txtStokKodu.Text = "";
            txtStokAdi.Text = "";
        }
        void Sec()
        {
            SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (SecimIcinAc == true)
            {
                Sec();
                frmAnaForm.AraDegiskenString = SecilenId;//static değişkene atadık böylece heryerden erişebileceğiz
                this.Dispose();//formu öldür
            }
            else
            {

            }
        
        }

        private void SagEkle_Click(object sender, EventArgs e)
        {
            Ekranlar.StokTanitimKartiAc();
        }

        private void SagGuncelle_Click(object sender, EventArgs e)
        {
            Sec();

            Ekranlar.StokTanitimKartiAc(true, SecilenId);


        }

        private void SagSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sor("Seçilen Kaydı Silmek İstediğinize Emin misiniz?"))
            {
                Sec();
                if (Stok.Sil(SecilenId) == true)
                {
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);//satırı sildik.
                }

                
            }
        }

        private void SagHareketler_Click(object sender, EventArgs e)
        {
            Sec();
            Ekranlar.StokHareketKayitlari(true,SecilenId);
        }
    }
}