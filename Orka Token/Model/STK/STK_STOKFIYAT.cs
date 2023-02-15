using System;

namespace OrkaToken.Model.STK
{
    public class STK_STOKFIYAT
    {

        public int ID { get; set; }
        public int? pin { get; set; }
        public int konum { get; set; }
        public int? isaret { get; set; }
        public int? imgidx { get; set; }
        public short IOdurum { get; set; }
        public int fiyatno { get; set; }
        public string stokkod { get; set; }
        public int IDstokkod { get; set; }
        public short dovizcins { get; set; }
        public decimal? dvfiyat { get; set; }
        public decimal? dvkdvdahil { get; set; }
        public decimal? tlfiyat { get; set; }
        public decimal? tlkdvdahil { get; set; }
        public decimal? min_fiyat { get; set; }
        public decimal? min_kdvdahilfiyat { get; set; }
        public decimal? max_fiyat { get; set; }
        public decimal? max_kdvdahilfiyat { get; set; }
        public DateTime? fiyatvadesi { get; set; }
        public decimal? komisyontoplam { get; set; }
        public decimal? komisyondvtoplam { get; set; }
        public decimal? komisyonoran1 { get; set; }
        public decimal? komisyonoran2 { get; set; }
        public decimal? komisyonoran3 { get; set; }
        public bool? kontrol0 { get; set; }
        public bool? kontrol1 { get; set; }
        public bool? kontrol2 { get; set; }
        public bool? kontrol3 { get; set; }
        public bool? kontrol4 { get; set; }
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
