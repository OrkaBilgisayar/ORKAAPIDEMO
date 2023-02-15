using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Orka_Token.Class;
using OrkaToken.Class;
using OrkaToken.Model;
using OrkaToken.Model.DTO;
using OrkaToken.Model.DTO.Belge;
using OrkaToken.Model.DTO.Cari;
using OrkaToken.Model.DTO.Odemeler;
using OrkaToken.Model.DTO.Stoklar;
using RestSharp;
using static OrkaToken.Class.Enums;
using OrkaToken;

namespace Orka_Ticari
{
    public partial class frmOrkaTicari : Form
    {

        #region Constructor


        public string Token;

        public frmOrkaTicari()
        {
            InitializeComponent();
            
        }

        #endregion

        #region Fatura

        private void butInvoiceList_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Documents/GetAll");

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
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<BelgeListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = $"Fatura listesi alındı . Kayıt Sayısı : {Response.Data.ItemsCount}";
            }
        }

        private void butInvoiceListWithFilters_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Documents/ListwithCustomFilters");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Post;

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Request içinde body olarak request modeli oluşturuyoruz
            var Filter = new BelgeListFilterDTO();
            Filter.belgeTarihi = new DateTime(2022, 01, 01);
            Filter.bitisBelgeTarihi = new DateTime(2022, 12, 31);

            //Oluşturulan modeli Request içine ekliyoruz 
            Request.AddJsonBody(Filter);



            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<BelgeListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = $"Parametreli fatura listesi alındı . Kayıt Sayısı : {Response.Data.ItemsCount}";
            }
        }

        private void butAddOrder_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Documents/AddOrder");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Post;

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Request içinde body olarak request modeli oluşturuyoruz
            //Örnek Model jsonları için https://api.orka.com.tr/doc bakabilirsiniz .
            var Siparis = new BelgeEkleBasit();
            {
                Siparis.alisSatis = TIC_IODURUM.Satis;
                Siparis.belgeTipi = TIC_BELGE_TIPLERI._Siparis_;
                Siparis.cariKodu = "120 1 00001";
                Siparis.belgeSeriNo = "A";
                Siparis.belgeNo = 31;
                Siparis.belgeTarihi = new DateTime(2022, 01, 01);
                Siparis.belgeAciklamasi = "deneme Sipariş ";
                Siparis.belgeUQ = Guid.NewGuid();
                Siparis.Satirlar = new List<BelgeSatirlariBase>()
                {
                    new BelgeSatirlariBase()
                    {
                        stokKodu   = "9960001",
                        stokAdi    = "Deneme Ticari Ürün %18",
                        miktar = 1,
                        stokBirim = TIC_STOK_BIRIMLERI.Adet,
                        fiyat = 100,
                        kdvOrani = TIC_KDV_ORANLAR.Oran18

                    }
                };
            }

            //Oluşturulan modeli Request içine ekliyoruz 
            Request.AddJsonBody(Siparis);



            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<BelgeListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = "Sipariş eklendi";
            }
        }

        private void butAddInvoice_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Documents/AddSimpleInvoice");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Post;

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Request içinde body olarak request modeli oluşturuyoruz
            //Örnek Model jsonları için https://api.orka.com.tr/doc bakabilirsiniz .
            var Siparis = new BelgeEkleBasit();
            {
                Siparis.alisSatis = TIC_IODURUM.Satis;
                Siparis.belgeTipi = TIC_BELGE_TIPLERI._Fatura_;
                Siparis.cariKodu = "120 1 00001";
                Siparis.belgeSeriNo = "A";
                Siparis.belgeNo = 31;
                Siparis.belgeTarihi = new DateTime(2022, 01, 01);
                Siparis.belgeAciklamasi = "deneme Sipariş ";
                Siparis.belgeUQ = Guid.NewGuid();
                Siparis.Satirlar = new List<BelgeSatirlariBase>()
                {
                    new BelgeSatirlariBase()
                    {
                        stokKodu   = "9960001",
                        stokAdi    = "Deneme Ticari Ürün %18",
                        miktar = 1,
                        stokBirim = TIC_STOK_BIRIMLERI.Adet,
                        fiyat = 100,
                        kdvOrani = TIC_KDV_ORANLAR.Oran18

                    }
                };
            }

            //Oluşturulan modeli Request içine ekliyoruz 
            Request.AddJsonBody(Siparis);



            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<BelgeListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = "Fatura eklendi";
            }
        }

        #endregion

        #region Ödemeler

        private void butPaymentList_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Payments/GetAll");

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
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<OdemelerListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = $"Ödemeler listesi alındı. Kayıt Sayısı : {Response.Data.RecordSize}";
            }
        }

        private void butPaymentListWithFilters_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Payments/ListwithCustomFilters");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Post;

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Request içinde body olarak request modeli oluşturuyoruz
            var Filter = new OdemeListFilterDTO();
            Filter.belgeTarihi = new DateTime(2022, 01, 01);
            Filter.bitisBelgeTarihi = new DateTime(2022, 12, 31);

            //Oluşturulan modeli Request içine ekliyoruz 
            Request.AddJsonBody(Filter);



            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<BelgeListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = $"Parametre ödemeler listesi alındı. Kayıt Sayısı : {Response.Data.RecordSize}";
            }
        }

        private void butAddCashPayment_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Payments/AddCashPayment");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Post;

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Request içinde body olarak request modeli oluşturuyoruz
            //Örnek Model jsonları için https://api.orka.com.tr/doc bakabilirsiniz .
            var Odeme = new OdemeEkleBasit();
            {
                Odeme.belgeTarihi = new DateTime(2022, 01, 01);
                Odeme.belgeNo = 1324567;
                Odeme.belgeUQ = Guid.NewGuid();
                Odeme.hesapKodu = "120 1 00001";
                Odeme.karsiplankod = "100 1 1 00";
                Odeme.belgeSeriNo = "A";
                Odeme.tahsilTediye = TIC_IODURUM.Satis;
                Odeme.aciklama = "Nakit tahsilat";
                Odeme.odemeTutari = 1245;
            }

            //Oluşturulan modeli Request içine ekliyoruz 
            Request.AddJsonBody(Odeme);



            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<BelgeListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = "Nakit ödeme eklendi";
            }
        }

        private void butAddBankPayment_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Payments/AddBankPayment");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Post;

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Request içinde body olarak request modeli oluşturuyoruz
            //Örnek Model jsonları için https://api.orka.com.tr/doc bakabilirsiniz .
            var Odeme = new OdemeEkleBasit();
            {
                Odeme.belgeTarihi = new DateTime(2022, 01, 01);
                Odeme.belgeNo = 1324567;
                Odeme.belgeUQ = Guid.NewGuid();
                Odeme.hesapKodu = "120 1 00001";
                Odeme.karsiplankod = "100 1 1 00";
                Odeme.belgeSeriNo = "A";
                Odeme.tahsilTediye = TIC_IODURUM.Satis;
                Odeme.aciklama = "Nakit tahsilat";
                Odeme.odemeTutari = 1245;
            }

            //Oluşturulan modeli Request içine ekliyoruz 
            Request.AddJsonBody(Odeme);



            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<BelgeListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = "Banka ödemesi eklendi";
            }
        }

        #endregion

        #region Stoklar

        private void butGetAllStocks_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Stock/GetAll");

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
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<StokListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = $"Stok listesi alındı. Kayıt Sayısı : {Response.Data.ItemsCount}";
            }
        }
        private void butStockListWithFilters_Click(object sender, EventArgs e)
        {

            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Stock/ListwithCustomFilters");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Post;

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");

            //Request içinde body olarak request modeli oluşturuyoruz
            var Filter = new StokListFilterDTO();

            //Oluşturulan modeli Request içine ekliyoruz 
            Request.AddJsonBody(Filter);

            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<StokListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = $"Parametre stok listesi alındı. Kayıt Sayısı : {Response.Data.ItemsCount}";
            }
        }
        private void butAddStock_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Stock/AddStockCard");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Post;

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Request içinde body olarak request modeli oluşturuyoruz
            //Örnek Model jsonları için https://api.orka.com.tr/doc bakabilirsiniz .
            var Stok = new StokEkleBasit();
            {

                Stok.stokKodu = "1000001";
                Stok.stokAdi = "TEST STOK";
                Stok.kdvOrani = TIC_KDV_ORANLAR.Oran18;
                Stok.stokUQ = Guid.NewGuid();
                Stok.muhasebeTabloKodu = 15;
                Stok.birim = TIC_STOK_BIRIMLERI.Adet;
                Stok.cinsi = TIC_STOK_CINSLERI.Mal;

            }

            //Oluşturulan modeli Request içine ekliyoruz 
            Request.AddJsonBody(Stok);



            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<StokListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = "Stok eklendi";
            }
        }
        private void butDeleteStock_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Stock/DeleteStockCard");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Post;

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Request için QueryParametresi Ekleniyor 
            Request.AddQueryParameter("ID", "191");


            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync(Request).Result;

            //Status okey geliyorsa ekrana mesaj basılıyor . 
            //Response ekranda görüntülemek için yapıldı zorunlu değil
            if (Response.StatusCode == HttpStatusCode.OK)
            {
                rchSonuc.Text = "Stok kaydı silindi .";

                //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 

                StatusLabel.Text = "Token alındı";
            }
                

            
            

        }



        #endregion

        #region Raporlar

        private void butGetExtreWithCode_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Reports/CustomerReports/GetExtreWithcustomerCode");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Get;

            //Request için QueryParametresi Ekleniyor
            Request.AddQueryParameter("customerCode", "120 1 00001");
            Request.AddQueryParameter("endcustomerCode", "120 1 00001");
            Request.AddQueryParameter("startDate", "01.01.2022");
            Request.AddQueryParameter("endDate", "31.12.2022");

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<CariEkstreDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = $"Cari ekstresi alındı. Kayıt Sayısı : {Response.Data.ItemsCount}";
            }
        }

        private void butGetStockExtreWithCode_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("ERP/Reports/StockReports/GetExtreWithstockCode");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Get;

            //Request için QueryParametresi Ekleniyor
            Request.AddQueryParameter("stockCode", "9960001");
            Request.AddQueryParameter("startDate", "01.01.2022");
            Request.AddQueryParameter("endDate", "31.12.2022");

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<StokListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = $"Stok ekstresi alındı. Kayıt Sayısı : {Response.Data.ItemsCount}";
            }
        }


        #endregion

        #region Load
        //Ana formdan gelen token class içinden eşitleniyor
        private void frmOrkaTicari_Load(object sender, EventArgs e)
        {
            Token = MainToken.mainToken;
        }

        #endregion

    }

}
