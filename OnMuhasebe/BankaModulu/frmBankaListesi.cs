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

namespace OnMuhasebe.BankaModulu
{
    public partial class frmBankaListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmBankaListesi()
        {
            InitializeComponent();
        }


        Classlar.clsBanka Banka = new Classlar.clsBanka();
        public Boolean SecimIcinAc = false;
        string SecilenId = "-1";

        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();

        private void frmBankaListesi_Load(object sender, EventArgs e)
        {
            
        }



        void Listele()
        {
            Liste.DataSource = Banka.Listele(txtHesapno.Text, txtIban.Text, txtHesapAdi.Text, txtHesapAdi.Text, txtSube.Text, txtIlgili.Text);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (SecimIcinAc==true)
            {
                frmAnaForm.AraDegiskenString = SecilenId;//diğer forma veri aktarımı için static değişkeni kullandık
                this.Close();
            }
        }

        void Sec()
        {
            try
            {
                SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            }
            catch (Exception ex)
            {
                SecilenId = "-1";
            }
        }

        private void SagEkle_Click(object sender, EventArgs e)
        {
            Ekranlar.BankaTanitimKarti();
        }

        private void SagGuncelle_Click(object sender, EventArgs e)
        {
            Sec();
            Ekranlar.BankaTanitimKarti(true,SecilenId);
        }

        private void SagSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sor("Banka Tanıtım Kartını Silmek İstediğinizden Emin misiniz? ") == true)
            {
                Sec();
                if (Banka.Sil(SecilenId) == true)
                {
                    Mesajlar.Bilgi("Banka başarılı bir şekilde silinmiştir.");
                    Listele();
                    
                }
                else
                {
                    Mesajlar.Hata();
                }
            }
        }

        private void SagHareketler_Click(object sender, EventArgs e)
        {

        }

        private void bankaAçılışKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekranlar.BankaAcilisKarti();
        }

        private void bankaİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekranlar.BankaIslemi();
        }

        private void gelenHavaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekranlar.GelenHavale();
        }

        private void gönderilenHavaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekranlar.GonderilenHavale();
        }
    }
}

