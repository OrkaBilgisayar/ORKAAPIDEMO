using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Orka_Token.Class;
using OrkaToken.Class;
using OrkaToken.Model;
using OrkaToken.Model.DTO.Personel;
using RestSharp;


namespace Orka_Personel
{
    public partial class frmOrkaPersonel : Form
    {

        #region Constructor

        // BU ALANA ORKA LOGIN KISMINDAN ALDIĞINIZ VEYA KENDİ METHODLARINIZLA ALDIĞINIZ TOKENİ VEREBİLİRSİNİZ.
        public string Token = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiJPcmthRGVtbyIsInVuaXF1ZV9uYW1lIjoiT1JLQV8wMDAxXzIwMjIiLCJyb2xlIjoiQWRtaW4iLCJGaXJtYUtvZHUiOiJPUktBXzAwMDFfMjAyMiIsIkNvbm5lY3Rpb24iOiIiLCJFbnRlZ3JlQXBwIjoiT1JLQSDDlnJuZWsgUHJvamUiLCJFbnRlZ3JlVXNlciI6Ik9SS0Egw5ZybmVrIEt1bCIsIlNlc3Npb25HdWlkIjoiMDAwMDAwMDAtMDAwMC0wMDAwLTAwMDAtMDAwMDAwMDAwMDAwIiwiS2V5IjoiRC1FLU0tTyIsIm5iZiI6MTY0MzE4MDQ3NiwiZXhwIjoxNjQzMTg0MDc2LCJpYXQiOjE2NDMxODA0NzZ9.DRfOAqyV-jc8BSdyAAWiYQFcwTLoB9zE2f0MBTR-KeM";

        public frmOrkaPersonel()
        {
            InitializeComponent();
        }

        #endregion

        #region Personel

        private void butGetAllEmployees_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("HRM/Reports/GetAllEmployees");

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
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<PersonelListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = $"Personel listesi alındı. Kayıt Sayısı : {Response.Data.RecordSize}";
            }
        }

        private void butGetAllJoinedEmployees_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("HRM/Reports/GetAllJoinedEmployees");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Get;

            //Request için QueryParametresi Ekleniyor
            Request.AddQueryParameter("startJoinDate", "01.01.2024");
            Request.AddQueryParameter("finishJoinDate", "31.01.2024");

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<PersonelListDTO>>>(Request).Result;


            if(Response.Data != null)
            {
				//Response ekranda görüntülemek için yapıldı zorunlu değil
				rchSonuc.Text = Response.Data.ToJson();

				//Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
				if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
				{
					StatusLabel.Text = $"İşe başlayan personel listesi alındı. Kayıt Sayısı : {Response.Data.RecordSize}";
				}
			}

            else
            {
                rchSonuc.Text = Response.Content.ToString();
            }
        }

        private void butGetAllLeftedEmployees_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("HRM/Reports/GetAllLeftedEmployees");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Get;

            //Request için QueryParametresi Ekleniyor
            Request.AddQueryParameter("startLeavingDate", "01.01.2024");
            Request.AddQueryParameter("finishLeavingDate", "31.01.2024");

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<PersonelListDTO>>>(Request).Result;


            if(Response.Data != null)
            {
				//Response ekranda görüntülemek için yapıldı zorunlu değil
				rchSonuc.Text = Response.Data.ToJson();

				//Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
				if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
				{
					StatusLabel.Text = $"İşten çıkan personel listesi alındı. Kayıt Sayısı : {Response.Data.RecordSize}";
				}
			}

			else
			{
				rchSonuc.Text = Response.Content.ToString();
			}

		}

        #endregion

        #region İzin

        private void butGetAllPermit_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("HRM/Operations/Permits/GetAllPermit");

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
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<PersonelIzinListDTO>>>(Request).Result;


            if(Response.Data != null)
            {
				//Response ekranda görüntülemek için yapıldı zorunlu değil
				rchSonuc.Text = Response.Data.ToJson();

				//Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
				if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
				{
					StatusLabel.Text = $"Personel izin listesi alındı. Kayıt Sayısı : {Response.Data.RecordSize}";
				}
			}

			else
			{
				rchSonuc.Text = Response.Content.ToString();
			}

		}

        private void butAddPermit_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("HRM/Operations/Permits/AddPermit");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Post;

            //Request için header içine yetki bilgileri ekleniyor. Bearer 
            //Request için header içine dönüş tipi bilgileri ekleniyor 
            Request.AddHeader("Authorization", Token);
            Request.AddHeader("accept", "application/json");


            //Request içinde body olarak request modeli oluşturuyoruz
            //Örnek Model jsonları için https://api.orka.com.tr/doc bakabilirsiniz .
            var Izin = new PersonelIzinEkleDTO();
            {
                Izin.tcKimlikNo = "52087578866";
                Izin.isegiriscikis_kayitdamga = "01C795D0-9BAE-4D87-A04A-06EE4BAF41B4";
                Izin.FirstDate = new DateTime(2024, 01, 15);
                Izin.EndDate = new DateTime(2024, 01, 20);
                Izin.WorkStartingDate = new DateTime(2024, 01, 21);
                Izin.DayCount = 5;
                Izin.WorkType = Enums.TIC_PUB_CALISMATIP.Yillik;
            }

            //Oluşturulan modeli Request içine ekliyoruz 
            Request.AddJsonBody(Izin);



            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<OLUSTURULAN MODEL>
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<PersonelIzinListDTO>>>(Request).Result;

            //Response ekranda görüntülemek için yapıldı zorunlu değil
            rchSonuc.Text = Response.Data.ToJson();
        }

        private void butGetAllPersonPermit_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("HRM/Operations/Permits/GetAllPersonPermits");

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
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<PersonelIzinListDTO>>>(Request).Result;

            if(Response.Data !=null )
            {
				//Response ekranda görüntülemek için yapıldı zorunlu değil
				rchSonuc.Text = Response.Data.ToJson();

				//Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
				if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
				{
					StatusLabel.Text = $"Personel izin talep listesi alındı. Kayıt Sayısı : {Response.Data.RecordSize}";
				}
			}

            else
            {
                rchSonuc.Text = Response.Content.ToString();
            }
            
        }

        #endregion

        #region Ödeme

        private void butGetAllPayment_Click(object sender, EventArgs e)
        {
            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
            var Request = new RestRequest("HRM/Reports/GetAllPayment");

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
            var Response = Client.ExecuteAsync<OrkaResponseModel<IEnumerable<PersonelOdemeListDTO>>>(Request).Result;




            if (Response.Data != null)
            {
				//Response ekranda görüntülemek için yapıldı zorunlu değil
				rchSonuc.Text = Response.Data.ToJson();

				//Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
				if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
				{
					StatusLabel.Text = $"Personel icra listesi alındı. Kayıt Sayısı : {Response.Data.RecordSize}";
				}
			}

            else

            {
				rchSonuc.Text = Response.Content.ToString();
			}
				
        }
        
        #endregion

        #region Load
        //Ana formdan gelen token class içinden eşitleniyor
        private void frmOrkaPersonel_Load(object sender, EventArgs e)
        {
            Token = MainToken.mainToken;
        }

        #endregion

    }
}
