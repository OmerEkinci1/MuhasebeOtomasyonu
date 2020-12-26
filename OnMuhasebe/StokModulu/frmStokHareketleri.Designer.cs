namespace OnMuhasebe.StokModulu
{
    partial class frmStokHareketleri
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokHareketleri));
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FATURANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BRUTFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISK2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BIRIMFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnStokSec = new DevExpress.XtraEditors.SimpleButton();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokismi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtToplamCikis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtToplamGiris = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokismi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamCikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamGiris.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "GİRİŞ";
            this.GIRIS.DisplayFormat.FormatString = "N2";
            this.GIRIS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.MinWidth = 23;
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.FixedWidth = true;
            this.GIRIS.OptionsColumn.ReadOnly = true;
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 5;
            this.GIRIS.Width = 87;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "ÇIKIŞ";
            this.CIKIS.DisplayFormat.FormatString = "N2";
            this.CIKIS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.MinWidth = 23;
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.FixedWidth = true;
            this.CIKIS.OptionsColumn.ReadOnly = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 6;
            this.CIKIS.Width = 87;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.Liste.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.Liste.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.Liste.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.Liste.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.Liste.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Liste.Location = new System.Drawing.Point(0, 105);
            this.Liste.MainView = this.gridView1;
            this.Liste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(1020, 378);
            this.Liste.TabIndex = 3;
            this.Liste.UseEmbeddedNavigator = true;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Liste.Click += new System.EventHandler(this.Liste_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.CARIKODU,
            this.CARIISIM,
            this.FATURANO,
            this.TARIH,
            this.GCKOD,
            this.GIRIS,
            this.CIKIS,
            this.BRUTFIYAT,
            this.ISK1,
            this.ISK2,
            this.BIRIMFIYAT,
            this.TIPI});
            this.gridView1.DetailHeight = 431;
            gridFormatRule1.Column = this.GIRIS;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue1.Appearance.Options.UseFont = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater;
            formatConditionRuleValue1.Value1 = "0";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.Column = this.CIKIS;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleValue2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            formatConditionRuleValue2.Appearance.Options.UseFont = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Greater;
            formatConditionRuleValue2.Value1 = "0";
            gridFormatRule2.Rule = formatConditionRuleValue2;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
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
            this.ID.MinWidth = 23;
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.OptionsColumn.ReadOnly = true;
            this.ID.Width = 87;
            // 
            // CARIKODU
            // 
            this.CARIKODU.Caption = "CARİ KODU";
            this.CARIKODU.FieldName = "CARIKODU";
            this.CARIKODU.MinWidth = 23;
            this.CARIKODU.Name = "CARIKODU";
            this.CARIKODU.OptionsColumn.AllowEdit = false;
            this.CARIKODU.OptionsColumn.AllowFocus = false;
            this.CARIKODU.OptionsColumn.FixedWidth = true;
            this.CARIKODU.OptionsColumn.ReadOnly = true;
            this.CARIKODU.Visible = true;
            this.CARIKODU.VisibleIndex = 0;
            this.CARIKODU.Width = 87;
            // 
            // CARIISIM
            // 
            this.CARIISIM.Caption = "CARİ İSİM";
            this.CARIISIM.FieldName = "CARIISIM";
            this.CARIISIM.MinWidth = 23;
            this.CARIISIM.Name = "CARIISIM";
            this.CARIISIM.OptionsColumn.AllowEdit = false;
            this.CARIISIM.OptionsColumn.AllowFocus = false;
            this.CARIISIM.OptionsColumn.FixedWidth = true;
            this.CARIISIM.OptionsColumn.ReadOnly = true;
            this.CARIISIM.Visible = true;
            this.CARIISIM.VisibleIndex = 1;
            this.CARIISIM.Width = 87;
            // 
            // FATURANO
            // 
            this.FATURANO.Caption = "FATURA NO";
            this.FATURANO.FieldName = "FATURANO";
            this.FATURANO.MinWidth = 23;
            this.FATURANO.Name = "FATURANO";
            this.FATURANO.OptionsColumn.AllowEdit = false;
            this.FATURANO.OptionsColumn.AllowFocus = false;
            this.FATURANO.OptionsColumn.FixedWidth = true;
            this.FATURANO.OptionsColumn.ReadOnly = true;
            this.FATURANO.Visible = true;
            this.FATURANO.VisibleIndex = 2;
            this.FATURANO.Width = 87;
            // 
            // TARIH
            // 
            this.TARIH.Caption = "TARİH";
            this.TARIH.FieldName = "TARIH";
            this.TARIH.MinWidth = 23;
            this.TARIH.Name = "TARIH";
            this.TARIH.OptionsColumn.AllowEdit = false;
            this.TARIH.OptionsColumn.AllowFocus = false;
            this.TARIH.OptionsColumn.FixedWidth = true;
            this.TARIH.OptionsColumn.ReadOnly = true;
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 3;
            this.TARIH.Width = 87;
            // 
            // GCKOD
            // 
            this.GCKOD.Caption = "GC KODU";
            this.GCKOD.FieldName = "GCKOD";
            this.GCKOD.MinWidth = 23;
            this.GCKOD.Name = "GCKOD";
            this.GCKOD.OptionsColumn.AllowEdit = false;
            this.GCKOD.OptionsColumn.AllowFocus = false;
            this.GCKOD.OptionsColumn.FixedWidth = true;
            this.GCKOD.OptionsColumn.ReadOnly = true;
            this.GCKOD.Visible = true;
            this.GCKOD.VisibleIndex = 4;
            this.GCKOD.Width = 87;
            // 
            // BRUTFIYAT
            // 
            this.BRUTFIYAT.Caption = "BRÜT FİYAT";
            this.BRUTFIYAT.DisplayFormat.FormatString = "N2";
            this.BRUTFIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BRUTFIYAT.FieldName = "BRUTFIYAT";
            this.BRUTFIYAT.MinWidth = 23;
            this.BRUTFIYAT.Name = "BRUTFIYAT";
            this.BRUTFIYAT.OptionsColumn.AllowEdit = false;
            this.BRUTFIYAT.OptionsColumn.AllowFocus = false;
            this.BRUTFIYAT.OptionsColumn.FixedWidth = true;
            this.BRUTFIYAT.OptionsColumn.ReadOnly = true;
            this.BRUTFIYAT.Visible = true;
            this.BRUTFIYAT.VisibleIndex = 7;
            this.BRUTFIYAT.Width = 87;
            // 
            // ISK1
            // 
            this.ISK1.Caption = "İSK 1 (%)";
            this.ISK1.DisplayFormat.FormatString = "N2";
            this.ISK1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ISK1.FieldName = "ISK1";
            this.ISK1.MinWidth = 23;
            this.ISK1.Name = "ISK1";
            this.ISK1.OptionsColumn.AllowEdit = false;
            this.ISK1.OptionsColumn.AllowFocus = false;
            this.ISK1.OptionsColumn.FixedWidth = true;
            this.ISK1.OptionsColumn.ReadOnly = true;
            this.ISK1.Visible = true;
            this.ISK1.VisibleIndex = 8;
            this.ISK1.Width = 87;
            // 
            // ISK2
            // 
            this.ISK2.Caption = "İSK 2 (%)";
            this.ISK2.DisplayFormat.FormatString = "N2";
            this.ISK2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ISK2.FieldName = "ISK2";
            this.ISK2.MinWidth = 23;
            this.ISK2.Name = "ISK2";
            this.ISK2.OptionsColumn.AllowEdit = false;
            this.ISK2.OptionsColumn.AllowFocus = false;
            this.ISK2.OptionsColumn.FixedWidth = true;
            this.ISK2.OptionsColumn.ReadOnly = true;
            this.ISK2.Visible = true;
            this.ISK2.VisibleIndex = 9;
            this.ISK2.Width = 87;
            // 
            // BIRIMFIYAT
            // 
            this.BIRIMFIYAT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BIRIMFIYAT.AppearanceCell.Options.UseBackColor = true;
            this.BIRIMFIYAT.Caption = "BİRİM FİYAT";
            this.BIRIMFIYAT.DisplayFormat.FormatString = "N2";
            this.BIRIMFIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BIRIMFIYAT.FieldName = "BIRIMFIYAT";
            this.BIRIMFIYAT.MinWidth = 23;
            this.BIRIMFIYAT.Name = "BIRIMFIYAT";
            this.BIRIMFIYAT.OptionsColumn.AllowEdit = false;
            this.BIRIMFIYAT.OptionsColumn.AllowFocus = false;
            this.BIRIMFIYAT.OptionsColumn.FixedWidth = true;
            this.BIRIMFIYAT.OptionsColumn.ReadOnly = true;
            this.BIRIMFIYAT.Visible = true;
            this.BIRIMFIYAT.VisibleIndex = 10;
            this.BIRIMFIYAT.Width = 87;
            // 
            // TIPI
            // 
            this.TIPI.Caption = "TİPİ";
            this.TIPI.FieldName = "TIPI";
            this.TIPI.MinWidth = 23;
            this.TIPI.Name = "TIPI";
            this.TIPI.OptionsColumn.AllowEdit = false;
            this.TIPI.OptionsColumn.AllowFocus = false;
            this.TIPI.OptionsColumn.FixedWidth = true;
            this.TIPI.OptionsColumn.ReadOnly = true;
            this.TIPI.Visible = true;
            this.TIPI.VisibleIndex = 11;
            this.TIPI.Width = 87;
            // 
            // btnStokSec
            // 
            this.btnStokSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStokSec.ImageOptions.Image")));
            this.btnStokSec.Location = new System.Drawing.Point(582, 23);
            this.btnStokSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStokSec.Name = "btnStokSec";
            this.btnStokSec.Size = new System.Drawing.Size(35, 34);
            this.btnStokSec.TabIndex = 14;
            this.btnStokSec.Click += new System.EventHandler(this.btnStokSec_Click);
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.EditValue = "";
            this.txtStokKodu.Location = new System.Drawing.Point(125, 28);
            this.txtStokKodu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Properties.ReadOnly = true;
            this.txtStokKodu.Size = new System.Drawing.Size(450, 22);
            this.txtStokKodu.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 16);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Stok Kodu:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 76);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 16);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Stok İsmi:";
            // 
            // txtStokismi
            // 
            this.txtStokismi.EditValue = "";
            this.txtStokismi.Location = new System.Drawing.Point(125, 73);
            this.txtStokismi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStokismi.Name = "txtStokismi";
            this.txtStokismi.Properties.ReadOnly = true;
            this.txtStokismi.Size = new System.Drawing.Size(492, 22);
            this.txtStokismi.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnStokSec);
            this.groupControl1.Controls.Add(this.txtStokKodu);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtStokismi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1020, 105);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Stok Bilgileri";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtBakiye);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtToplamCikis);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtToplamGiris);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 483);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1020, 123);
            this.panelControl1.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(622, 55);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 16);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Bakiye";
            // 
            // txtBakiye
            // 
            this.txtBakiye.EditValue = "";
            this.txtBakiye.Location = new System.Drawing.Point(715, 52);
            this.txtBakiye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBakiye.Properties.Appearance.Options.UseBackColor = true;
            this.txtBakiye.Properties.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(175, 22);
            this.txtBakiye.TabIndex = 13;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(328, 55);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 16);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Toplam Çıkış";
            // 
            // txtToplamCikis
            // 
            this.txtToplamCikis.EditValue = "";
            this.txtToplamCikis.Location = new System.Drawing.Point(421, 52);
            this.txtToplamCikis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToplamCikis.Name = "txtToplamCikis";
            this.txtToplamCikis.Properties.ReadOnly = true;
            this.txtToplamCikis.Size = new System.Drawing.Size(175, 22);
            this.txtToplamCikis.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 55);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 16);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Toplam Giriş";
            // 
            // txtToplamGiris
            // 
            this.txtToplamGiris.EditValue = "";
            this.txtToplamGiris.Location = new System.Drawing.Point(125, 52);
            this.txtToplamGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToplamGiris.Name = "txtToplamGiris";
            this.txtToplamGiris.Properties.ReadOnly = true;
            this.txtToplamGiris.Size = new System.Drawing.Size(175, 22);
            this.txtToplamGiris.TabIndex = 13;
            // 
            // frmStokHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 606);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStokHareketleri";
            this.Text = "Stok Hareket Kayıtları";
            this.Load += new System.EventHandler(this.frmStokHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokismi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamCikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamGiris.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraGrid.Columns.GridColumn CARIISIM;
        private DevExpress.XtraGrid.Columns.GridColumn FATURANO;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
        private DevExpress.XtraGrid.Columns.GridColumn GCKOD;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn BRUTFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn ISK1;
        private DevExpress.XtraGrid.Columns.GridColumn ISK2;
        private DevExpress.XtraGrid.Columns.GridColumn BIRIMFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI;
        private DevExpress.XtraEditors.SimpleButton btnStokSec;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtStokismi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtToplamCikis;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtToplamGiris;
    }
}