using System;

namespace OrkaToken.Model.PUB
{
    public class PUB_ODEMESATIR
    {

        public int ID { get; set; }
        public int? pin { get; set; }
        public int konum { get; set; }
        public int? isaret { get; set; }
        public int? imgidx { get; set; }
        public bool? secim { get; set; }
        public Guid? isegiriscikis_kayitdamga { get; set; }
        public Guid? odemebaslik_kayitdamga { get; set; }
        public int? borcalacak { get; set; }
        public int? kesintituru { get; set; }
        public DateTime? kesintidonemi { get; set; }
        public int? taksitno { get; set; }
        public string aciklama { get; set; }
        public short? dovizcinsi { get; set; }
        public decimal? dovizkuru { get; set; }
        public decimal? doviztutari { get; set; }
        public decimal? odemetutari { get; set; }
        public decimal? borcvergiist { get; set; }
        public bool? bordroaktarildi { get; set; }
        public bool? bordroiliskili { get; set; }
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
