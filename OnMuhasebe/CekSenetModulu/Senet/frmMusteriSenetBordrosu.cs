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

namespace OnMuhasebe.CekSenetModulu.Senet
{
    public partial class frmMusteriSenetBordrosu : DevExpress.XtraEditors.XtraForm
    {

        //NOT:gridin datasource'una  oluşturmuş olduğumuz CekGirisi datasetini verdik.grid üzerinde bir değişiklik falan yapacaksak bunu yapmamız gerekiyor.örneğin grid içinde ki butondan bir form açtırıp daha sonra değeri gridde göstermek istiyorsak bu işlemi yapmalıyız.aksi takdirde değer gözükmeyip kayboluyor.
        public frmMusteriSenetBordrosu()
        {
            InitializeComponent();
        }
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        MusteriCeki[] GirilenCekler = new MusteriCeki[0];//0 boyutlu dizi
        int CariId = -1;
        OnMuhasebe.CariModulu.Classlar.clsCariTanitimKarti Cari = new CariModulu.Classlar.clsCariTanitimKarti();

        Boolean CariSecildiMi = false;
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        Classlar.clsBordrolar Bordro = new Classlar.clsBordrolar();
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();//tarih formatı için

        Boolean Edit = false;
        string AcilanBordroNo = "-1";
        string AcilanBordroId = "-1";
        //Grid üzerindeki belgeno butonu
        private void btnSec_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (CariSecildiMi == true)
            {




                MusteriCeki GelenCek = Ekranlar.BordroIcinCekSec(txtCariKodu.Text, txtCariIsim.Text);
                if (GelenCek.EklemeBasariliMi == true)
                {
                    Array.Resize(ref GirilenCekler, GirilenCekler.Length + 1);//dizinin boyutunu artırıyoruz.
                    GirilenCekler[GirilenCekler.Length - 1] = GelenCek;

                    gridView1.AddNewRow();//yeni satır ekleme
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BELGENO", GelenCek.BelgeNo);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "CEKNO", GelenCek.CekNo);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "VADETARIHI", GelenCek.VadeTarihi);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BANKA", GelenCek.Banka);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SUBE", GelenCek.Sube);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "TUTAR", GelenCek.Tutar);
                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "DIZIID", GirilenCekler.Length - 1);
                    ToplamTutarHesapla();
                }


            }
            else
            {
                Mesajlar.Uyarı("Cari Seçmeden işleme devam edemezsiniz!!!");
            }
        }

        private void frmMusteriCekBordrosu_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void Liste_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            //navigator üzerindeki butonun tipi remove ise.yani griddeki satırları silen butonu yakaladık.
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
            {
                try
                {
                    int DiziId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIZIID").ToString());
                    MessageBox.Show(DiziId.ToString());
                    GirilenCekler[DiziId].EklemeBasariliMi = false;//bu değere göre veritabanına ekleme yapıcaz.true olan çekleri veritabanına eklicez.
                }
                catch (Exception ex)
                {


                }
            }

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            int DiziId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIZIID").ToString());

            SatirGuncelle(Ekranlar.BordroIcinCekGuncelle(GirilenCekler[DiziId], txtCariKodu.Text, txtCariIsim.Text), DiziId);

        }

        void SatirGuncelle(MusteriCeki GuncelCek, int DiziId)
        {
            GirilenCekler[DiziId] = GuncelCek;
            if (GuncelCek.EklemeBasariliMi == false)//kullanıcı bu çeki sildi ise .
            {
                int _DiziId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DIZIID").ToString());
             
                GirilenCekler[_DiziId].EklemeBasariliMi = false;//çeklerdende silme yapıyoruz.
                gridView1.DeleteRow(gridView1.FocusedRowHandle);//ilgili satırı sil
            }
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BELGENO", GuncelCek.BelgeNo);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "CEKNO", GuncelCek.CekNo);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "VADETARIHI", GuncelCek.VadeTarihi);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BANKA", GuncelCek.Banka);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SUBE", GuncelCek.Sube);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "TUTAR", GuncelCek.Tutar);
            // gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "DIZIID", GuncelCek.);
        }

        void CariSec()
        {
            CariId = Convert.ToInt32(Ekranlar.CariListesiAc());

            DataRow satir = Cari.Ac(CariId.ToString());//istediğimiz idye göre satırı seçtik
            txtCariKodu.Text = satir["CARIKODU"].ToString();


            txtCariIsim.Text = satir["CARIISIM"].ToString();

            if (CariId > 0)
            {
                CariSecildiMi = true;

            }


        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CariSec();
        }

        void ToplamTutarHesapla()
        {
            decimal ToplamTutar = 0;
            DateTime Tarih, VadeTarihi;
            decimal Islem1 = 0;
            int VadeGunSayisi = 0;
            decimal Tutar = 0;
            int OrtalamaVadeGunu=0;
            for (int i = 0; i < GirilenCekler.Length; i++)
            {
                if (GirilenCekler[i].EklemeBasariliMi == true)
                {
                    //ortalama vade hesaplama
                    Tutar = GirilenCekler[i].Tutar;
                    Tarih = Convert.ToDateTime(txtTarih.Text);
                    VadeTarihi = Convert.ToDateTime(GirilenCekler[i].VadeTarihi);


                    TimeSpan Fark = (VadeTarihi - Tarih);

                   // MessageBox.Show(Fark.Days.ToString());
                    VadeGunSayisi = Fark.Days;

                    Islem1 += Tutar * VadeGunSayisi;

                    ToplamTutar += Tutar;
                }
            }

            try
            {
                OrtalamaVadeGunu = Convert.ToInt32(Islem1 / ToplamTutar);
            }
            catch (Exception)
            {

            }
          
            txtToplamTutar.Text = ToplamTutar.ToString();
            txtOrtalamaVade.Text = OrtalamaVadeGunu.ToString();

        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            ToplamTutarHesapla();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit == true)
            {
                Guncelle();
            }
            else
            {
                Kaydet();

            }
        }

        void Kaydet()
        {

            if (gridView1.RowCount < 1)//hiç kayıt yoksa
            {
                Mesajlar.Uyarı("Çek girişi yapmadan bordroyu kaydedemezsiniz!");
            }
            else
            {



                //dizi olarak cekleri yolladık
                if (Bordro.Ekle(txtNumara.Text, txtCariKodu.Text, Formatlar.IngilizceTarihFormati(txtTarih.Text), txtAciklama.Text, frmAnaForm.UserId, GirilenCekler))
                {

                    Mesajlar.Bilgi("Bordro Başarılı bir şekilde kaydedilmiştir.");
                }
                else
                {
                    Mesajlar.Hata();
                }

            }
        }

        void Guncelle()
        {
            if (Bordro.Guncelle(AcilanBordroId, txtNumara.Text, txtCariKodu.Text, Formatlar.IngilizceTarihFormati(txtTarih.Text), txtAciklama.Text, frmAnaForm.UserId, GirilenCekler))
            {

                Mesajlar.Bilgi("Bordro Başarılı bir şekilde güncellenmiştir..");
            }
            else
            {
                Mesajlar.Hata();
            }
        }


        //--------------------------------
      
        public void BordroAc(string Id)
        {
            Edit = true;//güncelleme için
            AcilanBordroId = Id;
            DataRow Satir = Bordro.Ac(Id);
            txtAciklama.Text = Satir["ACIKLAMA"].ToString();
           txtCariKodu.Text = Satir["CARIKODU"].ToString();
           txtCariIsim.Text = Satir["CARIISIM"].ToString();
            txtNumara.Text= Satir["NUMARA"].ToString();
            txtTarih.Text= Satir["TARIH"].ToString();
            AcilanBordroNo = Satir["NUMARA"].ToString();
            CekleriAc(AcilanBordroNo);
        }

        void CekleriAc(string BordroNo)
        {
          
            DataTable _GelenCekler= Bordro.CekleriGetir(BordroNo);

            Liste.DataSource = _GelenCekler;
            Array.Resize(ref GirilenCekler, 0);//dizinin boyutunu sıfırladık

            MusteriCeki AktarmaCeki = new MusteriCeki();
            for (int i = 0; i < _GelenCekler.Rows.Count; i++)
            {
                Array.Resize(ref GirilenCekler, GirilenCekler.Length + 1);//dizinin boyutunu artırıyoruz.
                AktarmaCeki.Aciklama = _GelenCekler.Rows[i]["ACIKLAMA"].ToString();
                AktarmaCeki.AsilBorclu = _GelenCekler.Rows[i]["ASILBORCLU"].ToString();
                AktarmaCeki.AsilCiro = _GelenCekler.Rows[i]["ASILCIRO"].ToString();
                AktarmaCeki.Banka = _GelenCekler.Rows[i]["BANKA"].ToString();
                AktarmaCeki.BelgeNo = _GelenCekler.Rows[i]["BELGENO"].ToString();
                AktarmaCeki.CekNo = _GelenCekler.Rows[i]["CEKNO"].ToString();
                AktarmaCeki.EklemeBasariliMi = true;
                AktarmaCeki.HesapNo = _GelenCekler.Rows[i]["HESAPNO"].ToString();
                AktarmaCeki.Sube = _GelenCekler.Rows[i]["SUBE"].ToString();
                AktarmaCeki.Tutar = Convert.ToDecimal(_GelenCekler.Rows[i]["TUTAR"].ToString());
                AktarmaCeki.VadeTarihi = _GelenCekler.Rows[i]["VADETARIHI"].ToString();


                GirilenCekler[GirilenCekler.Length - 1] = AktarmaCeki;

                gridView1.SetRowCellValue(i, "DIZIID", GirilenCekler.Length - 1);
            }

            ToplamTutarHesapla();
        }

        private void txtNumara_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           string Id= Ekranlar.CekBordroListesi(true);

            BordroAc(Id);
        }
    }
}