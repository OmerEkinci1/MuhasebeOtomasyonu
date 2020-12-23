namespace OnMuhasebe.BankaModulu
{
    partial class frmBankaListesi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankaListesi));
            this.BANKAADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESAPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtBanka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtIban = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapno = new DevExpress.XtraEditors.TextEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESAPADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SUBE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ILGILI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.SagMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SagEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.SagGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.SagSil = new System.Windows.Forms.ToolStripMenuItem();
            this.SagHareketler = new System.Windows.Forms.ToolStripMenuItem();
            this.bankaAçılışKartıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankaİşlemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelenHavaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gönderilenHavaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtIlgili = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSube = new DevExpress.XtraEditors.TextEdit();
            this.txtHesapAdi = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SagMenu.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlgili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BANKAADI
            // 
            this.BANKAADI.Caption = "BANKA";
            this.BANKAADI.FieldName = "BANKAADI";
            this.BANKAADI.MinWidth = 23;
            this.BANKAADI.Name = "BANKAADI";
            this.BANKAADI.OptionsColumn.AllowEdit = false;
            this.BANKAADI.OptionsColumn.AllowFocus = false;
            this.BANKAADI.Visible = true;
            this.BANKAADI.VisibleIndex = 2;
            this.BANKAADI.Width = 292;
            // 
            // HESAPNO
            // 
            this.HESAPNO.Caption = "HESAP NO";
            this.HESAPNO.FieldName = "HESAPNO";
            this.HESAPNO.MinWidth = 23;
            this.HESAPNO.Name = "HESAPNO";
            this.HESAPNO.OptionsColumn.AllowEdit = false;
            this.HESAPNO.OptionsColumn.AllowFocus = false;
            this.HESAPNO.OptionsColumn.FixedWidth = true;
            this.HESAPNO.Visible = true;
            this.HESAPNO.VisibleIndex = 0;
            this.HESAPNO.Width = 175;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 23;
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.AllowShowHide = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.Width = 87;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 144);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 16);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "BANKA Adı";
            // 
            // txtBanka
            // 
            this.txtBanka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBanka.Location = new System.Drawing.Point(13, 167);
            this.txtBanka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBanka.Name = "txtBanka";
            this.txtBanka.Size = new System.Drawing.Size(274, 22);
            this.txtBanka.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 90);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "IBAN";
            // 
            // txtIban
            // 
            this.txtIban.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIban.Location = new System.Drawing.Point(13, 113);
            this.txtIban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(274, 22);
            this.txtIban.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 22);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Hesap Numarası";
            // 
            // txtHesapno
            // 
            this.txtHesapno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHesapno.Location = new System.Drawing.Point(13, 46);
            this.txtHesapno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHesapno.Name = "txtHesapno";
            this.txtHesapno.Size = new System.Drawing.Size(274, 22);
            this.txtHesapno.TabIndex = 1;
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(110, 382);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(104, 38);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.HESAPNO,
            this.IBAN,
            this.BANKAADI,
            this.HESAPADI,
            this.SUBE,
            this.ILGILI});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // IBAN
            // 
            this.IBAN.Caption = "IBAN";
            this.IBAN.FieldName = "IBAN";
            this.IBAN.MinWidth = 23;
            this.IBAN.Name = "IBAN";
            this.IBAN.OptionsColumn.AllowEdit = false;
            this.IBAN.OptionsColumn.AllowFocus = false;
            this.IBAN.OptionsColumn.FixedWidth = true;
            this.IBAN.Visible = true;
            this.IBAN.VisibleIndex = 1;
            this.IBAN.Width = 350;
            // 
            // HESAPADI
            // 
            this.HESAPADI.Caption = "HESAP ADI";
            this.HESAPADI.FieldName = "HESAPADI";
            this.HESAPADI.MinWidth = 23;
            this.HESAPADI.Name = "HESAPADI";
            this.HESAPADI.OptionsColumn.AllowEdit = false;
            this.HESAPADI.OptionsColumn.AllowFocus = false;
            this.HESAPADI.OptionsColumn.FixedWidth = true;
            this.HESAPADI.Visible = true;
            this.HESAPADI.VisibleIndex = 3;
            this.HESAPADI.Width = 87;
            // 
            // SUBE
            // 
            this.SUBE.Caption = "ŞUBE";
            this.SUBE.FieldName = "SUBE";
            this.SUBE.MinWidth = 23;
            this.SUBE.Name = "SUBE";
            this.SUBE.OptionsColumn.AllowEdit = false;
            this.SUBE.OptionsColumn.AllowFocus = false;
            this.SUBE.OptionsColumn.FixedWidth = true;
            this.SUBE.Visible = true;
            this.SUBE.VisibleIndex = 4;
            this.SUBE.Width = 87;
            // 
            // ILGILI
            // 
            this.ILGILI.Caption = "İLGİLİ KİŞİ";
            this.ILGILI.FieldName = "ILGILI";
            this.ILGILI.MinWidth = 23;
            this.ILGILI.Name = "ILGILI";
            this.ILGILI.OptionsColumn.AllowEdit = false;
            this.ILGILI.OptionsColumn.AllowFocus = false;
            this.ILGILI.OptionsColumn.FixedWidth = true;
            this.ILGILI.Visible = true;
            this.ILGILI.VisibleIndex = 5;
            this.ILGILI.Width = 87;
            // 
            // Liste
            // 
            this.Liste.ContextMenuStrip = this.SagMenu;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(827, 553);
            this.Liste.TabIndex = 1;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // SagMenu
            // 
            this.SagMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SagMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SagEkle,
            this.SagGuncelle,
            this.SagSil,
            this.SagHareketler,
            this.bankaAçılışKartıToolStripMenuItem,
            this.bankaİşlemiToolStripMenuItem,
            this.gelenHavaleToolStripMenuItem,
            this.gönderilenHavaleToolStripMenuItem});
            this.SagMenu.Name = "SagMenu";
            this.SagMenu.Size = new System.Drawing.Size(233, 196);
            // 
            // SagEkle
            // 
            this.SagEkle.Name = "SagEkle";
            this.SagEkle.Size = new System.Drawing.Size(232, 24);
            this.SagEkle.Text = "Ekle";
            this.SagEkle.Click += new System.EventHandler(this.SagEkle_Click);
            // 
            // SagGuncelle
            // 
            this.SagGuncelle.Name = "SagGuncelle";
            this.SagGuncelle.Size = new System.Drawing.Size(232, 24);
            this.SagGuncelle.Text = "Güncelle";
            this.SagGuncelle.Click += new System.EventHandler(this.SagGuncelle_Click);
            // 
            // SagSil
            // 
            this.SagSil.Name = "SagSil";
            this.SagSil.Size = new System.Drawing.Size(232, 24);
            this.SagSil.Text = "Sil";
            this.SagSil.Click += new System.EventHandler(this.SagSil_Click);
            // 
            // SagHareketler
            // 
            this.SagHareketler.Name = "SagHareketler";
            this.SagHareketler.Size = new System.Drawing.Size(232, 24);
            this.SagHareketler.Text = "Banka Hareket Kayıtları";
            this.SagHareketler.Click += new System.EventHandler(this.SagHareketler_Click);
            // 
            // bankaAçılışKartıToolStripMenuItem
            // 
            this.bankaAçılışKartıToolStripMenuItem.Name = "bankaAçılışKartıToolStripMenuItem";
            this.bankaAçılışKartıToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.bankaAçılışKartıToolStripMenuItem.Text = "Banka Açılış Kartı";
            this.bankaAçılışKartıToolStripMenuItem.Click += new System.EventHandler(this.bankaAçılışKartıToolStripMenuItem_Click);
            // 
            // bankaİşlemiToolStripMenuItem
            // 
            this.bankaİşlemiToolStripMenuItem.Name = "bankaİşlemiToolStripMenuItem";
            this.bankaİşlemiToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.bankaİşlemiToolStripMenuItem.Text = "Banka İşlemi";
            this.bankaİşlemiToolStripMenuItem.Click += new System.EventHandler(this.bankaİşlemiToolStripMenuItem_Click);
            // 
            // gelenHavaleToolStripMenuItem
            // 
            this.gelenHavaleToolStripMenuItem.Name = "gelenHavaleToolStripMenuItem";
            this.gelenHavaleToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.gelenHavaleToolStripMenuItem.Text = "Gelen Havale";
            this.gelenHavaleToolStripMenuItem.Click += new System.EventHandler(this.gelenHavaleToolStripMenuItem_Click);
            // 
            // gönderilenHavaleToolStripMenuItem
            // 
            this.gönderilenHavaleToolStripMenuItem.Name = "gönderilenHavaleToolStripMenuItem";
            this.gönderilenHavaleToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.gönderilenHavaleToolStripMenuItem.Text = "Gönderilen Havale";
            this.gönderilenHavaleToolStripMenuItem.Click += new System.EventHandler(this.gönderilenHavaleToolStripMenuItem_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.Ac;
            this.btnAra.Location = new System.Drawing.Point(15, 382);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(87, 38);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Arama";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.txtIlgili);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtSube);
            this.xtraTabPage1.Controls.Add(this.txtHesapAdi);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.txtBanka);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtIban);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtHesapno);
            this.xtraTabPage1.Controls.Add(this.btnTemizle);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(295, 519);
            this.xtraTabPage1.Text = "Arama";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 318);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(23, 16);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "İlgili";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 262);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 16);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Şube";
            // 
            // txtIlgili
            // 
            this.txtIlgili.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIlgili.Location = new System.Drawing.Point(13, 341);
            this.txtIlgili.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIlgili.Name = "txtIlgili";
            this.txtIlgili.Size = new System.Drawing.Size(274, 22);
            this.txtIlgili.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 212);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 16);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Hesap Adı";
            // 
            // txtSube
            // 
            this.txtSube.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSube.Location = new System.Drawing.Point(13, 286);
            this.txtSube.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSube.Name = "txtSube";
            this.txtSube.Size = new System.Drawing.Size(274, 22);
            this.txtSube.TabIndex = 5;
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHesapAdi.Location = new System.Drawing.Point(13, 235);
            this.txtHesapAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHesapAdi.Name = "txtHesapAdi";
            this.txtHesapAdi.Size = new System.Drawing.Size(274, 22);
            this.txtHesapAdi.TabIndex = 4;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(302, 553);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Collapsed = true;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1135, 553);
            this.splitContainerControl1.SplitterPosition = 302;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // frmBankaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 553);
            this.Controls.Add(this.splitContainerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBankaListesi";
            this.Text = "Banka Listesi";
            this.Load += new System.EventHandler(this.frmBankaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBanka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.SagMenu.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlgili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn BANKAADI;
        private DevExpress.XtraGrid.Columns.GridColumn HESAPNO;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtBanka;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtIban;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtHesapno;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IBAN;
        private DevExpress.XtraGrid.GridControl Liste;
        private System.Windows.Forms.ContextMenuStrip SagMenu;
        private System.Windows.Forms.ToolStripMenuItem SagEkle;
        private System.Windows.Forms.ToolStripMenuItem SagGuncelle;
        private System.Windows.Forms.ToolStripMenuItem SagSil;
        private System.Windows.Forms.ToolStripMenuItem SagHareketler;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtIlgili;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSube;
        private DevExpress.XtraEditors.TextEdit txtHesapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn HESAPADI;
        private DevExpress.XtraGrid.Columns.GridColumn SUBE;
        private DevExpress.XtraGrid.Columns.GridColumn ILGILI;
        private System.Windows.Forms.ToolStripMenuItem bankaAçılışKartıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankaİşlemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelenHavaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gönderilenHavaleToolStripMenuItem;
    }
}