namespace OnMuhasebe.CariModulu.Raporlar
{
    partial class frmRapCariHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRapCariHareket));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BORC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ALACAK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ILCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VERGIDAIRESI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.SagMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SagHareketler = new System.Windows.Forms.ToolStripMenuItem();
            this.SagGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.SagExcel2003 = new System.Windows.Forms.ToolStripMenuItem();
            this.SagExcel2007 = new System.Windows.Forms.ToolStripMenuItem();
            this.SagPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.SagHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariAdi = new DevExpress.XtraEditors.TextEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtCariKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.txtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.txtIlce = new DevExpress.XtraEditors.TextEdit();
            this.txtIl = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barRaporla = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barExcel2003 = new DevExpress.XtraBars.BarButtonItem();
            this.barExcel2007 = new DevExpress.XtraBars.BarButtonItem();
            this.barPdf = new DevExpress.XtraBars.BarButtonItem();
            this.barHtml = new DevExpress.XtraBars.BarButtonItem();
            this.barCikis = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SagMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.CARIKODU,
            this.CARIISIM,
            this.BORC,
            this.ALACAK,
            this.BAKIYE,
            this.IL,
            this.ILCE,
            this.VERGIDAIRESI});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // CARIKODU
            // 
            this.CARIKODU.Caption = "CARIKODU";
            this.CARIKODU.FieldName = "CARIKODU";
            this.CARIKODU.MinWidth = 23;
            this.CARIKODU.Name = "CARIKODU";
            this.CARIKODU.OptionsColumn.AllowEdit = false;
            this.CARIKODU.OptionsColumn.AllowFocus = false;
            this.CARIKODU.OptionsColumn.FixedWidth = true;
            this.CARIKODU.OptionsColumn.ReadOnly = true;
            this.CARIKODU.Visible = true;
            this.CARIKODU.VisibleIndex = 0;
            this.CARIKODU.Width = 175;
            // 
            // CARIISIM
            // 
            this.CARIISIM.Caption = "CARIISIM";
            this.CARIISIM.FieldName = "CARIISIM";
            this.CARIISIM.MinWidth = 23;
            this.CARIISIM.Name = "CARIISIM";
            this.CARIISIM.OptionsColumn.AllowEdit = false;
            this.CARIISIM.OptionsColumn.AllowFocus = false;
            this.CARIISIM.OptionsColumn.ReadOnly = true;
            this.CARIISIM.Visible = true;
            this.CARIISIM.VisibleIndex = 1;
            this.CARIISIM.Width = 350;
            // 
            // BORC
            // 
            this.BORC.Caption = "BORC";
            this.BORC.DisplayFormat.FormatString = "N2";
            this.BORC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BORC.FieldName = "BORC";
            this.BORC.MinWidth = 23;
            this.BORC.Name = "BORC";
            this.BORC.OptionsColumn.AllowEdit = false;
            this.BORC.OptionsColumn.AllowFocus = false;
            this.BORC.OptionsColumn.FixedWidth = true;
            this.BORC.OptionsColumn.ReadOnly = true;
            this.BORC.Visible = true;
            this.BORC.VisibleIndex = 2;
            this.BORC.Width = 87;
            // 
            // ALACAK
            // 
            this.ALACAK.Caption = "ALACAK";
            this.ALACAK.DisplayFormat.FormatString = "N2";
            this.ALACAK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ALACAK.FieldName = "ALACAK";
            this.ALACAK.MinWidth = 23;
            this.ALACAK.Name = "ALACAK";
            this.ALACAK.OptionsColumn.AllowEdit = false;
            this.ALACAK.OptionsColumn.AllowFocus = false;
            this.ALACAK.OptionsColumn.FixedWidth = true;
            this.ALACAK.OptionsColumn.ReadOnly = true;
            this.ALACAK.Visible = true;
            this.ALACAK.VisibleIndex = 3;
            this.ALACAK.Width = 87;
            // 
            // BAKIYE
            // 
            this.BAKIYE.Caption = "BAKIYE";
            this.BAKIYE.DisplayFormat.FormatString = "N2";
            this.BAKIYE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BAKIYE.FieldName = "BAKIYE";
            this.BAKIYE.MinWidth = 23;
            this.BAKIYE.Name = "BAKIYE";
            this.BAKIYE.OptionsColumn.AllowEdit = false;
            this.BAKIYE.OptionsColumn.AllowFocus = false;
            this.BAKIYE.OptionsColumn.FixedWidth = true;
            this.BAKIYE.OptionsColumn.ReadOnly = true;
            this.BAKIYE.Visible = true;
            this.BAKIYE.VisibleIndex = 4;
            this.BAKIYE.Width = 87;
            // 
            // IL
            // 
            this.IL.Caption = "IL";
            this.IL.FieldName = "IL";
            this.IL.MinWidth = 23;
            this.IL.Name = "IL";
            this.IL.Visible = true;
            this.IL.VisibleIndex = 5;
            this.IL.Width = 87;
            // 
            // ILCE
            // 
            this.ILCE.Caption = "ILCE";
            this.ILCE.FieldName = "ILCE";
            this.ILCE.MinWidth = 23;
            this.ILCE.Name = "ILCE";
            this.ILCE.Visible = true;
            this.ILCE.VisibleIndex = 6;
            this.ILCE.Width = 87;
            // 
            // VERGIDAIRESI
            // 
            this.VERGIDAIRESI.Caption = "VERGIDAIRESI";
            this.VERGIDAIRESI.FieldName = "VERGIDAIRESI";
            this.VERGIDAIRESI.MinWidth = 23;
            this.VERGIDAIRESI.Name = "VERGIDAIRESI";
            this.VERGIDAIRESI.Visible = true;
            this.VERGIDAIRESI.VisibleIndex = 7;
            this.VERGIDAIRESI.Width = 87;
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
            this.Liste.Size = new System.Drawing.Size(1070, 415);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // SagMenu
            // 
            this.SagMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SagMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SagHareketler,
            this.SagGuncelle});
            this.SagMenu.Name = "SagMenu";
            this.SagMenu.Size = new System.Drawing.Size(252, 52);
            // 
            // SagHareketler
            // 
            this.SagHareketler.Name = "SagHareketler";
            this.SagHareketler.Size = new System.Drawing.Size(251, 24);
            this.SagHareketler.Text = "Cari Hareket Kayıtlarını Aç";
            this.SagHareketler.Click += new System.EventHandler(this.SagHareketler_Click);
            // 
            // SagGuncelle
            // 
            this.SagGuncelle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SagExcel2003,
            this.SagExcel2007,
            this.SagPdf,
            this.SagHtml});
            this.SagGuncelle.Name = "SagGuncelle";
            this.SagGuncelle.Size = new System.Drawing.Size(251, 24);
            this.SagGuncelle.Text = "Gönder";
            // 
            // SagExcel2003
            // 
            this.SagExcel2003.Name = "SagExcel2003";
            this.SagExcel2003.Size = new System.Drawing.Size(188, 26);
            this.SagExcel2003.Text = "Excel 2003";
            this.SagExcel2003.Click += new System.EventHandler(this.SagExcel2003_Click);
            // 
            // SagExcel2007
            // 
            this.SagExcel2007.Name = "SagExcel2007";
            this.SagExcel2007.Size = new System.Drawing.Size(188, 26);
            this.SagExcel2007.Text = "Excel 2007";
            this.SagExcel2007.Click += new System.EventHandler(this.SagExcel2007_Click);
            // 
            // SagPdf
            // 
            this.SagPdf.Name = "SagPdf";
            this.SagPdf.Size = new System.Drawing.Size(188, 26);
            this.SagPdf.Text = "Acrobat Reader";
            this.SagPdf.Click += new System.EventHandler(this.SagPdf_Click);
            // 
            // SagHtml
            // 
            this.SagHtml.Name = "SagHtml";
            this.SagHtml.Size = new System.Drawing.Size(188, 26);
            this.SagHtml.Text = "Html";
            this.SagHtml.Click += new System.EventHandler(this.SagHtml_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 278);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 16);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Vergi Dairesi";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 206);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 16);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "İlçe";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(13, 144);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(7, 16);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "İl";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 90);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Cari Adı:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 22);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Cari  Kodu:";
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariAdi.Location = new System.Drawing.Point(13, 113);
            this.txtCariAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(286, 22);
            this.txtCariAdi.TabIndex = 1;
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(107, 334);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(104, 38);
            this.btnTemizle.TabIndex = 0;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.Ac;
            this.btnAra.Location = new System.Drawing.Point(13, 334);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(87, 38);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Raporla";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtCariAdi);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.btnTemizle);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.txtCariKodu);
            this.xtraTabPage1.Controls.Add(this.txtVergiDairesi);
            this.xtraTabPage1.Controls.Add(this.txtIlce);
            this.xtraTabPage1.Controls.Add(this.txtIl);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(295, 381);
            this.xtraTabPage1.Text = "Arama";
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCariKodu.Location = new System.Drawing.Point(13, 46);
            this.txtCariKodu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCariKodu.Size = new System.Drawing.Size(282, 22);
            this.txtCariKodu.TabIndex = 1;
            this.txtCariKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCariKodu_ButtonClick);
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVergiDairesi.Location = new System.Drawing.Point(13, 302);
            this.txtVergiDairesi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(286, 22);
            this.txtVergiDairesi.TabIndex = 5;
            // 
            // txtIlce
            // 
            this.txtIlce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIlce.Location = new System.Drawing.Point(13, 229);
            this.txtIlce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(286, 22);
            this.txtIlce.TabIndex = 7;
            // 
            // txtIl
            // 
            this.txtIl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIl.Location = new System.Drawing.Point(13, 167);
            this.txtIl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(286, 22);
            this.txtIl.TabIndex = 8;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(302, 415);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Collapsed = true;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 29);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1378, 415);
            this.splitContainerControl1.SplitterPosition = 302;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barRaporla,
            this.barButtonItem2,
            this.barSubItem1,
            this.barExcel2003,
            this.barExcel2007,
            this.barPdf,
            this.barHtml,
            this.barCikis});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barRaporla),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCikis)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barRaporla
            // 
            this.barRaporla.Caption = "Raporla";
            this.barRaporla.Id = 0;
            this.barRaporla.Name = "barRaporla";
            this.barRaporla.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barRaporla_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Gönder";
            this.barSubItem1.Id = 2;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barExcel2003),
            new DevExpress.XtraBars.LinkPersistInfo(this.barExcel2007),
            new DevExpress.XtraBars.LinkPersistInfo(this.barPdf),
            new DevExpress.XtraBars.LinkPersistInfo(this.barHtml, true)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barExcel2003
            // 
            this.barExcel2003.Caption = "Excel 2003";
            this.barExcel2003.Id = 3;
            this.barExcel2003.Name = "barExcel2003";
            this.barExcel2003.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barExcel2003_ItemClick);
            // 
            // barExcel2007
            // 
            this.barExcel2007.Caption = "Excel 2007";
            this.barExcel2007.Id = 4;
            this.barExcel2007.Name = "barExcel2007";
            this.barExcel2007.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barExcel2007_ItemClick);
            // 
            // barPdf
            // 
            this.barPdf.Caption = "Acrobat Reader";
            this.barPdf.Id = 5;
            this.barPdf.Name = "barPdf";
            this.barPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barPdf_ItemClick);
            // 
            // barHtml
            // 
            this.barHtml.Caption = "Html\'e Gönder";
            this.barHtml.Id = 6;
            this.barHtml.Name = "barHtml";
            this.barHtml.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barHtml_ItemClick);
            // 
            // barCikis
            // 
            this.barCikis.Caption = "Çıkış";
            this.barCikis.Id = 7;
            this.barCikis.Name = "barCikis";
            this.barCikis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCikis_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1378, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 444);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1378, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 415);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1378, 29);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 415);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Gönder";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // frmRapCariHareket
            // 
            this.AcceptButton = this.btnAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 468);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRapCariHareket";
            this.Text = "Cari Hareket Raporu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRapStokHareket_FormClosing);
            this.Load += new System.EventHandler(this.frmRapStokHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.SagMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraGrid.Columns.GridColumn CARIISIM;
        private DevExpress.XtraGrid.GridControl Liste;
        private System.Windows.Forms.ContextMenuStrip SagMenu;
        private System.Windows.Forms.ToolStripMenuItem SagHareketler;
        private System.Windows.Forms.ToolStripMenuItem SagGuncelle;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCariAdi;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Columns.GridColumn BORC;
        private DevExpress.XtraGrid.Columns.GridColumn ALACAK;
        private DevExpress.XtraGrid.Columns.GridColumn BAKIYE;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barRaporla;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barExcel2003;
        private DevExpress.XtraBars.BarButtonItem barExcel2007;
        private DevExpress.XtraBars.BarButtonItem barPdf;
        private DevExpress.XtraBars.BarButtonItem barHtml;
        private DevExpress.XtraBars.BarButtonItem barCikis;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.ToolStripMenuItem SagExcel2003;
        private System.Windows.Forms.ToolStripMenuItem SagExcel2007;
        private System.Windows.Forms.ToolStripMenuItem SagPdf;
        private System.Windows.Forms.ToolStripMenuItem SagHtml;
        private DevExpress.XtraEditors.ButtonEdit txtCariKodu;
        private DevExpress.XtraEditors.TextEdit txtVergiDairesi;
        private DevExpress.XtraEditors.TextEdit txtIlce;
        private DevExpress.XtraEditors.TextEdit txtIl;
        private DevExpress.XtraGrid.Columns.GridColumn IL;
        private DevExpress.XtraGrid.Columns.GridColumn ILCE;
        private DevExpress.XtraGrid.Columns.GridColumn VERGIDAIRESI;
    }
}