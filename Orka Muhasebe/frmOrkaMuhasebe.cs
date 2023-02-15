using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Orka_Token.Class;
using OrkaToken.Class;
using OrkaToken.Model;
using OrkaToken.Model.DTO.Banka;
using OrkaToken.Model.DTO.Cari;
using OrkaToken.Model.DTO.Hesap;
using OrkaToken.Model.DTO.MuhasebeFisi;
using RestSharp;

namespace Orka_Muhasebe
{
    public partial class frmOrkaMuhasebe : Form
    {

        #region Constructor

        // BU ALANA ORKA LOGIN KISMINDAN ALDIĞINIZ VEYA KENDİ METHODLARINIZLA ALDIĞINIZ TOKENİ VEREBİLİRSİNİZ.
        public string Token = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiJPcmthRGVtbyIsInVuaXF1ZV9uYW1lIjoiT1JLQV8wMDAxXzIwMjIiLCJyb2xlIjoiQWRtaW4iLCJGaXJtYUtvZHUiOiJPUktBXzAwMDFfMjAyMiIsIkNvbm5lY3Rpb24iOiIiLCJFbnRlZ3JlQXBwIjoiT1JLQSDDlnJuZWsgUHJvamUiLCJFbnRlZ3JlVXNlciI6Ik9SS0Egw5ZybmVrIEt1bCIsIlNlc3Npb25HdWlkIjoiMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDAwMDAwMDAwIiwiS2V5IjoiRC1FLU0tTyIsIm5iZiI6MTY0NDc0NjY2NSwiZXhwIjoxNjQ0NzUwMjY1LCJpYXQiOjE2NDQ3NDY2NjV9.xURwXAVm9Lj7PhgQW_itZnNHsRl4Fv0TX8yYrMfCDTQ";

        public frmOrkaMuhasebe()
        {
            InitializeComponent();
        }

        #endregion

        #region Hesap Planı

        private void butGetAllAccoountingCodeList_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Accounting/GetAllAccountingCodeList");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Get;

