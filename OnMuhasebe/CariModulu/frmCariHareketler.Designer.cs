namespace OnMuhasebe.CariModulu
{
    partial class frmCariHareketler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariHareketler));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCariSec = new DevExpress.XtraEditors.SimpleButton();
            this.txtCariKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariIsim = new DevExpress.XtraEditors.TextEdit();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VADETARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BORC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ALACAK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtToplamBorc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtToplamAlacak = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariIsim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamBorc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamAlacak.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnCariSec);
            this.groupControl1.Controls.Add(this.txtCariKodu);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtCariIsim);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1267, 105);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Cari Bilgileri";
            // 
            // btnCariSec
            // 
            this.btnCariSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCariSec.ImageOptions.Image")));
            this.btnCariSec.Location = new System.Drawing.Point(582, 23);
            this.btnCariSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCariSec.Name = "btnCariSec";
            this.btnCariSec.Size = new System.Drawing.Size(35, 34);
            this.btnCariSec.TabIndex = 14;
            this.btnCariSec.Click += new System.EventHandler(this.btnCariSec_Click);
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.EditValue = "";
            this.txtCariKodu.Location = new System.Drawing.Point(125, 28);
            this.txtCariKodu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Properties.ReadOnly = true;
            this.txtCariKodu.Size = new System.Drawing.Size(450, 22);
            this.txtCariKodu.TabIndex = 1;
            this.txtCariKodu.EditValueChanged += new System.EventHandler(this.txtCariKodu_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 16);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Cari Kodu:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 76);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 16);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Cari İsmi:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // txtCariIsim
            // 
            this.txtCariIsim.EditValue = "";
            this.txtCariIsim.Location = new System.Drawing.Point(125, 73);
            this.txtCariIsim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCariIsim.Name = "txtCariIsim";
            this.txtCariIsim.Properties.ReadOnly = true;
            this.txtCariIsim.Size = new System.Drawing.Size(492, 22);
            this.txtCariIsim.TabIndex = 2;
            this.txtCariIsim.EditValueChanged += new System.EventHandler(this.txtCariIsim_EditValueChanged);
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
            this.Liste.Size = new System.Drawing.Size(1267, 256);
            this.Liste.TabIndex = 1;
            this.Liste.UseEmbeddedNavigator = true;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.BELGENO,
            this.ACIKLAMA,
            this.VADETARIHI,
            this.BORC,
            this.ALACAK,
            this.BAKIYE,
            this.TARIH,
            this.TIPI});
            this.gridView1.DetailHeight = 431;
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
            this.ID.OptionsColumn.AllowShowHide = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.OptionsColumn.ReadOnly = true;
            this.ID.Width = 87;
            // 
            // BELGENO
            // 
            this.BELGENO.Caption = "BELGE NUMARASI";
            this.BELGENO.FieldName = "BELGENO";
            this.BELGENO.MinWidth = 23;
            this.BELGENO.Name = "BELGENO";
            this.BELGENO.OptionsColumn.AllowEdit = false;
            this.BELGENO.OptionsColumn.AllowFocus = false;
            this.BELGENO.OptionsColumn.FixedWidth = true;
            this.BELGENO.OptionsColumn.ReadOnly = true;
            this.BELGENO.Visible = true;
            this.BELGENO.VisibleIndex = 0;
            this.BELGENO.Width = 175;
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "AÇIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.MinWidth = 23;
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.ACIKLAMA.OptionsColumn.ReadOnly = true;
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 4;
            this.ACIKLAMA.Width = 350;
            // 
            // VADETARIHI
            // 
            this.VADETARIHI.Caption = "VADE TARİHİ";
            this.VADETARIHI.FieldName = "VADETARIHI";
            this.VADETARIHI.MinWidth = 23;
            this.VADETARIHI.Name = "VADETARIHI";
            this.VADETARIHI.OptionsColumn.AllowEdit = false;
            this.VADETARIHI.OptionsColumn.AllowFocus = false;
            this.VADETARIHI.OptionsColumn.FixedWidth = true;
            this.VADETARIHI.OptionsColumn.ReadOnly = true;
            this.VADETARIHI.Visible = true;
            this.VADETARIHI.VisibleIndex = 2;
            this.VADETARIHI.Width = 87;
            // 
            // BORC
            // 
            this.BORC.Caption = "BORÇ";
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
            this.BORC.VisibleIndex = 5;
            this.BORC.Width = 117;
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
            this.ALACAK.VisibleIndex = 6;
            this.ALACAK.Width = 117;
            // 
            // BAKIYE
            // 
            this.BAKIYE.Caption = "BAKİYE";
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
            this.BAKIYE.VisibleIndex = 7;
            this.BAKIYE.Width = 117;
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
            this.TARIH.VisibleIndex = 1;
            this.TARIH.Width = 140;
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
            this.TIPI.VisibleIndex = 3;
            this.TIPI.Width = 140;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txtBakiye);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.txtToplamBorc);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtToplamAlacak);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 361);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1267, 123);
            this.panelControl1.TabIndex = 5;
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
            // txtToplamBorc
            // 
            this.txtToplamBorc.EditValue = "";
            this.txtToplamBorc.Location = new System.Drawing.Point(421, 52);
            this.txtToplamBorc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToplamBorc.Name = "txtToplamBorc";
            this.txtToplamBorc.Properties.ReadOnly = true;
            this.txtToplamBorc.Size = new System.Drawing.Size(175, 22);
            this.txtToplamBorc.TabIndex = 13;
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
            // txtToplamAlacak
            // 
            this.txtToplamAlacak.EditValue = "";
            this.txtToplamAlacak.Location = new System.Drawing.Point(125, 52);
            this.txtToplamAlacak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToplamAlacak.Name = "txtToplamAlacak";
            this.txtToplamAlacak.Properties.ReadOnly = true;
            this.txtToplamAlacak.Size = new System.Drawing.Size(175, 22);
            this.txtToplamAlacak.TabIndex = 13;
            // 
            // frmCariHareketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 484);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCariHareketler";
            this.Text = "Cari Hareket Kayıtları";
            this.Load += new System.EventHandler(this.frmCariHareketler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariIsim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamBorc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamAlacak.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCariSec;
        private DevExpress.XtraEditors.TextEdit txtCariKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCariIsim;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn BELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn VADETARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn BORC;
        private DevExpress.XtraGrid.Columns.GridColumn ALACAK;
        private DevExpress.XtraGrid.Columns.GridColumn BAKIYE;
        private DevExpress.XtraGrid.Columns.GridColumn TARIH;
        private DevExpress.XtraGrid.Columns.GridColumn TIPI;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtToplamBorc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtToplamAlacak;
    }
}