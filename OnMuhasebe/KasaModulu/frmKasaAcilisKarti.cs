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
    public partial class frmKasaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmKasaAcilisKarti()
        {
            InitializeComponent();
        }
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        Classlar.clsKasa Kasa = new Classlar.clsKasa();
        Classlar.clsKasaHareketleri Hareketler = new Classlar.clsKasaHareketleri();
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        string SecilenKasaId = "-1";
        string AcilanHareketId = "-1";
        public Boolean Edit = false;
        private void btnKasaSec_Click(object sender, EventArgs e)
        {
            SecilenKasaId = Ekranlar.KasaListesi(true);

            DataRow satir = Kasa.Ac(SecilenKasaId);
            txtKasaKodu.Text = satir["KODU"].ToString();
            txtKasaAdi.Text = satir["ADI"].ToString();



        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKasaKodu.Text=="")
            {
                Mesajlar.Uyarı("Kasa Seçmeden işleme devam edemezsiniz.");
                return;//direk metotdan çık
            }

            string GcKodu = "G";
            if (raCikis.Checked == true)
            {
                GcKodu = "C";//çıkış
            }
            else
            {
                GcKodu = "G";//giriş
            }

            if (Edit == true)//güncelleme
            {
                if (Hareketler.KasaAcilisKartiGuncelle(AcilanHareketId, txtKasaKodu.Text, txtBelgeNo.Text, Formatlar.IngilizceTarihFormati(txtTarih.Text), GcKodu, "A", txtTutar.Text, "", frmAnaForm.UserId))
                {
                    Mesajlar.Bilgi("Kasa Açılış kartı başarılı bir şekilde güncellenmiştir.");
                    this.Close();
                }
                else
                {
                    Mesajlar.Hata();
                }
            }
            else//kaydetme
            {
                //fisno=belgeno
                //tipi alanına Açılış kartı olduğu için A'yı gönderdik.
                //Cari kodu alanını boş bıraktık çünkü Açılış kartında cariyle ilgili birşey yok
                if (Hareketler.KasaAcilisKarti(txtKasaKodu.Text, txtBelgeNo.Text, Formatlar.IngilizceTarihFormati(txtTarih.Text), GcKodu, "A", txtTutar.Text, "", frmAnaForm.UserId))
                {
                    Mesajlar.Bilgi("Kasa Açılış kartı başarılı bir şekilde kaydedilmiştir..");
                    Temizle();
                }
                else
                {
                    Mesajlar.Hata();
                }
            }
            

        }
        void Temizle()
        {
            Edit = false;
            txtBelgeNo.Text = "";
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtTarih.Text = "";
            txtTutar.Text = "0";
            txtBelgeNo.Focus();
            txtBelgeNo.Enabled = true;
        }

        public void Ac(string Id)
        {


            //   txtBelgeNo.Text = Id;
            DataRow Satir = Hareketler.Ac(Id);
            txtKasaKodu.Text = Satir["KODU"].ToString();
            txtKasaAdi.Text = Satir["ADI"].ToString();
            txtTarih.Text = Convert.ToDateTime(Satir["TARIH"].ToString()).ToShortDateString();

            txtTutar.Text = Satir["TUTAR"].ToString();
            string GcKodu = Satir["GCKODU"].ToString();
            txtBelgeNo.Text = Satir["FISNO"].ToString();
            txtBelgeNo.Enabled = false;

            if (GcKodu == "G")//Giriş ise
            {
                raGiris.Checked = true;
            }
            else
            {
                raCikis.Checked = true;
            }

            Edit = true;//güncelleme için
            AcilanHareketId = Id;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit == true)//açılma işlemi yapıldıysa
            {
                if (Mesajlar.Sor("Kasa Açılış kartını silmek istediğinizden emin misiniz?") == true)
                {
                    if (Hareketler.Sil(AcilanHareketId) == true)
                    {
                        Mesajlar.Bilgi("Kasa Açılış kartı başarılı bir şekilde silinmiştir.");
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
}