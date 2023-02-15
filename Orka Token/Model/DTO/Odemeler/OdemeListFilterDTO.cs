using System;
using static OrkaToken.Class.Enums;

namespace OrkaToken.Model.DTO.Odemeler
{
    public class OdemeListFilterDTO
    {
        public int? ID { get; set; }
        public int[] IDlist { get; set; }

        public string kayitdamga { get; set; }
        //

        public TIC_IODURUM? tahsilTediye { get; set; }
        //
        public string belgeNo { get; set; }
        public string belgeNoBitis { get; set; }
        public string[] belgeNoList { get; set; }
        //
        public DateTime? belgeTarihi { get; set; }
        public DateTime? bitisBelgeTarihi { get; set; }
        //

        public TIC_CARI_KODTIPI? cariKodAramaTipi { get; set; }
        public string cariHesapKodu { get; set; }
        public string cariHesapKoduBitis { get; set; }


        public TIC_ODEME_TIPLERI? odemeTipi { get; set; }


        public TIC_ODEME_TIPLERI? odemeTipiBitis { get; set; }
        public TIC_ODEME_TIPLERI[] odemeTipList { get; set; }
        //
        public DateTime? vadeTarihi { get; set; }
        public DateTime? bitisVadeTarihi { get; set; }

        public int? grpdepartman { get; set; }
        public int? grpdepartmanBitis { get; set; }

        public int? grpdepoyeri { get; set; }
        public int? grpdepoyeriBitis { get; set; }

        public int? grpprojehizmet { get; set; }
        public int? grpprojehizmetBitis { get; set; }

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
        public int? grpcari { get; set; }
        public int? grpcariBitis { get; set; }
    }
}
