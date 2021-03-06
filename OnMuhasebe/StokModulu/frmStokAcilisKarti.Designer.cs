﻿namespace OnMuhasebe.StokModulu
{
    partial class frmStokAcilisKarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokAcilisKarti));
            this.raGiris = new System.Windows.Forms.RadioButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.raCikis = new System.Windows.Forms.RadioButton();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.txtBelgeNo = new DevExpress.XtraEditors.TextEdit();
            this.txtMiktar = new DevExpress.XtraEditors.TextEdit();
            this.btnStokSec = new DevExpress.XtraEditors.SimpleButton();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // raGiris
            // 
            this.raGiris.AutoSize = true;
            this.raGiris.Checked = true;
            this.raGiris.Location = new System.Drawing.Point(148, 279);
            this.raGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.raGiris.Name = "raGiris";
            this.raGiris.Size = new System.Drawing.Size(95, 21);
            this.raGiris.TabIndex = 29;
            this.raGiris.TabStop = true;
            this.raGiris.Text = "Giriş Miktarı";
            this.raGiris.UseVisualStyleBackColor = true;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.Yeni24x24;
            this.simpleButton2.Location = new System.Drawing.Point(42, 6);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(140, 43);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Yeni";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton5.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.Kapat24x24;
            this.simpleButton5.Location = new System.Drawing.Point(497, 6);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(140, 43);
            this.simpleButton5.TabIndex = 0;
            this.simpleButton5.Text = "Kapat";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.Kaydet24x241;
            this.btnKaydet.Location = new System.Drawing.Point(189, 6);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(140, 43);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.ImageOptions.Image = global::OnMuhasebe.Properties.Resources.Sil24x24;
            this.btnSil.Location = new System.Drawing.Point(345, 6);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(140, 43);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton5);
            this.panelControl1.Controls.Add(this.btnKaydet);
            this.panelControl1.Controls.Add(this.btnSil);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 313);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(663, 59);
            this.panelControl1.TabIndex = 39;
            // 
            // raCikis
            // 
            this.raCikis.AutoSize = true;
            this.raCikis.Location = new System.Drawing.Point(288, 279);
            this.raCikis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.raCikis.Name = "raCikis";
            this.raCikis.Size = new System.Drawing.Size(97, 21);
            this.raCikis.TabIndex = 30;
            this.raCikis.Text = "Çıkış Miktarı";
            this.raCikis.UseVisualStyleBackColor = true;
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(148, 154);
            this.txtTarih.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Size = new System.Drawing.Size(182, 22);
            this.txtTarih.TabIndex = 4;
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(148, 20);
            this.txtBelgeNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(182, 22);
            this.txtBelgeNo.TabIndex = 1;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(148, 197);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(182, 22);
            this.txtMiktar.TabIndex = 5;
            // 
            // btnStokSec
            // 
            this.btnStokSec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStokSec.ImageOptions.Image")));
            this.btnStokSec.Location = new System.Drawing.Point(605, 62);
            this.btnStokSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStokSec.Name = "btnStokSec";
            this.btnStokSec.Size = new System.Drawing.Size(35, 34);
            this.btnStokSec.TabIndex = 38;
            this.btnStokSec.Click += new System.EventHandler(this.btnStokSec_Click);
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.EditValue = "";
            this.txtStokKodu.Location = new System.Drawing.Point(148, 67);
            this.txtStokKodu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Properties.ReadOnly = true;
            this.txtStokKodu.Size = new System.Drawing.Size(450, 22);
            this.txtStokKodu.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(55, 24);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 16);
            this.labelControl6.TabIndex = 33;
            this.labelControl6.Text = "Belge No:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(55, 206);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 16);
            this.labelControl4.TabIndex = 34;
            this.labelControl4.Text = "Miktar";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(55, 71);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 16);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Stok Kodu:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(55, 163);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 16);
            this.labelControl3.TabIndex = 36;
            this.labelControl3.Text = "Tarih";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(55, 115);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 16);
            this.labelControl2.TabIndex = 37;
            this.labelControl2.Text = "Stok  İsmi:";
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.EditValue = "";
            this.txtStokAdi.Location = new System.Drawing.Point(148, 111);
            this.txtStokAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Properties.ReadOnly = true;
            this.txtStokAdi.Size = new System.Drawing.Size(492, 22);
            this.txtStokAdi.TabIndex = 3;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(56, 241);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(27, 16);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "Fiyat";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(149, 237);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(182, 22);
            this.txtFiyat.TabIndex = 6;
            // 
            // frmStokAcilisKarti
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButton5;
            this.ClientSize = new System.Drawing.Size(663, 372);
            this.Controls.Add(this.raGiris);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.raCikis);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtBelgeNo);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.btnStokSec);
            this.Controls.Add(this.txtStokKodu);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtStokAdi);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStokAcilisKarti";
            this.Text = "Stok Açılış Kartı";
            this.Load += new System.EventHandler(this.frmStokAcilisKarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton raGiris;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.RadioButton raCikis;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.TextEdit txtBelgeNo;
        private DevExpress.XtraEditors.TextEdit txtMiktar;
        private DevExpress.XtraEditors.SimpleButton btnStokSec;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
    }
}