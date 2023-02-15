using System;
using static OrkaToken.Class.Enums;
using OrkaToken.Model.DTO.Gruplar;

namespace OrkaToken.Model.DTO.Odemeler
{
    public class OdemeEkleDTO
    {

        public TIC_PIN? pin { get; set; }
        public Guid belgeUQ { get; set; }
        public TIC_IODURUM tahsilTediye { get; set; }
        public TIC_ODEME_TIPLERI? odemeTipi { get; set; }
        public TIC_DOVIZ_CINSLERI? paraCinsi { get; set; }
        public string belgeSeriNo { get; set; }
        public long belgeNo { get; set; }
        public DateTime belgeTarihi { get; set; }
        public decimal? dovizKuru { get; set; }
        public string aciklama { get; set; }
        public bool? devirKaydi { get; set; }

    }


    public class OdemeEkleBasit : OdemeEkleDTO
    {
        public string hesapKodu { get; set; }
        public string karsiplankod { get; set; }
        public DateTime? vadeTarihi { get; set; }
        public decimal odemeTutari { get; set; }
        public Grup Gruplar { get; set; }
    }
}
