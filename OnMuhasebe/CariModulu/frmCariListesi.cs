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

namespace OnMuhasebe.CariModulu
{
    public partial class frmCariListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmCariListesi()
        {
            InitializeComponent();
        }
        Classlar.clsCariTanitimKarti Cari = new Classlar.clsCariTanitimKarti();
        String SecilenId = "-1";
        private void frmCariListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }


        void Listele()
        {
            Liste.DataSource = Cari.Listele(txtCariKodu.Text,txtCariAdi.Text,txtIl.Text,txtIlce.Text,txtTc.Text,txtTipi.Text);//gridde listeledik
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
        void Sec()
        {
            try
            {
                //Not:gridView1.FocusedRowHandle bize seçili satırın index numarasını verir.
                //griddeki seçili değeri aldık
                SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            }
            catch (Exception)
            {
                SecilenId = "-1";//bir hata olursa 
            }
        }
        private void Liste_DoubleClick(object sender, EventArgs e)
        {
           

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }


        void Temizle()
        {
            txtTipi.Text = "";
            txtTc.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtCariKodu.Text = "";
            txtCariAdi.Text = "";
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            frmAnaForm.AraDegiskenString = SecilenId;//static değişkene atarak bu değeri daha sonra kullancaz heryerden
            this.Dispose();//formu kapattık yani öldürdük
        }
    }
}