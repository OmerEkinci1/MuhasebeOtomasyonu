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

namespace OnMuhasebe.BankaModulu
{
    public partial class frmBankaIslemi : DevExpress.XtraEditors.XtraForm
    {
        public frmBankaIslemi()
        {
            InitializeComponent();
        }
        string BankaId = "-1";
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        Classlar.clsBanka Banka = new Classlar.clsBanka();
        Boolean Edit = false;
        Classlar.clsBankaHareketleri Hareketler = new Classlar.clsBankaHareketleri();
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();//tarih formatı için
        string AcilanIslemId = "-1";
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        private void txtHesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            BankaSec();
        }


        void BankaSec()
        {
            BankaId = Ekranlar.BankaListesi(true);//seçim için açsın

            DataRow Satir = Banka.Ac(BankaId);
            txtHesapNo.Text = Satir["HESAPNO"].ToString();
            txtBankaAdi.Text = Satir["BANKAADI"].ToString();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtHesapNo.Text=="")
            {
                if(Mesajlar.Sor("Banka seçmeden işleme devam edemezsiniz!.Şimdi Banka Seçmek istermisiz!") == true)
                {
                    BankaSec();
                    return;//direk metotdan çık
                }
             
            }
            string GcKodu = "G";
            if (raCikis.Checked == true)
            {
                GcKodu = "C";
            }
            else
            {
                GcKodu = "G";
            }


            if (Edit==true)
            {
                if(Hareketler.Guncelle(AcilanIslemId,BankaId, txtBelgeNo.Text, txtMakbuzNo.Text, Formatlar.IngilizceTarihFormati(txtTarih.Text), GcKodu, "B", txtTutar.Text, "", txtAciklama.Text, frmAnaForm.UserId))
                {
                    Mesajlar.Bilgi("Güncelleme başarılı");
                    this.Close();
                }
                else
                {
                    Mesajlar.Hata();
                }
            }
            else
            {
               
                //belgeno=Fisno
                //Banka işlemi olduğu için Tipi=B olcak
                //Carikodu boş olcak
                if(Hareketler.Ekle(BankaId, txtBelgeNo.Text, txtMakbuzNo.Text, Formatlar.IngilizceTarihFormati(txtTarih.Text), GcKodu, "B", txtTutar.Text, "", txtAciklama.Text, frmAnaForm.UserId))
                {
                    Mesajlar.Bilgi("Kaydetme  başarılı");
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
            AcilanIslemId = Id;
            Edit = true;
            DataRow Satir = Hareketler.Ac(Id);
            txtAciklama.Text = Satir["ACIKLAMA"].ToString();
            txtBankaAdi.Text= Satir["BANKAADI"].ToString();
            txtBelgeNo.Text= Satir["FISNO"].ToString();
            txtHesapNo.Text= Satir["HESAPNO"].ToString();
            txtMakbuzNo.Text= Satir["MAKBUZNO"].ToString();
            txtTarih.Text= Satir["TARIH"].ToString();
            txtTutar.Text= Satir["TUTAR"].ToString();
            BankaId= Satir["BANKAID"].ToString();
            string GcKodu = Satir["GCKODU"].ToString();
            if (GcKodu=="C")//çıkış ise
            {
                raCikis.Checked = true;
            }
            else
            {
                raGiris.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sor("Banka İşlemini Silmek istediğinizden eminmisiniz?")==true)
            {
                if (Hareketler.Sil(AcilanIslemId)==true)
                {
                    
                    this.Close();
                }
                else
                {
                    Mesajlar.Hata();
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtBelgeNo.Text!="" || txtMakbuzNo.Text!="" || txtHesapNo.Text!="")
            {
                if (Mesajlar.Sor("Geçerli  işlemi iptal etmek istediğinizden emin misiniz?"))
                {
                    Temizle();
                }
            }
        }
        void Temizle()
        {
            txtAciklama.Text = "";
            txtBankaAdi.Text = "";
            txtBelgeNo.Text = "";
            txtHesapNo.Text = "";
            txtMakbuzNo.Text = "";
            txtTarih.Text = "";
            txtTutar.Text = "0";
            txtBelgeNo.Focus();
            Edit = false;
            
        }

        private void frmBankaIslemi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}