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

namespace OnMuhasebe.CekSenetModulu.Cek
{
    public partial class frmBankayaCekCikisi : DevExpress.XtraEditors.XtraForm
    {
        //NOT:gridin datasource'una  oluşturmuş olduğumuz CekGirisi datasetini verdik.grid üzerinde bir değişiklik falan yapacaksak bunu yapmamız gerekiyor.örneğin grid içinde ki butondan bir form açtırıp daha sonra değeri gridde göstermek istiyorsak bu işlemi yapmalıyız.aksi takdirde değer gözükmeyip kayboluyor.
        public frmBankayaCekCikisi()
        {
            InitializeComponent();
        }
        string AcilanBankaId = "-1";
        OnMuhasebe.BankaModulu.Classlar.clsBanka Banka = new BankaModulu.Classlar.clsBanka();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        MusteriCeki[] GirilenCekler = new MusteriCeki[0];//0 boyutlu dizi

        Classlar.Cekler Cekler = new Classlar.Cekler();

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
            string AcilanCekId = Ekranlar.MusteriCekListesi(true,false,true,false);//portfoydeki çekleri ancak bankaya verebiliriz.
            //MessageBox.Show(AcilanCekId);






            DataRow Satir = Cekler.Ac(AcilanCekId);
            MusteriCeki AcilanCek = new MusteriCeki();
            AcilanCek.Aciklama = Satir["ACIKLAMA"].ToString();
            AcilanCek.AsilBorclu = Satir["ASILBORCLU"].ToString();
            AcilanCek.AsilCiro = Satir["ASILCIRO"].ToString();
            AcilanCek.Banka = Satir["BANKA"].ToString();
            AcilanCek.BelgeNo = Satir["BELGENO"].ToString();
            AcilanCek.CekNo = Satir["CEKNO"].ToString();
            AcilanCek.EklemeBasariliMi = true;
            AcilanCek.HesapNo = Satir["HESAPNO"].ToString();
            AcilanCek.Sube = Satir["SUBE"].ToString();
            AcilanCek.Tarih = Satir["TARIH"].ToString();
            AcilanCek.Tutar = Convert.ToDecimal(Satir["TUTAR"].ToString());
            AcilanCek.VadeTarihi = Satir["VADETARIHI"].ToString();


            AcilanCek.Id = Convert.ToInt32(Satir["ID"].ToString());



            CekSec(AcilanCek);

        }

        void CekSec(MusteriCeki GelenCek)
        {

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
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "ID", GelenCek.Id);

                ToplamTutarHesapla();
            }
        }


        void ToplamTutarHesapla()
        {
            decimal ToplamTutar = 0;
            decimal Tutar = 0;

            for (int i = 0; i < GirilenCekler.Length; i++)
            {
                if (GirilenCekler[i].EklemeBasariliMi == true)
                {

                    Tutar = GirilenCekler[i].Tutar;
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
                    int CekId;
                    string BelgeNo = txtNumara.Text;
                    string Tarih = txtTarih.Text;
                    for (int i = 0; i < GirilenCekler.Length; i++)
                    {
                        if (GirilenCekler[i].EklemeBasariliMi == true)
                        {
                            CekId = GirilenCekler[i].Id;
                            Cekler.CekiBankayaVer(CekId.ToString(), AcilanBankaId, Formatlar.IngilizceTarihFormati(Tarih), BelgeNo);//Portföydeki çekleri Bankaya verdik.
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


        
        private void frmBankayaCekCikisi_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (gridView1.RowCount > 0 || txtNumara.Text != "" || txtBankaAdi.Text != "")
            {
                if (Mesajlar.Sor("İşlemi kaydetmeden çıkmak istediğinizden emin misiniz?") == false)
                {
                    e.Cancel = true;//işlemi iptal et.
                }

            }
        }

        private void frmBankayaCekCikisi_Load(object sender, EventArgs e)
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

            Array.Resize(ref GirilenCekler, 0);//dizi boyutunu 0 'a çektik.


        }


    }
}