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
    public partial class frmBankaHareketKayitlari : DevExpress.XtraEditors.XtraForm
    {
        public frmBankaHareketKayitlari()
        {
            InitializeComponent();
        }
        string AcilanBankaId = "-1";
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        Classlar.clsBanka Banka = new Classlar.clsBanka();
        Classlar.clsBankaHareketleri Hareketler = new Classlar.clsBankaHareketleri();
     
        private void txtKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            AcilanBankaId = Ekranlar.BankaListesi(true);//dialog olarak açtık
            Ac(AcilanBankaId);
        }

        public void Ac(string BankaId)
        {
           

            DataRow Satir = Banka.Ac(AcilanBankaId);
            txtKodu.Text = Satir["HESAPNO"].ToString();
            txtBankaAdi.Text = Satir["BANKAADI"].ToString();

            HareketleriListele(BankaId);
            BankaBakiye(BankaId);
        }
        void BankaBakiye(string BankaId)
        {
            DataRow Satir = Hareketler.Bakiye(BankaId);
            txtGiris.Text = Satir["GIRIS"].ToString();
            txtCikis.Text = Satir["CIKIS"].ToString();
            txtBakiye.Text= Satir["BAKIYE"].ToString();
        }
        void HareketleriListele(string BankaId)
        {
            Liste.DataSource = Hareketler.Listele(BankaId);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            string Tipi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TIPI").ToString();
            string GcKodu = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GCKODU").ToString();
            string SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HAREKETID").ToString();
            if (Tipi == "A")//açılış kartı ise güncelleme yapılacak diğer durumlarda hareketi güncellemiyoruz
            {
                Ekranlar.BankaAcilisKarti(true, SecilenId);
                Ac(AcilanBankaId);





            }
            else if (Tipi == "B")//Banka işlemi ise
            {
                Ekranlar.BankaIslemi(true, SecilenId);
            }

            else if (Tipi=="H" && GcKodu=="G")//Havele ise ve Giriş ise -->Gelen Havale
            {
                Ekranlar.GelenHavale(true, SecilenId);
            }


            else if (Tipi == "H" && GcKodu == "C")//Havele ise ve Çıkış ise -->Gönderilen Havale
            {
                Ekranlar.GonderilenHavale(true, SecilenId);
            }

            HareketleriListele(AcilanBankaId);
            BankaBakiye(AcilanBankaId);
        }
    }
}