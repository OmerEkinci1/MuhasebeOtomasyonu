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
    public partial class frmBankaTanitimKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmBankaTanitimKarti()
        {
            InitializeComponent();
        }
        Classlar.clsBanka Banka = new Classlar.clsBanka();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        Classlar.clsBankaHareketleri Hareketler = new Classlar.clsBankaHareketleri();
        Boolean Edit = false;
        string AcilanBankaId = "-1";
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
        void Kaydet()
        {
            if (Edit==true)//güncelleme
            {
                if(Banka.Guncelle(AcilanBankaId,txtHesapNo.Text, txtIban.Text, txtBankaAdi.Text, txtHesapAdi.Text, txtSube.Text, txtTelefon.Text, txtIlgili.Text, txtAdres.Text, frmAnaForm.UserId))
                {
                    Mesajlar.Bilgi("Banka Başarılı bir şekilde güncellenmiştir.");
                    Temizle();
                }
                else
                {
                    Mesajlar.Hata();
                }
            }
            else//kaydetme
            {
                if(Banka.Ekle( txtHesapNo.Text, txtIban.Text, txtBankaAdi.Text, txtHesapAdi.Text, txtSube.Text, txtTelefon.Text, txtIlgili.Text, txtAdres.Text, frmAnaForm.UserId))
                {
                    Mesajlar.Bilgi("Banka Başarılı bir şekilde kaydedilmiştir");
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
            txtAdres.Text = "";
            txtBankaAdi.Text = "";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            txtIban.Text = "";
            txtIlgili.Text = "";
            txtSube.Text = "";
            txtTelefon.Text = "";
            Edit = false;
        }

        void BakiyeListesi(string Id)
        {
            ListeBankaBakiye.DataSource = Hareketler.BakiyeListesi(Id);
            
        }
       public void Ac(string Id)
        {

            DataRow satir = Banka.Ac(Id);
            AcilanBankaId = Id;
            txtAdres.Text = satir["ADRES"].ToString();
            txtBankaAdi.Text = satir["BANKAADI"].ToString();
            txtHesapAdi.Text = satir["HESAPADI"].ToString();
            txtHesapNo.Text = satir["HESAPNO"].ToString();
            txtIban.Text = satir["IBAN"].ToString();
            txtIlgili.Text = satir["ILGILI"].ToString();
            txtSube.Text = satir["SUBE"].ToString();
            txtTelefon.Text = satir["TEL"].ToString();
            Edit = true;//güncelleme olduğunu bildirmek için

            BakiyeListesi(Id);

        }

        private void txtHesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            AcilanBankaId = Ekranlar.BankaListesi(true);//dialog şeklinde açıcaz

            Ac(AcilanBankaId);


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sor("Banka Tanıtım Kartını Silmek İstediğinizden Emin misiniz? ") == true)
            {
                if (Banka.Sil(AcilanBankaId) == true)
                {
                    Mesajlar.Bilgi("Banka başarılı bir şekilde silinmiştir.");
                    Temizle();
                }
                else
                {
                    Mesajlar.Hata();
                }
            }
        }
    }
}