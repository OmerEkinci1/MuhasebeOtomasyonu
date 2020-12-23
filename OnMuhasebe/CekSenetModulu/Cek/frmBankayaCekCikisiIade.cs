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

namespace OnMuhasebe.CekSenetModulu.Cek
{
    public partial class frmBankayaCekCikisiIade : DevExpress.XtraEditors.XtraForm
    {
        public frmBankayaCekCikisiIade()
        {
            InitializeComponent();
        }

        string AcilanCekId = "-1";
        Classlar.Cekler Cekler = new Classlar.Cekler();
        OnMuhasebe.BankaModulu.Classlar.clsBanka Banka = new BankaModulu.Classlar.clsBanka();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        public void CekAc(string Id)
        {
            AcilanCekId = Id;


            DataRow Satir = Cekler.Ac(Id);
            MusteriCeki AcilanCek = new MusteriCeki();
        
          
            txtBanka.Text = Satir["BANKA"].ToString();
            txtCekNo.Text = Satir["CEKNO"].ToString();
            txtSube.Text = Satir["SUBE"].ToString();
            txtTutar.Text = Satir["TUTAR"].ToString();
            txtVadeTarihi.Text = Satir["VADETARIHI"].ToString();
            txtNumara.Text= Satir["VER_BANKA_BELGENO"].ToString();
            txtTarih.Text = Satir["VER_BANKA_TARIH"].ToString();




            string VerilenBanka= Satir["VERILENBANKA"].ToString();


          

            DataRow SatirBanka = Banka.Ac(VerilenBanka);
            txtBankaAdi.Text = SatirBanka["BANKAADI"].ToString();
            txtHesapNo.Text = SatirBanka["HESAPNO"].ToString();

            this.ShowDialog();
        }
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Çekin Durumunu Portföye Çekicez.
            if (Mesajlar.Sor("Çeki bankadan İade Almak İstediğinize emin misiniz?"))
            {
                if (Cekler.CekiBankadanIadeAl(AcilanCekId))
                {
                    this.Close();
                }
                else
                {
                    Mesajlar.Hata();
                }
            }
        }
    }
}