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

namespace OnMuhasebe
{
    public partial class frmMasaustu : DevExpress.XtraEditors.XtraForm
    {
        public frmMasaustu()
        {
            InitializeComponent();
        }

        OnMuhasebe.Classlar.Ekranlar Ekranlar = new Classlar.Ekranlar();

        private void frmMasaustu_Load(object sender, EventArgs e)
        {
            YetkileriUygula();
            
        }

        void YetkileriUygula()
        {

            if (frmAnaForm.AdminMi == "0")//admin değilse 
            {
                navBarKullanici.Visible = false;//admin değilse kullanıcı navbarı göremeyecek
            }



      
        }

        private void navStokTanitimKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Ekranlar.StokTanitimKartiAc();
        }

        private void navStokListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Ekranlar.StokListesi();
        }

        private void navStokHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Ekranlar.StokHareketKayitlari();
        }

        private void navTopluStokAcma_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Ekranlar.TopluStokAcma();
        }

        private void navTopluFiyatGuncelleme_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Ekranlar.TopluStokGuncelleme();
        }

        private void navCariTanitimKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Ekranlar.CariTanitimKartiAc();
        }

        private void navCariListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Ekranlar.CariListesiAc();
        }

        private void navTopluCariAcma_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Ekranlar.CariTanitimKartiAc();
        }

        private void navSatısFaturasi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Ekranlar.SatisFaturasiAc();
        }

        private void navSatisİade_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Ekranlar.SatisIadeFaturasiAc();
        }

        private void navAlısFaturasi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Ekranlar.AlisFaturasiAc();
        }

        private void navAlısİadeFaturasi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Ekranlar.AlisIadeFaturasiAc();
        }

        private void navKullaniciEkle_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Ekranlar.KullaniciEkle();
        }

        private void navKullaniciYetkileri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Ekranlar.KullaniciYetkileri();
        }

        private void navKullaniciListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Ekranlar.KullaniciListesi();
        }

        private void navParolyiDegistir_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Ekranlar.ParolaDegistir();
        }
    }
}