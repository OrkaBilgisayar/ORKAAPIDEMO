using System;

namespace OrkaToken.Model.ICE
{
    public class ICE_CARIADRES
    {

        public int ID { get; set; }
        public int? pin { get; set; }
        public int konum { get; set; }
        public int? isaret { get; set; }
        public int? imgidx { get; set; }
        public int IDicetablo { get; set; }
        public string plankod { get; set; }
        public int subenumara { get; set; }
        public string subeadi { get; set; }
        public string cariunvan { get; set; }
        public string cariunvan2 { get; set; }
        public int? vergidairekod { get; set; }
        public string vergidairesi { get; set; }
        public string vergino { get; set; }
        public string tckimliknr { get; set; }
        public string adres1 { get; set; }
        public string adres2 { get; set; }
        public string binaadi { get; set; }
        public string binano { get; set; }
        public string kapino { get; set; }
        public string kasabakoy { get; set; }
        public string semt { get; set; }
        public int? postakod { get; set; }
        public string ilce { get; set; }
        public string il { get; set; }
        public string adresno { get; set; }
        public string tel1 { get; set; }
        public string tel2 { get; set; }
        public string gsm { get; set; }
        public string fax { get; set; }
        public string eposta { get; set; }
        public string kepadresi { get; set; }
        public string webadresi { get; set; }
        public string babaadi { get; set; }
        public string dogumyeri { get; set; }
        public DateTime? dogumtarihi { get; set; }
        public string bagkurno { get; set; }
        public string efatura_senderpostboxname { get; set; }
        public string efatura_receiverpostboxname { get; set; }
        public long? IDexpimp1 { get; set; }
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
        public string ekkod_1 { get; set; }
        public string ekkod_2 { get; set; }
    }
}
