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
    public partial class frmGelenHavale : DevExpress.XtraEditors.XtraForm
    {
        public frmGelenHavale()
        {
            InitializeComponent();
        }
        Classlar.clsBankaHareketleri Hareketler = new Classlar.clsBankaHareketleri();
        Boolean Edit = false;
        string AcilanHareketId = "-1";
        string BankaId = "-1";
        string CariId = "-1";
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        Classlar.clsBanka Banka = new Classlar.clsBanka();
        OnMuhasebe.CariModulu.Classlar.clsCariTanitimKarti Cari = new CariModulu.Classlar.clsCariTanitimKarti();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        void BankaSec()
        {
            BankaId = Ekranlar.BankaListesi(true);

            DataRow Satir = Banka.Ac(BankaId);
            txtHesapNo.Text = Satir["HESAPNO"].ToString();
            txtBankaAdi.Text = Satir["BANKAADI"].ToString();
        }

        void CariSec()
        {
            CariId = Ekranlar.CariListesiAc();

            DataRow Satir = Cari.Ac(CariId);
            txtCariAdi.Text = Satir["CARIISIM"].ToString();
            txtCariKodu.Text = Satir["CARIKODU"].ToString();
        }
        void Kaydet()
        {
            if (txtHesapNo.Text == "")
            {
                if (Mesajlar.Sor("Banka seçmeden işleme devam edemezsiniz!.Şimdi Banka Seçmek istermisiz!") == true)
                {
                    BankaSec();
                    txtHesapNo.Focus();
                }

            }
            else if (txtCariKodu.Text == "")
            {
                if (Mesajlar.Sor("Cari seçmeden işleme devam edemezsiniz!.Şimdi Cari Seçmek istermisiz!") == true)
                {
                    CariSec();
                    txtCariKodu.Focus();

                }
            }
            else
            {



                if (Edit == true)
                {
                    //Gelen havale olduğu için GcKodu='G' olcak yani giriş
                    //Tipi Havale olduğu  için H dedik.
                    if (Hareketler.Guncelle(AcilanHareketId, BankaId, txtBelgeNo.Text, txtMakbuzNo.Text, Formatlar.IngilizceTarihFormati(txtTarih.Text), "G", "H", txtTutar.Text, txtCariKodu.Text, txtAciklama.Text, frmAnaForm.UserId))
                    {
                        Mesajlar.Bilgi("Gelen Havale başarılı bir şekilde güncellenmiştir.");
                        Temizle();
                    }
                }
                else
                {
                    if (Hareketler.Ekle(BankaId, txtBelgeNo.Text, txtMakbuzNo.Text, Formatlar.IngilizceTarihFormati(txtTarih.Text), "G", "H", txtTutar.Text, txtCariKodu.Text, txtAciklama.Text, frmAnaForm.UserId))
                    {
                        Mesajlar.Bilgi("Gelen Havale başarılı bir şekilde kaydedilmiştir..");
                        Temizle();
                    }
                }

            }
        }

        public void Ac(string Id)
        {
            AcilanHareketId = Id;
            Edit = true;
            DataRow Satir = Hareketler.Ac(Id);
            txtCariAdi.Text = Satir["CARIISIM"].ToString();
            txtCariKodu.Text = Satir["CARIKODU"].ToString();
            txtAciklama.Text = Satir["ACIKLAMA"].ToString();
            txtBankaAdi.Text = Satir["BANKAADI"].ToString();
            txtBelgeNo.Text = Satir["FISNO"].ToString();
            txtHesapNo.Text = Satir["HESAPNO"].ToString();
            txtMakbuzNo.Text = Satir["MAKBUZNO"].ToString();
            txtTarih.Text = Satir["TARIH"].ToString();
            txtTutar.Text = Satir["TUTAR"].ToString();
            BankaId = Satir["BANKAID"].ToString();
         

           
        }


        void Temizle()
        {
            Edit = false;
            txtAciklama.Text = "";
            txtBankaAdi.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtHesapNo.Text = "";
            txtMakbuzNo.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";

        }

        private void frmGelenHavale_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void txtHesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            BankaId = Ekranlar.BankaListesi(true);

            DataRow Satir = Banka.Ac(BankaId);
            txtHesapNo.Text = Satir["HESAPNO"].ToString();
            txtBankaAdi.Text = Satir["BANKAADI"].ToString();


        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CariId = Ekranlar.CariListesiAc();

            DataRow Satir = Cari.Ac(CariId);
            txtCariAdi.Text = Satir["CARIISIM"].ToString();
            txtCariKodu.Text = Satir["CARIKODU"].ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtBelgeNo.Text != "" || txtMakbuzNo.Text != "" || txtHesapNo.Text != "" || txtCariKodu.Text != "")
            {
                if (Mesajlar.Sor("Geçerli  işlemi iptal etmek istediğinizden emin misiniz?"))
                {
                    Temizle();
                    
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sor("Gelen Havaleyi Silmek istediğinizden emin misiniz?")==true)
            {
                if (Hareketler.Sil(AcilanHareketId))
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