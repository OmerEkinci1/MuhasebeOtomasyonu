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
    public partial class frmBankayaSenetCikisiTek : DevExpress.XtraEditors.XtraForm
    {
        public frmBankayaSenetCikisiTek()
        {
            InitializeComponent();
        }
        string AcilanBankaId = "-1";
        Classlar.Cekler Cekler = new Classlar.Cekler();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        OnMuhasebe.BankaModulu.Classlar.clsBanka Banka = new BankaModulu.Classlar.clsBanka();

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
        
        void BankaSec()
        {
            AcilanBankaId = Ekranlar.BankaListesi(true);//dialog şeklinde açıcaz

            DataRow Satir = Banka.Ac(AcilanBankaId);
            txtBankaAdi.Text = Satir["BANKAADI"].ToString();
            txtHesapNo.Text = Satir["HESAPNO"].ToString();
        }

       

        private void frmBankayaCekCikisiTek_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void txtHesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            BankaSec();
        }
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();//tarih formatı için
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtNumara.Text == "")
            {
                Mesajlar.Uyarı("Belge Numarası girmeden işleme devam edemezsiniz?");
                txtNumara.Focus();
            }
            else if (txtBankaAdi.Text == "")
            {
                Mesajlar.Uyarı("Banka seçimi yapmadan  işleme devam edemezsiniz?");
                txtHesapNo.Focus();
            }
            else
            {

                if (Mesajlar.Sor("İşlemi kaydetmek istediğinizden eminmisiniz?"))
                {
                  
                   
                    string BelgeNo = txtNumara.Text;
                    string Tarih = txtTarih.Text;

                    Cekler.CekiBankayaVer(AcilanCekId, AcilanBankaId, Formatlar.IngilizceTarihFormati(Tarih), BelgeNo);//Portföydeki çekleri Bankaya verdik.

                    Mesajlar.Uyarı("Kayıt işlemi başarılı bir şekilde tamamlanmıştır?");
                    this.Close();

                }

            }
        }
    }
}