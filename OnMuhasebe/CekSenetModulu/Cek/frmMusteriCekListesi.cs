﻿using System;
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
    public partial class frmMusteriCekListesi : DevExpress.XtraEditors.XtraForm
    {
        Classlar.Cekler Cekler = new Classlar.Cekler();


        public frmMusteriCekListesi()
        {
            InitializeComponent();
        }
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        OnMuhasebe.Classlar.Ekranlar Ekranlar = new OnMuhasebe.Classlar.Ekranlar();
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();


        public Boolean Bankadakiler, Cirodakiler, Portfoydakiler;

        string SecilenId = "-1";
      public  Boolean SecimIcinAc = false;
        void Listele()
        {
          Liste.DataSource = Cekler.MusteriCekListesi(txtBelgeNo.Text,txtCekNo.Text,txtCariKodu.Text,txtCariAdi.Text,txtTarih.Text,txtVadeTarihi.Text,txtAciklama.Text,txtDurum.Text,Bankadakiler,Portfoydakiler,Cirodakiler);


            

        }

        private void frmMusteriCekListesi_Load(object sender, EventArgs e)
        {
            Listele();
            if (SecimIcinAc==true)
            {
                SagMenu.Enabled = false;
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtCekNo.Text = "";
            txtDurum.Text = "";
            txtTarih.Text = "";
            txtVadeTarihi.Text = "";
            txtBelgeNo.Focus();
        }

        private void SagCekGirisi_Click(object sender, EventArgs e)
        {
            Ekranlar.MusteriCekGirisi();
        }

        private void SagBordroGirisi_Click(object sender, EventArgs e)
        {
            Ekranlar.MusteriCekBordroGirisi();
        }

        private void SagGuncelle_Click(object sender, EventArgs e)
        {
            Sec();
            Ekranlar.MusteriCekGirisi(true, SecilenId);
        }

        private void SagSil_Click(object sender, EventArgs e)
        {
            if (Mesajlar.Sor("Çekilen Çeki Silmek istediğinizden eminmisiniz?")==true)
            {
                Sec();
                Cekler.Sil(SecilenId);
                Listele();
            }
        }

        private void SagCekiBankayaCik_Click(object sender, EventArgs e)
        {
            Sec();
            Ekranlar.BankayaCekCikisiTek(SecilenId);
        }

        private void SagCekiCariyeCik_Click(object sender, EventArgs e)
        {
            Sec();
            Ekranlar.CariyeCekCikisiTek(SecilenId);
        }

        private void SagMenu_Opening(object sender, CancelEventArgs e)
        {
            SagCekinDurumu.Enabled = true;
            SagSil.Enabled = true;
            SagGuncelle.Enabled = true;


           



            //Çek Portföyde ise Cariye yada Bankaya verebiliriz.Diğer durumlarda veremeyiz.Onun kontrolünü yapıcaz.


            string Yeri = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "YERI").ToString();
            if (Yeri=="P")//porföyde ise 
            {
                SagCekiBankayaCik.Enabled = true;
                SagCekiCariyeCik.Enabled = true;
                SagCekiBankadanIadeAl.Enabled = false;
                SagCekiCaridenIadeAl.Enabled = false;
            }
            else
            {
                //kullanıcı bu menülere erişemesin
                SagCekiBankayaCik.Enabled = false;
                SagCekiCariyeCik.Enabled = false;
            }



            if (Yeri == "B")//banka ise 
            {
              
                SagCekiBankadanIadeAl.Enabled = true;
                SagCekiCaridenIadeAl.Enabled = false;
            }


            if (Yeri == "C")//caride ise 
            {
                SagCekiCaridenIadeAl.Enabled = true;
                SagCekiBankadanIadeAl.Enabled = false;


                SagCekinDurumu.Enabled = false;
                SagSil.Enabled = false; 
                SagGuncelle.Enabled = false;
            }


            if (CekinDurumu().Trim() == "T" || CekinDurumu().Trim() == "K")//tahsilat ise VEYA KARŞILIKSIZ İSE 
            {
                SagSil.Enabled = false;
                SagGuncelle.Enabled = false;

                SagCekiBankayaCik.Enabled = false;
                SagCekiCariyeCik.Enabled = false;
            }
            else
            {
                SagSil.Enabled = true;
                SagGuncelle.Enabled = true;


                SagCekiBankayaCik.Enabled = true;
                SagCekiCariyeCik.Enabled = true;
            }

        }

        private void SagCekiBankadanIadeAl_Click(object sender, EventArgs e)
        {
            Sec();
            Ekranlar.BankayaCekCikisiIade(SecilenId);
        }

        private void SagCekiCaridenIadeAl_Click(object sender, EventArgs e)
        {
            Sec();
            Ekranlar.CariyeCekCikisiIade(SecilenId);
        }
        string CekinYeri()
        {
            string Yeri = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "YERI").ToString();
            return Yeri;
        }


        string CekinDurumu()
        {
            string Durum = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DURUMU").ToString();
            return Durum;
        }
        private void SagCekinDurumu_Click(object sender, EventArgs e)
        {
            Sec();

            if (CekinYeri()=="P")//PORTFÖY İSE 
            {
                Ekranlar.CekDurumu(SecilenId,"P");
            }


            if (CekinYeri() == "B")//BANKA İSE 
            {
                Ekranlar.CekDurumu(SecilenId, "B");
            }


        }

        void Sec()
        {
            try
            {
                SecilenId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
            }
            catch (Exception)
            {

                SecilenId = "-1";
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (SecimIcinAc==true)
            {
                Sec();
                frmAnaForm.AraDegiskenString=SecilenId;
                this.Close();
            }
            else
            {
                Ekranlar.MusteriCekGirisi(true, SecilenId);
            }
        }
    }
}