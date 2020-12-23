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
    public partial class frmYetkiler : DevExpress.XtraEditors.XtraForm
    {
        clsYetkiler Yetkiler = new clsYetkiler();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new Classlar.Ekranlar();
        string AcilanKullaniciId = "-1";
        clsKullanici Kullanici = new clsKullanici();
        public frmYetkiler()
        {
            InitializeComponent();
        }

        private void frmYetkiler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsYETKILER.TBLYETKILER' table. You can move, or remove it, as needed.
            //this.tBLYETKILERTableAdapter.Fill(this.dsYETKILER.TBLYETKILER);

        }

        public void Ac(string Id)
        {
            KullaniciSec(Id);
        }

        void YetkileriGetir(string Id)
        {
            Liste.DataSource = Yetkiler.Listele(Id);
        }

        private void txtAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            KullaniciSec(Ekranlar.KullaniciListesi(true));
        }


        public void KullaniciSec(string Id)
        {
            AcilanKullaniciId = Id;

            DataRow Satir = Kullanici.Ac(AcilanKullaniciId);
            txtAdi.Text = Satir["ADI"].ToString();
            txtSoyadi.Text = Satir["SOYADI"].ToString();
            YetkileriGetir(AcilanKullaniciId);
        }





        OnMuhasebe.Classlar.Mesajlar Mesajlar = new Classlar.Mesajlar();

        private void barKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Mesajlar.Sor("Yetkileri Kaydetmek İstediğinizden emin misiniz?"))
            {


                DataTable YetkiListesi = new DataTable();
                YetkiListesi = (DataTable)Liste.DataSource;//griddeki datatable dışarı çıkardık.(unboxing)
                Yetkiler.YetkileriKaydet(AcilanKullaniciId, YetkiListesi, frmAnaForm.UserId);
            }
        }
        private void barKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barKullaniciSec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KullaniciSec(Ekranlar.KullaniciListesi(true));
        }

        void TopluYetkilendirme(Boolean Durum)
        {


            for (int i = 0; i < gridView1.RowCount; i++)
            {
                gridView1.SetRowCellValue(i, "SEC", Durum);//griddeki checklerin hepsine tik koyuyoruz yada tikleri kaldırıyoruz.
            }
        }

        private void barTumYetkileriVeri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TopluYetkilendirme(true);
        }

        private void barYetkiAl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TopluYetkilendirme(false);
        }
    }
}