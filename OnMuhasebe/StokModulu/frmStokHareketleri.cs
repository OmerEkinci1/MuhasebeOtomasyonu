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
    public partial class frmStokHareketleri : DevExpress.XtraEditors.XtraForm
    {
        public frmStokHareketleri()
        {
            InitializeComponent();
        }

        Classlar.clsStokHareketleri Hareketler = new Classlar.clsStokHareketleri();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        Classlar.clsStokTanitimKarti Stok = new Classlar.clsStokTanitimKarti();
        string SecilenStokKodu = "";
        string UrunId;

        private void frmStokHareketleri_Load(object sender, EventArgs e)
        {

        }



        void Listele()
        {
            Liste.DataSource = Hareketler.Listele(SecilenStokKodu);
        }


        void StokSec()
        {
            UrunId = Ekranlar.StokListesi(true);
            if (UrunId == "")
            {
                return;
            }

            Ac(UrunId);
           
        }


        public void Ac(string Id)
        {
            UrunId = Id;
            DataRow Satir = Stok.Ac(UrunId);//stok listesinden gelen id yi alıyoruz ve o idye ait stok satırını getiriyoruz

            SecilenStokKodu = Satir["STOKKODU"].ToString();

            txtStokKodu.Text = SecilenStokKodu;
            txtStokismi.Text = Satir["STOKADI"].ToString();
            Listele();
            GetStokBakiye(SecilenStokKodu);
        } 

        private void btnStokSec_Click(object sender, EventArgs e)
        {
            StokSec();
        }

        private void Liste_Click(object sender, EventArgs e)
        {

        }

        void GetStokBakiye(string StokKodu)
        {
            DataRow Satir = Hareketler.StokBakiye(StokKodu);
            txtToplamCikis.Text = Satir["CIKIS"].ToString();
            txtToplamGiris.Text= Satir["GIRIS"].ToString();
            txtBakiye.Text= Satir["BAKIYE"].ToString();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            string Tipi = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"TIPI").ToString();
            if (Tipi=="A")//yani devir işlemi ise
            {
                string AcilisKartiId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();


              //  MessageBox.Show(AcilisKartiId);
                Ekranlar.StokAcilisKarti(AcilisKartiId, true);
            }
        }
    }
}