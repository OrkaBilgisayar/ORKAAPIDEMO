using System;

namespace OrkaToken.Model.PUB
{
    public class PUB_ADRESLER
    {

        public int ID { get; set; }
        public int? pin { get; set; }
        public int konum { get; set; }
        public int? isaret { get; set; }
        public int? imgidx { get; set; }
        public Guid personel_kayitdamga { get; set; }
        public int? adrestipi { get; set; }
        public string adres1 { get; set; }
        public string adres2 { get; set; }
        public string kapino { get; set; }
        public string daireno { get; set; }
        public int? postakod { get; set; }
        public int? ilcekodu { get; set; }
        public string semt { get; set; }
        public string ilce { get; set; }
        public string il { get; set; }
        public string tel1 { get; set; }
        public string tel2 { get; set; }
        public string gsm { get; set; }
        public string fax { get; set; }
        public string eposta { get; set; }
        public string kepadresi { get; set; }
        public string webadresi { get; set; }
        public string webparola { get; set; }
        public Guid kayitdamga { get; set; }
        public byte[] tarihdamga { get; set; }
        public Guid? baglidamga { get; set; }
        public int? IDtranskayit { get; set; }
        public int? priority { get; set; }
        public int? firmnmbr { get; set; }
        public int? firmyear { get; set; }
        public string firstuser { get; set; }
        public DateTime? firstdate { get; set; }
        public string edituser { get; set; }
        public DateTime? editdate { get; set; }
    }
}
