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

namespace OnMuhasebe.CekSenetModulu.Senet
{
    public partial class frmCariyeSenetCikisiTek : DevExpress.XtraEditors.XtraForm
    {
        public frmCariyeSenetCikisiTek()
        {
            InitializeComponent();
        }
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        string CariId = "-1";
        OnMuhasebe.CariModulu.Classlar.clsCariTanitimKarti Cari = new CariModulu.Classlar.clsCariTanitimKarti();

        Classlar.Cekler Cekler = new Classlar.Cekler();
        string AcilanCariId = "-1";
        private void txtCarikodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CariSec(false);
        }
        
        void CariSec(Boolean Ac = false)
        {

            if (Ac == false)
            {
                AcilanCariId = Ekranlar.CariListesiAc();
            }

            DataRow satir = Cari.Ac(AcilanCariId);//istediğimiz idye göre satırı seçtik
            txtCarikodu.Text = satir["CARIKODU"].ToString();
            txtCariAdi.Text = satir["CARIISIM"].ToString();



        }
        string AcilanCekId = "-1";
        public void CekAc(string Id)
        {
            AcilanCekId = Id;


            DataRow Satir = Cekler.Ac(Id);
            MusteriCeki AcilanCek = new MusteriCeki();
            string CariKodu, CariAdi;
            CariKodu = Satir["ALINANCARI"].ToString();
            CariAdi = Satir["ALINANCARIISIM"].ToString();
            txtBanka.Text = Satir["BANKA"].ToString();
            txtCekNo.Text = Satir["CEKNO"].ToString();
            txtSube.Text = Satir["SUBE"].ToString();
            txtTutar.Text = Satir["TUTAR"].ToString();
            txtVadeTarihi.Text = Satir["VADETARIHI"].ToString();







            this.ShowDialog();
        }
        private void frmCariyeCekCikisiTek_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void CariyeCekCikisiTek_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (txtNumara.Text == "")
            {
                Mesajlar.Uyarı("Belge Numarası girmeden işleme devam edemezsiniz?");
                txtNumara.Focus();
            }
            else if (txtCarikodu.Text == "")
            {
                Mesajlar.Uyarı("Cari seçimi yapmadan  işleme devam edemezsiniz?");
                txtCarikodu.Focus();
            }
            else
            {

                if (Mesajlar.Sor("İşlemi kaydetmek istediğinizden eminmisiniz?"))
                {


                    string BelgeNo = txtNumara.Text;
                    string Tarih = txtTarih.Text;

                  

                    Cekler.CekiCariyeVer(AcilanCekId, txtCarikodu.Text, Formatlar.IngilizceTarihFormati(Tarih), BelgeNo);//Portföydeki çekleri Bankaya verdik.

                    Mesajlar.Uyarı("Kayıt işlemi başarılı bir şekilde tamamlanmıştır?");
                    this.Close();

                }

            }
        }
    }
}