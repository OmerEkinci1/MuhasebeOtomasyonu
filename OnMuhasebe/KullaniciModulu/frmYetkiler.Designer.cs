namespace OnMuhasebe.KullaniciModulu
{
    partial class frmYetkiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYetkiler));
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODUL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYETKI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tBLYETKILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsYETKILER = new OnMuhasebe.KullaniciModulu.dsYETKILER();
            this.tBLYETKILERTableAdapter = new OnMuhasebe.KullaniciModulu.dsYETKILERTableAdapters.TBLYETKILERTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barKullaniciSec = new DevExpress.XtraBars.BarButtonItem();
            this.barKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.barKapat = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barTumYetkileriVeri = new DevExpress.XtraBars.BarButtonItem();
            this.barYetkiAl = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.txtAdi = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLYETKILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYETKILER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Liste.Location = new System.Drawing.Point(0, 129);
            this.Liste.MainView = this.gridView1;
            this.Liste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1028, 384);
            this.Liste.TabIndex = 4;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMODUL,
            this.colYETKI,
            this.colACIKLAMA,
            this.colSEC});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 23;
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.OptionsColumn.AllowShowHide = false;
            this.colID.OptionsColumn.FixedWidth = true;
            this.colID.Width = 87;
            // 
            // colMODUL
            // 
            this.colMODUL.FieldName = "MODUL";
            this.colMODUL.MinWidth = 23;
            this.colMODUL.Name = "colMODUL";
            this.colMODUL.OptionsColumn.AllowEdit = false;
            this.colMODUL.OptionsColumn.AllowFocus = false;
            this.colMODUL.OptionsColumn.FixedWidth = true;
            this.colMODUL.Visible = true;
            this.colMODUL.VisibleIndex = 1;
            this.colMODUL.Width = 87;
            // 
            // colYETKI
            // 
            this.colYETKI.FieldName = "YETKI";
            this.colYETKI.MinWidth = 23;
            this.colYETKI.Name = "colYETKI";
            this.colYETKI.OptionsColumn.AllowEdit = false;
            this.colYETKI.OptionsColumn.AllowFocus = false;
            this.colYETKI.OptionsColumn.FixedWidth = true;
            this.colYETKI.Visible = true;
            this.colYETKI.VisibleIndex = 2;
            this.colYETKI.Width = 121;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.MinWidth = 23;
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.OptionsColumn.AllowEdit = false;
            this.colACIKLAMA.OptionsColumn.AllowFocus = false;
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 3;
            this.colACIKLAMA.Width = 383;
            // 
            // colSEC
            // 
            this.colSEC.FieldName = "SEC";
            this.colSEC.MinWidth = 23;
            this.colSEC.Name = "colSEC";
            this.colSEC.OptionsColumn.FixedWidth = true;
            this.colSEC.Visible = true;
            this.colSEC.VisibleIndex = 0;
            this.colSEC.Width = 415;
            // 
            // tBLYETKILERBindingSource
            // 
            this.tBLYETKILERBindingSource.DataMember = "TBLYETKILER";
            this.tBLYETKILERBindingSource.DataSource = this.dsYETKILER;
            // 
            // dsYETKILER
            // 
            this.dsYETKILER.DataSetName = "dsYETKILER";
            this.dsYETKILER.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLYETKILERTableAdapter
            // 
            this.tBLYETKILERTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barKullaniciSec,
            this.barKaydet,
            this.barKapat,
            this.barButtonItem1,
            this.barSubItem1,
            this.barTumYetkileriVeri,
            this.barYetkiAl});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barKullaniciSec, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barKaydet, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barKapat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barKullaniciSec
            // 
            this.barKullaniciSec.Caption = "Kullanıcı Seç";
            this.barKullaniciSec.Id = 0;
            this.barKullaniciSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barKullaniciSec.ImageOptions.Image")));
            this.barKullaniciSec.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barKullaniciSec.ImageOptions.LargeImage")));
            this.barKullaniciSec.Name = "barKullaniciSec";
            this.barKullaniciSec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barKullaniciSec_ItemClick);
            // 
            // barKaydet
            // 
            this.barKaydet.Caption = "Kaydet";
            this.barKaydet.Id = 1;
            this.barKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barKaydet.ImageOptions.Image")));
            this.barKaydet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barKaydet.ImageOptions.LargeImage")));
            this.barKaydet.Name = "barKaydet";
            this.barKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barKaydet_ItemClick);
            // 
            // barKapat
            // 
            this.barKapat.Caption = "Kapat";
            this.barKapat.Id = 2;
            this.barKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barKapat.ImageOptions.Image")));
            this.barKapat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barKapat.ImageOptions.LargeImage")));
            this.barKapat.Name = "barKapat";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Toplu Yetkiler";
            this.barSubItem1.Id = 4;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barTumYetkileriVeri),
            new DevExpress.XtraBars.LinkPersistInfo(this.barYetkiAl)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barTumYetkileriVeri
            // 
            this.barTumYetkileriVeri.Caption = "Tüm Yetkileri Ver";
            this.barTumYetkileriVeri.Id = 5;
            this.barTumYetkileriVeri.Name = "barTumYetkileriVeri";
            this.barTumYetkileriVeri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barTumYetkileriVeri_ItemClick);
            // 
            // barYetkiAl
            // 
            this.barYetkiAl.Caption = "Tüm Yetkileri İptal Et";
            this.barYetkiAl.Id = 6;
            this.barYetkiAl.Name = "barYetkiAl";
            this.barYetkiAl.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barYetkiAl_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1028, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 513);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1028, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 483);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1028, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 483);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Toplu Yetkiler";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(129, 6);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtAdi.Size = new System.Drawing.Size(313, 22);
            this.txtAdi.TabIndex = 52;
            this.txtAdi.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtAdi_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 16);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 16);
            this.labelControl1.TabIndex = 49;
            this.labelControl1.Text = "Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 48);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 16);
            this.labelControl2.TabIndex = 50;
            this.labelControl2.Text = "Soyadı:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.EditValue = "";
            this.txtSoyadi.Location = new System.Drawing.Point(129, 44);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(313, 22);
            this.txtSoyadi.TabIndex = 51;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtAdi);
            this.panelControl1.Controls.Add(this.txtSoyadi);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Location = new System.Drawing.Point(14, 37);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1000, 85);
            this.panelControl1.TabIndex = 53;
            // 
            // frmYetkiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 513);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmYetkiler";
            this.Text = "Kullanıcı Yetkileri";
            this.Load += new System.EventHandler(this.frmYetkiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLYETKILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYETKILER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private dsYETKILER dsYETKILER;
        private System.Windows.Forms.BindingSource tBLYETKILERBindingSource;
        private dsYETKILERTableAdapters.TBLYETKILERTableAdapter tBLYETKILERTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMODUL;
        private DevExpress.XtraGrid.Columns.GridColumn colYETKI;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn colSEC;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barKullaniciSec;
        private DevExpress.XtraBars.BarButtonItem barKaydet;
        private DevExpress.XtraBars.BarButtonItem barKapat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.ButtonEdit txtAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSoyadi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barTumYetkileriVeri;
        private DevExpress.XtraBars.BarButtonItem barYetkiAl;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}