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
    public partial class frmCariAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmCariAcilisKarti()
        {
            InitializeComponent();
        }
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        Classlar.clsCariTanitimKarti Cari = new Classlar.clsCariTanitimKarti();
        Classlar.clsCariHareketleri Hareketler = new Classlar.clsCariHareketleri();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        string CariId = "-1";
        string SecilenCariKodu = "";
        string SecilenID = "";
        public Boolean Edit = false;

        string SecilenAcilisKartiId = "-1";

        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void btnCariSec_Click(object sender, EventArgs e)
        {
            CariSec();
        }


        void CariSec(Boolean Ac = false)
        {

            if (Ac == false)
            {
                CariId = Ekranlar.CariListesiAc();
            }




            DataRow satir = Cari.Ac(CariId);//istediğimiz idye göre satırı seçtik
            SecilenCariKodu = satir["CARIKODU"].ToString();


            txtCariIsim.Text = satir["CARIISIM"].ToString();
            txtCariKodu.Text = SecilenCariKodu;


        }
        void Kaydet()
        {
            decimal Borc, Alacak;
            if (raAlacak.Checked == true)
            {
                Alacak = Convert.ToDecimal(txtTutar.Text);
                Borc = 0;
            }
            else
            {
                Alacak = 0;
                Borc = Convert.ToDecimal(txtTutar.Text);
            }


            if (Edit == true)//güncelleme
            {
                Hareketler.CariAcilisKartiGuncelle(SecilenID, txtCariKodu.Text, txtBelgeNo.Text, Borc, Alacak, txtTarih.EditValue.ToString(), txtAciklama.Text);
            }
            else
            {//YENİ KAYIT


                Hareketler.CariAcilisKarti(txtCariKodu.Text, txtBelgeNo.Text, Borc, Alacak, txtTarih.EditValue.ToString(), txtAciklama.Text);

            }

            this.Close();


        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {



            Kaydet();

        }


        public void Ac(string id)
        {
            Edit = true;//güncelleme için
            SecilenID = id;
            DataRow satir = Hareketler.CariAcilisKartiAc(SecilenID);
            txtAciklama.Text = satir["ACIKLAMA"].ToString();
            txtBelgeNo.Text = satir["BELGENO"].ToString();
            string CariKodu = satir["CARIKODU"].ToString();
            SecilenAcilisKartiId = satir["ID"].ToString();

            CariId = Cari.CariIdAl(CariKodu);
            CariSec(true);

            //   txtCariIsim.Text= satir["CARIISIM"].ToString();
            //  txtCariKodu.Text= satir["ACIKLAMA"].ToString();

            decimal Borc, Alacak;
            Borc = Convert.ToDecimal(satir["BORC"].ToString());
            Alacak = Convert.ToDecimal(satir["ALACAK"].ToString());

            if (Borc > 0)
            {
                txtTutar.Text = Borc.ToString();
                raBorc.Checked = true;
            }
            else
            {
                txtTutar.Text = Alacak.ToString();
                raAlacak.Checked = true;

            }

            txtTarih.EditValue = satir["TARIH"].ToString();

        }

        private void frmCariAcilisKarti_Load(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sor("Açılış Kartını Silmek İstediğinizden Emin misiniz?") == true)
            {
                if (Hareketler.CariAcilisKartiSil(SecilenAcilisKartiId) == true)
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
            txtBelgeNo.Text = "";
            txtCariIsim.Text = "";
            txtCariKodu.Text = "";
            txtTarih.EditValue = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit = false;
            txtBelgeNo.Focus();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}