namespace OnMuhasebe
{
    partial class frmMasaustu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasaustu));
            this.navBarKullanici = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navStokTanitimKarti = new DevExpress.XtraNavBar.NavBarItem();
            this.navStokListesi = new DevExpress.XtraNavBar.NavBarItem();
            this.navStokHareketleri = new DevExpress.XtraNavBar.NavBarItem();
            this.navTopluStokAcma = new DevExpress.XtraNavBar.NavBarItem();
            this.navTopluFiyatGuncelleme = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navCariTanitimKarti = new DevExpress.XtraNavBar.NavBarItem();
            this.navCariListesi = new DevExpress.XtraNavBar.NavBarItem();
            this.navTopluCariAcma = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navSatısFaturasi = new DevExpress.XtraNavBar.NavBarItem();
            this.navSatisİade = new DevExpress.XtraNavBar.NavBarItem();
            this.navAlısFaturasi = new DevExpress.XtraNavBar.NavBarItem();
            this.navAlısİadeFaturasi = new DevExpress.XtraNavBar.NavBarItem();
            this.navKullaniciEkle = new DevExpress.XtraNavBar.NavBarItem();
            this.navKullaniciYetkileri = new DevExpress.XtraNavBar.NavBarItem();
            this.navKullaniciListesi = new DevExpress.XtraNavBar.NavBarItem();
            this.navParolyiDegistir = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem13 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarKullanici)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarKullanici
            // 
            this.navBarKullanici.ActiveGroup = this.navBarGroup1;
            this.navBarKullanici.BackColor = System.Drawing.Color.DimGray;
            this.navBarKullanici.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.navBarKullanici.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarKullanici.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarKullanici.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navStokTanitimKarti,
            this.navStokListesi,
            this.navStokHareketleri,
            this.navTopluStokAcma,
            this.navTopluFiyatGuncelleme,
            this.navCariTanitimKarti,
            this.navCariListesi,
            this.navTopluCariAcma,
            this.navSatısFaturasi,
            this.navSatisİade,
            this.navAlısFaturasi,
            this.navAlısİadeFaturasi,
            this.navBarItem13,
            this.navKullaniciEkle,
            this.navKullaniciYetkileri,
            this.navKullaniciListesi,
            this.navParolyiDegistir});
            this.navBarKullanici.Location = new System.Drawing.Point(0, 0);
            this.navBarKullanici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.navBarKullanici.Name = "navBarKullanici";
            this.navBarKullanici.OptionsNavPane.ExpandedWidth = 218;
            this.navBarKullanici.Size = new System.Drawing.Size(218, 576);
            this.navBarKullanici.TabIndex = 0;
            this.navBarKullanici.Text = "navBarControl1";
            this.navBarKullanici.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("Office 2010 Silver");
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Stok İşlemleri";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navStokTanitimKarti),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navStokListesi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navStokHareketleri),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navTopluStokAcma),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navTopluFiyatGuncelleme)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navStokTanitimKarti
            // 
            this.navStokTanitimKarti.Caption = "Stok Tanıtım Kartı";
            this.navStokTanitimKarti.ImageOptions.LargeImage = global::OnMuhasebe.Properties.Resources.Stok_Kartı32x321;
            this.navStokTanitimKarti.Name = "navStokTanitimKarti";
            this.navStokTanitimKarti.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navStokTanitimKarti_LinkClicked);
            // 
            // navStokListesi
            // 
            this.navStokListesi.Caption = "Stok Listesi";
            this.navStokListesi.ImageOptions.LargeImage = global::OnMuhasebe.Properties.Resources.Stok_Liste32x32;
            this.navStokListesi.Name = "navStokListesi";
            this.navStokListesi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navStokListesi_LinkClicked);
            // 
            // navStokHareketleri
            // 
            this.navStokHareketleri.Caption = "Stok Hareketleri";
            this.navStokHareketleri.ImageOptions.LargeImage = global::OnMuhasebe.Properties.Resources.Stok_Hareket32x32;
            this.navStokHareketleri.Name = "navStokHareketleri";
            this.navStokHareketleri.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navStokHareketleri_LinkClicked);
            // 
            // navTopluStokAcma
            // 
            this.navTopluStokAcma.Caption = "Toplu Stok Açma";
            this.navTopluStokAcma.ImageOptions.LargeImage = global::OnMuhasebe.Properties.Resources.Stok_Grup32x32;
            this.navTopluStokAcma.Name = "navTopluStokAcma";
            this.navTopluStokAcma.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navTopluStokAcma_LinkClicked);
            // 
            // navTopluFiyatGuncelleme
            // 
            this.navTopluFiyatGuncelleme.Caption = "Toplu Fiyat Güncelleme";
            this.navTopluFiyatGuncelleme.ImageOptions.LargeImage = global::OnMuhasebe.Properties.Resources.Banka_Hareket32x32;
            this.navTopluFiyatGuncelleme.Name = "navTopluFiyatGuncelleme";
            this.navTopluFiyatGuncelleme.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navTopluFiyatGuncelleme_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Cari İşlemleri";
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCariTanitimKarti),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCariListesi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navTopluCariAcma)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navCariTanitimKarti
            // 
            this.navCariTanitimKarti.Caption = "Cari Tanıtım Kartı";
            this.navCariTanitimKarti.ImageOptions.LargeImage = global::OnMuhasebe.Properties.Resources.Cari_Kart32x32;
            this.navCariTanitimKarti.Name = "navCariTanitimKarti";
            this.navCariTanitimKarti.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navCariTanitimKarti_LinkClicked);
            // 
            // navCariListesi
            // 
            this.navCariListesi.Caption = "Cari Listesi";
            this.navCariListesi.ImageOptions.LargeImage = global::OnMuhasebe.Properties.Resources.Cari_Liste32x32;
            this.navCariListesi.Name = "navCariListesi";
            this.navCariListesi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navCariListesi_LinkClicked);
            // 
            // navTopluCariAcma
            // 
            this.navTopluCariAcma.Caption = "Toplu Cari Açma";
            this.navTopluCariAcma.ImageOptions.LargeImage = global::OnMuhasebe.Properties.Resources.Cari_Grup32x32;
            this.navTopluCariAcma.Name = "navTopluCariAcma";
            this.navTopluCariAcma.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navTopluCariAcma_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Fatura İşlemleri";
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navSatısFaturasi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navSatisİade),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navAlısFaturasi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navAlısİadeFaturasi)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navSatısFaturasi
            // 
            this.navSatısFaturasi.Caption = "Satış Faturası";
            this.navSatısFaturasi.ImageOptions.LargeImage = global::OnMuhasebe.Properties.Resources.Fatura_Satis32x32;
            this.navSatısFaturasi.Name = "navSatısFaturasi";
            this.navSatısFaturasi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navSatısFaturasi_LinkClicked);
            // 
            // navSatisİade
            // 
            this.navSatisİade.Caption = "Satış İade Faturası";
            this.navSatisİade.ImageOptions.LargeImage = global::OnMuhasebe.Properties.Resources.Fatura_SatisIade32x32;
            this.navSatisİade.Name = "navSatisİade";
            this.navSatisİade.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navSatisİade_LinkClicked);
            // 
            // navAlısFaturasi
            // 
            this.navAlısFaturasi.Caption = "Alış Faturası";
            this.navAlısFaturasi.ImageOptions.LargeImage = global::OnMuhasebe.Properties.Resources.Fatura_Alis32x32;
            this.navAlısFaturasi.Name = "navAlısFaturasi";
            this.navAlısFaturasi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navAlısFaturasi_LinkClicked);
            // 
            // navAlısİadeFaturasi
            // 
            this.navAlısİadeFaturasi.Caption = "Alış İade Faturası";
            this.navAlısİadeFaturasi.ImageOptions.LargeImage = global::OnMuhasebe.Properties.Resources.Fatura_AlisIade32x32;
            this.navAlısİadeFaturasi.Name = "navAlısİadeFaturasi";
            this.navAlısİadeFaturasi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navAlısİadeFaturasi_LinkClicked);
            // 
            // navKullaniciEkle
            // 
            this.navKullaniciEkle.Caption = "Kullanıcı Ekle";
            this.navKullaniciEkle.ImageOptions.LargeImage = global::OnMuhasebe.Properties.Resources.Banka_Hareket32x32;
            this.navKullaniciEkle.Name = "navKullaniciEkle";
            this.navKullaniciEkle.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navKullaniciEkle_LinkClicked);
            // 
            // navKullaniciYetkileri
            // 
            this.navKullaniciYetkileri.Caption = "Kullanıcı Yetkileri";
            this.navKullaniciYetkileri.Name = "navKullaniciYetkileri";
            this.navKullaniciYetkileri.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navKullaniciYetkileri_LinkClicked);
            // 
            // navKullaniciListesi
            // 
            this.navKullaniciListesi.Caption = "Kullanıcı Listesi";
            this.navKullaniciListesi.Name = "navKullaniciListesi";
            this.navKullaniciListesi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navKullaniciListesi_LinkClicked);
            // 
            // navParolyiDegistir
            // 
            this.navParolyiDegistir.Caption = "Parolayı Değiştir";
            this.navParolyiDegistir.Name = "navParolyiDegistir";
            this.navParolyiDegistir.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navParolyiDegistir_LinkClicked);
            // 
            // navBarItem13
            // 
            this.navBarItem13.Caption = "navBarItem13";
            this.navBarItem13.Name = "navBarItem13";
            // 
            // frmMasaustu
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1190, 576);
            this.Controls.Add(this.navBarKullanici);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMasaustu";
            this.Text = "Muhasebe Programı";
            this.Load += new System.EventHandler(this.frmMasaustu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarKullanici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarKullanici;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navStokTanitimKarti;
        private DevExpress.XtraNavBar.NavBarItem navStokListesi;
        private DevExpress.XtraNavBar.NavBarItem navStokHareketleri;
        private DevExpress.XtraNavBar.NavBarItem navTopluStokAcma;
        private DevExpress.XtraNavBar.NavBarItem navTopluFiyatGuncelleme;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navCariTanitimKarti;
        private DevExpress.XtraNavBar.NavBarItem navCariListesi;
        private DevExpress.XtraNavBar.NavBarItem navTopluCariAcma;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navSatısFaturasi;
        private DevExpress.XtraNavBar.NavBarItem navSatisİade;
        private DevExpress.XtraNavBar.NavBarItem navAlısFaturasi;
        private DevExpress.XtraNavBar.NavBarItem navAlısİadeFaturasi;
        private DevExpress.XtraNavBar.NavBarItem navBarItem13;
        private DevExpress.XtraNavBar.NavBarItem navKullaniciEkle;
        private DevExpress.XtraNavBar.NavBarItem navKullaniciYetkileri;
        private DevExpress.XtraNavBar.NavBarItem navKullaniciListesi;
        private DevExpress.XtraNavBar.NavBarItem navParolyiDegistir;
    }
}