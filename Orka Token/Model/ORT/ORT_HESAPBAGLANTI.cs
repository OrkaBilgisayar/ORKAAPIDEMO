using System;

namespace OrkaToken.Model.ORT
{
    public class ORT_HESAPBAGLANTI
    {

        public int ID { get; set; }
        public int? pin { get; set; }
        public int? isaret { get; set; }
        public int konum { get; set; }
        public int? imgidx { get; set; }
        public int? ID102 { get; set; }
        public string banka_plankod { get; set; }
        public int? islemtipi { get; set; }
        public int? kebirkod { get; set; }
        public string kod { get; set; }
        public int? mevduattip { get; set; }
        public int? mevduatcins { get; set; }
        public int? mevduatsira { get; set; }
        public string subekod { get; set; }
        public string subeadi { get; set; }
        public string hesapnr { get; set; }
        public string posmakina { get; set; }
        public string kredikart { get; set; }
        public int? hesapsira { get; set; }
        public string plankod { get; set; }
        public string planadi { get; set; }
        public int? vade_gun_tipi { get; set; }
        public int? vade_gun_bankakart { get; set; }
        public int? vade_gun_baskakart { get; set; }
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
