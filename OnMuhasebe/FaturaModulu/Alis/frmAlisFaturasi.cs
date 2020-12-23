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

namespace OnMuhasebe.FaturaModulu.Alis
{
    public partial class frmAlisFaturasi : DevExpress.XtraEditors.XtraForm
    {
        public frmAlisFaturasi()
        {
            InitializeComponent();
        }


        OnMuhasebe.StokModulu.Classlar.clsStokTanitimKarti Stok = new StokModulu.Classlar.clsStokTanitimKarti();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        Classlar.clsNumaralar Numaralar = new Classlar.clsNumaralar();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        Classlar.clsAlisFaturasi AlisFaturasi = new Classlar.clsAlisFaturasi();
        string UrunId = "";
        Boolean Edit = false;
        string AcilacakFaturaId = "-1";

        Boolean KapaliFatura = false;
        string OdemeTuru = "Kasa";

        string SecilenBankaId = "-1";
        string SecilenKasaId = "-1";

        string SecilenBankaAdi = "";
        string SecilenKasaAdi = "";
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comTuru.SelectedIndex == 1)//Kapalı fatura ise 
            {
                PanelFaturaKapatma.Visible = true;
                KapaliFatura = true;
            }
            else
            {
                PanelFaturaKapatma.Visible = false;
                KapaliFatura = false;
            }
        }

        void YeniFatura()
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();

            txtFaturaNumarasi.Text = Numaralar.GetYeniAlisFaturasiNumarasi();
            Liste.DataSource = AlisFaturasi.KalemleriAc("-1");//gridi temizlemek için
            txtAciklama.Text = "";
            txtCariIsim.Text = "";
            btnCariSec.Text = "";
            txtVadeTarihi.EditValue = DateTime.Now.ToShortDateString();
            txtTarih.EditValue = DateTime.Now.ToShortDateString();
            comTuru.SelectedIndex = 0;
            txtFaturaNumarasi.Focus();
            Hesapla();
            //Hesapla2();
            Edit = false;
        }
        private void frmSatisFaturasi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kARIYER2012DataSet2.VWTEST' table. You can move, or remove it, as needed.
            // this.vWTESTTableAdapter2.Fill(this.kARIYER2012DataSet2.VWTEST);


            YeniFatura();
        }

        //grid üzerindeki butonunun click'i
        private void btnStokSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            StokSec();
        }

        //grid üzerindeki butona basınca bir form açılacak ve ordan stoğu seçicez stok bilgilerini gridde gösterebileceğiz.
        void StokSec()
        {
            UrunId = Ekranlar.StokListesi(true);
            if (UrunId == "")
            {
                return;
            }
            DataRow Satir = Stok.Ac(UrunId);//stok listesinden gelen id yi alıyoruz ve o idye ait stok satırını getiriyoruz


            string StokKodu, Barkod, StokAdi, Birim;
            decimal BirimFiyat, SatisKdv;

            //gridde yeni bir satır oluşurmak için
            gridView1.AddNewRow();
            //griddeki satıra bizim değerlerimizi atadık.(ridView1.FocusedRowHandle:seçili satır no demek)
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "STOKKODU", Satir["STOKKODU"].ToString());
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "STOKADI", Satir["STOKADI"].ToString());
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BARKOD", Satir["BARKOD"].ToString());
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BIRIMFIYAT", Satir["ALISFIYAT1"].ToString());//aLIŞFİYAT1 OLARAK DEĞİŞTİRİYORUZ
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BIRIM", Satir["BIRIM"].ToString());
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "KDV", Satir["ALISKDV"].ToString());//ALISKDV OLARAK DEĞİŞTİRİYORUZ









            /*  txtStokAdi.Text = Satir["STOKADI"].ToString();
              txtStokAdiIng.Text = Satir["INGILIZCEISIM"].ToString();
              txtAlisFiyati1.Text = Satir["ALISFIYAT1"].ToString();
              txtAlisFiyati2.Text = Satir["ALISFIYAT2"].ToString();
              txtAlisKdv.Text = Satir["ALISKDV"].ToString();
              txtSatisKdv.Text = Satir["SATISKDV"].ToString();
              btnKod1Sec.Text = Satir["KOD1"].ToString();
              btnKod2Sec.Text = Satir["KOD2"].ToString();
              btnKod3Sec.Text = Satir["KOD3"].ToString();
              btnKod4Sec.Text = Satir["KOD4"].ToString();
              btnKod5Sec.Text = Satir["KOD5"].ToString();
              txtBirim.Text = Satir["BIRIM"].ToString();
              txtBarkod.Text = Satir["BARKOD"].ToString();
              txtSatisFiyati1.Text = Satir["SATISFIYAT1"].ToString();
              txtSatisFiyati2.Text = Satir["SATISFIYAT2"].ToString();
              Edit = true;//güncelleme için*/
        }


        void Hesapla()
        {
            decimal BirimFiyat = 0, Miktar = 0, Isk1, Isk2, KdvOrani = 0, Toplam, IskontoOncesiToplam, IskontoToplam = 0, KDVToplam = 0;
            IskontoOncesiToplam = 0;
            Toplam = 0;
            KDVToplam = 0;
            for (int i = 0; i < gridView1.RowCount; i++)//gridview'in tüm satırlarında gez
            {

                //fatura seçildimiyi ise fatura seç(btnSec_Click) (yani faturayı getir butonunda true değeri vermiştim.)
                if (FaturaSecildiMi == true)//Aşağıdaki BirimFiyat,Miktar gibi alanlara değer atarken null reference hatası veriyordu bende gridviewden datatable'ı çıkararak sorunu halletim.
                {
                    //Griddeki datatable'ı ortaya çıkarmak için
                    // DataTable dt= ((DataView)gridView1.DataSource).ToTable()
                    //
                    BirimFiyat = Convert.ToDecimal(((DataView)gridView1.DataSource).ToTable().Rows[i].ItemArray[17]);
                    Miktar = Convert.ToDecimal(((DataView)gridView1.DataSource).ToTable().Rows[i].ItemArray[8]);
                    KdvOrani = Convert.ToDecimal(((DataView)gridView1.DataSource).ToTable().Rows[i].ItemArray[12]);
                    IskontoOncesiToplam = IskontoOncesiToplam + (BirimFiyat * Miktar);
                    Toplam = Toplam + Convert.ToDecimal(((DataView)gridView1.DataSource).ToTable().Rows[i].ItemArray[18]);
                }
                else
                {
                    //BirimFiyat = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BIRIMFIYAT").ToString());//seçili satırdaki BIRIMFIYAT kolonundaki değeri alır.
                    //Miktar = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MIKTAR").ToString());
                    //KdvOrani = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KDV").ToString());
                    //IskontoOncesiToplam = IskontoOncesiToplam + (BirimFiyat * Miktar);
                    //Toplam = Toplam + Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TOPLAM").ToString());//seçili satırdaki BIRIMFIYAT kolonundaki değeri alır.



                    BirimFiyat = Convert.ToDecimal(gridView1.GetRowCellValue(i, "BIRIMFIYAT").ToString());//seçili satırdaki BIRIMFIYAT kolonundaki değeri alır.
                    Miktar = Convert.ToDecimal(gridView1.GetRowCellValue(i, "MIKTAR").ToString());
                    KdvOrani = Convert.ToDecimal(gridView1.GetRowCellValue(i, "KDV").ToString());
                    IskontoOncesiToplam = IskontoOncesiToplam + (BirimFiyat * Miktar);
                    Toplam = Toplam + Convert.ToDecimal(gridView1.GetRowCellValue(i, "TOPLAM").ToString());//seçili satırdaki BIRIMFIYAT kolonundaki değeri alır.

                }


                KDVToplam += Toplam / 100 * KdvOrani;

            }

            txtAraToplam.Text = IskontoOncesiToplam.ToString("0.00");//virgülden sonra 2 basamak şeklinde formatlandı.
            txtNetFiyat.Text = Toplam.ToString("0.00");

            if (IskontoOncesiToplam != 0)
            {
                IskontoToplam = Toplam / IskontoOncesiToplam;
                IskontoToplam = (1 - IskontoToplam) * 100;
                txtIskonto.Text = IskontoToplam.ToString("0.00");
                txtKdv.Text = KDVToplam.ToString("0.00");
                txtGenelToplam.Text = (KDVToplam + Toplam).ToString("0.00");
            }

        }






        void Hesapla2()
        {
            decimal BirimFiyat = 0, Miktar = 0, Isk1, Isk2, KdvOrani = 0, Toplam, IskontoOncesiToplam, IskontoToplam = 0, KDVToplam = 0;

            try
            {
                IskontoOncesiToplam = 0;
                Toplam = 0;
                KDVToplam = 0;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    BirimFiyat = Convert.ToDecimal(gridView1.GetRowCellValue(i, "BIRIMFIYAT").ToString());//seçili satırdaki BIRIMFIYAT kolonundaki değeri alır.
                    Miktar = Convert.ToDecimal(gridView1.GetRowCellValue(i, "MIKTAR").ToString());
                    KdvOrani = Convert.ToDecimal(gridView1.GetRowCellValue(i, "KDV").ToString());
                    IskontoOncesiToplam = IskontoOncesiToplam + (BirimFiyat * Miktar);
                    Toplam = Toplam + Convert.ToDecimal(gridView1.GetRowCellValue(i, "TOPLAM").ToString());//seçili satırdaki BIRIMFIYAT kolonundaki değeri alır.
                    KDVToplam += Toplam / 100 * KdvOrani;
                }



                txtAraToplam.Text = IskontoOncesiToplam.ToString("0.00");//virgülden sonra 2 basamak şeklinde formatlandı.
                txtNetFiyat.Text = Toplam.ToString("0.00");
                IskontoToplam = Toplam / IskontoOncesiToplam;
                IskontoToplam = (1 - IskontoToplam) * 100;
                txtIskonto.Text = IskontoToplam.ToString("0.00");
                txtKdv.Text = KDVToplam.ToString("0.00");
                txtGenelToplam.Text = (KDVToplam + Toplam).ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        //griddeki bir hücre değiştiğinde
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //if komutu yazmamızın sebebi aşağıdaki    gridView1.SetRowCellValue(gridView1.FocusedRowHandle,"TOPLAM",AraToplam); komutuna değer atadığımız için burdaki cellvalue changeda düşüyor sürekli ve sonsuz döngüye giriyor bizde bu sonsuz döngüyü kırmak için bu if bloğunu koyduk.
            if (e.Column.Name != "TOPLAM")//hangi kolonun değiştiğini e parametresinden yakalıyoruz.
            {
                try
                {
                    decimal BirimFiyat, Miktar, Isk1, Isk2;
                    BirimFiyat = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BIRIMFIYAT").ToString());//seçili satırdaki BIRIMFIYAT kolonundaki değeri alır.

                    //  MessageBox.Show(BirimFiyat.ToString());


                    Miktar = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MIKTAR").ToString());
                    Isk1 = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ISK1").ToString());
                    Isk2 = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ISK2").ToString());


                    decimal AraToplam;
                    AraToplam = BirimFiyat * Miktar;
                    AraToplam = AraToplam - (AraToplam / 100 * Isk1);
                    AraToplam = AraToplam - (AraToplam / 100 * Isk2);


                    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "TOPLAM", AraToplam);
                    Hesapla();
                    //  Hesapla2();
                }
                catch (Exception)
                {
                    //gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "TOPLAM", 0);
                }

            }
        }

        //gridde yeni bir satır eklendiği an oluşan event
        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //default değerleri verdik.
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "MIKTAR", 1);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "ISK1", 0);
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "ISK2", 0);
        }
        int ilgiris = 0;
        private void gridView1_RowCountChanged(object sender, EventArgs e)//gridde satırsayısı değiştiğinde
        {
            if (ilgiris != 0)//Hesapla fonksiyonunda 0'a bölme hatası veriyordu o yüzden böyle yaptım.
            {
                Hesapla();
                //Hesapla2();
            }
            ilgiris++;
        }


        OnMuhasebe.CariModulu.Classlar.clsCariTanitimKarti Cari = new CariModulu.Classlar.clsCariTanitimKarti();
        string CariId = "";
        private void btnCariSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CariId = Ekranlar.CariListesiAc();

            DataRow satir = Cari.Ac(CariId);//istediğimiz idye göre satırı seçtik

            txtCariIsim.Text = satir["CARIISIM"].ToString();
            btnCariSec.Text = satir["CARIKODU"].ToString();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
        //EXECUTE SP_FATURA_EKLE @FATURANO,@CARIKODU ,@TARIH,@VADETARIHI,@TURU,@TIPI,@ACIKLAMA,@SAVEUSER
        void Kaydet()
        {

            string OdemeYeri = "";
            string OdemeYeriId = "-1";
            string Turu = "K";//kapalı fatura
            if (comTuru.SelectedIndex == 0)//açık fatura ise 
            {
                Turu = "A";//Açık Fatura

            }
            else //kapalı fatura ise 
            {
                if (comOdemeTuru.SelectedIndex == 1)//banka
                {
                    OdemeYeri = "B";//BANKA
                    OdemeYeriId = SecilenBankaId;


                }
                else//KAsa
                {
                    OdemeYeri = "K";//kASA
                    OdemeYeriId = SecilenKasaId;

                }
            }






            DataSet Kalemler = null;
            DataTable dt = null;
            if (FaturaSecildiMi == true)
            {
                //dolu gridi yeniden datatable olarak ortaya çıkarmak için aşağıdaki işlemi yaptık.
                dt = (DataTable)Liste.DataSource;//kalemler
                                                 // dt = ((DataView)(Liste.DataSource)).ToTable();

            }
            else
            {
                //dolu gridi yeniden datatable olarak ortaya çıkarmak için aşağıdaki işlemi yaptık.
                //BindingSource bs = (BindingSource)Liste.DataSource;
                //Kalemler = (DataSet)bs.DataSource;
                dt = (DataTable)Liste.DataSource;//kalemler

            }





            //DataTable dt=Kalemler.Tables[0] gibi

            if (Edit == true)
            {
                //güncelleme

                if (AlisFaturasi.Guncelle(AcilacakFaturaId, txtFaturaNumarasi.Text, btnCariSec.Text, txtTarih.Text, txtVadeTarihi.Text, txtGenelToplam.Text, Turu, txtAciklama.Text, dt, OdemeYeri, OdemeYeriId) == true)
                {
                    Mesajlar.Bilgi("Fatura başarılı bir şekilde güncellenmiştir");
                }
                else
                {
                    Mesajlar.Hata();
                }

            }
            else
            {
                //kaydetme
                if (AlisFaturasi.Ekle(txtFaturaNumarasi.Text, btnCariSec.Text, txtTarih.Text, txtVadeTarihi.Text, txtGenelToplam.Text, Turu, txtAciklama.Text, dt, OdemeYeri, OdemeYeriId) == true)
                {
                    Mesajlar.Bilgi("Fatura başarılı bir şekilde kaydedilmiştir.");
                }
                else
                {
                    Mesajlar.Hata();
                }
            }
            YeniFatura();
        }


        string AcilacakFaturaNo = "-1";

        bool FaturaSecildiMi = false;
        private void btnSec_Click(object sender, EventArgs e)
        {
            try
            {
                AcilacakFaturaNo = Ekranlar.AlisFaturasiListesi();

                DataRow Ac = AlisFaturasi.Ac(AcilacakFaturaNo);
                AcilacakFaturaId = Ac["ID"].ToString();
                txtAciklama.Text = Ac["ACIKLAMA"].ToString();
                txtCariIsim.Text = Ac["CARIISIM"].ToString();
                txtFaturaNumarasi.Text = AcilacakFaturaNo;
                btnCariSec.Text = Ac["CARIKODU"].ToString();
                DateTime Tarih = Convert.ToDateTime(Ac["TARIH"].ToString());
                DateTime VadeTarih = Convert.ToDateTime(Ac["VADETARIHI"].ToString());


                txtTarih.EditValue = Tarih;
                txtVadeTarihi.EditValue = VadeTarih;

                string Turu = Ac["TURU"].ToString();
                if (Turu == "A")//Açık Fatura ise
                {
                    comTuru.SelectedIndex = 0;
                    PanelFaturaKapatma.Visible = false;
                }
                else//Kapalı Fatura ise
                {
                    comTuru.SelectedIndex = 1;
                    PanelFaturaKapatma.Visible = true;
                    string OdemeYeri = Ac["ODEMEYERI"].ToString();
                    if (OdemeYeri == "B")//BANKA İSE
                    {
                        OdemeTuru = "Banka";
                        lblYer.Text = "Banka Seçimi";
                        SecilenBankaAdi = Ac["TAHSILYERI"].ToString();
                        txtHedef.Text = SecilenBankaAdi;
                        comOdemeTuru.SelectedIndex = 1;
                    }
                    else//KASA İSE
                    {
                        OdemeTuru = "Kasa";
                        lblYer.Text = "Kasa Seçimi";
                        SecilenKasaAdi = Ac["TAHSILYERI"].ToString();
                        txtHedef.Text = SecilenKasaAdi;
                        comOdemeTuru.SelectedIndex = 0;
                    }

                }











                FaturaSecildiMi = true;//Hesapla fonksiyonunda null referennces hatasını gidermek için böyle bir yol izledim.
                Liste.DataSource = AlisFaturasi.KalemleriAc(AcilacakFaturaNo);

                Edit = true;



                Hesapla();
                // Hesapla2();


            }
            catch (Exception ex)
            {
                Edit = false;

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit == true)
            {

                if (Mesajlar.Sor("Faturayı silmek istediğinizden emin misiniz?") == true)
                {
                    AlisFaturasi.Sil(AcilacakFaturaId);//ilgili faturayı silerken cari hareketini vede stok hareketinide silmek gerekiyor.onları siliceğiz

                    YeniFatura();//temizleme işlemi.
                }


            }
        }

        private void comOdemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comOdemeTuru.SelectedIndex == 1)//banka
            {
                OdemeTuru = "Banka";
                lblYer.Text = "Banka Seçimi";
                txtHedef.Text = SecilenBankaAdi;
            }
            else//KAsa
            {
                OdemeTuru = "Kasa";
                lblYer.Text = "Kasa Seçimi";
                txtHedef.Text = SecilenKasaAdi;
            }



        }

        OnMuhasebe.BankaModulu.Classlar.clsBanka Banka = new BankaModulu.Classlar.clsBanka();
        OnMuhasebe.KasaModulu.Classlar.clsKasa Kasa = new KasaModulu.Classlar.clsKasa();
        void BankaSec()
        {
            SecilenBankaId = Ekranlar.BankaListesi(true);//dialog şeklinde açıcaz

            DataRow Satir = Banka.Ac(SecilenBankaId);
            SecilenBankaAdi = Satir["BANKAADI"].ToString();
            txtHedef.Text = SecilenBankaAdi;


        }

        void KasaSec()
        {
            SecilenKasaId = Ekranlar.KasaListesi(true);//dialog şeklinde açıcaz

            DataRow Satir = Kasa.Ac(SecilenKasaId);
            SecilenKasaAdi = Satir["ADI"].ToString();
            txtHedef.Text = SecilenKasaAdi;
        }

        private void txtHedef_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (OdemeTuru == "Kasa")
            {
                KasaSec();
            }
            else if (OdemeTuru == "Banka")
            {
                BankaSec();
            }
        }
        Dizaynlar.DizaynYazdir Yazdir = new Dizaynlar.DizaynYazdir();
        private void btnYazdir_Click(object sender, EventArgs e)
        {
          

            Yazdir.AlisFaturasi(AcilacakFaturaNo);//fatura yazdırma


        }
    }
}