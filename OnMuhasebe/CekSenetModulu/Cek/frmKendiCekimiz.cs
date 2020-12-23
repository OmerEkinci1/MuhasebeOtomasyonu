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

namespace OnMuhasebe.CekSenetModulu.Cek
{
    public partial class frmKendiCekimiz : DevExpress.XtraEditors.XtraForm
    {
        Classlar.Cekler Cekler = new Classlar.Cekler();
        public MusteriCeki GirilenCek;//struct tipinde
        public Boolean BordroIcinSec = false;
        Boolean Edit = false;
        string AcilanCekId = "-1";

        string AsilMiCiroMu = "";
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();//ttarih formatını çevirmek için

        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        public frmKendiCekimiz()
        {
            InitializeComponent();
        }

        string CariId = "-1";
        OnMuhasebe.CariModulu.Classlar.clsCariTanitimKarti Cari = new CariModulu.Classlar.clsCariTanitimKarti();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        public MusteriCeki Sec(string CariKodu, string CariAdi)//struct dönen metod
        {
            BordroIcinSec = true;

            Edit = false;
            this.ShowDialog();//bu formu aç
            return GirilenCek;
        }

        public MusteriCeki Guncelle(MusteriCeki Cek, string CariKodu, string CariAdi, Boolean BordroIcinMi, Boolean DialogAc = true)
        {
            BordroIcinSec = BordroIcinMi;
            Edit = true;
            GirilenCek = Cek;
            BilgileriTextlereAktar(CariKodu, CariAdi);
            if (DialogAc == true)
            {
                this.ShowDialog();
            }

            return GirilenCek;
        }

        void BilgileriTextlereAktar(string CariKodu, string CariAdi)
        {
            txtAciklama.Text = GirilenCek.Aciklama;

            txtBanka.Text = GirilenCek.Banka;
            txtBelgeNo.Text = GirilenCek.BelgeNo;

            txtCekNo.Text = GirilenCek.CekNo;
            txtHesapNo.Text = GirilenCek.HesapNo;
            txtSube.Text = GirilenCek.Sube;
            txtTutar.Text = GirilenCek.Tutar.ToString();
            txtVadeTarihi.Text = GirilenCek.VadeTarihi;
            txtTarih.Text = GirilenCek.Tarih;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {



            if (Mesajlar.Sor("Çeki KAydetmek İstediğinizden Eminmisiniz?"))
            {
                //GirilenCek.EklemeBasariliMi = false;

                if (Edit == true)
                {
                    DirekGuncelle();
                }
                else
                {
                    DirekKaydet();
                }

            }




        }


        void DirekKaydet()
        {

            //çekin Tipi=K olcak yani kendi çekimiz
            //CARİ KISIMLARINI BOŞ YOLLUYORUZ
            //ASIL CIRO=A OLCAK
            //DURUMU=B YANİ BEKLİYOR.


            if (Cekler.CekGirisi(txtBelgeNo.Text, txtCekNo.Text, "K", "", "", "", "A", "KENDİ ÇEKİMİZ", Formatlar.IngilizceTarihFormati(txtTarih.Text), Formatlar.IngilizceTarihFormati(txtVadeTarihi.Text), txtBanka.Text, txtSube.Text, txtHesapNo.Text, txtTutar.Text, txtAciklama.Text, "B", "", "", frmAnaForm.UserId) == true)
            {
                Mesajlar.Bilgi("Çek Başarılı bir şekilde kaydedilmiştir.");

            }
            else
            {
                Mesajlar.Hata();
            }


        }


        void DirekGuncelle()
        {

            if (Cekler.CekGuncelle(AcilanCekId, txtBelgeNo.Text, txtCekNo.Text, "K", "", "", "", "A", "KENDİ ÇEKİMİZ", Formatlar.IngilizceTarihFormati(txtTarih.Text), Formatlar.IngilizceTarihFormati(txtVadeTarihi.Text), txtBanka.Text, txtSube.Text, txtHesapNo.Text, txtTutar.Text, txtAciklama.Text, "B", "", "", frmAnaForm.UserId) == true)
            {
                Mesajlar.Bilgi("Çek Başarılı bir şekilde güncellenmiştir..");

            }
            else
            {
                Mesajlar.Hata();
            }
        }








        private void frmMusteriCeki_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (Mesajlar.Sor("Çeki Silmek istediğinizden eminmisiniz?"))
            {
                if (BordroIcinSec == true)
                {



                    GirilenCek.EklemeBasariliMi = false;
                    this.Close();

                }
                else
                {
                    Cekler.Sil(AcilanCekId);//bordrodan açılmamışsa
                    Mesajlar.Bilgi("Çek Başarılı bir şekilde silinmiştir.");
                    this.Close();
                }
            }

        }
        public void Ac(string Id, Boolean Dialog = true)
        {
            AcilanCekId = Id;

            DataRow Satir = Cekler.Ac(AcilanCekId);
            MusteriCeki AcilanCek = new MusteriCeki();
            AcilanCek.Aciklama = Satir["ACIKLAMA"].ToString();
            AcilanCek.AsilBorclu = Satir["ASILBORCLU"].ToString();
            AcilanCek.AsilCiro = Satir["ASILCIRO"].ToString();
            AcilanCek.Banka = Satir["BANKA"].ToString();
            AcilanCek.BelgeNo = Satir["BELGENO"].ToString();
            AcilanCek.CekNo = Satir["CEKNO"].ToString();
            AcilanCek.EklemeBasariliMi = true;
            AcilanCek.HesapNo = Satir["HESAPNO"].ToString();
            AcilanCek.Sube = Satir["SUBE"].ToString();
            AcilanCek.Tarih = Satir["TARIH"].ToString();
            AcilanCek.Tutar = Convert.ToDecimal(Satir["TUTAR"].ToString());
            AcilanCek.VadeTarihi = Satir["VADETARIHI"].ToString();

            string CariKodu, CariAdi;
            CariKodu = Satir["ALINANCARI"].ToString();
            CariAdi = Satir["ALINANCARIISIM"].ToString();

            Guncelle(AcilanCek, CariKodu, CariAdi, false, Dialog);


        }

        private void txtBelgeNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            AcilanCekId = Ekranlar.MusteriCekListesi(true);
            Ac(AcilanCekId, false);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (txtBelgeNo.Text != "" || txtCekNo.Text != "")
            {
                if (Mesajlar.Sor("işlemi iptal etmek istedeiğinizden eminmmiisiniz?"))
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}