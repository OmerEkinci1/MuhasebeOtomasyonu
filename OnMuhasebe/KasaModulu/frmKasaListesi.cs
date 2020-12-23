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

namespace OnMuhasebe.KasaModulu
{
    public partial class frmKasaListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmKasaListesi()
        {
            InitializeComponent();
        }
        Classlar.clsKasa Kasa = new Classlar.clsKasa();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        string SecilenId = "-1";

        public Boolean SecimIcinAc = false;
        private void frmKasaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }


        void Listele()
        {
            Liste.DataSource = Kasa.Listele(txtKasaKodu.Text, txtAdi.Text, txtAciklama.Text);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }


        void Temizle()
        {
            txtAciklama.Text = "";
            txtAdi.Text = "";
            txtKasaKodu.Text = "";
            txtKasaKodu.Focus();
        }

        void Sec()
        {
            try
            {
                SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            }
            catch (Exception ex)
            {

                SecilenId = "-1";
            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (SecimIcinAc==true)
            {
                OnMuhasebe.frmAnaForm.AraDegiskenString = SecilenId;//formlar arası veri aktardık
                this.Close();
            }
        }

        private void SagEkle_Click(object sender, EventArgs e)
        {
            Ekranlar.KasaTanitimKarti();
        }

        private void SagSil_Click(object sender, EventArgs e)
        {
            
            if (Mesajlar.Sor("Secilen Kasayı Silmek İstediğinizden Emin misiniz? ") == true)
            {
                Sec();
                if (Kasa.Sil(SecilenId) == true)
                {
                    Listele();
                 //   gridView1.DeleteRow(Convert.ToInt32(SecilenId));//seçili satırı sildik.
                }
            }
        }

        private void SagGuncelle_Click(object sender, EventArgs e)
        {
            Sec();//SecilenId yi oluşturmak için
            Ekranlar.KasaTanitimKarti(true, SecilenId);
        }

        private void SagHareketler_Click(object sender, EventArgs e)
        {
            Sec();
            Ekranlar.KasaHareketleri(true, SecilenId);
        }
    }
}