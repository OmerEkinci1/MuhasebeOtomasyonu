namespace OnMuhasebe.StokModulu
{
    partial class frmStokListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokListesi));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtKod5 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKod3 = new DevExpress.XtraEditors.TextEdit();
            this.txtKod4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtKod2 = new DevExpress.XtraEditors.TextEdit();
            this.txtKod1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SATISFIYAT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MIKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KOD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KOD2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KOD3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KOD4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KOD5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SagMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SagEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.SagGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.SagSil = new System.Windows.Forms.ToolStripMenuItem();
            this.SagHareketler = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SagMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainerControl1.Size = new System.Drawing.Size(779, 467);
            this.splitContainerControl1.SplitterPosition = 259;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(259, 467);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.txtKod5);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtKod3);
            this.xtraTabPage1.Controls.Add(this.txtKod4);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.txtKod2);
            this.xtraTabPage1.Controls.Add(this.txtKod1);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtStokAdi);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtStokKodu);
            this.xtraTabPage1.Controls.Add(this.btnTemizle);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(256, 442);
            this.xtraTabPage1.Text = "Arama";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 344);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Kod 5:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 226);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Kod 3:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 285);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Kod 4:";
            // 
            // txtKod5
            // 
            this.txtKod5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKod5.Location = new System.Drawing.Point(11, 363);
            this.txtKod5.Name = "txtKod5";
            this.txtKod5.Size = new System.Drawing.Size(242, 20);
            this.txtKod5.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 167);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Kod 2:";
            // 
            // txtKod3
            // 
            this.txtKod3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKod3.Location = new System.Drawing.Point(11, 245);
            this.txtKod3.Name = "txtKod3";
            this.txtKod3.Size = new System.Drawing.Size(242, 20);
            this.txtKod3.TabIndex = 5;
            // 
            // txtKod4
            // 
            this.txtKod4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKod4.Location = new System.Drawing.Point(11, 304);
            this.txtKod4.Name = "txtKod4";
            this.txtKod4.Size = new System.Drawing.Size(242, 20);
            this.txtKod4.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(11, 117);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(31, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Kod 1:";
            // 
            // txtKod2
            // 
            this.txtKod2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKod2.Location = new System.Drawing.Point(11, 186);
            this.txtKod2.Name = "txtKod2";
            this.txtKod2.Size = new System.Drawing.Size(242, 20);
            this.txtKod2.TabIndex = 7;
            // 
            // txtKod1
            // 
            this.txtKod1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKod1.Location = new System.Drawing.Point(11, 136);
            this.txtKod1.Name = "txtKod1";
            this.txtKod1.Size = new System.Drawing.Size(242, 20);
            this.txtKod1.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Stok Adı:";
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokAdi.Location = new System.Drawing.Point(11, 92);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(242, 20);
            this.txtStokAdi.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Stok Kodu:";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStokKodu.Location = new System.Drawing.Point(11, 37);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(242, 20);
            this.txtStokKodu.TabIndex = 1;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(92, 401);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(89, 31);
            this.btnTemizle.TabIndex = 0;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Image = global::OnMuhasebe.Properties.Resources.Ac;
            this.btnAra.Location = new System.Drawing.Point(11, 401);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 31);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Arama";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Liste
            // 
            this.Liste.ContextMenuStrip = this.SagMenu;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(515, 467);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STOKKODU,
            this.STOKADI,
            this.SATISFIYAT1,
            this.MIKTAR,
            this.KOD1,
            this.KOD2,
            this.KOD3,
            this.KOD4,
            this.KOD5});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
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
            // STOKKODU
            // 
            this.STOKKODU.Caption = "STOKKODU";
            this.STOKKODU.FieldName = "STOKKODU";
            this.STOKKODU.Name = "STOKKODU";
            this.STOKKODU.OptionsColumn.AllowEdit = false;
            this.STOKKODU.OptionsColumn.AllowFocus = false;
            this.STOKKODU.OptionsColumn.FixedWidth = true;
            this.STOKKODU.OptionsColumn.ReadOnly = true;
            this.STOKKODU.Visible = true;
            this.STOKKODU.VisibleIndex = 0;
            this.STOKKODU.Width = 150;
            // 
            // STOKADI
            // 
            this.STOKADI.Caption = "STOKADI";
            this.STOKADI.FieldName = "STOKADI";
            this.STOKADI.Name = "STOKADI";
            this.STOKADI.OptionsColumn.AllowEdit = false;
            this.STOKADI.OptionsColumn.AllowFocus = false;
            this.STOKADI.OptionsColumn.ReadOnly = true;
            this.STOKADI.Visible = true;
            this.STOKADI.VisibleIndex = 1;
            this.STOKADI.Width = 300;
            // 
            // SATISFIYAT1
            // 
            this.SATISFIYAT1.Caption = "SATISFIYAT1";
            this.SATISFIYAT1.FieldName = "SATISFIYAT1";
            this.SATISFIYAT1.Name = "SATISFIYAT1";
            this.SATISFIYAT1.OptionsColumn.AllowEdit = false;
            this.SATISFIYAT1.OptionsColumn.AllowFocus = false;
            this.SATISFIYAT1.OptionsColumn.FixedWidth = true;
            this.SATISFIYAT1.OptionsColumn.ReadOnly = true;
            this.SATISFIYAT1.Visible = true;
            this.SATISFIYAT1.VisibleIndex = 2;
            // 
            // MIKTAR
            // 
            this.MIKTAR.Caption = "MIKTAR";
            this.MIKTAR.FieldName = "MIKTAR";
            this.MIKTAR.Name = "MIKTAR";
            this.MIKTAR.OptionsColumn.AllowEdit = false;
            this.MIKTAR.OptionsColumn.AllowFocus = false;
            this.MIKTAR.OptionsColumn.FixedWidth = true;
            this.MIKTAR.OptionsColumn.ReadOnly = true;
            this.MIKTAR.Visible = true;
            this.MIKTAR.VisibleIndex = 3;
            // 
            // KOD1
            // 
            this.KOD1.Caption = "KOD1";
            this.KOD1.FieldName = "KOD1";
            this.KOD1.Name = "KOD1";
            this.KOD1.OptionsColumn.AllowEdit = false;
            this.KOD1.OptionsColumn.AllowFocus = false;
            this.KOD1.OptionsColumn.FixedWidth = true;
            this.KOD1.OptionsColumn.ReadOnly = true;
            this.KOD1.Visible = true;
            this.KOD1.VisibleIndex = 4;
            this.KOD1.Width = 120;
            // 
            // KOD2
            // 
            this.KOD2.Caption = "KOD2";
            this.KOD2.FieldName = "KOD2";
            this.KOD2.Name = "KOD2";
            this.KOD2.OptionsColumn.AllowEdit = false;
            this.KOD2.OptionsColumn.AllowFocus = false;
            this.KOD2.OptionsColumn.FixedWidth = true;
            this.KOD2.OptionsColumn.ReadOnly = true;
            this.KOD2.Visible = true;
            this.KOD2.VisibleIndex = 5;
            this.KOD2.Width = 120;
            // 
            // KOD3
            // 
            this.KOD3.Caption = "KOD3";
            this.KOD3.FieldName = "KOD3";
            this.KOD3.Name = "KOD3";
            this.KOD3.OptionsColumn.AllowEdit = false;
            this.KOD3.OptionsColumn.AllowFocus = false;
            this.KOD3.OptionsColumn.FixedWidth = true;
            this.KOD3.OptionsColumn.ReadOnly = true;
            this.KOD3.Visible = true;
            this.KOD3.VisibleIndex = 6;
            this.KOD3.Width = 120;
            // 
            // KOD4
            // 
            this.KOD4.Caption = "KOD4";
            this.KOD4.FieldName = "KOD4";
            this.KOD4.Name = "KOD4";
            this.KOD4.OptionsColumn.AllowEdit = false;
            this.KOD4.OptionsColumn.AllowFocus = false;
            this.KOD4.OptionsColumn.FixedWidth = true;
            this.KOD4.OptionsColumn.ReadOnly = true;
            this.KOD4.Visible = true;
            this.KOD4.VisibleIndex = 7;
            this.KOD4.Width = 120;
            // 
            // KOD5
            // 
            this.KOD5.Caption = "KOD5";
            this.KOD5.FieldName = "KOD5";
            this.KOD5.Name = "KOD5";
            this.KOD5.OptionsColumn.AllowEdit = false;
            this.KOD5.OptionsColumn.AllowFocus = false;
            this.KOD5.OptionsColumn.FixedWidth = true;
            this.KOD5.OptionsColumn.ReadOnly = true;
            this.KOD5.Visible = true;
            this.KOD5.VisibleIndex = 8;
            this.KOD5.Width = 120;
            // 
            // SagMenu
            // 
            this.SagMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SagEkle,
            this.SagGuncelle,
            this.SagSil,
            this.SagHareketler});
            this.SagMenu.Name = "SagMenu";
            this.SagMenu.Size = new System.Drawing.Size(187, 114);
            // 
            // SagEkle
            // 
            this.SagEkle.Name = "SagEkle";
            this.SagEkle.Size = new System.Drawing.Size(186, 22);
            this.SagEkle.Text = "Ekle";
            this.SagEkle.Click += new System.EventHandler(this.SagEkle_Click);
            // 
            // SagGuncelle
            // 
            this.SagGuncelle.Name = "SagGuncelle";
            this.SagGuncelle.Size = new System.Drawing.Size(186, 22);
            this.SagGuncelle.Text = "Güncelle";
            this.SagGuncelle.Click += new System.EventHandler(this.SagGuncelle_Click);
            // 
            // SagSil
            // 
            this.SagSil.Name = "SagSil";
            this.SagSil.Size = new System.Drawing.Size(186, 22);
            this.SagSil.Text = "Sil";
            this.SagSil.Click += new System.EventHandler(this.SagSil_Click);
            // 
            // SagHareketler
            // 
            this.SagHareketler.Name = "SagHareketler";
            this.SagHareketler.Size = new System.Drawing.Size(186, 22);
            this.SagHareketler.Text = "Stok Hareket Kayıtları";
            this.SagHareketler.Click += new System.EventHandler(this.SagHareketler_Click);
            // 
            // frmStokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 467);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmStokListesi";
            this.Text = "Stok Listesi";
            this.Load += new System.EventHandler(this.frmStokListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.SagMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn STOKKODU;
        private DevExpress.XtraGrid.Columns.GridColumn STOKADI;
        private DevExpress.XtraGrid.Columns.GridColumn SATISFIYAT1;
        private DevExpress.XtraGrid.Columns.GridColumn MIKTAR;
        private DevExpress.XtraGrid.Columns.GridColumn KOD1;
        private DevExpress.XtraGrid.Columns.GridColumn KOD2;
        private DevExpress.XtraGrid.Columns.GridColumn KOD3;
        private DevExpress.XtraGrid.Columns.GridColumn KOD4;
        private DevExpress.XtraGrid.Columns.GridColumn KOD5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtKod5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtKod3;
        private DevExpress.XtraEditors.TextEdit txtKod4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtKod2;
        private DevExpress.XtraEditors.TextEdit txtKod1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private System.Windows.Forms.ContextMenuStrip SagMenu;
        private System.Windows.Forms.ToolStripMenuItem SagEkle;
        private System.Windows.Forms.ToolStripMenuItem SagGuncelle;
        private System.Windows.Forms.ToolStripMenuItem SagSil;
        private System.Windows.Forms.ToolStripMenuItem SagHareketler;
    }
}