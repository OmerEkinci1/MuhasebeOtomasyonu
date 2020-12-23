namespace OnMuhasebe.CekSenetModulu.Cek
{
    partial class frmKendiCekListesi
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue4 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKendiCekListesi));
            this.YERI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VADETARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ASILBORCLU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VERILENBANKAISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new DevExpress.XtraEditors.TextEdit();
            this.txtVadeTarihi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtVerilenBanka = new DevExpress.XtraEditors.TextEdit();
            this.VERILENCARIISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DURUMU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CEKNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YERI_ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.SagMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SagCekGirisi = new System.Windows.Forms.ToolStripMenuItem();
            this.SagGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.SagSil = new System.Windows.Forms.ToolStripMenuItem();
            this.SagCekiBankayaCik = new System.Windows.Forms.ToolStripMenuItem();
            this.SagCekiCariyeCik = new System.Windows.Forms.ToolStripMenuItem();
            this.SagCekiBankadanIadeAl = new System.Windows.Forms.ToolStripMenuItem();
            this.SagCekiCaridenIadeAl = new System.Windows.Forms.ToolStripMenuItem();
            this.SagCekinDurumu = new System.Windows.Forms.ToolStripMenuItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtVerilenCari = new DevExpress.XtraEditors.TextEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDurum = new DevExpress.XtraEditors.TextEdit();
            this.txtTarih = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtBelgeNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekNo = new DevExpress.XtraEditors.TextEdit();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVadeTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVerilenBanka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SagMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVerilenCari.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // YERI
            // 
            this.YERI.Caption = "YERI";
            this.YERI.FieldName = "YERI";
            this.YERI.MinWidth = 23;
            this.YERI.Name = "YERI";
            this.YERI.OptionsColumn.AllowEdit = false;
            this.YERI.OptionsColumn.AllowFocus = false;
            this.YERI.OptionsColumn.AllowShowHide = false;
            this.YERI.OptionsColumn.FixedWidth = true;
            this.YERI.OptionsColumn.ReadOnly = true;
            this.YERI.Width = 87;
            // 
            // VADETARIHI
            // 
            this.VADETARIHI.Caption = "VADETARIHI";
            this.VADETARIHI.FieldName = "VADETARIHI";
            this.VADETARIHI.MinWidth = 23;
            this.VADETARIHI.Name = "VADETARIHI";
            this.VADETARIHI.OptionsColumn.AllowEdit = false;
            this.VADETARIHI.OptionsColumn.AllowFocus = false;
            this.VADETARIHI.OptionsColumn.FixedWidth = true;
            this.VADETARIHI.OptionsColumn.ReadOnly = true;
            this.VADETARIHI.Visible = true;
            this.VADETARIHI.VisibleIndex = 6;
            this.VADETARIHI.Width = 140;
            // 
            // ASILBORCLU
            // 
            this.ASILBORCLU.Caption = "ASIL BORÇLU";
            this.ASILBORCLU.FieldName = "ASILBORCLU";
            this.ASILBORCLU.MinWidth = 23;
            this.ASILBORCLU.Name = "ASILBORCLU";
            this.ASILBORCLU.OptionsColumn.AllowEdit = false;
            this.ASILBORCLU.OptionsColumn.AllowFocus = false;
            this.ASILBORCLU.OptionsColumn.FixedWidth = true;
            this.ASILBORCLU.OptionsColumn.ReadOnly = true;
            this.ASILBORCLU.Visible = true;
            this.ASILBORCLU.VisibleIndex = 4;
            this.ASILBORCLU.Width = 87;
            // 
            // VERILENBANKAISIM
            // 
            this.VERILENBANKAISIM.Caption = "VERİLEN BANKA";
            this.VERILENBANKAISIM.FieldName = "VERILENBANKAISIM";
            this.VERILENBANKAISIM.MinWidth = 23;
            this.VERILENBANKAISIM.Name = "VERILENBANKAISIM";
            this.VERILENBANKAISIM.OptionsColumn.AllowEdit = false;
            this.VERILENBANKAISIM.OptionsColumn.AllowFocus = false;
            this.VERILENBANKAISIM.OptionsColumn.ReadOnly = true;
            this.VERILENBANKAISIM.Visible = true;
            this.VERILENBANKAISIM.VisibleIndex = 3;
            this.VERILENBANKAISIM.Width = 350;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 377);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 16);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Açıklama";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 304);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 16);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Vade Tarihi";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAciklama.Location = new System.Drawing.Point(13, 400);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(274, 22);
            this.txtAciklama.TabIndex = 4;
            // 
            // txtVadeTarihi
            // 
            this.txtVadeTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVadeTarihi.Location = new System.Drawing.Point(13, 327);
            this.txtVadeTarihi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVadeTarihi.Name = "txtVadeTarihi";
            this.txtVadeTarihi.Size = new System.Drawing.Size(274, 22);
            this.txtVadeTarihi.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 188);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(78, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Verilen Banka";
            // 
            // txtVerilenBanka
            // 
            this.txtVerilenBanka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVerilenBanka.Location = new System.Drawing.Point(13, 212);
            this.txtVerilenBanka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVerilenBanka.Name = "txtVerilenBanka";
            this.txtVerilenBanka.Size = new System.Drawing.Size(274, 22);
            this.txtVerilenBanka.TabIndex = 1;
            // 
            // VERILENCARIISIM
            // 
            this.VERILENCARIISIM.Caption = "VERILEN CARİ";
            this.VERILENCARIISIM.FieldName = "VERILENCARIISIM";
            this.VERILENCARIISIM.MinWidth = 23;
            this.VERILENCARIISIM.Name = "VERILENCARIISIM";
            this.VERILENCARIISIM.OptionsColumn.AllowEdit = false;
            this.VERILENCARIISIM.OptionsColumn.AllowFocus = false;
            this.VERILENCARIISIM.OptionsColumn.FixedWidth = true;
            this.VERILENCARIISIM.OptionsColumn.ReadOnly = true;
            this.VERILENCARIISIM.Visible = true;
            this.VERILENCARIISIM.VisibleIndex = 2;
            this.VERILENCARIISIM.Width = 175;
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
            this.ID.OptionsColumn.ReadOnly = true;
            this.ID.Width = 87;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.VERILENCARIISIM,
            this.VERILENBANKAISIM,
            this.ASILBORCLU,
            this.TARIH,
            this.VADETARIHI,
            this.ACIKLAMA,
            this.TUTAR,
            this.DURUMU,
            this.BELGENO,
            this.CEKNO,
            this.YERI,
            this.YERI_ACIKLAMA});
            this.gridView1.DetailHeight = 431;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Column = this.YERI;
            gridFormatRule3.Name = "Format0";
            formatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleValue3.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue3.Value1 = "B";
            gridFormatRule3.Rule = formatConditionRuleValue3;
            gridFormatRule4.ApplyToRow = true;
            gridFormatRule4.Column = this.YERI;
            gridFormatRule4.Name = "Format1";
            formatConditionRuleValue4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleValue4.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue4.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue4.Value1 = "C";
            gridFormatRule4.Rule = formatConditionRuleValue4;
            this.gridView1.FormatRules.Add(gridFormatRule3);
            this.gridView1.FormatRules.Add(gridFormatRule4);
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // TARIH
            // 
            this.TARIH.Caption = "TARIH";
            this.TARIH.FieldName = "TARIH";
            this.TARIH.MinWidth = 23;
            this.TARIH.Name = "TARIH";
            this.TARIH.OptionsColumn.AllowEdit = false;
            this.TARIH.OptionsColumn.AllowFocus = false;
            this.TARIH.OptionsColumn.FixedWidth = true;
            this.TARIH.OptionsColumn.ReadOnly = true;
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 5;
            this.TARIH.Width = 87;
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "ACIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.MinWidth = 23;
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.ACIKLAMA.OptionsColumn.FixedWidth = true;
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 9;
            this.ACIKLAMA.Width = 87;
            // 
            // TUTAR
            // 
            this.TUTAR.Caption = "TUTAR";
            this.TUTAR.FieldName = "TUTAR";
            this.TUTAR.MinWidth = 23;
            this.TUTAR.Name = "TUTAR";
            this.TUTAR.OptionsColumn.AllowEdit = false;
            this.TUTAR.OptionsColumn.AllowFocus = false;
            this.TUTAR.OptionsColumn.FixedWidth = true;
            this.TUTAR.Visible = true;
            this.TUTAR.VisibleIndex = 7;
            this.TUTAR.Width = 87;
            // 
            // DURUMU
            // 
            this.DURUMU.Caption = "DURUMU";
            this.DURUMU.FieldName = "DURUMU";
            this.DURUMU.MinWidth = 23;
            this.DURUMU.Name = "DURUMU";
            this.DURUMU.OptionsColumn.AllowEdit = false;
            this.DURUMU.OptionsColumn.AllowFocus = false;
            this.DURUMU.OptionsColumn.FixedWidth = true;
            this.DURUMU.Visible = true;
            this.DURUMU.VisibleIndex = 8;
            this.DURUMU.Width = 87;
            // 
            // BELGENO
            // 
            this.BELGENO.Caption = "BELGENO";
            this.BELGENO.FieldName = "BELGENO";
            this.BELGENO.MinWidth = 23;
            this.BELGENO.Name = "BELGENO";
            this.BELGENO.OptionsColumn.AllowEdit = false;
            this.BELGENO.OptionsColumn.AllowFocus = false;
            this.BELGENO.OptionsColumn.FixedWidth = true;
            this.BELGENO.Visible = true;
            this.BELGENO.VisibleIndex = 0;
            this.BELGENO.Width = 87;
            // 
            // CEKNO
            // 
            this.CEKNO.Caption = "CEKNO";
            this.CEKNO.FieldName = "CEKNO";
            this.CEKNO.MinWidth = 23;
            this.CEKNO.Name = "CEKNO";
            this.CEKNO.OptionsColumn.AllowEdit = false;
            this.CEKNO.OptionsColumn.AllowFocus = false;
            this.CEKNO.OptionsColumn.FixedWidth = true;
            this.CEKNO.Visible = true;
            this.CEKNO.VisibleIndex = 1;
            this.CEKNO.Width = 87;
            // 
            // YERI_ACIKLAMA
            // 
            this.YERI_ACIKLAMA.Caption = "YERI";
            this.YERI_ACIKLAMA.FieldName = "YERI_ACIKLAMA";
            this.YERI_ACIKLAMA.MinWidth = 23;
            this.YERI_ACIKLAMA.Name = "YERI_ACIKLAMA";
            this.YERI_ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.YERI_ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.YERI_ACIKLAMA.OptionsColumn.FixedWidth = true;
            this.YERI_ACIKLAMA.OptionsColumn.ReadOnly = true;
            this.YERI_ACIKLAMA.Visible = true;
            this.YERI_ACIKLAMA.VisibleIndex = 10;
            this.YERI_ACIKLAMA.Width = 87;
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
            this.Liste.Size = new System.Drawing.Size(640, 578);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Liste.Click += new System.EventHandler(this.Liste_Click);
            // 
            // SagMenu
            // 
            this.SagMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SagMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SagCekGirisi,
            this.SagGuncelle,
            this.SagSil,
            this.SagCekiBankayaCik,
            this.SagCekiCariyeCik,
            this.SagCekiBankadanIadeAl,
            this.SagCekiCaridenIadeAl,
            this.SagCekinDurumu});
            this.SagMenu.Name = "SagMenu";
            this.SagMenu.Size = new System.Drawing.Size(227, 196);
            this.SagMenu.Opening += new System.ComponentModel.CancelEventHandler(this.SagMenu_Opening);
            // 
            // SagCekGirisi
            // 
            this.SagCekGirisi.Name = "SagCekGirisi";
            this.SagCekGirisi.Size = new System.Drawing.Size(226, 24);
            this.SagCekGirisi.Text = "Kendi Çek Girişi";
            this.SagCekGirisi.Click += new System.EventHandler(this.SagCekGirisi_Click);
            // 
            // SagGuncelle
            // 
            this.SagGuncelle.Name = "SagGuncelle";
            this.SagGuncelle.Size = new System.Drawing.Size(226, 24);
            this.SagGuncelle.Text = "Güncelle";
            this.SagGuncelle.Click += new System.EventHandler(this.SagGuncelle_Click);
            // 
            // SagSil
            // 
            this.SagSil.Name = "SagSil";
            this.SagSil.Size = new System.Drawing.Size(226, 24);
            this.SagSil.Text = "Sil";
            this.SagSil.Click += new System.EventHandler(this.SagSil_Click);
            // 
            // SagCekiBankayaCik
            // 
            this.SagCekiBankayaCik.Name = "SagCekiBankayaCik";
            this.SagCekiBankayaCik.Size = new System.Drawing.Size(226, 24);
            this.SagCekiBankayaCik.Text = "Çeki Bankaya Çık";
            this.SagCekiBankayaCik.Click += new System.EventHandler(this.SagCekiBankayaCik_Click);
            // 
            // SagCekiCariyeCik
            // 
            this.SagCekiCariyeCik.Name = "SagCekiCariyeCik";
            this.SagCekiCariyeCik.Size = new System.Drawing.Size(226, 24);
            this.SagCekiCariyeCik.Text = "Çeki Cariye Çık";
            this.SagCekiCariyeCik.Click += new System.EventHandler(this.SagCekiCariyeCik_Click);
            // 
            // SagCekiBankadanIadeAl
            // 
            this.SagCekiBankadanIadeAl.Name = "SagCekiBankadanIadeAl";
            this.SagCekiBankadanIadeAl.Size = new System.Drawing.Size(226, 24);
            this.SagCekiBankadanIadeAl.Text = "Çeki Bankadan İade Al";
            this.SagCekiBankadanIadeAl.Click += new System.EventHandler(this.SagCekiBankadanIadeAl_Click);
            // 
            // SagCekiCaridenIadeAl
            // 
            this.SagCekiCaridenIadeAl.Name = "SagCekiCaridenIadeAl";
            this.SagCekiCaridenIadeAl.Size = new System.Drawing.Size(226, 24);
            this.SagCekiCaridenIadeAl.Text = "Çeki Cariden Iade Al";
            this.SagCekiCaridenIadeAl.Click += new System.EventHandler(this.SagCekiCaridenIadeAl_Click);
            // 
            // SagCekinDurumu
            // 
            this.SagCekinDurumu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SagCekinDurumu.Name = "SagCekinDurumu";
            this.SagCekinDurumu.Size = new System.Drawing.Size(226, 24);
            this.SagCekinDurumu.Text = "Çekin Durumu";
            this.SagCekinDurumu.Click += new System.EventHandler(this.SagCekinDurumu_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 121);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Verilen Cari";
            // 
            // txtVerilenCari
            // 
            this.txtVerilenCari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVerilenCari.Location = new System.Drawing.Point(13, 144);
            this.txtVerilenCari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVerilenCari.Name = "txtVerilenCari";
            this.txtVerilenCari.Size = new System.Drawing.Size(274, 22);
            this.txtVerilenCari.TabIndex = 0;
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(107, 497);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(104, 38);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtDurum);
            this.xtraTabPage1.Controls.Add(this.txtTarih);
            this.xtraTabPage1.Controls.Add(this.txtAciklama);
            this.xtraTabPage1.Controls.Add(this.txtVadeTarihi);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtVerilenBanka);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.txtBelgeNo);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.txtCekNo);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtVerilenCari);
            this.xtraTabPage1.Controls.Add(this.btnTemizle);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(295, 544);
            this.xtraTabPage1.Text = "Arama";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 432);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 16);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Durum";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 244);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(30, 16);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "Tarih";
            // 
            // txtDurum
            // 
            this.txtDurum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDurum.Location = new System.Drawing.Point(13, 455);
            this.txtDurum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(274, 22);
            this.txtDurum.TabIndex = 4;
            // 
            // txtTarih
            // 
            this.txtTarih.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarih.Location = new System.Drawing.Point(13, 267);
            this.txtTarih.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(274, 22);
            this.txtTarih.TabIndex = 3;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 4);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 16);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Belge No:";
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBelgeNo.Location = new System.Drawing.Point(13, 27);
            this.txtBelgeNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(274, 22);
            this.txtBelgeNo.TabIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 64);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 16);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Çek No:";
            // 
            // txtCekNo
            // 
            this.txtCekNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCekNo.Location = new System.Drawing.Point(13, 87);
            this.txtCekNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCekNo.Name = "txtCekNo";
            this.txtCekNo.Size = new System.Drawing.Size(274, 22);
            this.txtCekNo.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.Ac;
            this.btnAra.Location = new System.Drawing.Point(13, 497);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(87, 38);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Arama";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(302, 578);
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
            this.splitContainerControl1.Size = new System.Drawing.Size(948, 578);
            this.splitContainerControl1.SplitterPosition = 302;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // frmKendiCekListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 578);
            this.Controls.Add(this.splitContainerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmKendiCekListesi";
            this.Text = "Kendi Çek Listesi";
            this.Load += new System.EventHandler(this.frmMusteriCekListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVadeTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVerilenBanka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.SagMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtVerilenCari.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn VADETARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn ASILBORCLU;
        private DevExpress.XtraGrid.Columns.GridColumn VERILENBANKAISIM;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAciklama;
        private DevExpress.XtraEditors.TextEdit txtVadeTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtVerilenBanka;
        private DevExpress.XtraGrid.Columns.GridColumn VERILENCARIISIM;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtVerilenCari;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtDurum;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn TUTAR;
        private DevExpress.XtraGrid.Columns.GridColumn DURUMU;
        private DevExpress.XtraGrid.Columns.GridColumn BELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn CEKNO;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtBelgeNo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtCekNo;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtTarih;
        private System.Windows.Forms.ContextMenuStrip SagMenu;
        private System.Windows.Forms.ToolStripMenuItem SagCekGirisi;
        private System.Windows.Forms.ToolStripMenuItem SagGuncelle;
        private System.Windows.Forms.ToolStripMenuItem SagSil;
        private System.Windows.Forms.ToolStripMenuItem SagCekiBankayaCik;
        private System.Windows.Forms.ToolStripMenuItem SagCekiCariyeCik;
        private DevExpress.XtraGrid.Columns.GridColumn YERI;
        private DevExpress.XtraGrid.Columns.GridColumn YERI_ACIKLAMA;
        private System.Windows.Forms.ToolStripMenuItem SagCekiBankadanIadeAl;
        private System.Windows.Forms.ToolStripMenuItem SagCekiCaridenIadeAl;
        private System.Windows.Forms.ToolStripMenuItem SagCekinDurumu;
    }
}