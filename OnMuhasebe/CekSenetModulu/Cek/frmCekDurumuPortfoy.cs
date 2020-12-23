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
    public partial class frmCekDurumuPortfoy : DevExpress.XtraEditors.XtraForm
    {
        public frmCekDurumuPortfoy()
        {
            InitializeComponent();
        }
        Classlar.Cekler Cekler = new Classlar.Cekler();
        string AcilanCekId = "-1";
        string CariKodu = "-1";
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
            txtNumara.Text = Satir["BELGENO"].ToString();
            txtTarih.Text = Satir["TARIH"].ToString();
            txtAsilBorclu.Text = Satir["ASILBORCLU"].ToString();

            CariKodu = Satir["ALINANCARI"].ToString();//hangi cariden tahsil ettiğimiz falan
            string CekDurumu = Satir["DURUMU"].ToString().Trim();


            if (CekDurumu == "B")//BEKLİYOR İSE 
            {
                comDurumu.SelectedIndex = 0;
            }
            else if (CekDurumu == "T")//TAHSİL EDİLMİŞ İSE 
            {
                comDurumu.SelectedIndex = 1;
                string KasaKodu = Cekler.CekTahsilatiYapilanKasa(AcilanCekId);
                string KasaId = "-1";
                if (KasaKodu != "")
                {
                    KasaId = Kasa.IdAl_Koduile(KasaKodu);
                    KasaAc(KasaId);
                    txtKasaAdi.Enabled = false;
                    txtKasaKodu.Enabled = false;
                    btnKaydet.Enabled = false;
                }

            }
            else//KARŞILIKSIZ İSE 
            {
                comDurumu.SelectedIndex = 2;
            }
            this.ShowDialog();
        }
        string SecilenKasaId = "-1";
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        OnMuhasebe.KasaModulu.Classlar.clsKasa Kasa = new KasaModulu.Classlar.clsKasa();

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SecilenKasaId = Ekranlar.KasaListesi(true);

            DataRow satir = Kasa.Ac(SecilenKasaId);
            txtKasaKodu.Text = satir["KODU"].ToString();
            txtKasaAdi.Text = satir["ADI"].ToString();
        }


        void KasaAc(string Id)
        {
            DataRow satir = Kasa.Ac(Id);
            txtKasaKodu.Text = satir["KODU"].ToString();
            txtKasaAdi.Text = satir["ADI"].ToString();
        }
        private void comDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comDurumu.SelectedIndex == 1)//TAHSIL EDILDI İSE 
            {
                panelKasaSecim.Visible = true;
            }
            else
            {
                panelKasaSecim.Visible = false;

            }
        }
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        OnMuhasebe.KasaModulu.Classlar.clsKasaHareketleri KasaHareketleri = new KasaModulu.Classlar.clsKasaHareketleri();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string CekDurumu = "B";
            if (comDurumu.SelectedIndex == 1)
            {
                CekDurumu = "T";//TAHSİL EDİLDİ
            }
            else if (comDurumu.SelectedIndex == 2)
            {
                CekDurumu = "K";//KARŞILIKSIZ
            }
            if (Mesajlar.Sor("İşlemi kaydetmek istediğinizden eminmisiniz?"))
            {
                if (Cekler.CekDurumu(AcilanCekId, CekDurumu))//çekin durumunu tahsil yapıyoruz.
                {

                    if (CekDurumu == "T")//EĞER TAHSİLAT İSE KASAHAREKETİ İŞLİCEZ
                    {
                        //Fisno=Belgeno,
                        //Makbuz No boş olcak
                        //eVRAKTURU=CEK OLCAK
                        //EVRAKID İSE aCİLANCEKID OLCAK
                        KasaHareketleri.CekTahsilatGirisi(txtKasaKodu.Text, txtNumara.Text, "", Formatlar.IngilizceTarihFormati(DateTime.Now.ToShortDateString()), txtTutar.Text, CariKodu, "" + txtCekNo.Text + "- NUMARALI ÇEK TAHSİL EDİLDİ(Vade=" + txtVadeTarihi.Text + ")", frmAnaForm.UserId, "CEK", AcilanCekId);
                    }




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