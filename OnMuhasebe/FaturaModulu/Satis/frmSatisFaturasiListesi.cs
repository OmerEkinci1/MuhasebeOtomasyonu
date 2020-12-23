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

namespace OnMuhasebe.FaturaModulu.Satis
{
    public partial class frmSatisFaturasiListesi : DevExpress.XtraEditors.XtraForm
    {
        Classlar.clsSatisFaturasi SatisFaturasi = new Classlar.clsSatisFaturasi();
        public frmSatisFaturasiListesi()
        {
            InitializeComponent();
        }
        public Boolean SecimIcinAc = true;
        private void frmSatisFaturasiListesi_Load(object sender, EventArgs e)
        {

        }
        void Listele()
        {
            //gride verdik.
            Liste.DataSource = SatisFaturasi.Listele(txtCariKodu.Text, txtCariAdi.Text, txtFaturaNo.Text);
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
        string SecilenId = "";
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (SecimIcinAc == true)
            {
                Sec();
                frmAnaForm.AraDegiskenString = SecilenId;//static değişkene atarak bu değeri daha sonra kullancaz heryerden
                this.Dispose();//formu kapattık yani öldürdük
            }
        }

        private void Sec()
        {
            try
            {
                //Not:gridView1.FocusedRowHandle bize seçili satırın index numarasını verir.
                //griddeki seçili değeri aldık
                SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FATURANO").ToString();
            }
            catch (Exception)
            {
                SecilenId = "-1";//bir hata olursa 
            }
        }
    }
}