            //Request için QueryParametresi Ekleniyor
            Request.AddQueryParameter("Page", "1");

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<HesapKartListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = $"Hesap planı alındı . Kayıt Sayısı : {Response.Data.ItemsCount}";
            }
        }
        private void butAddAccountingCode_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Accounting/AddAccountingCode");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Post;

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Request içinde body olarak request modeli oluşturuyoruz
            //Örnek Model jsonları için https://api.orka.com.tr/doc bakabilirsiniz .
            var Hesap = new HesapEkleBasit();
            {
                Hesap.planKodu = "770 4 78";
                Hesap.planAdi = "Deneme Hesabı - Sonra Siliniz";
                Hesap.planTuru = Enums.TIC_HESAP_SEVIYELER.Detay;
                Hesap.kdvOrani = Enums.TIC_KDV_ORANLAR.Oran18;
                Hesap.pin = Enums.TIC_PIN.Ok;
            }

            //Oluşturulan modeli Request içine ekliyoruz 
            Request.AddJsonBody(Hesap);



            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<HesapKartListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = "Yeni hesap eklendi";
            }
        }
        private void butAddCustomer_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Accounting/AddAccountingCode");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Post;

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Request içinde body olarak request modeli oluşturuyoruz
            //Örnek Model jsonları için https://api.orka.com.tr/doc bakabilirsiniz .
            var cariHesap = new CariEkleDTO();
            {
                cariHesap.planKodu = "120 1 11992";
                cariHesap.planAdi = "Deneme Cari - Sonra Siliniz";
                cariHesap.planTuru = Enums.TIC_HESAP_SEVIYELER.Detay;
                cariHesap.vergino = "6470009903";
                cariHesap.vergidairekod = 034203;
                cariHesap.pin = Enums.TIC_PIN.Ok;
                cariHesap.paraBirimi = Enums.TIC_DOVIZ_CINSLERI.TL;
                cariHesap.CARIKART = new CariBilgiBase()
                {
                    ilgilikisi = "Soner Soysal",
                    efaturayatabi = true,
                    efaturasenaryo = 1,
                    earsivgonderimyontemi = 0,
                };
                cariHesap.CARIADRES = new CariAdresBase()
                {
                    adres1 = "MENDİREK SK. NO:3",
                    adres2 = "ORKA PLAZA",
                    semt = "KÜÇÜKYALI",
                    binano = "3",
                    kapino = "1",
                    binaadi = "ORKA PLAZA",
                    ilce = "MALTEPE",
                    il = "İSTANBUL",
                    gsm = "0541 900 90 90",
                    tel = "0216 330 83 50",
                    eposta = "orka@orka.com.tr",
                    web = "www.orka.com.tr"
                };
            }

            //Oluşturulan modeli Request içine ekliyoruz 
            Request.AddJsonBody(cariHesap);



            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<HesapKartListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = "Yeni cari kart eklendi";
            }
        }


        #endregion

        #region Bankalar

        private void butGetAllBanks_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Accounting/GetAllBanks");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Get;

            //Request için QueryParametresi Ekleniyor
            Request.AddQueryParameter("Page", "1");

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<BankaListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = $"Banka listesi alındı. Kayıt Sayısı : {Response.Data.ItemsCount}";
            }
        }
        private void butAddBank_Click(object sender, EventArgs e)
        {

            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Accounting/AddBankAccountingCodes");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Post;

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Request içinde body olarak request modeli oluşturuyoruz
            //Örnek Model jsonları için https://api.orka.com.tr/doc bakabilirsiniz .
            var Banka = new BankaEkleDTO();
            {
                Banka.pin = Enums.TIC_PIN.Ok;
                Banka.bankaKodu = "AKB";
                Banka.siraNo = 1;
                Banka.paraCinsi = Enums.TIC_DOVIZ_CINSLERI.TL;
                Banka.mevduatTipi = Enums.TIC_BANKA_MEVDUAT_CINSLERI.Vadesiz;
                Banka.subeKodu = "1400";
                Banka.subeAdi = "Kadiköy";
                Banka.musteriNo = "1200-1";
                Banka.hesapNo = "123456-1";
                Banka.IBAN = "TR320010009999901234567890";
                Banka.efaturadaGoster = 0;

                Banka.baglantilar = new bankaBaglihesaplar()
                {
                    tahsileCekVeriliyor = true,
                    teminataCekVeriliyor = true,
                    tahsileSenetVeriliyor = true,
                    teminataSenetVeriliyor = true,
                };

                Banka.posTanimlari = new List<bankaPosBaglantilari>()
                {
                    new bankaPosBaglantilari()
                    {
                        posTipi = Enums.TIC_BANKA_POS_TURLERI.BONUS,
                        vadeGunTipi = 0,
                        vadeGunu = 0,

                    }
                };

                Banka.krediKartTanimlari = new List<bankaKrediKartBaglantilari>()
                {
                    new bankaKrediKartBaglantilari()
                    {
                        krediKartTipi = Enums.TIC_BANKA_KREDIKART_TURLERI.MAST,
                        krediKartisiraNo = 1,
                        vadeGunu = 0,
                        vadeGunTipi = 0,
                    }
                };

                Banka.krediTanimlari = new List<bankaKrediBaglantilari>()
                {
                    new bankaKrediBaglantilari()
                    {
                        hesapAciklamasi = "Araç Kredisi",
                        krediSiraNo = 1,
                        kredihesapNo = "132165",
                    }
                };

            }

            //Oluşturulan modeli Request içine ekliyoruz 
            Request.AddJsonBody(Banka);



            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<HesapKartListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = $"Yeni banka eklendi.";
            }
        }


        #endregion

        #region Muhasebe Fişi
        private void butGetAllReceipts_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Accounting/GetAllReceipts");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Get;

            //Request için QueryParametresi Ekleniyor
            Request.AddQueryParameter("Page", "1");

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<MuhasebeFisListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = $"Muhasebe fişi listesi alındı. Kayıt Sayısı : {Response.Data.ItemsCount}";
            }
        }

        private void butAddSimpleReceipts_Click(object sender, EventArgs e)
        {

            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Accounting/AddSimpleReceipt");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Post;

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Request içinde body olarak request modeli oluşturuyoruz
            //Örnek Model jsonları için https://api.orka.com.tr/doc bakabilirsiniz .
            var Fis = new MuhasebeFisBasitEkleDTO();
            {
                Fis.fisTipi = Enums.TIC_FIS_TIPLERI._FisTipMahsup_;
                Fis.belgeTipi = Enums.TIC_BELGE_TIPLERI._Fatura_;
                Fis.belgeNo = 4548;
                Fis.fisTarihi = new DateTime(2022, 01, 01);
                Fis.belgeTarihi = new DateTime(2022, 01, 01);
                Fis.seriNo = "EAR";
                Fis.fisaciklama = "Satış Faturası";
                Fis.fisGuid = Guid.NewGuid();
                Fis.satirlar = new List<MuhasebeFisSatirBase>()
                {

                    new MuhasebeFisSatirBase()
                    {
                        hesapKodu =  "600 1 18",
                        hesapAdi = "Satışlar",
                        kdvOrani =  Enums.TIC_KDV_ORANLAR.Oran18,
                        belgeaciklama = "ORKA VİNÇ LTD. ŞTİ",
                        borcAlacak = Enums.TIC_MUH_BORCALACAK.Alacak,
                        tutar =  5508.47m,

                    },
                    new MuhasebeFisSatirBase()
                    {
                        hesapKodu =  "391 1 18",
                        hesapAdi = "KDV",
                        kdvOrani =  Enums.TIC_KDV_ORANLAR.Oran18,
                        belgeaciklama = "ORKA VİNÇ LTD. ŞTİ",
                        borcAlacak = Enums.TIC_MUH_BORCALACAK.Alacak,
                        tutar =  991.53m,
                    },
                    new MuhasebeFisSatirBase()
                    {
                        hesapKodu =  "120 1 00001",
                        hesapAdi = "Orka Vinç",
                        kdvOrani =  Enums.TIC_KDV_ORANLAR.Oran18,
                        belgeaciklama = "Satış Faturası",
                        borcAlacak = Enums.TIC_MUH_BORCALACAK.Borc,
                        tutar =  6500.00m,
                    },

                };

            }

            //Oluşturulan modeli Request içine ekliyoruz 
            Request.AddJsonBody(Fis);



            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<HesapKartListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = $"Yeni muhasebe fişi eklendi.";
            }
        }


        #endregion

        #region Load
        //Ana formdan gelen token class içinden eşitleniyor
        private void frmMuhasebe_Load(object sender, EventArgs e)
        {
            Token = MainToken.mainToken;
        }

        #endregion

    }
}
