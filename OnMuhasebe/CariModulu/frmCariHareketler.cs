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
    public partial class frmCariHareketler : DevExpress.XtraEditors.XtraForm
    {
        public frmCariHareketler()
        {
            InitializeComponent();
        }

        string SecilenId = "-1";
        string SecilenTip = "";

        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        Classlar.clsCariTanitimKarti Cari = new Classlar.clsCariTanitimKarti();
        Classlar.clsCariHareketleri Hareketler = new Classlar.clsCariHareketleri();

        public string CariId, SecilenCariKodu;
        private void btnCariSec_Click(object sender, EventArgs e)
        {
            CariId = Ekranlar.CariListesiAc();
            CariSec(CariId);
        }


        public void CariSec(string Id)
        {

            CariId = Id;
            DataRow satir = Cari.Ac(CariId);//istediğimiz idye göre satırı seçtik
            SecilenCariKodu = satir["CARIKODU"].ToString();


            txtCariIsim.Text = satir["CARIISIM"].ToString();
            txtCariKodu.Text = SecilenCariKodu;

            GetCariHareketler();
        }

        private void txtCariKodu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void txtCariIsim_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();

            if (SecilenTip == "A")//Açılış kartı 
            {
                //MessageBox.Show("Açılış Kartıdır");
                Ekranlar.CariAcilisKarti(true, SecilenId);
            }
            else
            {
                MessageBox.Show("Açılış kartı değildir.");
            }

        }

        void GetCariHareketler()
        {
            Liste.DataSource = Hareketler.Listele(SecilenCariKodu);
            GetCariBakiye(SecilenCariKodu);
        }
        void GetCariBakiye(string CariKodu)
        {
            DataRow Satir = Hareketler.CariBakiye(CariKodu);
            txtToplamAlacak.Text = Satir["ALACAK"].ToString();
            txtToplamBorc.Text = Satir["BORC"].ToString();
            txtBakiye.Text = Satir["BAKIYE"].ToString();



            decimal CariBakiye = Convert.ToDecimal(txtBakiye.Text);
            if (CariBakiye > 0)
            {
                txtBakiye.BackColor = Color.MediumSeaGreen;
            }
            else
            {
                txtBakiye.BackColor = Color.LightCoral;
            }

        }
        private void frmCariHareketler_Load(object sender, EventArgs e)
        {

        }

        void Sec()
        {
            try
            {
                SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                SecilenTip = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TIPI").ToString();
            }
            catch (Exception ex)
            {

                SecilenId = "-1";
            }
        }
    }
}