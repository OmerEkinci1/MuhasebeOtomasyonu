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
    public partial class frmServerAyarlari : DevExpress.XtraEditors.XtraForm
    {
        public frmServerAyarlari()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Projeye sağ tıklayıp Properties kısmındaki settings kısmında tanımladığımız değişkenlere değerleri atadık.
            OnMuhasebe.Properties.Settings.Default.ServerIpAdress = txtServer.Text;
            OnMuhasebe.Properties.Settings.Default.Veritabani = txtDatabase.Text;
            OnMuhasebe.Properties.Settings.Default.VeritabaniKullaniciAdi = txtUserName.Text;
            OnMuhasebe.Properties.Settings.Default.VeritabaniSifresi = txtPassword.Text;
            OnMuhasebe.Properties.Settings.Default.Save();//kayıt ettik.
            this.Close();
        }

        private void frmServerAyarlari_Load(object sender, EventArgs e)
        {
            //değerleri okuduk
            txtServer.Text = OnMuhasebe.Properties.Settings.Default.ServerIpAdress;
            txtDatabase.Text = OnMuhasebe.Properties.Settings.Default.Veritabani;
            txtUserName.Text = OnMuhasebe.Properties.Settings.Default.VeritabaniKullaniciAdi;
            txtPassword.Text = OnMuhasebe.Properties.Settings.Default.VeritabaniSifresi;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }
    }
}