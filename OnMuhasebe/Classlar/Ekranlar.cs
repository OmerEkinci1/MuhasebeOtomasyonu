using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnMuhasebe.Classlar
{
    class Ekranlar
    {
        public string StokKod1Ac(Boolean Sec)
        {
            OnMuhasebe.StokModulu.frmStokKod1 frm = new StokModulu.frmStokKod1();

            if (Sec == true)
            {
                frm.SecimIcinAcildiMi = true;
                frm.ShowDialog();
                return frmAnaForm.AraDegiskenString;
            }
            else
            {
                frm.SecimIcinAcildiMi = false;
                frm.ShowDialog();
            }
            return "";
        }
        public string StokKod2Ac(Boolean Sec)
        {
            OnMuhasebe.StokModulu.frmStokKod2 frm = new StokModulu.frmStokKod2();

            if (Sec == true)
            {
                frm.SecimIcinAcildiMi = true;
                frm.ShowDialog();
                return frmAnaForm.AraDegiskenString;
            }
            else
            {
                frm.SecimIcinAcildiMi = false;
                frm.ShowDialog();
            }
            return "";
        }
        public string StokKod3Ac(Boolean Sec)
        {
            OnMuhasebe.StokModulu.frmStokKod3 frm = new StokModulu.frmStokKod3();

            if (Sec == true)
            {
                frm.SecimIcinAcildiMi = true;
                frm.ShowDialog();
                return frmAnaForm.AraDegiskenString;
            }
            else
            {
                frm.SecimIcinAcildiMi = false;
                frm.ShowDialog();
            }
            return "";
        }
        public string StokKod4Ac(Boolean Sec)
        {
            OnMuhasebe.StokModulu.frmStokKod4 frm = new StokModulu.frmStokKod4();

            if (Sec == true)
            {
                frm.SecimIcinAcildiMi = true;
                frm.ShowDialog();
                return frmAnaForm.AraDegiskenString;
            }
            else
            {
                frm.SecimIcinAcildiMi = false;
                frm.ShowDialog();
            }
            return "";
        }
        public string StokKod5Ac(Boolean Sec)
        {
            OnMuhasebe.StokModulu.frmStokKod5 frm = new StokModulu.frmStokKod5();

            if (Sec == true)
            {
                frm.SecimIcinAcildiMi = true;
                frm.ShowDialog();
                return frmAnaForm.AraDegiskenString;
            }
            else
            {
                frm.SecimIcinAcildiMi = false;
                frm.ShowDialog();
            }
            return "";
        }
        public void StokTanitimKartiAc(bool Edit = false, string UrunId = "-1")
        {
            OnMuhasebe.StokModulu.frmStokTanitimKarti frm = new StokModulu.frmStokTanitimKarti();

            if (Edit == true)//güncelleme yapıalcaksa
            {
                frm.Ac(UrunId);
            }
            frm.ShowDialog();
        }
        public void TopluStokAcma()
        {
            OnMuhasebe.StokModulu.frmTopluStokAcma frm = new StokModulu.frmTopluStokAcma();
            frm.MdiParent = OnMuhasebe.frmAnaForm.ActiveForm;
            frm.Show();
        }


        public void TopluStokGuncelleme()
        {
            OnMuhasebe.StokModulu.frmTopluStokGuncelle frm = new StokModulu.frmTopluStokGuncelle();
            frm.MdiParent = OnMuhasebe.frmAnaForm.ActiveForm;
            frm.Show();
        }
        public void StokHareketKayitlari(Boolean StokGonder = false, string UrunId = "-1")
        {
            OnMuhasebe.StokModulu.frmStokHareketleri frm = new StokModulu.frmStokHareketleri();
            if (StokGonder == true)
            {
                frm.Ac(UrunId);
            }

            frm.MdiParent = OnMuhasebe.frmAnaForm.ActiveForm;//babası anaformdur
            frm.Show();
        }
        public void StokAcilisKarti(string Id = "-1", Boolean Ac = false)
        {
            OnMuhasebe.StokModulu.frmStokAcilisKarti frm = new StokModulu.frmStokAcilisKarti();
            if (Ac == true)
            {
                frm.Ac(Id);
            }
            frm.ShowDialog();
        }

        public void CariTanitimKartiAc()
        {
            OnMuhasebe.CariModulu.frmCariTanitimKarti frm = new OnMuhasebe.CariModulu.frmCariTanitimKarti();
            frm.ShowDialog();
        }


        public void CariHareketKayitlari(Boolean CariKoduGonder = false, string Id = "-1")
        {
            OnMuhasebe.CariModulu.frmCariHareketler frm = new CariModulu.frmCariHareketler();
            if (CariKoduGonder == true)
            {
                frm.CariSec(Id);
            }
            frm.MdiParent = frmAnaForm.ActiveForm;//bu formun babası frmAnaFormdur dedik.//frmCariHareketler formunu frmAnaform için mdi şekilde açılmasını sağladık.
            frm.Show();

        }


        public void CariAcilisKarti(Boolean Ac = false, string Id = "-1")
        {
            OnMuhasebe.CariModulu.frmCariAcilisKarti frm = new CariModulu.frmCariAcilisKarti();

            if (Ac == true)
            {
                frm.Ac(Id); //form açılmadan formdaki öğelere (textbox gibi öğeler) değerleri atadık sonra aşağıdada formu açtık
            }
            frm.ShowDialog();


        }
        public string StokListesi(Boolean Sec = false)
        {
            OnMuhasebe.StokModulu.frmStokListesi frm = new StokModulu.frmStokListesi();

            if (Sec == true)
            {
                frm.SecimIcinAc = true;
                frm.ShowDialog();
                return frmAnaForm.AraDegiskenString;

            }
            else
            {
                frm.MdiParent = OnMuhasebe.frmAnaForm.ActiveForm;
                frm.SecimIcinAc = false;
                frm.Show();
                return "";
            }


        }

        public string CariListesiAc(Boolean Dialog = true)
        {
            OnMuhasebe.CariModulu.frmCariListesi frm = new OnMuhasebe.CariModulu.frmCariListesi();
            if (Dialog == true)
            {
                frm.ShowDialog();

            }
            else
            {
                frm.MdiParent = frmAnaForm.ActiveForm;
                frm.Show();
            }


            return frmAnaForm.AraDegiskenString;//içinde double clikcten dönen ID' değerini tutmuştuk onu geri dönderiyoruz
        }

        public void SatisFaturasiAc()
        {
            OnMuhasebe.FaturaModulu.Satis.frmSatisFaturasi frm = new FaturaModulu.Satis.frmSatisFaturasi();
            frm.MdiParent = frmAnaForm.ActiveForm;//bu formun babası frmAnaFormdur dedik.//SatisFaturası formunu frmAnaform için mdi şekilde açılmasını sağladık.
            frm.Show();
        }





        public string SatisFaturasiListesi(Boolean Dialog = true)
        {
            OnMuhasebe.FaturaModulu.Satis.frmSatisFaturasiListesi frm = new FaturaModulu.Satis.frmSatisFaturasiListesi();

            if (Dialog == true)
            {
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = frmAnaForm.ActiveForm;
                frm.SecimIcinAc = false;
                frm.Show();
            }


            return frmAnaForm.AraDegiskenString;//içinde double clikcten dönen ID' değerini tutmuştuk onu geri dönderiyoruz
        }



        //satış iade 

        public void SatisIadeFaturasiAc()
        {
            OnMuhasebe.FaturaModulu.SatisIade.frmSatisIadeFaturasi frm = new FaturaModulu.SatisIade.frmSatisIadeFaturasi();
            frm.MdiParent = frmAnaForm.ActiveForm;//bu formun babası frmAnaFormdur dedik.//SatisFaturası formunu frmAnaform için mdi şekilde açılmasını sağladık.
            frm.Show();
        }





        public string SatisIadeFaturasiListesi(Boolean Dialog = true)
        {
            OnMuhasebe.FaturaModulu.SatisIade.frmSatisIadeFaturasiListesi frm = new FaturaModulu.SatisIade.frmSatisIadeFaturasiListesi();
            if (Dialog == true)
            {
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = frmAnaForm.ActiveForm;
                frm.SecimIcinAc = false;
                frm.Show();
            }

            return frmAnaForm.AraDegiskenString;//içinde double clikcten dönen ID' değerini tutmuştuk onu geri dönderiyoruz
        }


        //alış faturası
        public void AlisFaturasiAc()
        {
            OnMuhasebe.FaturaModulu.Alis.frmAlisFaturasi frm = new FaturaModulu.Alis.frmAlisFaturasi();
            frm.MdiParent = frmAnaForm.ActiveForm;//bu formun babası frmAnaFormdur dedik.//SatisFaturası formunu frmAnaform için mdi şekilde açılmasını sağladık.
            frm.Show();
        }





        public string AlisFaturasiListesi(Boolean Dialog = true)
        {
            OnMuhasebe.FaturaModulu.Alis.frmAlisFaturasiListesi frm = new FaturaModulu.Alis.frmAlisFaturasiListesi();

            if (Dialog == true)
            {
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = frmAnaForm.ActiveForm;
                frm.SecimIcinAc = false;
                frm.Show();
            }

            return frmAnaForm.AraDegiskenString;//içinde double clikcten dönen ID' değerini tutmuştuk onu geri dönderiyoruz
        }


        //alış iade faturası
        public void AlisIadeFaturasiAc()
        {
            FaturaModulu.AlisIade.frmAlisIadeFaturasi frm = new FaturaModulu.AlisIade.frmAlisIadeFaturasi();
            frm.MdiParent = frmAnaForm.ActiveForm;//bu formun babası frmAnaFormdur dedik.//SatisFaturası formunu frmAnaform için mdi şekilde açılmasını sağladık.
            frm.Show();
        }





        public string AlisIadeFaturasiListesi(Boolean Dialog = true)
        {
            OnMuhasebe.FaturaModulu.AlisIade.frmAlisIadeFaturasiListesi frm = new FaturaModulu.AlisIade.frmAlisIadeFaturasiListesi();
            if (Dialog == true)
            {
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = frmAnaForm.ActiveForm;
                frm.SecimIcinAc = false;
                frm.Show();
            }

            return frmAnaForm.AraDegiskenString;//içinde double clikcten dönen ID' değerini tutmuştuk onu geri dönderiyoruz
        }



        public void KasaTanitimKarti(Boolean Ac = false, string Id = "-1")
        {
            OnMuhasebe.KasaModulu.frmKasaTanitimKarti frm = new KasaModulu.frmKasaTanitimKarti();
            if (Ac == true)
            {
                frm.Ac(Id);
            }

            frm.ShowDialog();
        }
        public string KasaListesi(Boolean Dialog = false)
        {

            OnMuhasebe.KasaModulu.frmKasaListesi frm = new KasaModulu.frmKasaListesi();
            if (Dialog == true)
            {
                frm.SecimIcinAc = true;
                frm.ShowDialog();
                return frmAnaForm.AraDegiskenString;
            }
            else
            {

                frm.SecimIcinAc = false;
                frm.MdiParent = OnMuhasebe.frmAnaForm.ActiveForm;
                frm.Show();
            }

            return "";

        }


        public void KasaHareketleri(Boolean Ac = false, string KasaId = "-1")
        {
            OnMuhasebe.KasaModulu.frmKasaHareketKayitlari frm = new KasaModulu.frmKasaHareketKayitlari();
            if (Ac == true)
            {
                frm.Ac(KasaId);
            }
            frm.MdiParent = OnMuhasebe.frmAnaForm.ActiveForm;//babası anaformdur dedik.
            frm.Show();
        }

        public void KasaAcilisKarti(Boolean Ac = false, string Id = "-1")
        {
            OnMuhasebe.KasaModulu.frmKasaAcilisKarti frm = new KasaModulu.frmKasaAcilisKarti();
            if (Ac == true)
            {
                frm.Ac(Id);
            }
            frm.ShowDialog();
        }

        public void KasaTahsilatGirisi(Boolean Ac = false, string Id = "-1")
        {
            OnMuhasebe.KasaModulu.frmKasaTahsilat frm = new KasaModulu.frmKasaTahsilat();
            if (Ac == true)
            {
                frm.Ac(Id);
            }
            frm.ShowDialog();
        }

        public void KasaOdemeGirisi(Boolean Ac = false, string Id = "-1")
        {
            OnMuhasebe.KasaModulu.frmKasaOdeme frm = new KasaModulu.frmKasaOdeme();
            if (Ac == true)
            {
                frm.Ac(Id);
            }
            frm.ShowDialog();
        }

        public void BankaTanitimKarti(Boolean Ac = false, string Id = "-1")
        {
            OnMuhasebe.BankaModulu.frmBankaTanitimKarti frm = new BankaModulu.frmBankaTanitimKarti();
            if (Ac == true)
            {
                frm.Ac(Id);
            }

            frm.ShowDialog();
        }


        public string BankaListesi(Boolean Dialog = false)
        {

            OnMuhasebe.BankaModulu.frmBankaListesi frm = new BankaModulu.frmBankaListesi();
            if (Dialog == true)
            {
                frm.SecimIcinAc = true;
                frm.ShowDialog();
                return frmAnaForm.AraDegiskenString;
            }
            else
            {

                frm.SecimIcinAc = false;
                frm.MdiParent = OnMuhasebe.frmAnaForm.ActiveForm;
                frm.Show();
            }

            return "";

        }

        public void BankaAcilisKarti(Boolean Ac = false, string Id = "-1")
        {
            OnMuhasebe.BankaModulu.frmBankaAcilisKarti frm = new OnMuhasebe.BankaModulu.frmBankaAcilisKarti();
            if (Ac == true)
            {
                frm.Ac(Id);
            }
            frm.ShowDialog();




        }

        public void BankaHareketKayitlari()
        {
            OnMuhasebe.BankaModulu.frmBankaHareketKayitlari frm = new BankaModulu.frmBankaHareketKayitlari();
            frm.MdiParent = frmAnaForm.ActiveForm;
            frm.Show();
        }

        public void BankaIslemi(Boolean Ac = false, string Id = "-1")
        {
            OnMuhasebe.BankaModulu.frmBankaIslemi frm = new BankaModulu.frmBankaIslemi();
            if (Ac == true)
            {
                frm.Ac(Id);
            }
            frm.ShowDialog();
        }

        public void GelenHavale(Boolean Ac = false, string Id = "-1")
        {
            OnMuhasebe.BankaModulu.frmGelenHavale frm = new BankaModulu.frmGelenHavale();
            if (Ac == true)
            {
                frm.Ac(Id);
            }

            frm.ShowDialog();
        }

        public void GonderilenHavale(Boolean Ac = false, string Id = "-1")
        {
            OnMuhasebe.BankaModulu.frmGonderilenHavale frm = new BankaModulu.frmGonderilenHavale();
            if (Ac == true)
            {
                frm.Ac(Id);
            }

            frm.ShowDialog();
        }

        //ÇEK MODÜLÜ

        public void MusteriCekGirisi(Boolean Ac = false, string Id = "-1")
        {
            OnMuhasebe.CekSenetModulu.Cek.frmMusteriCeki frm = new CekSenetModulu.Cek.frmMusteriCeki();
            if (Ac == true)//güncelleme için açıcaksak
            {
                frm.Ac(Id);
            }
            else
            {
                frm.ShowDialog();
            }

        }


        public void MusteriCekBordroGirisi(Boolean Ac = false, string Id = "-1")
        {
            OnMuhasebe.CekSenetModulu.Cek.frmMusteriCekBordrosu frm = new CekSenetModulu.Cek.frmMusteriCekBordrosu();
            frm.MdiParent = frmAnaForm.ActiveForm;
            if (Ac == true) frm.BordroAc(Id);
            frm.Show();
        }

        public MusteriCeki BordroIcinCekSec(string CariKodu, string CariAdi)//geriye Struct dönüyor.
        {
            OnMuhasebe.CekSenetModulu.Cek.frmMusteriCeki frm = new CekSenetModulu.Cek.frmMusteriCeki();
            return frm.Sec(CariKodu, CariAdi);
        }

        public MusteriCeki BordroIcinCekGuncelle(MusteriCeki Cek, string CariKodu, string CariAdi)//geriye Struct dönüyor.
        {
            OnMuhasebe.CekSenetModulu.Cek.frmMusteriCeki frm = new CekSenetModulu.Cek.frmMusteriCeki();
            return frm.Guncelle(Cek, CariKodu, CariAdi, true);
        }
        public string CekBordroListesi(Boolean Dialog = false)
        {
            OnMuhasebe.CekSenetModulu.Cek.frmCekBordroListesi frm = new CekSenetModulu.Cek.frmCekBordroListesi();
            if (Dialog == true)
            {
                frm.SecimIcinAc = true;
                frm.ShowDialog();
                return frmAnaForm.AraDegiskenString;//static değişken
            }
            else
            {
                frm.MdiParent = frmAnaForm.ActiveForm;
                frm.Show();
            }

            return "";
        }

        public string MusteriCekListesi(Boolean Dialog = false, Boolean Bankadakiler = false, Boolean Portfoydekiler = false, Boolean CiroEdilenler = false)
        {
            OnMuhasebe.CekSenetModulu.Cek.frmMusteriCekListesi frm = new CekSenetModulu.Cek.frmMusteriCekListesi();

            if (Dialog == true)
            {
                frm.SecimIcinAc = true;
                frm.Bankadakiler = Bankadakiler;
                frm.Portfoydakiler = Portfoydekiler;
                frm.Cirodakiler = CiroEdilenler;
                frm.ShowDialog();
                return frmAnaForm.AraDegiskenString;
            }
            else
            {
                frm.Bankadakiler = true;
                frm.Portfoydakiler = true;
                frm.Cirodakiler = true;

                frm.MdiParent = frmAnaForm.ActiveForm;
                frm.Show();
            }


            return "";
        }


        public string MusteriSenetListesi(Boolean Dialog = false, Boolean Bankadakiler = false, Boolean Portfoydekiler = false, Boolean CiroEdilenler = false)
        {
            OnMuhasebe.CekSenetModulu.Cek.frmMusteriCekListesi frm = new CekSenetModulu.Cek.frmMusteriCekListesi();

            if (Dialog == true)
            {
                frm.SecimIcinAc = true;
                frm.Bankadakiler = Bankadakiler;
                frm.Portfoydakiler = Portfoydekiler;
                frm.Cirodakiler = CiroEdilenler;
                frm.ShowDialog();
                return frmAnaForm.AraDegiskenString;
            }
            else
            {
                frm.Bankadakiler = true;
                frm.Portfoydakiler = true;
                frm.Cirodakiler = true;

                frm.MdiParent = frmAnaForm.ActiveForm;
                frm.Show();
            }


            return "";
        }
        public void BankayaCekCikisi()
        {
            OnMuhasebe.CekSenetModulu.Cek.frmBankayaCekCikisi frm = new CekSenetModulu.Cek.frmBankayaCekCikisi();
            frm.ShowDialog();
        }


        public void CariyeCekCikisi()
        {
            OnMuhasebe.CekSenetModulu.Cek.frmCariyeCekCikisi frm = new CekSenetModulu.Cek.frmCariyeCekCikisi();
            frm.ShowDialog();
        }

        public void BankayaCekCikisiTek(string CekId)
        {
            OnMuhasebe.CekSenetModulu.Cek.frmBankayaCekCikisiTek frm = new CekSenetModulu.Cek.frmBankayaCekCikisiTek();
            frm.CekAc(CekId);
        }


        public void CariyeCekCikisiTek(string CekId)
        {
            OnMuhasebe.CekSenetModulu.Cek.frmCariyeCekCikisiTek frm = new CekSenetModulu.Cek.frmCariyeCekCikisiTek();
            frm.CekAc(CekId);
        }
        public void BankayaCekCikisiIade(string CekId)
        {
            OnMuhasebe.CekSenetModulu.Cek.frmBankayaCekCikisiIade frm = new CekSenetModulu.Cek.frmBankayaCekCikisiIade();
            frm.CekAc(CekId);
        }

        public void CariyeCekCikisiIade(string CekId)
        {
            OnMuhasebe.CekSenetModulu.Cek.frmCariyeCekCikisiIade frm = new CekSenetModulu.Cek.frmCariyeCekCikisiIade();
            frm.CekAc(CekId);
        }

        public void CekDurumu(string CekId, string Yeri)
        {
            if (Yeri == "P")//PORTFÖY İSE 
            {
                OnMuhasebe.CekSenetModulu.Cek.frmCekDurumuPortfoy frm = new CekSenetModulu.Cek.frmCekDurumuPortfoy();
                frm.CekAc(CekId);
            }
            else if (Yeri == "B")//bANKA İSE
            {
                OnMuhasebe.CekSenetModulu.Cek.frmCekDurumuBanka frm = new CekSenetModulu.Cek.frmCekDurumuBanka();
                frm.CekAc(CekId);
            }

        }


        public void KendiCekGirisi(Boolean Ac = false, string Id = "-1")
        {
            OnMuhasebe.CekSenetModulu.Cek.frmKendiCekimiz frm = new CekSenetModulu.Cek.frmKendiCekimiz();
            if (Ac == true)//güncelleme için açıcaksak
            {
                frm.Ac(Id);
            }
            else
            {
                frm.ShowDialog();
            }

        }


        public string KendiCekListesi(Boolean Dialog = false, Boolean Bankadakiler = false, Boolean Portfoydekiler = false, Boolean CiroEdilenler = false)
        {
            OnMuhasebe.CekSenetModulu.Cek.frmKendiCekListesi frm = new CekSenetModulu.Cek.frmKendiCekListesi();

            if (Dialog == true)
            {
                frm.SecimIcinAc = true;
                frm.Bankadakiler = Bankadakiler;
                frm.Portfoydakiler = Portfoydekiler;
                frm.Cirodakiler = CiroEdilenler;
                frm.ShowDialog();
                return frmAnaForm.AraDegiskenString;
            }
            else
            {
                frm.Bankadakiler = true;
                frm.Portfoydakiler = true;
                frm.Cirodakiler = true;

                frm.MdiParent = frmAnaForm.ActiveForm;
                frm.Show();
            }


            return "";
        }

        //RAPORLAR
        //******STOK RAPORLARI

        public void RaporStokHareket()
        {
            OnMuhasebe.StokModulu.Raporlar.frmRapStokHareket rap = new StokModulu.Raporlar.frmRapStokHareket();
            rap.MdiParent = frmAnaForm.ActiveForm;
            rap.Show();


        }

        public void RaporCariStokHareket()
        {
            OnMuhasebe.StokModulu.Raporlar.frmRapCariStokHareket rap = new StokModulu.Raporlar.frmRapCariStokHareket();
            rap.MdiParent = frmAnaForm.ActiveForm;
            rap.Show();


        }

        public void RaporTarihAraligiStokHareket()
        {
            OnMuhasebe.StokModulu.Raporlar.frmRapTarihAraligiStokHareket rap = new StokModulu.Raporlar.frmRapTarihAraligiStokHareket();
            rap.MdiParent = frmAnaForm.ActiveForm;
            rap.Show();


        }

        //CARI RAPORLARI

        public void RaporCariHareket()
        {
            OnMuhasebe.CariModulu.Raporlar.frmRapCariHareket rap = new CariModulu.Raporlar.frmRapCariHareket();
            rap.MdiParent = frmAnaForm.ActiveForm;
            rap.Show();


        }

        public void Rapor_OzelCariRaporu()
        {
            OnMuhasebe.CariModulu.Raporlar.frmRapCariOzelRaporu rap = new CariModulu.Raporlar.frmRapCariOzelRaporu();
            rap.MdiParent = frmAnaForm.ActiveForm;
            rap.Show();


        }

        //KULLANICI İŞLEMLERİ


        public void KullaniciEkle()
        {
            OnMuhasebe.KullaniciModulu.frmKullanici frm = new KullaniciModulu.frmKullanici();
            frm.Edit = false;
            frm.ShowDialog();
        }

        public void KullaniciGuncelle(string Id)
        {
            OnMuhasebe.KullaniciModulu.frmKullanici frm = new KullaniciModulu.frmKullanici();
            frm.Edit = true;//güncelleme için
            frm.Ac(Id);
            frm.ShowDialog();
        }

        public string KullaniciListesi(Boolean Dialog = false)
        {
            OnMuhasebe.KullaniciModulu.frmKullaniciListesi frm = new KullaniciModulu.frmKullaniciListesi();

            if (Dialog == true)
            {
                frm.SecimmIcinAc = true;
                frm.ShowDialog();

                return frmAnaForm.AraDegiskenString;
            }
            else
            {
                frm.MdiParent = frmAnaForm.ActiveForm;
                frm.Show();
            }


            return "";

        }

     


        public void KullaniciYetkileri(Boolean Ac = false, string Id = "-1")
        {
            OnMuhasebe.KullaniciModulu.frmYetkiler frm = new KullaniciModulu.frmYetkiler();
            frm.MdiParent = frmAnaForm.ActiveForm;
            if (Ac == true)
            {
                frm.Ac(Id);
            }
           
            frm.Show();
        }

        public void ParolaDegistir()
        {
            frmParolaDegistir frm = new frmParolaDegistir();
            frm.ShowDialog();
        }

        public void ServerAyarlari()
        {
            frmServerAyarlari frm = new frmServerAyarlari();
            frm.Show();
        }
    }
}
