namespace OnMuhasebe.CekSenetModulu.Senet
{
    partial class frmMusteriSenetBordrosu
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtOrtalamaVade = new DevExpress.XtraEditors.TextEdit();
            this.txtToplamTutar = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumara = new DevExpress.XtraEditors.ButtonEdit();
            this.txtCariKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.txtCariIsim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.cEKGIRISIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cekGirisi = new OnMuhasebe.CekSenetModulu.Cek.CekGirisi();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCEKNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVADETARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBANKA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSec = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colSUBE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIZIID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrtalamaVade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumara.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariIsim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEKGIRISIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cekGirisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSec)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.txtAciklama);
            this.panelControl1.Controls.Add(this.labelControl12);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.txtOrtalamaVade);
            this.panelControl1.Controls.Add(this.txtToplamTutar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 318);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(858, 159);
            this.panelControl1.TabIndex = 14;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnKapat);
            this.panelControl2.Controls.Add(this.btnSil);
            this.panelControl2.Controls.Add(this.btnKaydet);
            this.panelControl2.Controls.Add(this.btnYeni);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 104);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(854, 53);
            this.panelControl2.TabIndex = 16;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.Image = global::OnMuhasebe.Properties.Resources.Kapat24x24;
            this.btnKapat.Location = new System.Drawing.Point(747, 14);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(79, 35);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Image = global::OnMuhasebe.Properties.Resources.Sil24x24;
            this.btnSil.Location = new System.Drawing.Point(659, 14);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(79, 35);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Image = global::OnMuhasebe.Properties.Resources.Kaydet24x241;
            this.btnKaydet.Location = new System.Drawing.Point(575, 14);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(79, 35);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.btnYeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeni.Image = global::OnMuhasebe.Properties.Resources.Yeni24x24;
            this.btnYeni.Location = new System.Drawing.Point(490, 14);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(79, 35);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(106, 26);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(308, 66);
            this.txtAciklama.TabIndex = 3;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(14, 34);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(41, 13);
            this.labelControl12.TabIndex = 1;
            this.labelControl12.Text = "Açıklama";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Location = new System.Drawing.Point(533, 56);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(71, 13);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Ortalama Vade";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Location = new System.Drawing.Point(533, 30);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 13);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Toplam Tutar";
            // 
            // txtOrtalamaVade
            // 
            this.txtOrtalamaVade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrtalamaVade.EditValue = "0,00";
            this.txtOrtalamaVade.Location = new System.Drawing.Point(618, 53);
            this.txtOrtalamaVade.Name = "txtOrtalamaVade";
            this.txtOrtalamaVade.Properties.Appearance.Options.UseTextOptions = true;
            this.txtOrtalamaVade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtOrtalamaVade.Size = new System.Drawing.Size(183, 20);
            this.txtOrtalamaVade.TabIndex = 2;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToplamTutar.EditValue = "0,00";
            this.txtToplamTutar.Location = new System.Drawing.Point(618, 27);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Properties.Appearance.Options.UseTextOptions = true;
            this.txtToplamTutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtToplamTutar.Size = new System.Drawing.Size(183, 20);
            this.txtToplamTutar.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTarih);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtNumara);
            this.groupControl1.Controls.Add(this.txtCariKodu);
            this.groupControl1.Controls.Add(this.txtCariIsim);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(858, 101);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Bordro Bilgileri";
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(97, 52);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Size = new System.Drawing.Size(202, 20);
            this.txtTarih.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Tarih";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(97, 26);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtNumara.Properties.Appearance.Options.UseBackColor = true;
            this.txtNumara.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtNumara.Size = new System.Drawing.Size(202, 20);
            this.txtNumara.TabIndex = 1;
            this.txtNumara.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtNumara_ButtonClick);
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(408, 26);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCariKodu.Properties.ReadOnly = true;
            this.txtCariKodu.Size = new System.Drawing.Size(306, 20);
            this.txtCariKodu.TabIndex = 1;
            this.txtCariKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCariKodu_ButtonClick);
            // 
            // txtCariIsim
            // 
            this.txtCariIsim.Location = new System.Drawing.Point(408, 52);
            this.txtCariIsim.Name = "txtCariIsim";
            this.txtCariIsim.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCariIsim.Properties.Appearance.Options.UseBackColor = true;
            this.txtCariIsim.Properties.ReadOnly = true;
            this.txtCariIsim.Size = new System.Drawing.Size(306, 20);
            this.txtCariIsim.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(323, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Cari İsim";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(323, 29);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Cari Kodu";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Bordro Numarası";
            // 
            // Liste
            // 
            this.Liste.DataSource = this.cEKGIRISIBindingSource;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.Liste_EmbeddedNavigator_ButtonClick);
            this.Liste.Location = new System.Drawing.Point(0, 101);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSec});
            this.Liste.Size = new System.Drawing.Size(858, 217);
            this.Liste.TabIndex = 15;
            this.Liste.UseEmbeddedNavigator = true;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cEKGIRISIBindingSource
            // 
            this.cEKGIRISIBindingSource.DataMember = "CEKGIRISI";
            this.cEKGIRISIBindingSource.DataSource = this.cekGirisi;
            // 
            // cekGirisi
            // 
            this.cekGirisi.DataSetName = "CekGirisi";
            this.cekGirisi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCEKNO,
            this.colVADETARIHI,
            this.colBANKA,
            this.colBELGENO,
            this.colSUBE,
            this.colTUTAR,
            this.DIZIID});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            this.gridView1.RowCountChanged += new System.EventHandler(this.gridView1_RowCountChanged);
            // 
            // colCEKNO
            // 
            this.colCEKNO.FieldName = "CEKNO";
            this.colCEKNO.Name = "colCEKNO";
            this.colCEKNO.OptionsColumn.AllowEdit = false;
            this.colCEKNO.OptionsColumn.AllowFocus = false;
            this.colCEKNO.OptionsColumn.FixedWidth = true;
            this.colCEKNO.OptionsColumn.ReadOnly = true;
            this.colCEKNO.Visible = true;
            this.colCEKNO.VisibleIndex = 1;
            // 
            // colVADETARIHI
            // 
            this.colVADETARIHI.FieldName = "VADETARIHI";
            this.colVADETARIHI.Name = "colVADETARIHI";
            this.colVADETARIHI.OptionsColumn.AllowEdit = false;
            this.colVADETARIHI.OptionsColumn.AllowFocus = false;
            this.colVADETARIHI.OptionsColumn.FixedWidth = true;
            this.colVADETARIHI.OptionsColumn.ReadOnly = true;
            this.colVADETARIHI.Visible = true;
            this.colVADETARIHI.VisibleIndex = 2;
            // 
            // colBANKA
            // 
            this.colBANKA.FieldName = "BANKA";
            this.colBANKA.Name = "colBANKA";
            this.colBANKA.OptionsColumn.AllowEdit = false;
            this.colBANKA.OptionsColumn.AllowFocus = false;
            this.colBANKA.OptionsColumn.ReadOnly = true;
            this.colBANKA.Visible = true;
            this.colBANKA.VisibleIndex = 3;
            // 
            // colBELGENO
            // 
            this.colBELGENO.ColumnEdit = this.btnSec;
            this.colBELGENO.FieldName = "BELGENO";
            this.colBELGENO.Name = "colBELGENO";
            this.colBELGENO.OptionsColumn.FixedWidth = true;
            this.colBELGENO.Visible = true;
            this.colBELGENO.VisibleIndex = 0;
            // 
            // btnSec
            // 
            this.btnSec.AutoHeight = false;
            this.btnSec.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnSec.Name = "btnSec";
            this.btnSec.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSec_ButtonClick_1);
            // 
            // colSUBE
            // 
            this.colSUBE.FieldName = "SUBE";
            this.colSUBE.Name = "colSUBE";
            this.colSUBE.OptionsColumn.AllowEdit = false;
            this.colSUBE.OptionsColumn.FixedWidth = true;
            this.colSUBE.OptionsColumn.ReadOnly = true;
            this.colSUBE.Visible = true;
            this.colSUBE.VisibleIndex = 4;
            // 
            // colTUTAR
            // 
            this.colTUTAR.FieldName = "TUTAR";
            this.colTUTAR.Name = "colTUTAR";
            this.colTUTAR.OptionsColumn.AllowEdit = false;
            this.colTUTAR.OptionsColumn.AllowFocus = false;
            this.colTUTAR.OptionsColumn.FixedWidth = true;
            this.colTUTAR.OptionsColumn.ReadOnly = true;
            this.colTUTAR.Visible = true;
            this.colTUTAR.VisibleIndex = 5;
            // 
            // DIZIID
            // 
            this.DIZIID.Caption = "DIZIID";
            this.DIZIID.FieldName = "DIZIID";
            this.DIZIID.Name = "DIZIID";
            this.DIZIID.Visible = true;
            this.DIZIID.VisibleIndex = 6;
            // 
            // frmMusteriCekBordrosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 477);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmMusteriCekBordrosu";
            this.Text = "Çek Bordro Girişi";
            this.Load += new System.EventHandler(this.frmMusteriCekBordrosu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrtalamaVade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumara.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariIsim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEKGIRISIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cekGirisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtOrtalamaVade;
        private DevExpress.XtraEditors.TextEdit txtToplamTutar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ButtonEdit txtNumara;
        private DevExpress.XtraEditors.ButtonEdit txtCariKodu;
        private DevExpress.XtraEditors.TextEdit txtCariIsim;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSec;
        private System.Windows.Forms.BindingSource cEKGIRISIBindingSource;
        private CekGirisi cekGirisi;
        private DevExpress.XtraGrid.Columns.GridColumn colCEKNO;
        private DevExpress.XtraGrid.Columns.GridColumn colVADETARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn colBANKA;
        private DevExpress.XtraGrid.Columns.GridColumn colBELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBE;
        private DevExpress.XtraGrid.Columns.GridColumn colTUTAR;
        private DevExpress.XtraGrid.Columns.GridColumn DIZIID;
    }
}