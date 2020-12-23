using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Diagnostics;

namespace OnMuhasebe
{
    public partial class frmAnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }

        /*
         TEMEL ERİŞİM DEĞİŞKENLERİ
       
         */

        public static Boolean GirisDurumu = false;

        public static string AraDegiskenString;//heryerden erişebilmek için static yaptık.bu değişken formlar arası veri transferinde kullanılmak için kullandık

        public static string UserId = "-1";

        public static string UserName = "-1";

        public static string AdminMi = "0";

        //static değişken artık tüm formlardan erişilebilen Yetkilerimiz var.bu yetkileri kullanarak formu açtırıp açtırmama işlemleri yapıcaz.
        public static YetkiYapisiListesi KullaniciYetkileri = new YetkiYapisiListesi();//struct


        OnMuhasebe.KullaniciModulu.clsYetkiler Yetkiler = new KullaniciModulu.clsYetkiler();

        /*
          TEMEL ERİŞİM DEĞİŞKENLERİ
         
         */


        public static Boolean ErisimBilgisiHatasi = false;

        OnMuhasebe.Classlar.Ekranlar Ekranlar = new Classlar.Ekranlar();

        private void barStokTanitimKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.StokTanitimKartiAc();
        }

        private void barCariTanitimKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.CariTanitimKartiAc();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {
            // Ekranlar.CariListesiAc();
        }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            GirisIslemi();
                        this.barUser.Caption = UserName.ToString();

            frmMasaustu frm = new frmMasaustu();
            frm.MdiParent = this;//mdi olarak formu açtık
            frm.Show();
        }


        void GirisIslemi()
        {
            frmGirisFormu Giris = new frmGirisFormu();
            Giris.ShowDialog();
            if (GirisDurumu == false)
            {
                //MessageBox.Show("Giriş Yok");
                Application.Exit();
            }
            else
            {

                KullaniciYetkileri = Yetkiler.YetkileriOku(frmAnaForm.UserId.ToString());
                YetkileriUygula();

                //MessageBox.Show("Giriş Yapıldı");
                this.Opacity = 100;//yüzde yüz şekilde görüntülensin
                this.Show();
            }
        }


        //Yetkiye göre menüyü enable yapıp yapmayacağımızı yazdık
        void YetkileriUygula()
        {

            if (AdminMi == "0")//admin değilse 
            {
                pageKullanici.Visible = false;//admin değilse kullanıcı page ni göremeyecek
            }



            //Yetkiye göre menüyü enable yapıp yapmayacağımızı yazdık
            barStokTanitimKarti.Enabled = KullaniciYetkileri.STOKEKLE;
            barstokTanitimkarti1.Enabled = KullaniciYetkileri.STOKEKLE;

            barButtonItem3.Enabled = KullaniciYetkileri.STOKLISTE;//stok listesi
        }


        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }

        private void barSatisFaturasi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.SatisFaturasiAc();
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.CariHareketKayitlari(false);
        }

        private void barCariAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.CariAcilisKarti();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.StokHareketKayitlari();
        }

        private void barStokAciliskarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.StokAcilisKarti();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.StokListesi(false);
        }

        private void barTopluStokAcma_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.TopluStokAcma();
        }

        private void barTopluStokGuncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.TopluStokGuncelleme();
        }

        private void barKasaTanitimKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.KasaTanitimKarti();
        }

        private void barKasaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.KasaListesi(false);
        }

        private void barKasaHareket_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.KasaHareketleri();
        }

        private void barKasaAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.KasaAcilisKarti();
        }

        private void barTahsilatGirisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.KasaTahsilatGirisi();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.KasaOdemeGirisi();
        }

        private void barBankaTanitimKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.BankaTanitimKarti();
        }

        private void barBankaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.BankaListesi();
        }

        private void barBankaAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.BankaAcilisKarti();
        }

        private void barBankaHareketKayitlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.BankaHareketKayitlari();
        }

        private void barBankaIslemi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.BankaIslemi();
        }

        private void barGelenHavale_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.GelenHavale();
        }

        private void barGonderilenHavale_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.GonderilenHavale();
        }

        private void barMusteriCekGirisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.MusteriCekGirisi();
        }

        private void barMusteriBordroGirisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.MusteriCekBordroGirisi();
        }

        private void barBordroListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.CekBordroListesi();
        }

        private void barMusteriCekListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.MusteriCekListesi();
        }

        private void barBankayaCekCikisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.BankayaCekCikisi();
        }

        private void barCariyeCekCikisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.CariyeCekCikisi();
        }

        private void barKendiCekimiz_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.KendiCekGirisi(false);
        }

        private void barKendiCekListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.KendiCekListesi();
        }

        private void barSatisIadeFaturasi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.SatisIadeFaturasiAc();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.AlisFaturasiAc();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.CariListesiAc(false);
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.AlisIadeFaturasiAc();
        }

        private void barStokHareketRaporu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.RaporStokHareket();
        }

        private void barCariStokHareketRaporu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.RaporCariStokHareket();
        }

        private void barTarihAraligiStokHareket_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.RaporTarihAraligiStokHareket();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.RaporCariHareket();
        }

        private void barCariStokHareketRaporu1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.RaporCariStokHareket();
        }

        private void barOzelCariRaporu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.Rapor_OzelCariRaporu();
        }

        private void barSatisIadeFaturasiListesi1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.SatisIadeFaturasiListesi(false);
        }

        private void barSatisFaturasiListesi1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.SatisFaturasiListesi(false);
        }

        private void barAlisFaturasiListesi1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.AlisFaturasiListesi(false);
        }

        private void barAlisIadeFaturasiListesi1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.AlisIadeFaturasiListesi(false);
        }

        private void barKod1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.StokKod1Ac(false);
        }

        private void barKod2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.StokKod2Ac(false);
        }

        private void barKod3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.StokKod3Ac(false);
        }

        private void barKod4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.StokKod4Ac(false);
        }

        private void barKod5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.StokKod5Ac(false);
        }

        private void barKullaniciEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.KullaniciEkle();
        }

        private void barKullaniciListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.KullaniciListesi(false);
        }

        private void barkullaniciyetkiler_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.KullaniciYetkileri();
        }

        private void barParoladegistir_ItemClick(object sender, ItemClickEventArgs e)
        {
            Ekranlar.ParolaDegistir();
        }

        private void barexcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("excel");//exceli açar
        }

        private void barword_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("winword");
        }

        private void barHesapmakinesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("calc");
        }

        private void barnotdefteri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("notepad");
        }

        private void barPaint_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("mspaint");
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("https://eleksa.com.tr");
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("calc");
        }

        public void cikissorusu()
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                Form.ActiveForm.Close();
            }
        }
        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            cikissorusu();
        }

        

        private void barNow_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
