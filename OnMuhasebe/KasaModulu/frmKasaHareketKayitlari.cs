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
    public partial class frmKasaHareketKayitlari : DevExpress.XtraEditors.XtraForm
    {
        public frmKasaHareketKayitlari()
        {
            InitializeComponent();
        }
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        string SecilenKasaId = "-1";
        Classlar.clsKasa Kasa = new Classlar.clsKasa();
        Classlar.clsKasaHareketleri Hareketler = new Classlar.clsKasaHareketleri();
        private void frmKasaHareketKayitlari_Load(object sender, EventArgs e)
        {

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            SecilenKasaId = Ekranlar.KasaListesi(true);
            Ac(SecilenKasaId);
        }

        public void Ac(string Id)
        {
            SecilenKasaId = Id;
            DataRow satir = Kasa.Ac(SecilenKasaId);
            txtKasaKodu.Text = satir["KODU"].ToString();
            txtAdi.Text = satir["ADI"].ToString();

            Liste.DataSource = Hareketler.Listele(Id);

            GetKasaBakiye(txtKasaKodu.Text);
        }


        void GetKasaBakiye(string KasaKodu)
        {
            DataRow Bakiye = Kasa.KasaBakiye(KasaKodu).Rows[0];
            txtGiris.Text = Bakiye["GIRIS"].ToString();
            txtCikis.Text = Bakiye["CIKIS"].ToString();
            txtBakiye.Text = Bakiye["BAKIYE"].ToString();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            string Tipi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TIPI").ToString();
            string GcKodu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GCKODU").ToString();
            string SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HAREKETID").ToString();
            if (Tipi == "A")//açılış kartı ise güncelleme yapılacak diğer durumlarda hareketi güncellemiyoruz
            {
                Ekranlar.KasaAcilisKarti(true, SecilenId);
                Ac(SecilenKasaId);
            }
            if (Tipi == "T")//TAHSİLAT ise güncelleme yapılacak diğer durumlarda hareketi güncellemiyoruz
            {
                if (GcKodu=="G")//GİRİŞ İSE 
                {
                    Ekranlar.KasaTahsilatGirisi(true, SecilenId);
                   
                }
                else//C:ÇIKIŞ İSE
                {
                    Ekranlar.KasaOdemeGirisi(true, SecilenId);
                   
                }
                Ac(SecilenKasaId);
            }
        }
    }
}