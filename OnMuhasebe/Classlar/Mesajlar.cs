using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OnMuhasebe.Classlar
{
    class Mesajlar
    {
        public Boolean Sor(string Mesaj)
        {
            DialogResult Sor = new DialogResult();
            Sor = MessageBox.Show(Mesaj, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Sor==DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        public void Bilgi(string Mesaj)
        {
            MessageBox.Show(Mesaj,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void Uyarı(string Mesaj)
        {
            MessageBox.Show(Mesaj, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Hata()
        {
            MessageBox.Show("Beklenmedik bir hata oluştu.Lütfen tekrar deneyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
