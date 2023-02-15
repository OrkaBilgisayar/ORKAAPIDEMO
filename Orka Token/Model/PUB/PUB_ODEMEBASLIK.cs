using System;

namespace OrkaToken.Model.PUB
{
    public class PUB_ODEMEBASLIK
    {

        public int ID { get; set; }
        public int? pin { get; set; }
        public int konum { get; set; }
        public int? isaret { get; set; }
        public int? imgidx { get; set; }
        public Guid? toplu_islem_UQ { get; set; }
        public bool? secim { get; set; }
        public Guid isegiriscikis_kayitdamga { get; set; }
        public Guid? icra_kayitdamga { get; set; }
        public DateTime bordrodonemi { get; set; }
        public int borcalacak { get; set; }
        public int kayityeri { get; set; }
        public int islemtipi { get; set; }
        public int kesintituru { get; set; }
        public DateTime taleptarihi { get; set; }
        public long? belgeno { get; set; }
        public string aciklama { get; set; }
        public short? dovizcinsi { get; set; }
        public decimal? dovizkuru { get; set; }
        public decimal? doviztutari { get; set; }
        public decimal? odemetutari { get; set; }
        public int? taksitsayisi { get; set; }
        public decimal? tltaksittutari { get; set; }
        public decimal? dvtaksittutari { get; set; }
        public DateTime ilkkesintidonemi { get; set; }
        public decimal? borcvergiist { get; set; }
        public string odemeplankod { get; set; }
        public string personelplankod { get; set; }
        public bool? odemeonayi { get; set; }
        public DateTime? odemetarihi { get; set; }
        public int? web_onaydurumu { get; set; }
        public bool? bordroiliskili { get; set; }
        public bool? muhentegre { get; set; }
        public int? IDfisbaslik { get; set; }
        public int? grpadres { get; set; }
        public int? grpcari { get; set; }
        public int? grpdepartman { get; set; }
        public int? grpgelirler { get; set; }
        public int? grpgenel { get; set; }
        public int? grpistatistik { get; set; }
        public int? grpkatalog { get; set; }
        public int? grpliste { get; set; }
        public int? grpnakliye { get; set; }
        public int? grppersonel { get; set; }
        public int? grpplasiyer { get; set; }
        public int? grpprojehizmet { get; set; }
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
        public int? grpdepoyeri { get; set; }
        public int? grpsatisyeri { get; set; }
    }
}
