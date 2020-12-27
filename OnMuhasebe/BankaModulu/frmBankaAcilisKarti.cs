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

using System.Data.SqlClient;//ekledik
namespace OnMuhasebe.BankaModulu
{
    public partial class frmBankaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmBankaAcilisKarti()
        {
            InitializeComponent();
        }

        Classlar.clsBanka Banka = new Classlar.clsBanka();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        Classlar.clsBankaHareketleri Hareketler = new Classlar.clsBankaHareketleri();
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();//tarih formatını çevirmek için
        public string AcilanBankaId = "-1";
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        Boolean Edit = false;
        string AcilanHareketId = "-1";

        private void txtHesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            AcilanBankaId = Ekranlar.BankaListesi(true);//dialog şeklinde açıcaz

            DataRow Satir = Banka.Ac(AcilanBankaId);
            txtBankaAdi.Text = Satir["BANKAADI"].ToString();
            txtHesapNo.Text = Satir["HESAPNO"].ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string GcKodu = "G";
            if (raBorc.Checked == true)
            {
                GcKodu = "C";//borçsa demekki çıkış olmuştur.

            }
            else
            {
                GcKodu = "G";

            }


            if (Edit == false)//kaydet
            {
                //belgeno=fisno
                //tarih formatını çeviriyoruz
                if (Hareketler.BankaAcilisKarti(AcilanBankaId, txtBelgeNo.Text, Formatlar.IngilizceTarihFormati(txtTarih.Text), GcKodu, txtTutar.Text, frmAnaForm.UserId) == true)
                {
                    Mesajlar.Bilgi("Banka Açılış Kartı başarılı bir şekilde oluşturulmuştur.");
                    Temizle();
                }
                else
                {
                    Mesajlar.Hata();
                }

            }
            else//güncelle
            {
                if (Hareketler.BankaAcilisKartiGuncelle(AcilanHareketId, AcilanBankaId, txtBelgeNo.Text, Formatlar.IngilizceTarihFormati(txtTarih.Text), GcKodu, txtTutar.Text, frmAnaForm.UserId) == true)
                {
                    Mesajlar.Bilgi("Banka Açılış Kartı başarılı bir şekilde güncellenmiştir.");
                    this.Close();
                }
                else
                {
                    Mesajlar.Hata();
                }
            }





        }



        public void Ac(string Id)
        {


            //   txtBelgeNo.Text = Id;
            DataRow Satir = Hareketler.Ac(Id);
            txtHesapNo.Text = Satir["HESAPNO"].ToString();
            txtBankaAdi.Text = Satir["BANKAADI"].ToString();
            txtTarih.Text = Convert.ToDateTime(Satir["TARIH"].ToString()).ToShortDateString();

            txtTutar.Text = Satir["TUTAR"].ToString();
            string GcKodu = Satir["GCKODU"].ToString();
            txtBelgeNo.Text = Satir["FISNO"].ToString();
            txtBelgeNo.Enabled = false;

            if (GcKodu == "G")//Giriş ise
            {
                raAlacak.Checked = true;
            }
            else
            {
                raBorc.Checked = true;
            }

            Edit = true;//güncelleme için
            AcilanHareketId = Id;
            AcilanBankaId = Satir["BANKAID"].ToString();

        }


        void Temizle()
        {
            Edit = false;
            txtBelgeNo.Text = "";
            txtHesapNo.Text = "";
            txtBankaAdi.Text = "";
            txtTarih.Text = "";
            txtTutar.Text = "0";
            txtBelgeNo.Focus();
            txtBelgeNo.Enabled = true;
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit == true)//açılma işlemi yapıldıysa
            {
                if (Mesajlar.Sor("Banka Açılış kartını silmek istediğinizden emin misiniz?") == true)
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

        private void frmBankaAcilisKarti_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            if (Edit==true)
            {
                btnSil.Enabled = true;
            }
            else
            {
                btnSil.Enabled = false;
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {

        }
    }
}