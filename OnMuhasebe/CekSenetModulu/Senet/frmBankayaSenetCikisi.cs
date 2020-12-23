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
    public partial class frmBankayaSenetCikisi : DevExpress.XtraEditors.XtraForm
    {
        //NOT:gridin datasource'una  oluşturmuş olduğumuz SenetGirisi datasetini verdik.grid üzerinde bir değişiklik falan yapacaksak bunu yapmamız gerekiyor.örneğin grid içinde ki butondan bir form açtırıp daha sonra değeri gridde göstermek istiyorsak bu işlemi yapmalıyız.aksi takdirde değer gözükmeyip kayboluyor.
        public frmBankayaSenetCikisi()
        {
            InitializeComponent();
        }
        string AcilanBankaId = "-1";
        OnMuhasebe.BankaModulu.Classlar.clsBanka Banka = new BankaModulu.Classlar.clsBanka();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        MusteriSeneti[] GirilenSenetler = new MusteriSeneti[0];//0 boyutlu dizi

        Classlar.Senetler Senetler = new Classlar.Senetler();

        private void Liste_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {

        }

        void BankaSec()
        {
            AcilanBankaId = Ekranlar.BankaListesi(true);//dialog şeklinde açıcaz

            DataRow Satir = Banka.Ac(AcilanBankaId);
            txtBankaAdi.Text = Satir["BANKAADI"].ToString();
            txtHesapNo.Text = Satir["HESAPNO"].ToString();
        }

        private void txtHesapNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            BankaSec();
        }

        private void btnSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string AcilanSenetId = Ekranlar.MusteriSenetListesi(true,false,true,false);//portfoydeki çekleri ancak bankaya verebiliriz.
            //MessageBox.Show(AcilanSenetId);






            DataRow Satir = Senetler.Ac(AcilanSenetId);
            MusteriSeneti AcilanSenet = new MusteriSeneti();
            AcilanSenet.Aciklama = Satir["ACIKLAMA"].ToString();
            AcilanSenet.AsilBorclu = Satir["ASILBORCLU"].ToString();
            AcilanSenet.AsilCiro = Satir["ASILCIRO"].ToString();
            AcilanSenet.Banka = Satir["BANKA"].ToString();
            AcilanSenet.BelgeNo = Satir["BELGENO"].ToString();
            AcilanSenet.SenetNo = Satir["SenetNO"].ToString();
            AcilanSenet.EklemeBasariliMi = true;
            AcilanSenet.HesapNo = Satir["HESAPNO"].ToString();
            AcilanSenet.Sube = Satir["SUBE"].ToString();
            AcilanSenet.Tarih = Satir["TARIH"].ToString();
            AcilanSenet.Tutar = Convert.ToDecimal(Satir["TUTAR"].ToString());
            AcilanSenet.VadeTarihi = Satir["VADETARIHI"].ToString();


            AcilanSenet.Id = Convert.ToInt32(Satir["ID"].ToString());



            SenetSec(AcilanSenet);

        }

        void SenetSec(MusteriSeneti GelenSenet)
        {

            if (GelenSenet.EklemeBasariliMi == true)
            {
                Array.Resize(ref GirilenSenetler, GirilenSenetler.Length + 1);//dizinin boyutunu artırıyoruz.
                GirilenSenetler[GirilenSenetler.Length - 1] = GelenSenet;

                gridView1.AddNewRow();//yeni satır ekleme
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BELGENO", GelenSenet.BelgeNo);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SenetNO", GelenSenet.SenetNo);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "VADETARIHI", GelenSenet.VadeTarihi);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "BANKA", GelenSenet.Banka);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "SUBE", GelenSenet.Sube);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "TUTAR", GelenSenet.Tutar);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "DIZIID", GirilenSenetler.Length - 1);
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "ID", GelenSenet.Id);

                ToplamTutarHesapla();
            }
        }


        void ToplamTutarHesapla()
        {
            decimal ToplamTutar = 0;
            decimal Tutar = 0;

            for (int i = 0; i < GirilenSenetler.Length; i++)
            {
                if (GirilenSenetler[i].EklemeBasariliMi == true)
                {

                    Tutar = GirilenSenetler[i].Tutar;
                    ToplamTutar += Tutar;
                }
            }



            txtToplamTutar.Text = ToplamTutar.ToString();


        }
        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtNumara.Text == "")
            {
                Mesajlar.Uyarı("Belge Numarası girmeden işleme devam edemezsiniz?");
                txtNumara.Focus();
            }
            else if (txtBankaAdi.Text == "")
            {
                Mesajlar.Uyarı("Banka seçimi yapmadan  işleme devam edemezsiniz?");
                txtHesapNo.Focus();
            }
            else
            {
                
                if (Mesajlar.Sor("İşlemi kaydetmek istediğinizden eminmisiniz?"))
                {
                    Boolean GuncellediMi = false;
                    int SenetId;
                    string BelgeNo = txtNumara.Text;
                    string Tarih = txtTarih.Text;
                    for (int i = 0; i < GirilenSenetler.Length; i++)
                    {
                        if (GirilenSenetler[i].EklemeBasariliMi == true)
                        {
                            SenetId = GirilenSenetler[i].Id;
                            Senetler.SenetiBankayaVer(SenetId.ToString(), AcilanBankaId, Formatlar.IngilizceTarihFormati(Tarih), BelgeNo);//Portföydeki çekleri Bankaya verdik.
                            GuncellediMi = true;
                        }
                    }


                    if (GuncellediMi==true)
                    {
                        Mesajlar.Bilgi("Kayıt işlemi başarılı bir şekilde tamamlanmıştır..");
                        Temizle();
                    }


                }

            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0 || txtNumara.Text != "" || txtBankaAdi.Text != "")
            {
                if (Mesajlar.Sor("Çeçerli işlemi iptal etmek istediğinizden eminmisiniz?"))
                {
                    Temizle();
                }

            }
        }


        
        private void frmBankayaSenetCikisi_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (gridView1.RowCount > 0 || txtNumara.Text != "" || txtBankaAdi.Text != "")
            {
                if (Mesajlar.Sor("İşlemi kaydetmeden çıkmak istediğinizden emin misiniz?") == false)
                {
                    e.Cancel = true;//işlemi iptal et.
                }

            }
        }

        private void frmBankayaSenetCikisi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtBankaAdi.Text = "";
            txtHesapNo.Text = "";
            txtNumara.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();


            //grid satırlarını sil.
            for (int i = 0; i <= gridView1.RowCount; i++)
            {
               
                gridView1.DeleteRow(0);

            }

            Array.Resize(ref GirilenSenetler, 0);//dizi boyutunu 0 'a çektik.


        }


    }
}