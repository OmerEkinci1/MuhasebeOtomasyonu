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

namespace OnMuhasebe.KullaniciModulu
{
    public partial class frmKullanici : DevExpress.XtraEditors.XtraForm
    {
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new Classlar.Mesajlar();
        clsKullanici Kullanici = new clsKullanici();
        public Boolean Edit = false;
        string AcilanKullaniciId = "-1";
        public frmKullanici()
        {
            InitializeComponent();
        }
        public void Ac(string Id)
        {
            try
            {
                AcilanKullaniciId = Id;
                Edit = true;//güncelleme için
                DataRow Satir = Kullanici.Ac(AcilanKullaniciId);
                txtAdi.Text = Satir["ADI"].ToString();
                txtSoyadi.Text = Satir["SOYADI"].ToString();
                txtUnvani.Text = Satir["UNVANI"].ToString();
                txtEmail.Text = Satir["EMAIL"].ToString();
                txtTel.Text = Satir["TEL"].ToString();
                txtKullaniciAdi.Text = Satir["KULLANICIADI"].ToString();
                txtParola.Text = Satir["PAROLA"].ToString();
                txtAciklama.Text = Satir["ACIKLAMA"].ToString();

                AdminMi = Satir["ADMIN"].ToString();
                if (AdminMi.Trim() == "1")
                {
                    cheYonetici.Checked = true;
                }
                else
                {
                    cheYonetici.Checked = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        string AdminMi = "0";
        void Kaydet()
        {
            if (Mesajlar.Sor("Kullancıyı kaydetmek istediğinizden emin misiniz?"))
            {


                if (Kullanici.Ekle(txtAdi.Text, txtSoyadi.Text, txtUnvani.Text, txtEmail.Text, txtTel.Text, txtKullaniciAdi.Text, txtParola.Text, AdminMi,txtAciklama.Text, frmAnaForm.UserId))
                {
                    Temizle();
                }
                else
                {
                    Mesajlar.Hata();
                }
            }

        }
        void Guncelle()
        {
            if (Mesajlar.Sor("Kullancıyı güncellemek istediğinizden emin misiniz?"))
            {

                if (Kullanici.Guncelle(AcilanKullaniciId, txtAdi.Text, txtSoyadi.Text, txtUnvani.Text, txtEmail.Text, txtTel.Text, txtKullaniciAdi.Text, txtParola.Text, AdminMi, txtAciklama.Text, frmAnaForm.UserId))
                {
                    Temizle();
                }
                else
                {
                    Mesajlar.Hata();
                }
            }
        }


        void Sil()
        {
            if (Mesajlar.Sor("Kullanıcıyı Silmek İstediğinizden emin misiniz?"))
            {
                if (Kullanici.Sil(AcilanKullaniciId))
                {
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
            txtAciklama.Text = "";
            txtAdi.Text = "";
            txtEmail.Text = "";
            txtKullaniciAdi.Text = "";
            txtParola.Text = "";
            txtSoyadi.Text = ""; txtTel.Text = "";
            txtUnvani.Text = "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit == true)
            {
                Guncelle();
            }
            else
            {
                Kaydet();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit == true)
            {
                Sil();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text != "")
            {
                if (Mesajlar.Sor("Geçerli işlemi iptal etmek istediğinizden emin misiniz?"))
                {
                    Edit = false;
                    Temizle();
                }
            }

        }
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new Classlar.Ekranlar();
        private void txtAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Ac(Ekranlar.KullaniciListesi(true));
        }

        private void cheYonetici_CheckedChanged(object sender, EventArgs e)
        {
            if (cheYonetici.Checked == true)
            {
                AdminMi = "1";
            }
            else
            {
                AdminMi = "0";
            }
        }
    }
}