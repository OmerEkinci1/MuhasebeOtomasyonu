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
    public partial class frmParolaDegistir : DevExpress.XtraEditors.XtraForm
    {
        public frmParolaDegistir()
        {
            InitializeComponent();
        }

        OnMuhasebe.Classlar.GirisIslemi Parola = new Classlar.GirisIslemi();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new Classlar.Mesajlar();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtEski.Text == txtTekrar.Text)
            {
                if (Parola.ParolaDegistir(frmAnaForm.UserId, txtEski.Text, txtYeni.Text))
                {
                    Mesajlar.Bilgi("Parolanız Başarılı Bir Şekilde Güncellenmiştir.");
                    this.Close();
                }
                else
                {
                    Mesajlar.Hata();
                }

            }
            else
            {
                Mesajlar.Uyarı("Parolalarınız uyuşmamaktadır.Lütfen Tekrar deneyiniz!");
            }
        }
    }
}