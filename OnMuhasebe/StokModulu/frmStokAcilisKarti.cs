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

namespace OnMuhasebe.StokModulu
{
    public partial class frmStokAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmStokAcilisKarti()
        {
            InitializeComponent();
        }
        Classlar.clsStokHareketleri Hareketler = new Classlar.clsStokHareketleri();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        Classlar.clsStokTanitimKarti Stok = new Classlar.clsStokTanitimKarti();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        Boolean Edit = false;
        string UrunId;
        string StokGirisKdv, StokCikisKdv;
        string AcilanId = "-1";



        //load da değilde Ac metodunda form açılırkenki gösterimleri yapıyoruz
        public void Ac(string Id)
        {
            AcilanId = Id;
            DataRow Satir = Hareketler.StokAcilisKartiAc(Id);
            txtBelgeNo.Text = Satir["FATURANO"].ToString();
            txtFiyat.Text = Convert.ToDecimal(Satir["BIRIMFIYAT"].ToString()).ToString("0.00");//virülden sonra iki basamk
            txtMiktar.Text = Satir["MIKTAR"].ToString();
            txtStokAdi.Text = Satir["STOKADI"].ToString();
            txtStokKodu.Text = Satir["STOKKODU"].ToString();
            txtTarih.Text = Convert.ToDateTime(Satir["TARIH"].ToString()).ToShortDateString();

            StokGirisKdv = Satir["KDV"].ToString();
            StokCikisKdv = Satir["KDV"].ToString();


            string GcKodu = Satir["GCKOD"].ToString();


            if (GcKodu == "G")
            {
                raGiris.Checked = true;
            }
            else
            {
                raCikis.Checked = true;
            }

            Edit = true;
        }
        private void btnStokSec_Click(object sender, EventArgs e)
        {
            UrunId = Ekranlar.StokListesi(true);
            if (UrunId == "")
            {
                return;
            }
            DataRow Satir = Stok.Ac(UrunId);//stok listesinden gelen id yi alıyoruz ve o idye ait stok satırını getiriyoruz

            txtStokKodu.Text = Satir["STOKKODU"].ToString();
            txtStokAdi.Text = Satir["STOKADI"].ToString();
            StokGirisKdv = Satir["ALISKDV"].ToString();
            StokCikisKdv = Satir["SATISKDV"].ToString();
        }

        private void frmStokAcilisKarti_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (txtBelgeNo.Text != "")
            {
                if (Mesajlar.Sor("İşlemi iptal etmek istediğinizden emin misiniz?") == true)
                {
                    this.Close();
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string GCKODU, Kdv;
            if (raCikis.Checked == true)
            {
                GCKODU = "C";
                Kdv = StokCikisKdv;


            }
            else
            {
                GCKODU = "G";
                Kdv = StokGirisKdv;
            }


            if (Edit == true)//güncelleme
            {
                bool durum = Hareketler.StokAcilisKartiGuncelle(AcilanId, txtBelgeNo.Text, txtStokKodu.Text, GCKODU, txtMiktar.Text, txtFiyat.Text, Kdv, txtTarih.EditValue.ToString());

                if (durum)
                {
                    MessageBox.Show("Açılış Kartı Başarılı bir şekilde güncellenmiştir");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("HATA");
                }

            }
            else
            {


                bool durum = Hareketler.StokAcilisKarti(txtBelgeNo.Text, txtStokKodu.Text, GCKODU, txtMiktar.Text, txtFiyat.Text, Kdv, txtTarih.EditValue.ToString());
                if (durum)
                {
                    MessageBox.Show("Açılış Kartı Başarılı bir şekilde kaydedilmiştir");
                }
                else
                {
                    MessageBox.Show("HATA");
                }
            }
            

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtBelgeNo.Text!="")
            {
                if (Mesajlar.Sor("Yeni Açılış Kartı açmak istediğinizden emin misiniz?")==true)
                {
                    Yeni();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sor("Stok Açılış Kartını silmek istediğinizden emin misiniz?") == true)
            {
                if (Hareketler.StokAcilisKartiSil(AcilanId) == true)
                {
                    Mesajlar.Bilgi("Stok Açılış kartı başarılı bir şekilde silinmiştir!");
                    this.Close();
                }
                else
                {
                    Mesajlar.Hata();
                }
            }
        }

        void Yeni()
        {
            txtBelgeNo.Text = "";
            txtFiyat.Text = "";
            txtMiktar.Text = "";
            txtStokAdi.Text = "";
            txtStokKodu.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            Edit = false;
            txtBelgeNo.Focus();
        }
    }
}