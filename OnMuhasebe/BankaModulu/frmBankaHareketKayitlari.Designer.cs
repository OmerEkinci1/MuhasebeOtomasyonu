namespace OnMuhasebe.BankaModulu
{
    partial class frmBankaHareketKayitlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankaHareketKayitlari));
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtBankaAdi = new DevExpress.XtraEditors.TextEdit();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KASAID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FISNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HAREKETID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCikis = new DevExpress.XtraEditors.TextEdit();
            this.txtGiris = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "GİRİS TUTAR";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.MinWidth = 23;
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.AllowShowHide = false;
            this.GIRIS.OptionsColumn.FixedWidth = true;
            this.GIRIS.OptionsColumn.ReadOnly = true;
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 2;
            this.GIRIS.Width = 142;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "ÇIKIŞ TUTAR";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.MinWidth = 23;
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.AllowShowHide = false;
            this.CIKIS.OptionsColumn.FixedWidth = true;
            this.CIKIS.OptionsColumn.ReadOnly = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 3;
            this.CIKIS.Width = 134;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtKodu);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtBankaAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1028, 105);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Banka Bilgileri";
            // 
            // txtKodu
            // 
            this.txtKodu.Location = new System.Drawing.Point(125, 32);
            this.txtKodu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKodu.Name = "txtKodu";
            this.txtKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtKodu.Properties.ReadOnly = true;
            this.txtKodu.Size = new System.Drawing.Size(492, 22);
            this.txtKodu.TabIndex = 1;
            this.txtKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtKodu_ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 16);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Hesap No";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 76);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 16);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Banka Adı";
            // 
            // txtBankaAdi
            // 
            this.txtBankaAdi.EditValue = "";
            this.txtBankaAdi.Location = new System.Drawing.Point(125, 73);
            this.txtBankaAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBankaAdi.Name = "txtBankaAdi";
            this.txtBankaAdi.Properties.ReadOnly = true;
            this.txtBankaAdi.Size = new System.Drawing.Size(492, 22);
            this.txtBankaAdi.TabIndex = 2;
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
            this.Liste.Size = new System.Drawing.Size(1028, 352);
            this.Liste.TabIndex = 10;
            this.Liste.UseEmbeddedNavigator = true;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KASAID,
            this.FISNO,
            this.TARIH,
            this.GIRIS,
            this.CIKIS,
            this.CARIKODU,
            this.CARIISIM,
            this.TIPI,
            this.HAREKETID,
            this.GCKODU,
            this.ACIKLAMA});
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
            // KASAID
            // 
            this.KASAID.Caption = "ID";
            this.KASAID.FieldName = "KASAID";
            this.KASAID.MinWidth = 23;
            this.KASAID.Name = "KASAID";
            this.KASAID.OptionsColumn.AllowEdit = false;
            this.KASAID.OptionsColumn.AllowFocus = false;
            this.KASAID.OptionsColumn.AllowShowHide = false;
            this.KASAID.OptionsColumn.FixedWidth = true;
            this.KASAID.OptionsColumn.ReadOnly = true;
            this.KASAID.Width = 87;
            // 
            // FISNO
            // 
            this.FISNO.Caption = "FISNO";
            this.FISNO.FieldName = "FISNO";
            this.FISNO.MinWidth = 23;
            this.FISNO.Name = "FISNO";
            this.FISNO.OptionsColumn.AllowEdit = false;
            this.FISNO.OptionsColumn.AllowFocus = false;
            this.FISNO.OptionsColumn.AllowShowHide = false;
            this.FISNO.OptionsColumn.FixedWidth = true;
            this.FISNO.OptionsColumn.ReadOnly = true;
            this.FISNO.Visible = true;
            this.FISNO.VisibleIndex = 0;
            this.FISNO.Width = 169;
            // 
            // TARIH
            // 
            this.TARIH.Caption = "TARİH";
            this.TARIH.FieldName = "TARIH";
            this.TARIH.MinWidth = 23;
            this.TARIH.Name = "TARIH";
            this.TARIH.OptionsColumn.AllowEdit = false;
            this.TARIH.OptionsColumn.AllowFocus = false;
            this.TARIH.OptionsColumn.AllowShowHide = false;
            this.TARIH.OptionsColumn.FixedWidth = true;
            this.TARIH.OptionsColumn.ReadOnly = true;
            this.TARIH.Visible = true;
            this.TARIH.VisibleIndex = 1;
            this.TARIH.Width = 161;
            // 
            // CARIKODU
            // 
            this.CARIKODU.Caption = "CARİ KODU";
            this.CARIKODU.FieldName = "CARIKODU";
            this.CARIKODU.MinWidth = 23;
            this.CARIKODU.Name = "CARIKODU";
            this.CARIKODU.OptionsColumn.AllowEdit = false;
            this.CARIKODU.OptionsColumn.AllowFocus = false;
            this.CARIKODU.OptionsColumn.AllowShowHide = false;
            this.CARIKODU.OptionsColumn.FixedWidth = true;
            this.CARIKODU.OptionsColumn.ReadOnly = true;
            this.CARIKODU.Visible = true;
            this.CARIKODU.VisibleIndex = 5;
            this.CARIKODU.Width = 156;
            // 
            // CARIISIM
            // 
            this.CARIISIM.Caption = "CARİ İSİM";
            this.CARIISIM.FieldName = "CARIISIM";
            this.CARIISIM.MinWidth = 23;
            this.CARIISIM.Name = "CARIISIM";
            this.CARIISIM.OptionsColumn.AllowEdit = false;
            this.CARIISIM.OptionsColumn.AllowFocus = false;
            this.CARIISIM.OptionsColumn.AllowShowHide = false;
            this.CARIISIM.OptionsColumn.FixedWidth = true;
            this.CARIISIM.OptionsColumn.ReadOnly = true;
            this.CARIISIM.Visible = true;
            this.CARIISIM.VisibleIndex = 6;
            this.CARIISIM.Width = 177;
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
            this.TIPI.VisibleIndex = 4;
            this.TIPI.Width = 87;
            // 
            // HAREKETID
            // 
            this.HAREKETID.Caption = "HAREKET ID";
            this.HAREKETID.FieldName = "HAREKETID";
            this.HAREKETID.MinWidth = 23;
            this.HAREKETID.Name = "HAREKETID";
            this.HAREKETID.OptionsColumn.AllowShowHide = false;
            this.HAREKETID.Width = 87;
            // 
            // GCKODU
            // 
            this.GCKODU.Caption = "GCKODU";
            this.GCKODU.FieldName = "GCKODU";
            this.GCKODU.MinWidth = 23;
            this.GCKODU.Name = "GCKODU";
            this.GCKODU.OptionsColumn.AllowEdit = false;
            this.GCKODU.OptionsColumn.AllowFocus = false;
            this.GCKODU.OptionsColumn.AllowShowHide = false;
            this.GCKODU.OptionsColumn.FixedWidth = true;
            this.GCKODU.OptionsColumn.ReadOnly = true;
            this.GCKODU.Visible = true;
            this.GCKODU.VisibleIndex = 7;
            this.GCKODU.Width = 87;
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "ACIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.MinWidth = 23;
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 8;
            this.ACIKLAMA.Width = 87;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 55);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 16);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Toplam Alacak";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtBakiye);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtCikis);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtGiris);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 457);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1028, 123);
            this.panelControl1.TabIndex = 11;
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
            this.labelControl4.Size = new System.Drawing.Size(72, 16);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Toplam Borç";
            // 
            // txtCikis
            // 
            this.txtCikis.EditValue = "";
            this.txtCikis.Location = new System.Drawing.Point(421, 52);
            this.txtCikis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCikis.Name = "txtCikis";
            this.txtCikis.Properties.ReadOnly = true;
            this.txtCikis.Size = new System.Drawing.Size(175, 22);
            this.txtCikis.TabIndex = 13;
            // 
            // txtGiris
            // 
            this.txtGiris.EditValue = "";
            this.txtGiris.Location = new System.Drawing.Point(125, 52);
            this.txtGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Properties.ReadOnly = true;
            this.txtGiris.Size = new System.Drawing.Size(175, 22);
            this.txtGiris.TabIndex = 13;
            // 
            // frmBankaHareketKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 580);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBankaHareketKayitlari";
            this.Text = "Banka Hareket Kayıtları";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtBankaAdi;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn KASAID;
        private DevExpress.XtraGrid.Columns.GridColumn FISNO;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn CARIKODU;
        private DevExpress.XtraGrid.Columns.GridColumn CARIISIM;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI;
        private DevExpress.XtraGrid.Columns.GridColumn HAREKETID;
        private DevExpress.XtraGrid.Columns.GridColumn GCKODU;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCikis;
        private DevExpress.XtraEditors.TextEdit txtGiris;
        private DevExpress.XtraEditors.ButtonEdit txtKodu;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
    }
}