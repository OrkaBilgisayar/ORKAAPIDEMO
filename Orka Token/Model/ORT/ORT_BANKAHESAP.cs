using System;

namespace OrkaToken.Model.ORT
{
    public class ORT_BANKAHESAP
    {

        public int ID { get; set; }
        public int? pin { get; set; }
        public int? isaret { get; set; }
        public int? imgidx { get; set; }
        public int konum { get; set; }
        public string plankod { get; set; }
        public string kod { get; set; }
        public int hesapsira { get; set; }
        public int mevduattip { get; set; }
        public int mevduatcins { get; set; }
        public string musterino { get; set; }
        public string hesapnr { get; set; }
        public string ibanno { get; set; }
        public string subekod { get; set; }
        public string subeadi { get; set; }
        public int? ilcekod { get; set; }
        public string swiftkodu { get; set; }
        public bool? cektahsil { get; set; }
        public bool? cekteminat { get; set; }
        public bool? snttahsil { get; set; }
        public bool? sntteminat { get; set; }
        public bool? kesidecek { get; set; }
        public bool? havaleemir { get; set; }
        public int? efaturada_goster { get; set; }
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
