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

namespace OnMuhasebe.StokModulu
{
    public partial class frmStokKod1 : DevExpress.XtraEditors.XtraForm
    {
        public frmStokKod1()
        {
            InitializeComponent();
        }
        Classlar.clsStokKod1 islemYap = new Classlar.clsStokKod1();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();

        string SecilenId = "-1";

        Boolean Edit = false;
       public Boolean SecimIcinAcildiMi = false;
        private void frmStokKod1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            //gridi dolduruyoruz
            Liste.DataSource = islemYap.Listele();
        }
        void Temizle()
        {
            txtKod.Text = "";
            txtAciklama.Text = "";
        }
        void Sec()
        {
            try
            {
                //griddeki seçili satırın idsini alıyoruz
                SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            }
            catch (Exception)
            {

                SecilenId = "-1";
            }
           
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit==true)
            {
                //Güncelleme
                islemYap.Guncelle(SecilenId,txtKod.Text, txtAciklama.Text, "-1");
                Listele();//gridi yeniliyoruz
                Temizle();
            }
            else
            {
                islemYap.Ekle(txtKod.Text, txtAciklama.Text, "-1");
                Listele();//gridi yeniliyoruz
                Temizle();
            }
        
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sor("Seçilen Kaydı Silmek İstediğinizden Emin misiniz?"))
            {
                Sec();
                islemYap.Sil(SecilenId);
                Listele();
                Temizle();
            }
          
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (SecimIcinAcildiMi==true)
            {
                Sec();
                frmAnaForm.AraDegiskenString = SecilenId;
                this.Dispose();//açık olan formu kapatır

            }
            else
            {
                Sec();
                DataRow satir = islemYap.Ac(SecilenId);
                txtAciklama.Text = satir["ACIKLAMA"].ToString();
                txtKod.Text = satir["KOD"].ToString();

                Edit = true;//güncelleme için yaptığımızı bilmek için
            }
          
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Temizle();
            txtKod.Focus();
            Edit = false;//kaydet için
        }
    }
}