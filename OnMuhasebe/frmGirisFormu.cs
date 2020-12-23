using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OnMuhasebe
{
    public partial class frmGirisFormu : DevExpress.XtraEditors.XtraForm
    {
        public frmGirisFormu()
        {
            InitializeComponent();
        }
        OnMuhasebe.Classlar.GirisIslemi Giris = new Classlar.GirisIslemi();
        private void frmGirisFormu_Load(object sender, EventArgs e)
        {
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //BackColor = Color.Gray;
            //TransparencyKey = BackColor;


            //PAROLA ANIMSAMA İŞLEMLERİ

            if (OnMuhasebe.Properties.Settings.Default.Animsa==true)
            {
                txtKullaniciAdi.Text = OnMuhasebe.Properties.Settings.Default.KullaniciAdi;
                txtParola.Text = OnMuhasebe.Properties.Settings.Default.Parola;
                cheAnimsa.Checked = true;
            }


            //this.reportViewer1.RefreshReport();
        }
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new Classlar.Mesajlar();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (Giris.KullaniciGirisi(txtKullaniciAdi.Text, txtParola.Text))
            {

                //PAROLA ANIMSAMA İŞLEMLERİ
              
                //Projenin properties kısmındaki settings kısmındakine değeri atadık.
                OnMuhasebe.Properties.Settings.Default.Animsa = cheAnimsa.Checked;
                OnMuhasebe.Properties.Settings.Default.KullaniciAdi = txtKullaniciAdi.Text;
                OnMuhasebe.Properties.Settings.Default.Parola = txtParola.Text;
                OnMuhasebe.Properties.Settings.Default.Save();


                this.Close();
            }
            else
            {
                if (frmAnaForm.ErisimBilgisiHatasi==true)
                {
                    Mesajlar.Uyarı("Yanlış giriş yaptınız .Lütfen tekrar deneyiniz! ");
                }
               
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new Classlar.Ekranlar();
        private void btnServerAyarlari_Click(object sender, EventArgs e)
        {
            Ekranlar.ServerAyarlari();
        }
    }
}