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

namespace OnMuhasebe.CariModulu
{
    public partial class frmCariTanitimKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmCariTanitimKarti()
        {
            InitializeComponent();
        }
        Classlar.clsCariTanitimKarti Cari = new Classlar.clsCariTanitimKarti();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        string CariId = "";

        Boolean Edit = false;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string Tipi = "Alici";
            if (raAlici.Checked == true)//radiobutton
            {
                Tipi = "ALICI";
            }
            else if (raSatici.Checked == true)
            {
                Tipi = "SATICI";
            }
            else
            {
                Tipi = "DİĞER";
            }

            if (Edit == true)
            {
                //Güncelleme için

                Cari.Guncelle(CariId, txtCariKodu.Text, txtCariIsim.Text, txtAdres.Text, txtIl.Text, txtIlce.Text, txtUlke.Text, txtTel.Text, txtFax.Text, txtVergiDairesi.Text, txtVergiNumarasi.Text, txtTc.Text, txtPostaKodu.Text, txtEmail.Text, txtWeb.Text, Tipi, frmAnaForm.UserId);
                Mesajlar.Bilgi("Kaydınız güncellenmiştir.");
                Temizle();
            }
            else
            {
                //kaydetme için

                Cari.Ekle(txtCariKodu.Text, txtCariIsim.Text, txtAdres.Text, txtIl.Text, txtIlce.Text, txtUlke.Text, txtTel.Text, txtFax.Text, txtVergiDairesi.Text, txtVergiNumarasi.Text, txtTc.Text, txtPostaKodu.Text, txtEmail.Text, txtWeb.Text, Tipi, frmAnaForm.UserId);
                Mesajlar.Bilgi("Kaydınız gerçekleşmiştir.");
                Temizle();

            }
            Edit = false;//daha sonra kaydetme işlemi yapabilmek için.
        }

        private void btnCariSec_Click(object sender, EventArgs e)
        {
            CariId = Ekranlar.CariListesiAc();

            DataRow satir = Cari.Ac(CariId);//istediğimiz idye göre satırı seçtik

            txtAdres.Text = satir["ADRES"].ToString();
            txtCariIsim.Text = satir["CARIISIM"].ToString();
            txtCariKodu.Text = satir["CARIKODU"].ToString();
            txtEmail.Text = satir["EMAIL"].ToString();
            txtFax.Text = satir["FAX"].ToString();
            txtIl.Text = satir["IL"].ToString();
            txtIlce.Text = satir["ILCE"].ToString();
            txtPostaKodu.Text = satir["POSTAKODU"].ToString();
            txtTc.Text = satir["TC"].ToString();
            txtTel.Text = satir["TELEFON"].ToString();
            txtUlke.Text = satir["ULKE"].ToString();
            txtVergiDairesi.Text = satir["VERGIDAIRESI"].ToString();
            txtVergiNumarasi.Text = satir["VERGINUMARASI"].ToString();
            txtWeb.Text = satir["WEB"].ToString();


            string Tipi = satir["TIPI"].ToString();
            if (Tipi == "ALICI")//radiobutton
            {
                raAlici.Checked = true;

            }
            else if (Tipi == "SATICI")
            {
                raSatici.Checked = true;

            }
            else
            {
                raDiger.Checked = true;
            }


            Edit = true;//güncelleme olduğunu belirtmek için

        }
        void Temizle()
        {
            txtAdres.Text = "";
            txtCariIsim.Text = "";
            txtCariKodu.Text = "";
            txtEmail.Text = "";
            txtFax.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtPostaKodu.Text = "";
            txtTc.Text = "";
            txtTel.Text = "";
            txtUlke.Text = "";
            txtVergiDairesi.Text = "";
            txtVergiNumarasi.Text = "";
            txtWeb.Text = "";
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sor("Seçilen Kaydı Silmek İstediğinizden Emin misiniz?") == true)
            {
                Cari.Sil(CariId);
                Temizle();
            }

        }

        private void frmCariTanitimKarti_Load(object sender, EventArgs e)
        {

        }
    }
}