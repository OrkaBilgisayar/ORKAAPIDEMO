using System;

namespace OrkaToken.Model.ICE
{
    public class ICE_CARIKART
    {

        public int ID { get; set; }
        public int? pin { get; set; }
        public int konum { get; set; }
        public int? isaret { get; set; }
        public int? imgidx { get; set; }
        public int? IDplan { get; set; }
        public int carino { get; set; }
        public string plankod { get; set; }
        public string planadi { get; set; }
        public int? indirimgurubu { get; set; }
        public decimal? sabitindirimoran { get; set; }
        public decimal? teminattutar { get; set; }
        public decimal? kredilimiti { get; set; }
        public decimal? portfoytutar { get; set; }
        public int? tevkifatno { get; set; }
        public int? fiyatgurubu { get; set; }
        public bool? kurfarki { get; set; }
        public bool? toplufatura { get; set; }
        public bool? parekendesatis { get; set; }
        public short? odemetipi { get; set; }
        public short? risktoplamametodu { get; set; }
        public short? ulkekodu { get; set; }
        public int? kargofirma { get; set; }
        public string kredikartno { get; set; }
        public string elektronikkartno { get; set; }
        public bool? acikhesabakaydet { get; set; }
        public bool? puantakipsistemi { get; set; }
        public decimal? komisyonyuzde { get; set; }
        public decimal? komisyontutar { get; set; }
        public decimal? komisyondvtutar { get; set; }
        public bool? kontrol4 { get; set; }
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
    }
}
