using System;
using OrkaToken.Class;

namespace OrkaToken.Model.DTO.Belge
{
    public class BelgeListFilterDTO
    {
        public int? ID { get; set; }
        public int[] IDlist { get; set; }
        public string kayitdamga { get; set; }
        //
        public Enums.TIC_IODURUM? alisSatis { get; set; }
        //
        public string belgeNo { get; set; }
        public string belgeNoBitis { get; set; }
        public string[] belgeNoList { get; set; }
        //
        public DateTime? belgeTarihi { get; set; }
        public DateTime? bitisBelgeTarihi { get; set; }
        //
        public string cariHesapKodu { get; set; }
        public Enums.TIC_CARI_KODTIPI? cariKodAramaTipi { get; set; }
        public string cariHesapKoduBitis { get; set; }
        public Enums.TIC_BELGE_TIPLERI? belgeTip { get; set; }
        public Enums.TIC_BELGE_TIPLERI[] belgeTipiList { get; set; }
        //
        public DateTime? vadeTarihi { get; set; }
        public DateTime? bitisVadeTarihi { get; set; }
        public int? grpdepartman { get; set; }
        public int? grpdepartmanBitis { get; set; }
        public int? grpdepoyeri { get; set; }
        public int? grpdepoyeriBitis { get; set; }
        public int? grpprojehizmet { get; set; }
        public int? grpprojehizmetBitis { get; set; }
        public int? grphazirlayanpersonel { get; set; }
        public int? grpyukleyenpersonel { get; set; }
        public int? grpsiparisalanpersonel { get; set; }
        public int? grpplasiyer { get; set; }
        public int? grpplasiyerBitis { get; set; }
        public int? grpgelirler { get; set; }
        public int? grpgelirlerBitis { get; set; }
        public int? grpgenel { get; set; }
        public int? grpgenelBitis { get; set; }
        public int? grpistatistik { get; set; }
        public int? grpistatistikBitis { get; set; }
        public int? grpsatisyeri { get; set; }
        public int? grpsatisyeriBitis { get; set; }
        public int? grpnakliye { get; set; }
        public int? grpnakliyeBitis { get; set; }
        public int? grpcari { get; set; }
        public int? grpcariBitis { get; set; }
    }
}
