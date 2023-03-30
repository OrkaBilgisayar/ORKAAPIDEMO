using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Orka_Token.Class;
using OrkaToken.Class;
using OrkaToken.Model;
using RestSharp;

namespace OrkaToken
{
    public partial class frmOrkaToken : Form
    {

        #region Constructor

        public string Token;


        private Form CagiranForm;
        public frmOrkaToken(Form F)
        {
            InitializeComponent();
            CagiranForm = F;
            butModul.Text = F.Text;
        }

        #endregion

        #region Token

        private void butToken_Click(object sender, EventArgs e)
        {

            RestClient Client = new RestClient("https://api.orka.com.tr/");

            //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz . Örn : Auth/Login
            var Request = new RestRequest("Auth/Login");

            //Request (istek) için method seçiliyor (Post,Get Vb.)
            Request.Method = Method.Post;

            //Request için QueryParametresi Ekleniyor Örn:(Auth/Login?ApiKey=D-E-M-O)
            //Api Key için sizlere özel verilmiş bilgiyi gönderiniz !
            Request.AddQueryParameter("ApiKey", "D-E-M-O");
            Request.AddQueryParameter("EntegreApp", "ORKA Örnek Proje");
            Request.AddQueryParameter("EntegreUserName", "ORKA Örnek Kullanıcı");


            /*
                    Eğer kendi localinizdeki bir ORKASQL veritabanına bağlantı kurmak istiyorsanız Connection Stringinizi şifreleyip bu Parametre ile göndermeniz gerekmektedir !!!!!!!!
                    ------------ KOD ------------
                    Request.AddQueryParameter("Connection", "____");
                    ------------ KOD ------------
            */

            //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
            //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<User>
            var Response = Client.ExecuteAsync<OrkaResponseModel<User>>(Request).Result;

            rchSonuc.Text = Response.Data.ToJson();

            //Sonraki işlemlerde pratik olması için token bir public değişkene atanıyor .
            Token = Response.Data.Data.Token;

            //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
            if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
            {
                StatusLabel.Text = "Token alındı";
            }

        }

        private void butCompanyList_Click(object sender, EventArgs e)
        {
            //Token Boş ise işlem yapmaması için eklendi . Token olmadan firma listesi alınamaz!!!
            if (!string.IsNullOrWhiteSpace(Token))
            {
                RestClient Client = new RestClient("https://api.orka.com.tr/");

                //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz . Örn : Auth/Login
                var Request = new RestRequest("Auth/GetCompanyCodes");

                //Request (istek) için method seçiliyor (Post,Get Vb.)
                Request.Method = Method.Get;

                //Request için QueryParametresi Ekleniyor
                Request.AddQueryParameter("CompanyDatabaseYear", "2023");

                //Request için header içine yetki bilgileri ekleniyor. Bearer 
                //Request için header içine dönüş tipi bilgileri ekleniyor 
                Request.AddHeader("Authorization", Token);
                Request.AddHeader("accept", "application/json");


                //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
                //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<User>
                var Response = Client.ExecuteAsync<OrkaResponseModel<List<GNL_FIRMATANIM>>>(Request).Result;

                //Response ekranda görüntülemek için yapıldı zorunlu değil
                rchSonuc.Text = Response.Data.ToJson();

                //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
                if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
                {
                    StatusLabel.Text = "Firma listesi alındı";
                }
            }
            else
            {
                rchSonuc.Text = "Token boş olduğu için işlem yapılamadı";
            }

        }

        private void butSetCompany_Click(object sender, EventArgs e)
        {
            //Token Boş ise işlem yapmaması için eklendi . Token olmadan firma listesi alınamaz!!!
            if (!string.IsNullOrWhiteSpace(Token))
            {
                RestClient Client = new RestClient("https://api.orka.com.tr/");

                //Request (istek) için oluşturuluyor içine data almak istediğiniz methodun url yazıyorsunuz 
                var Request = new RestRequest("Auth/SetCompanyCode");

                //Request (istek) için method seçiliyor (Post,Get Vb.)
                Request.Method = Method.Get;

                //Request için QueryParametresi Ekleniyor 
                Request.AddQueryParameter("VeritabaniKodu", "ORKA_0001_2023");

                //Request için header içine yetki bilgileri ekleniyor. Bearer 
                //Request için header içine dönüş tipi bilgileri ekleniyor 
                Request.AddHeader("Authorization", Token);
                Request.AddHeader("accept", "application/json");

                //Response (cevap) için oluşturuluyor içine Request(istek) gönderiliyor. 
                //OrkaResponse tüm dönüşlerde olan ana bir modeldir . Data kısmına ise kendi olutşurduğunuz modeli gönderebilirsiniz örneğin OrkaResponseModel<User>
                var Response = Client.ExecuteAsync<OrkaResponseModel<User>>(Request).Result;

                //Response ekranda görüntülemek için yapıldı zorunlu değil
                rchSonuc.Text = Response.Data.ToJson();

                //Sonraki işlemlerde pratik olması için token bir public değişkene atanıyor .
                MainToken.mainToken = Response.Data.Data.Token;


                //Statüs çubugu güncellemesi için yapıldı -- Zorunlu değil 
                if (string.IsNullOrWhiteSpace(Response.Data.ErrorCodeDescription))
                {
                    StatusLabel.Text = "Son token alındı";
                }

                //Burası zorunlu değildir form üzerinde token alındıktan sonra modül seçim butonlarının visible durumlarını ayarlamaktadır . -- ZORUNLU DEĞİL
                if (!string.IsNullOrWhiteSpace(MainToken.mainToken))
                {
                    grpModules.Visible = true;
                }

            }
            else
            {
                rchSonuc.Text = "Token boş olduğu için işlem yapılamadı";
            }
        }

        #endregion

        #region Modüller

        //Modül seçimleri içindir yapılması zorunlu değildir -- ZORUNLU DEĞİL
     
        private void butModul_Click(object sender, EventArgs e)
        {
            CagiranForm.ShowDialog();
        }


        #endregion

        #region Load

        //Burası zorunlu değildir form üzerinde token alındıktan sonra modül seçim butonlarının visible durumlarını ayarlamaktadır . -- ZORUNLU DEĞİL
        private void frmOrkaToken_Load(object sender, EventArgs e)
        {
            grpModules.Visible = false;

        }

        #endregion

      
    }
}
