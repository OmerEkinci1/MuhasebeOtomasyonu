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
    public partial class frmKasaTanitimKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmKasaTanitimKarti()
        {
            InitializeComponent();
        }
        Classlar.clsKasa Kasa = new Classlar.clsKasa();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();

        string AcilanKasaId = "-1";
        string AcilanKasaKodu = "-1";
        Boolean Edit = false;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit == true)//güncelleme
            {
                if (Kasa.Guncelle(AcilanKasaId, txtKodu.Text, txtAdi.Text, txtAciklama.Text, frmAnaForm.UserId) == true)
                {
                    Mesajlar.Bilgi("Kasa Başarılı bir şekilde güncellenmiştir");
                    Temizle();
                    Edit = false;
                }
                else
                {
                    Mesajlar.Hata();
                }


            }
            else//kaydetme
            {
                if (Kasa.Ekle(txtKodu.Text, txtAdi.Text, txtAciklama.Text, frmAnaForm.UserId) == true)
                {
                    Mesajlar.Bilgi("Kasa Başarılı bir şekilde kaydedilmiştir");
                    Temizle();
                    Edit = false;
                }
                else
                {
                    Mesajlar.Hata();
                }
            }





        }

        private void txtKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            AcilanKasaId = Ekranlar.KasaListesi(true);
            Ac(AcilanKasaId);


        }

        public void Ac(string Id)
        {
            AcilanKasaId = Id;
            DataRow Satir = Kasa.Ac(Id);
            txtKodu.Text = Satir["KODU"].ToString();
            txtAdi.Text = Satir["ADI"].ToString();
            txtAciklama.Text = Satir["ACIKLAMA"].ToString();
            AcilanKasaKodu = Satir["KODU"].ToString();
            GetKasaBakiye(AcilanKasaKodu);
            Edit = true;//güncelleme için

        }

        void GetKasaBakiye(string KasaKodu)
        {
            ListeKasaBakiye.DataSource = Kasa.KasaBakiye(AcilanKasaKodu);
        }

        void Temizle()
        {
            AcilanKasaId = "-1";
            AcilanKasaKodu = "-1";
            txtAciklama.Text = "";
            txtAdi.Text = "";
            txtKodu.Text = "";
            Edit = false;
            txtKodu.Focus();
            GetKasaBakiye(AcilanKasaKodu);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sor("Kasayı Silmek İstediğinizden Emin misiniz? ") == true)
            {
                if (Kasa.Sil(AcilanKasaId) == true)
                {
                    Temizle();
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            if (txtKodu.Text != "")
            {
                if (Mesajlar.Sor("Geçerli İşlemi iptal etmek istediğinizden eminmisiniz?") == true)
                {
                    Temizle();
                    Edit = false;

                }
            }
            else
            {
                Temizle();
                Edit = false;
            }

        }

        private void frmKasaTanitimKarti_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

            if (Mesajlar.Sor("Geçerli İşlemi iptal etmek istediğinizden eminmisiniz?") == true)
            {
                this.Close();

            }

        }
    }
}