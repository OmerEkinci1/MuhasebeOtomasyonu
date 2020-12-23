namespace OnMuhasebe
{
    partial class frmParolaDegistir
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEski = new DevExpress.XtraEditors.TextEdit();
            this.txtYeni = new DevExpress.XtraEditors.TextEdit();
            this.txtTekrar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtEski.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTekrar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Eski Parolanız";
            // 
            // txtEski
            // 
            this.txtEski.Location = new System.Drawing.Point(111, 12);
            this.txtEski.Name = "txtEski";
            this.txtEski.Size = new System.Drawing.Size(215, 20);
            this.txtEski.TabIndex = 2;
            // 
            // txtYeni
            // 
            this.txtYeni.Location = new System.Drawing.Point(111, 50);
            this.txtYeni.Name = "txtYeni";
            this.txtYeni.Size = new System.Drawing.Size(215, 20);
            this.txtYeni.TabIndex = 2;
            // 
            // txtTekrar
            // 
            this.txtTekrar.Location = new System.Drawing.Point(111, 87);
            this.txtTekrar.Name = "txtTekrar";
            this.txtTekrar.Size = new System.Drawing.Size(215, 20);
            this.txtTekrar.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Location = new System.Drawing.Point(32, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Yeni Parolanız";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(32, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Eski Parolanız";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Image = global::OnMuhasebe.Properties.Resources.Kapat24x24;
            this.simpleButton5.Location = new System.Drawing.Point(186, 126);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(120, 35);
            this.simpleButton5.TabIndex = 3;
            this.simpleButton5.Text = "Kapat";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::OnMuhasebe.Properties.Resources.Kaydet24x241;
            this.btnKaydet.Location = new System.Drawing.Point(48, 126);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 35);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmParolaDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 225);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtTekrar);
            this.Controls.Add(this.txtYeni);
            this.Controls.Add(this.txtEski);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmParolaDegistir";
            this.Text = "Parola Değiştir";
            ((System.ComponentModel.ISupportInitialize)(this.txtEski.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYeni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTekrar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEski;
        private DevExpress.XtraEditors.TextEdit txtYeni;
        private DevExpress.XtraEditors.TextEdit txtTekrar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}