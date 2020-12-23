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
    public partial class frmKasaTahsilat : DevExpress.XtraEditors.XtraForm
    {
        public frmKasaTahsilat()
        {
            InitializeComponent();
        }
        string SecilenKasaId = "-1";
        string SecilenCariId = "-1";
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        Classlar.clsKasa Kasa = new Classlar.clsKasa();
        OnMuhasebe.CariModulu.Classlar.clsCariTanitimKarti Cari = new CariModulu.Classlar.clsCariTanitimKarti();
        Classlar.clsKasaHareketleri Hareketler = new Classlar.clsKasaHareketleri();

        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        Boolean Edit = false;//güncelleme için
        string AcilanHareketId = "-1";
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            KasaSec();
        }

        void KasaSec()
        {
            SecilenKasaId = Ekranlar.KasaListesi(true);

            DataRow satir = Kasa.Ac(SecilenKasaId);
            txtKasaKodu.Text = satir["KODU"].ToString();
            txtKasaAdi.Text = satir["ADI"].ToString();
        }

        void CariSec()
        {

            SecilenCariId = Ekranlar.CariListesiAc();
            DataRow satir = Cari.Ac(SecilenCariId);//istediğimiz idye göre satırı seçtik


            txtCariKodu.Text = satir["CARIKODU"].ToString();
            txtCariAdi.Text = satir["CARIISIM"].ToString();
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CariSec();
        }

        private void frmKasaTahsilat_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKasaKodu.Text == "")
            {
                Mesajlar.Uyarı("Kasa  Seçmeden Tahsilat Girişi yapamazsınız.");
                txtKasaKodu.Focus();
            }
            else if (txtCariKodu.Text == "")
            {
                Mesajlar.Uyarı("Cari  Seçmeden Tahsilat Girişi yapamazsınız.");
                txtCariKodu.Focus();
            }
            else
            {




                if (Edit == false)//kaydet
                {
                    //belgeno=Fisno
                    //tarihi formatlı şekilde gönderiyoruz
                    //GCKODU =G OLCAK ÇÜNKÜ TAHSİLAT OLDUĞU İÇİN
                    //TİPİ T OLCAK ÇÜNKÜ TAHSİLAT
                    if (Hareketler.TahsilatGirisi(txtKasaKodu.Text, txtBelgeNo.Text, txtMakbuzNo.Text, Formatlar.IngilizceTarihFormati(txtTarih.Text), txtTutar.Text, txtCariKodu.Text, txtAciklama.Text, frmAnaForm.UserId) == true)
                    {
                        Mesajlar.Bilgi("Tahsilat başarılı bir şekilde kaydedilmiştir.");
                        Temizle();
                    }
                    else
                    {
                        Mesajlar.Hata();
                    }
                }
                else//güncelle
                {
                    if (Hareketler.TahsilatGirisiGuncelle(AcilanHareketId, txtKasaKodu.Text, txtBelgeNo.Text, txtMakbuzNo.Text, Formatlar.IngilizceTarihFormati(txtTarih.Text), txtTutar.Text, txtCariKodu.Text, txtAciklama.Text, frmAnaForm.UserId) == true)
                    {
                        Mesajlar.Bilgi("Tahsilat başarılı bir şekilde güncellenmiştir.");
                        this.Close();
                    }
                    else
                    {
                        Mesajlar.Hata();
                    }
                }


            }

        }



        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtMakbuzNo.Text = "";
            txtTarih.Text = "";
            txtTutar.Text = "";
            Edit = false;
            txtBelgeNo.Focus();
        }
        public void Ac(string Id)
        {
            AcilanHareketId = Id;//güncelleme için gerekli
            DataRow Satir = Hareketler.Ac(Id);
            txtKasaKodu.Text = Satir["KODU"].ToString();
            txtKasaAdi.Text = Satir["ADI"].ToString();
            txtCariKodu.Text = Satir["CARIKODU"].ToString();
            txtCariAdi.Text = Satir["CARIISIM"].ToString();
            txtBelgeNo.Text = Satir["FISNO"].ToString();
            txtMakbuzNo.Text = Satir["MAKBUZNO"].ToString();
            txtTarih.EditValue = Satir["TARIH"].ToString();
            txtTutar.Text = Satir["TUTAR"].ToString();
            txtAciklama.Text = Satir["ACIKLAMA"].ToString();
            Edit = true;//güncelleme için
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit == true)
            {
                if (Mesajlar.Sor("Tahsilat Girişini silmek istediğinizden emin misiniz?") == true)
                {
                    if (Hareketler.Sil(AcilanHareketId) == true)
                    {
                        Mesajlar.Bilgi("Tahsilat Başarılı bir şekilde silinmiştir..");
                        this.Close();
                    }
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtKasaKodu.Text != "" || txtCariKodu.Text!="")
            {
                if(Mesajlar.Sor("Geçerli İşlemi iptal etmek istediğinizden emin misiz?"))
                {
                    Temizle();
                }
            }
        }
    }
}