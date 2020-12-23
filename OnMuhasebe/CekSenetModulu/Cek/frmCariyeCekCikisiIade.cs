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
    public partial class frmCariyeCekCikisiIade : DevExpress.XtraEditors.XtraForm
    {
        public frmCariyeCekCikisiIade()
        {
            InitializeComponent();
        }
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //DURUMU PORTFÖYE ÇEKMİŞ OLUCAZ.


            //Çekin Durumunu Portföye Çekicez.
            if (Mesajlar.Sor("Çeki Cariden İade Almak İstediğinize emin misiniz?"))
            {
                if (Cekler.CekiCaridenIadeAl(AcilanCekId))
                {
                    this.Close();
                }
                else
                {
                    Mesajlar.Hata();
                }
            }




        }

        string AcilanCekId = "-1";
        OnMuhasebe.CariModulu.Classlar.clsCariTanitimKarti Cari = new CariModulu.Classlar.clsCariTanitimKarti();

        OnMuhasebe.CekSenetModulu.Cek.Classlar.Cekler Cekler = new Cek.Classlar.Cekler();
        string AcilanCariId = "-1";
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
            txtNumara.Text = Satir["VER_CARI_BELGENO"].ToString();
            txtTarih.Text = Satir["VER_CARI_TARIH"].ToString();




            string VerilenCari = Satir["VERILENCARI"].ToString();




            DataRow satir = Cari.Ac(Cari.CariIdAl(VerilenCari));//istediğimiz idye göre satırı seçtik
            txtCarikodu.Text = satir["CARIKODU"].ToString();
            txtCariAdi.Text = satir["CARIISIM"].ToString();

            this.ShowDialog();
        }
    }
}