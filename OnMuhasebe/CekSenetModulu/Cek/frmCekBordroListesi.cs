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

namespace OnMuhasebe.CekSenetModulu.Cek
{
    public partial class frmCekBordroListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmCekBordroListesi()
        {
            InitializeComponent();
        }
        Classlar.clsBordrolar Bordro = new Classlar.clsBordrolar();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        string SecilenId = "-1";

      public  Boolean SecimIcinAc = false;
        private void frmCekBordroListesi_Load(object sender, EventArgs e)
        {
            
        }


        void Listele()
        {
            Liste.DataSource = Bordro.Listele(txtNumara.Text, txtCariKodu.Text, txtCariAdi.Text, txtTarih.Text, txtAciklama.Text);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAciklama.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtNumara.Text = "";
            txtTarih.Text = "";
            txtCariKodu.Focus();
        }
        void Sec()
        {
            try
            {
                SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            }
            catch (Exception)
            {

                SecilenId = "-1";
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (SecimIcinAc==true)
            {
                frmAnaForm.AraDegiskenString = SecilenId;
                this.Close();
            }
            else
            {
              
                Ekranlar.MusteriCekBordroGirisi(true, SecilenId);
            }
          
        }
    }
}