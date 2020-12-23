namespace OnMuhasebe.CekSenetModulu.Senet
{
    partial class frmCariyeSenetCikisi
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.txtNumara = new DevExpress.XtraEditors.ButtonEdit();
            this.txtCarikodu = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtToplamTutar = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cEKGIRISIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cekGirisi = new OnMuhasebe.CekSenetModulu.Cek.CekGirisi();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCEKNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSec = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colVADETARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBANKA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIZIID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumara.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarikodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cEKGIRISIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cekGirisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSec)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Tarih";
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Location = new System.Drawing.Point(408, 52);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCariAdi.Properties.Appearance.Options.UseBackColor = true;
            this.txtCariAdi.Properties.ReadOnly = true;
            this.txtCariAdi.Size = new System.Drawing.Size(306, 20);
            this.txtCariAdi.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(323, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Cari Adı";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTarih);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtNumara);
            this.groupControl1.Controls.Add(this.txtCarikodu);
            this.groupControl1.Controls.Add(this.txtCariAdi);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(880, 101);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "Cari  Bilgileri";
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
            // 
            // txtCarikodu
            // 
            this.txtCarikodu.Location = new System.Drawing.Point(408, 26);
            this.txtCarikodu.Name = "txtCarikodu";
            this.txtCarikodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCarikodu.Properties.ReadOnly = true;
            this.txtCarikodu.Size = new System.Drawing.Size(306, 20);
            this.txtCarikodu.TabIndex = 1;
            this.txtCarikodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtCarikodu_ButtonClick);
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
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Belge Numarası";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Image = global::OnMuhasebe.Properties.Resources.Kapat24x24;
            this.btnKapat.Location = new System.Drawing.Point(769, 14);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(79, 35);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Image = global::OnMuhasebe.Properties.Resources.Kaydet24x241;
            this.btnKaydet.Location = new System.Drawing.Point(684, 13);
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
            this.btnYeni.Location = new System.Drawing.Point(599, 13);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(79, 35);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Location = new System.Drawing.Point(568, 9);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 13);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Toplam Tutar";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToplamTutar.EditValue = "0,00";
            this.txtToplamTutar.Location = new System.Drawing.Point(653, 6);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Properties.Appearance.Options.UseTextOptions = true;
            this.txtToplamTutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtToplamTutar.Size = new System.Drawing.Size(183, 20);
            this.txtToplamTutar.TabIndex = 2;
            this.txtToplamTutar.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnKapat);
            this.panelControl2.Controls.Add(this.btnKaydet);
            this.panelControl2.Controls.Add(this.btnYeni);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 40);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(876, 58);
            this.panelControl2.TabIndex = 17;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.txtToplamTutar);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 387);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(880, 100);
            this.panelControl1.TabIndex = 20;
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
            this.Liste.Size = new System.Drawing.Size(880, 286);
            this.Liste.TabIndex = 21;
            this.Liste.UseEmbeddedNavigator = true;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCEKNO,
            this.colVADETARIHI,
            this.colBANKA,
            this.colSUBE,
            this.colTUTAR,
            this.DIZIID,
            this.ID});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCEKNO
            // 
            this.colCEKNO.ColumnEdit = this.btnSec;
            this.colCEKNO.FieldName = "CEKNO";
            this.colCEKNO.Name = "colCEKNO";
            this.colCEKNO.OptionsColumn.FixedWidth = true;
            this.colCEKNO.OptionsColumn.ReadOnly = true;
            this.colCEKNO.Visible = true;
            this.colCEKNO.VisibleIndex = 0;
            // 
            // btnSec
            // 
            this.btnSec.AutoHeight = false;
            this.btnSec.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnSec.Name = "btnSec";
            this.btnSec.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSec_ButtonClick);
            // 
            // colVADETARIHI
            // 
            this.colVADETARIHI.DisplayFormat.FormatString = "d";
            this.colVADETARIHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colVADETARIHI.FieldName = "VADETARIHI";
            this.colVADETARIHI.Name = "colVADETARIHI";
            this.colVADETARIHI.OptionsColumn.AllowEdit = false;
            this.colVADETARIHI.OptionsColumn.AllowFocus = false;
            this.colVADETARIHI.OptionsColumn.FixedWidth = true;
            this.colVADETARIHI.OptionsColumn.ReadOnly = true;
            this.colVADETARIHI.Visible = true;
            this.colVADETARIHI.VisibleIndex = 1;
            // 
            // colBANKA
            // 
            this.colBANKA.FieldName = "BANKA";
            this.colBANKA.Name = "colBANKA";
            this.colBANKA.OptionsColumn.AllowEdit = false;
            this.colBANKA.OptionsColumn.AllowFocus = false;
            this.colBANKA.OptionsColumn.ReadOnly = true;
            this.colBANKA.Visible = true;
            this.colBANKA.VisibleIndex = 2;
            // 
            // colSUBE
            // 
            this.colSUBE.FieldName = "SUBE";
            this.colSUBE.Name = "colSUBE";
            this.colSUBE.OptionsColumn.AllowEdit = false;
            this.colSUBE.OptionsColumn.FixedWidth = true;
            this.colSUBE.OptionsColumn.ReadOnly = true;
            this.colSUBE.Visible = true;
            this.colSUBE.VisibleIndex = 3;
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
            this.colTUTAR.VisibleIndex = 4;
            // 
            // DIZIID
            // 
            this.DIZIID.Caption = "DIZIID";
            this.DIZIID.FieldName = "DIZIID";
            this.DIZIID.Name = "DIZIID";
            this.DIZIID.OptionsColumn.AllowShowHide = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowShowHide = false;
            // 
            // frmCariyeCekCikisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 487);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmCariyeCekCikisi";
            this.Text = "frmCariyeCekCikisi";
            this.Load += new System.EventHandler(this.frmCariyeCekCikisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumara.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarikodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cEKGIRISIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cekGirisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCariAdi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.ButtonEdit txtNumara;
        private DevExpress.XtraEditors.ButtonEdit txtCarikodu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtToplamTutar;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource cEKGIRISIBindingSource;
        private CekGirisi cekGirisi;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCEKNO;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSec;
        private DevExpress.XtraGrid.Columns.GridColumn colVADETARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn colBANKA;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBE;
        private DevExpress.XtraGrid.Columns.GridColumn colTUTAR;
        private DevExpress.XtraGrid.Columns.GridColumn DIZIID;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
    }
}