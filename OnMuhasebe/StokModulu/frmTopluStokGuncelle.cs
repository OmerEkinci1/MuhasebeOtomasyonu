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
    public partial class frmTopluStokGuncelle : DevExpress.XtraEditors.XtraForm
    {
        public frmTopluStokGuncelle()
        {
            InitializeComponent();
        }

        OnMuhasebe.Classlar.Formatlar Formatlar = new OnMuhasebe.Classlar.Formatlar();
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        private void cheStokAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (cheStokAdi.Checked == true)
            {
                comStokAdi.Enabled = true;
            }
            else
            {
                comStokAdi.Enabled = false;
            }
        }

        private void cheIngIsim_CheckedChanged(object sender, EventArgs e)
        {
            if (cheIngIsim.Checked == true)
            {
                comIngIsim.Enabled = true;
            }
            else
            {
                comIngIsim.Enabled = false;
            }
        }

        private void cheKod1_CheckedChanged(object sender, EventArgs e)
        {
            if (cheKod1.Checked == true)
            {
                comKod1.Enabled = true;
            }
            else
            {
                comKod1.Enabled = false;
            }
        }

        private void cheKod2_CheckedChanged(object sender, EventArgs e)
        {
            if (cheKod2.Checked == true)
            {
                comKod2.Enabled = true;
            }
            else
            {
                comKod2.Enabled = false;
            }
        }

        private void cheKod3_CheckedChanged(object sender, EventArgs e)
        {
            if (cheKod3.Checked == true)
            {
                comKod3.Enabled = true;
            }
            else
            {
                comKod3.Enabled = false;
            }
        }

        private void cheKod4_CheckedChanged(object sender, EventArgs e)
        {
            if (cheKod4.Checked == true)
            {
                comKod4.Enabled = true;
            }
            else
            {
                comKod4.Enabled = false;
            }
        }

        private void cheKod5_CheckedChanged(object sender, EventArgs e)
        {
            if (cheKod5.Checked == true)
            {
                comKod5.Enabled = true;
            }
            else
            {
                comKod5.Enabled = false;
            }
        }

        private void cheBirim_CheckedChanged(object sender, EventArgs e)
        {
            if (cheKod5.Checked == true)
            {
                comBirim.Enabled = true;
            }
            else
            {
                comBirim.Enabled = false;
            }
        }

        private void cheBarkod_CheckedChanged(object sender, EventArgs e)
        {
            if (cheBarkod.Checked == true)
            {
                comBarkod.Enabled = true;
            }
            else
            {
                comBarkod.Enabled = false;
            }
        }

        private void cheAlisKdv_CheckedChanged(object sender, EventArgs e)
        {
            if (cheAlisKdv.Checked == true)
            {
                comAlisKdv.Enabled = true;
            }
            else
            {
                comAlisKdv.Enabled = false;
            }
        }

        private void cheSatisKdv_CheckedChanged(object sender, EventArgs e)
        {
            if (cheSatisKdv.Checked == true)
            {
                comSatisKdv.Enabled = true;
            }
            else
            {
                comSatisKdv.Enabled = false;
            }
        }

        private void cheAlis1_CheckedChanged(object sender, EventArgs e)
        {
            if (cheAlis1.Checked == true)
            {
                comAlis1.Enabled = true;
            }
            else
            {
                comAlis1.Enabled = false;
            }
        }

        private void cheAlis2_CheckedChanged(object sender, EventArgs e)
        {
            if (cheAlis2.Checked == true)
            {
                comAlis2.Enabled = true;
            }
            else
            {
                comAlis2.Enabled = false;
            }
        }

        private void cheSatis1_CheckedChanged(object sender, EventArgs e)
        {
            if (cheSatis1.Checked == true)
            {
                comSatis1.Enabled = true;
            }
            else
            {
                comSatis1.Enabled = false;
            }
        }

        private void cheSatis2_CheckedChanged(object sender, EventArgs e)
        {
            if (cheSatis2.Checked == true)
            {
                comSatis2.Enabled = true;
            }
            else
            {
                comSatis2.Enabled = false;
            }
        }

        private void barAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog Ac = new OpenFileDialog();
            Ac.Filter = "Excel 2003(*.xls) |*.xls |Excel 2007(*.xlsx) |*.xlsx";//filtreyi belirttik.
            if (Ac.ShowDialog() == DialogResult.OK)
            {
                OnMuhasebe.Classlar.ExcelIslemleri Excel = new OnMuhasebe.Classlar.ExcelIslemleri();

                DataTable Veriler = Excel.Veriler(Ac.FileName);
                Liste.DataSource = Veriler;
                this.Cursor = Cursors.Default;



                foreach (Control Nesne in TasiyiciPanel.Panel1.Controls)
                {
                    if (Nesne is DevExpress.XtraEditors.ComboBoxEdit)//Nesnenin tipi comboboxedit ise
                    {
                        SutunAl((DevExpress.XtraEditors.ComboBoxEdit)Nesne);
                    }
                }
            }

        }

        void SutunAl(DevExpress.XtraEditors.ComboBoxEdit Nesne)
        {
            DevExpress.XtraEditors.Controls.ComboBoxItemCollection Sutunlar = Nesne.Properties.Items;
            Sutunlar.Clear();

            Sutunlar.BeginUpdate();//sütünlar içerisine değer aktarıcağımızı belirtmek için 

            Sutunlar.Add("");
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                Sutunlar.Add(gridView1.Columns[i].FieldName.ToString());
            }

            Nesne.SelectedIndex = 0;
            Sutunlar.EndUpdate();




        }

        private void barIceriAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IceriAktar();
        }
        OnMuhasebe.Classlar.Mesajlar Mesajlar = new OnMuhasebe.Classlar.Mesajlar();
        void IceriAktar()
        {

            if (comStokKodu.SelectedIndex == 0)
            {
                Mesajlar.Uyarı("Stok kodu seçmeden güncelleme işlemi yapamazsınız");
                comStokKodu.Focus();
            }
            else
            {



                Classlar.clsStokKod1 StokKod1 = new Classlar.clsStokKod1();
                Classlar.clsStokKod2 StokKod2 = new Classlar.clsStokKod2();
                Classlar.clsStokKod3 StokKod3 = new Classlar.clsStokKod3();
                Classlar.clsStokKod4 StokKod4 = new Classlar.clsStokKod4();
                Classlar.clsStokKod5 StokKod5 = new Classlar.clsStokKod5();

                string StokKodu, StokAdi, IngIsim, Kod1, Kod2, Kod3, Kod4, Kod5, Birim, Barkod, AlisKdv, SatisKdv, AlisFiyat1, AlisFiyat2, SatisFiyat1, SatisFiyat2;




                this.Cursor = Cursors.WaitCursor;//yükleniyor işareti

                for (int i = 0; i < gridView1.RowCount - 1; i++)
                {
                    StokKodu = DegerAl(comStokKodu, i);
                    StokAdi = DegerAl(comStokAdi, i);
                    IngIsim = DegerAl(comIngIsim, i);
                    Kod1 = DegerAl(comKod1, i);
                    Kod2 = DegerAl(comKod2, i);
                    Kod3 = DegerAl(comKod3, i);
                    Kod4 = DegerAl(comKod4, i);
                    Kod5 = DegerAl(comKod5, i);
                    Birim = DegerAl(comBirim, i);
                    Barkod = DegerAl(comBarkod, i);
                    AlisKdv = DegerAl(comAlisKdv, i);
                    SatisKdv = DegerAl(comSatisKdv, i);
                    AlisFiyat1 = DegerAl(comAlis1, i);
                    AlisFiyat2 = DegerAl(comAlis2, i);
                    SatisFiyat1 = DegerAl(comSatis1, i);
                    SatisFiyat2 = DegerAl(comSatis2, i);

                    string UserId = OnMuhasebe.frmAnaForm.UserId;

                    string sql = "UPDATE TBLSTOKLAR SET ";


                    if (cheStokAdi.Checked == true) { sql += "STOKADI = '" + StokAdi + "',"; }
                    if (cheIngIsim.Checked == true) { sql += "INGILIZCEISIM = '" + IngIsim + "',"; }
                    if (cheKod1.Checked == true) { sql += "KOD1 = '" + StokKod1.IdAl(Kod1, true, UserId) + "',"; }
                    if (cheKod2.Checked == true) { sql += "KOD2 = '" + StokKod2.IdAl(Kod2, true, UserId) + "',"; }
                    if (cheKod3.Checked == true) { sql += "KOD3 = '" + StokKod3.IdAl(Kod3, true, UserId) + "',"; }
                    if (cheKod4.Checked == true) { sql += "KOD4 = '" + StokKod4.IdAl(Kod4, true, UserId) + "',"; }
                    if (cheKod5.Checked == true) { sql += "KOD5 = '" + StokKod5.IdAl(Kod5, true, UserId) + "',"; }
                    if (cheBirim.Checked == true) { sql += "BIRIM = '" + Birim + "',"; }
                    if (cheBarkod.Checked == true) { sql += "BARKOD = '" + Barkod + "',"; }
                    if (cheAlisKdv.Checked == true) { sql += "ALISKDV = " + AlisKdv.Replace(",", ".").ToString() + ","; }
                    if (cheSatisKdv.Checked == true) { sql += "SATISKDV = " + SatisKdv.Replace(",", ".").ToString() + ","; }
                    if (cheAlis1.Checked == true) { sql += "ALISFIYAT1 = " + AlisFiyat1.Replace(",", ".").ToString() + ","; }
                    if (cheAlis2.Checked == true) { sql += "ALISFIYAT2 = " + AlisFiyat2.Replace(",", ".").ToString() + ","; }
                    if (cheSatis1.Checked == true) { sql += "SATISFIYAT1 = " + SatisFiyat1.Replace(",", ".").ToString() + ","; }
                    if (cheSatis2.Checked == true) { sql += "SATISFIYAT2 = " + SatisFiyat2.Replace(",", ".").ToString() + ","; }
                    sql += "EDITUSER = " + UserId + ",";
                    sql += "EDITDATE = GETDATE() "; //SİSTEM SAATİ

                    sql += "  WHERE STOKKODU = '" + StokKodu + "',";

                    Dbase.Isle(sql);


                }

                this.Cursor = Cursors.Default;
                Mesajlar.Bilgi("Toplu Stok Güncelleme işlemi başarılı bir şekilde tamamlanmıştır");

            }
        }

        string DegerAl(DevExpress.XtraEditors.ComboBoxEdit Nesne, int SatirId)
        {
            string Deger = "";

            if (Nesne.SelectedIndex > 0)//veri seçimi yapıldıysa
            {
                Deger = gridView1.GetRowCellValue(SatirId, Nesne.SelectedItem.ToString()).ToString();
            }




            return Deger;
        }



    }

}

