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
    public partial class frmCekDurumuBanka: DevExpress.XtraEditors.XtraForm
    {
        public frmCekDurumuBanka()
        {
            InitializeComponent();
        }
        Classlar.Cekler Cekler = new Classlar.Cekler();
        string AcilanCekId = "-1";
        string CariKodu = "-1";
        public void CekAc(string Id)
        {

            AcilanCekId = Id;


            DataRow Satir = Cekler.Ac(Id);
            MusteriCeki AcilanCek = new MusteriCeki();


            txtBanka.Text = Satir["BANKA"].ToString();
            txtCekNo.Text = Satir["CEKNO"].ToString();
            txtSube.Text = Satir["SUBE"].ToString();
            txtTutar.Text = Satir["TUTAR"].ToString();
            txtVadeTarihi.Text = Satir["VADETARIHI"].ToString();
            txtNumara.Text = Satir["BELGENO"].ToString();
            txtTarih.Text = Satir["TARIH"].ToString();
            txtAsilBorclu.Text = Satir["ASILBORCLU"].ToString();

            CariKodu = Satir["ALINANCARI"].ToString();//hangi cariden tahsil ettiğimiz falan
            string CekDurumu = Satir["DURUMU"].ToString().Trim();


            if (CekDurumu == "B")//BEKLİYOR İSE 
            {
                comDurumu.SelectedIndex = 0;
            }
            else if (CekDurumu == "T")//TAHSİL EDİLMİŞ İSE 
            {
                comDurumu.SelectedIndex = 1;
                string BankaId = Cekler.CekTahsilatiYapilanBanka(AcilanCekId);
       
                if (BankaId != "")
                {
                   
                    BankaAc(BankaId);
                    //txtBankaAdi.Enabled = false;
                    //txtHesapNo.Enabled = false;
                    //btnKaydet.Enabled = false;
                }

            }
            else//KARŞILIKSIZ İSE 
            {
                comDurumu.SelectedIndex = 2;
            }
            this.ShowDialog();
        }
        string SecilenBankaId = "-1";
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        OnMuhasebe.BankaModulu.Classlar.clsBanka Banka = new BankaModulu.Classlar.clsBanka();


        private void txtHesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SecilenBankaId = Ekranlar.BankaListesi(true);

            DataRow satir = Banka.Ac(SecilenBankaId);
            txtHesapNo.Text = satir["HESAPNO"].ToString();
            txtBankaAdi.Text = satir["BANKAADI"].ToString();
        }
        void BankaAc(string Id)
        {
            DataRow satir = Banka.Ac(Id);
            txtHesapNo.Text = satir["HESAPNO"].ToString();
            txtBankaAdi.Text = satir["BANKAADI"].ToString();
        }
        private void comDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comDurumu.SelectedIndex == 1)//TAHSIL EDILDI İSE 
            {
                panelKasaSecim.Visible = true;
            }
            else
            {
                panelKasaSecim.Visible = false;

            }
        }
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        OnMuhasebe.BankaModulu.Classlar.clsBankaHareketleri BankaHareketleri = new BankaModulu.Classlar.clsBankaHareketleri();

        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string CekDurumu = "B";
            if (comDurumu.SelectedIndex == 1)
            {
                CekDurumu = "T";//TAHSİL EDİLDİ
            }
            else if (comDurumu.SelectedIndex == 2)
            {
                CekDurumu = "K";//KARŞILIKSIZ
            }
            if (Mesajlar.Sor("İşlemi kaydetmek istediğinizden eminmisiniz?"))
            {
                if (Cekler.CekDurumu(AcilanCekId, CekDurumu))//çekin durumunu tahsil yapıyoruz.
                {

                    if (CekDurumu == "T")//EĞER TAHSİLAT İSE KASAHAREKETİ İŞLİCEZ
                    {
                        //Fisno=Belgeno,
                        //Makbuz No boş olcak
                        //eVRAKTURU=CEK OLCAK
                        //EVRAKID İSE aCİLANCEKID OLCAK
                        //TAHSİL ETTİĞİMİZ İÇİN GCKODU='G' YANİ GİRİŞ OLCAK
                        //TİPİ=B BANKA İŞLEMİ
                        BankaHareketleri.CekTahsilatGirisi(SecilenBankaId, txtNumara.Text, "", Formatlar.IngilizceTarihFormati(DateTime.Now.ToShortDateString()),"G" ,"B",txtTutar.Text, CariKodu, "" + txtCekNo.Text + "- NUMARALI ÇEK TAHSİL EDİLDİ(Vade=" + txtVadeTarihi.Text + ")", frmAnaForm.UserId, "CEK", AcilanCekId);
                    }




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