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

namespace OnMuhasebe.KullaniciModulu
{
    public partial class frmKullaniciListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmKullaniciListesi()
        {
            InitializeComponent();
        }
        clsKullanici Kullanici = new clsKullanici();
        public Boolean SecimmIcinAc = false;
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new Classlar.Ekranlar();
        private void frmKullaniciListesi_Load(object sender, EventArgs e)
        {

            Listele();
        }

        void Listele()
        {
            Liste.DataSource = Kullanici.Listele(txtAdi.Text, txtSoyadi.Text, txtUnvan.Text, txtEmail.Text);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        string Sec()
        {
            string SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            return SecilenId;
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (SecimmIcinAc==true)
            {
                frmAnaForm.AraDegiskenString = Sec();//static değişkene değer atadık.
                this.Close();
            }
            else
            {
                Ekranlar.KullaniciGuncelle(Sec());
            }
        }
    }
}