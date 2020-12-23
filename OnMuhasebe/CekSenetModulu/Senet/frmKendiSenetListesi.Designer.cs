namespace OnMuhasebe.CekSenetModulu.Senet
{
    partial class frmKendiSenetListesi
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
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
            this.YERI.Name = "YERI";
            this.YERI.OptionsColumn.AllowEdit = false;
            this.YERI.OptionsColumn.AllowFocus = false;
            this.YERI.OptionsColumn.AllowShowHide = false;
            this.YERI.OptionsColumn.FixedWidth = true;
            this.YERI.OptionsColumn.ReadOnly = true;
            // 
            // VADETARIHI
            // 
            this.VADETARIHI.Caption = "VADETARIHI";
            this.VADETARIHI.FieldName = "VADETARIHI";
            this.VADETARIHI.Name = "VADETARIHI";
            this.VADETARIHI.OptionsColumn.AllowEdit = false;
            this.VADETARIHI.OptionsColumn.AllowFocus = false;
            this.VADETARIHI.OptionsColumn.FixedWidth = true;
            this.VADETARIHI.OptionsColumn.ReadOnly = true;
            this.VADETARIHI.Visible = true;
            this.VADETARIHI.VisibleIndex = 6;
            this.VADETARIHI.Width = 120;
            // 
            // ASILBORCLU
            // 
            this.ASILBORCLU.Caption = "ASIL BORÇLU";
            this.ASILBORCLU.FieldName = "ASILBORCLU";
            this.ASILBORCLU.Name = "ASILBORCLU";
            this.ASILBORCLU.OptionsColumn.AllowEdit = false;
            this.ASILBORCLU.OptionsColumn.AllowFocus = false;
            this.ASILBORCLU.OptionsColumn.FixedWidth = true;
            this.ASILBORCLU.OptionsColumn.ReadOnly = true;
            this.ASILBORCLU.Visible = true;
            this.ASILBORCLU.VisibleIndex = 4;
            // 
            // VERILENBANKAISIM
            // 
            this.VERILENBANKAISIM.Caption = "VERİLEN BANKA";
            this.VERILENBANKAISIM.FieldName = "VERILENBANKAISIM";
            this.VERILENBANKAISIM.Name = "VERILENBANKAISIM";
            this.VERILENBANKAISIM.OptionsColumn.AllowEdit = false;
            this.VERILENBANKAISIM.OptionsColumn.AllowFocus = false;
            this.VERILENBANKAISIM.OptionsColumn.ReadOnly = true;
            this.VERILENBANKAISIM.Visible = true;
            this.VERILENBANKAISIM.VisibleIndex = 3;
            this.VERILENBANKAISIM.Width = 300;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 306);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Açıklama";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 247);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Vade Tarihi";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAciklama.Location = new System.Drawing.Point(11, 325);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(235, 20);
            this.txtAciklama.TabIndex = 4;
            // 
            // txtVadeTarihi
            // 
            this.txtVadeTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVadeTarihi.Location = new System.Drawing.Point(11, 266);
            this.txtVadeTarihi.Name = "txtVadeTarihi";
            this.txtVadeTarihi.Size = new System.Drawing.Size(235, 20);
            this.txtVadeTarihi.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 153);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Verilen Banka";
            // 
            // txtVerilenBanka
            // 
            this.txtVerilenBanka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVerilenBanka.Location = new System.Drawing.Point(11, 172);
            this.txtVerilenBanka.Name = "txtVerilenBanka";
            this.txtVerilenBanka.Size = new System.Drawing.Size(235, 20);
            this.txtVerilenBanka.TabIndex = 1;
            // 
            // VERILENCARIISIM
            // 
            this.VERILENCARIISIM.Caption = "VERILEN CARİ";
            this.VERILENCARIISIM.FieldName = "VERILENCARIISIM";
            this.VERILENCARIISIM.Name = "VERILENCARIISIM";
            this.VERILENCARIISIM.OptionsColumn.AllowEdit = false;
            this.VERILENCARIISIM.OptionsColumn.AllowFocus = false;
            this.VERILENCARIISIM.OptionsColumn.FixedWidth = true;
            this.VERILENCARIISIM.OptionsColumn.ReadOnly = true;
            this.VERILENCARIISIM.Visible = true;
            this.VERILENCARIISIM.VisibleIndex = 2;
            this.VERILENCARIISIM.Width = 150;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.AllowShowHide = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.OptionsColumn.ReadOnly = true;
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
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.YERI;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Value1 = "B";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.YERI;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = "C";
            gridFormatRule2.Rule = formatConditionRuleValue2;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
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
            this.TARIH.Name = "TARIH";
            this.TARIH.OptionsColumn.AllowEdit = false;
            this.TARIH.OptionsColumn.AllowFocus = false;
            this.TARIH.OptionsColumn.FixedWidth = true;
            this.TARIH.OptionsColumn.ReadOnly = true;
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 5;
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "ACIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.ACIKLAMA.OptionsColumn.FixedWidth = true;
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 9;
            // 
            // TUTAR
            // 
            this.TUTAR.Caption = "TUTAR";
            this.TUTAR.FieldName = "TUTAR";
            this.TUTAR.Name = "TUTAR";
            this.TUTAR.OptionsColumn.AllowEdit = false;
            this.TUTAR.OptionsColumn.AllowFocus = false;
            this.TUTAR.OptionsColumn.FixedWidth = true;
            this.TUTAR.Visible = true;
            this.TUTAR.VisibleIndex = 7;
            // 
            // DURUMU
            // 
            this.DURUMU.Caption = "DURUMU";
            this.DURUMU.FieldName = "DURUMU";
            this.DURUMU.Name = "DURUMU";
            this.DURUMU.OptionsColumn.AllowEdit = false;
            this.DURUMU.OptionsColumn.AllowFocus = false;
            this.DURUMU.OptionsColumn.FixedWidth = true;
            this.DURUMU.Visible = true;
            this.DURUMU.VisibleIndex = 8;
            // 
            // BELGENO
            // 
            this.BELGENO.Caption = "BELGENO";
            this.BELGENO.FieldName = "BELGENO";
            this.BELGENO.Name = "BELGENO";
            this.BELGENO.OptionsColumn.AllowEdit = false;
            this.BELGENO.OptionsColumn.AllowFocus = false;
            this.BELGENO.OptionsColumn.FixedWidth = true;
            this.BELGENO.Visible = true;
            this.BELGENO.VisibleIndex = 0;
            // 
            // CEKNO
            // 
            this.CEKNO.Caption = "CEKNO";
            this.CEKNO.FieldName = "CEKNO";
            this.CEKNO.Name = "CEKNO";
            this.CEKNO.OptionsColumn.AllowEdit = false;
            this.CEKNO.OptionsColumn.AllowFocus = false;
            this.CEKNO.OptionsColumn.FixedWidth = true;
            this.CEKNO.Visible = true;
            this.CEKNO.VisibleIndex = 1;
            // 
            // YERI_ACIKLAMA
            // 
            this.YERI_ACIKLAMA.Caption = "YERI";
            this.YERI_ACIKLAMA.FieldName = "YERI_ACIKLAMA";
            this.YERI_ACIKLAMA.Name = "YERI_ACIKLAMA";
            this.YERI_ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.YERI_ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.YERI_ACIKLAMA.OptionsColumn.FixedWidth = true;
            this.YERI_ACIKLAMA.OptionsColumn.ReadOnly = true;
            this.YERI_ACIKLAMA.Visible = true;
            this.YERI_ACIKLAMA.VisibleIndex = 10;
            // 
            // Liste
            // 
            this.Liste.ContextMenuStrip = this.SagMenu;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(574, 470);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Liste.Click += new System.EventHandler(this.Liste_Click);
            // 
            // SagMenu
            // 
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
            this.SagMenu.Size = new System.Drawing.Size(192, 202);
            this.SagMenu.Opening += new System.ComponentModel.CancelEventHandler(this.SagMenu_Opening);
            // 
            // SagCekGirisi
            // 
            this.SagCekGirisi.Name = "SagCekGirisi";
            this.SagCekGirisi.Size = new System.Drawing.Size(191, 22);
            this.SagCekGirisi.Text = "Kendi Çek Girişi";
            this.SagCekGirisi.Click += new System.EventHandler(this.SagCekGirisi_Click);
            // 
            // SagGuncelle
            // 
            this.SagGuncelle.Name = "SagGuncelle";
            this.SagGuncelle.Size = new System.Drawing.Size(191, 22);
            this.SagGuncelle.Text = "Güncelle";
            this.SagGuncelle.Click += new System.EventHandler(this.SagGuncelle_Click);
            // 
            // SagSil
            // 
            this.SagSil.Name = "SagSil";
            this.SagSil.Size = new System.Drawing.Size(191, 22);
            this.SagSil.Text = "Sil";
            this.SagSil.Click += new System.EventHandler(this.SagSil_Click);
            // 
            // SagCekiBankayaCik
            // 
            this.SagCekiBankayaCik.Name = "SagCekiBankayaCik";
            this.SagCekiBankayaCik.Size = new System.Drawing.Size(191, 22);
            this.SagCekiBankayaCik.Text = "Çeki Bankaya Çık";
            this.SagCekiBankayaCik.Click += new System.EventHandler(this.SagCekiBankayaCik_Click);
            // 
            // SagCekiCariyeCik
            // 
            this.SagCekiCariyeCik.Name = "SagCekiCariyeCik";
            this.SagCekiCariyeCik.Size = new System.Drawing.Size(191, 22);
            this.SagCekiCariyeCik.Text = "Çeki Cariye Çık";
            this.SagCekiCariyeCik.Click += new System.EventHandler(this.SagCekiCariyeCik_Click);
            // 
            // SagCekiBankadanIadeAl
            // 
            this.SagCekiBankadanIadeAl.Name = "SagCekiBankadanIadeAl";
            this.SagCekiBankadanIadeAl.Size = new System.Drawing.Size(191, 22);
            this.SagCekiBankadanIadeAl.Text = "Çeki Bankadan İade Al";
            this.SagCekiBankadanIadeAl.Click += new System.EventHandler(this.SagCekiBankadanIadeAl_Click);
            // 
            // SagCekiCaridenIadeAl
            // 
            this.SagCekiCaridenIadeAl.Name = "SagCekiCaridenIadeAl";
            this.SagCekiCaridenIadeAl.Size = new System.Drawing.Size(191, 22);
            this.SagCekiCaridenIadeAl.Text = "Çeki Cariden Iade Al";
            this.SagCekiCaridenIadeAl.Click += new System.EventHandler(this.SagCekiCaridenIadeAl_Click);
            // 
            // SagCekinDurumu
            // 
            this.SagCekinDurumu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SagCekinDurumu.Name = "SagCekinDurumu";
            this.SagCekinDurumu.Size = new System.Drawing.Size(191, 22);
            this.SagCekinDurumu.Text = "Çekin Durumu";
            this.SagCekinDurumu.Click += new System.EventHandler(this.SagCekinDurumu_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 98);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Verilen Cari";
            // 
            // txtVerilenCari
            // 
            this.txtVerilenCari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVerilenCari.Location = new System.Drawing.Point(11, 117);
            this.txtVerilenCari.Name = "txtVerilenCari";
            this.txtVerilenCari.Size = new System.Drawing.Size(235, 20);
            this.txtVerilenCari.TabIndex = 0;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(92, 404);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(89, 31);
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
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(256, 445);
            this.xtraTabPage1.Text = "Arama";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 351);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Durum";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(11, 198);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(24, 13);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "Tarih";
            // 
            // txtDurum
            // 
            this.txtDurum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDurum.Location = new System.Drawing.Point(11, 370);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(235, 20);
            this.txtDurum.TabIndex = 4;
            // 
            // txtTarih
            // 
            this.txtTarih.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarih.Location = new System.Drawing.Point(11, 217);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(235, 20);
            this.txtTarih.TabIndex = 3;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(11, 3);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Belge No:";
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBelgeNo.Location = new System.Drawing.Point(11, 22);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(235, 20);
            this.txtBelgeNo.TabIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 52);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(38, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Çek No:";
            // 
            // txtCekNo
            // 
            this.txtCekNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCekNo.Location = new System.Drawing.Point(11, 71);
            this.txtCekNo.Name = "txtCekNo";
            this.txtCekNo.Size = new System.Drawing.Size(235, 20);
            this.txtCekNo.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.Image = global::OnMuhasebe.Properties.Resources.Ac;
            this.btnAra.Location = new System.Drawing.Point(11, 404);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 31);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Arama";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(259, 470);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Collapsed = true;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(838, 470);
            this.splitContainerControl1.SplitterPosition = 259;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // frmKendiCekListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 470);
            this.Controls.Add(this.splitContainerControl1);
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