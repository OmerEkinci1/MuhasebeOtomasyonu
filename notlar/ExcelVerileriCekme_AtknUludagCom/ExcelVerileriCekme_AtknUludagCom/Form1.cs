using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ExcelVerileriCekme_AtknUludagCom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        OleDbConnection xlsxbaglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=excel_dosya.xlsx; Extended Properties='Excel 12.0 Xml;HDR=YES'");
        DataTable tablo = new DataTable();

        private void VerileriCekButton_Click(object sender, EventArgs e)
        {
            try
            {
                xlsxbaglanti.Open();
                tablo.Clear();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [YeniSayfa$]", xlsxbaglanti);
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                xlsxbaglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Programda Hata Meydana Geldi." + Environment.NewLine + "Hata : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void VerileriTekTekCekButton_Click(object sender, EventArgs e)
        {
            int kayitsay = 0;
            try
            {
                xlsxbaglanti.Open();
                OleDbCommand komut = new OleDbCommand("SELECT * FROM [YeniSayfa$]", xlsxbaglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    string adSoyad = oku["AdSoyad"].ToString();
                    string Cinsiyet = oku["Cinsiyet"].ToString();
                    string Yas = oku["Yas"].ToString();
                    kayitsay++;
                    //Environment.NewLine kodu bir alt satıra geçmek için kullanılmaktadır.
                    MessageBox.Show("Ad Soyad : " + adSoyad + Environment.NewLine + "Cinsiyet : " + Cinsiyet + Environment.NewLine + "Yaş : " + Yas);
                }
                xlsxbaglanti.Close();
                MessageBox.Show("Toplam " + kayitsay + " Tane Kayıt Başarı ile Excelden Alındı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kayitsay = 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Programda Hata Meydana Geldi." + Environment.NewLine + "Hata : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
