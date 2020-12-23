using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
namespace OnMuhasebe.FaturaModulu.Dizaynlar
{
    public class DizaynYazdir
    {
        OnMuhasebe.Classlar.Veritabani Dbase = new OnMuhasebe.Classlar.Veritabani();
        public void SatisFaturasi(string Numara)
        {
            string sql = "select * from DIZFATURALAR WHERE FATURANO='" + Numara + "'";
            DataSet Fatura = new DataSet();
            Fatura = Dbase.DataSetCek(sql, "DIZFATURALAR");

            rapSATISFATURASI rapor = new rapSATISFATURASI();
            rapor.DataSource = Fatura;
            rapor.ShowPreview();
        }




        public void SatisIadeFaturasi(string Numara)
        {
            string sql = "select * from DIZFATURALAR WHERE FATURANO='" + Numara + "'";
            DataSet Fatura = new DataSet();
            Fatura = Dbase.DataSetCek(sql, "DIZFATURALAR");

            rapSATISIADEFATURASI rapor = new rapSATISIADEFATURASI();
            rapor.DataSource = Fatura;
            rapor.ShowPreview();
        }



        public void AlisFaturasi(string Numara)
        {
            string sql = "select * from DIZFATURALAR WHERE FATURANO='" + Numara + "'";
            DataSet Fatura = new DataSet();
            Fatura = Dbase.DataSetCek(sql, "DIZFATURALAR");

            rapALISFATURASI rapor = new rapALISFATURASI();
            rapor.DataSource = Fatura;
            rapor.ShowPreview();
        }

        public void AlisIadeFaturasi(string Numara)
        {
            string sql = "select * from DIZFATURALAR WHERE FATURANO='" + Numara + "'";
            DataSet Fatura = new DataSet();
            Fatura = Dbase.DataSetCek(sql, "DIZFATURALAR");

            rapALISIADEFATURASI rapor = new rapALISIADEFATURASI();
            rapor.DataSource = Fatura;
            rapor.ShowPreview();
        }
    }
}
