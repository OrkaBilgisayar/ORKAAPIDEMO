using OrkaToken.Model.DTO.Gruplar;
using static OrkaToken.Class.Enums;

namespace OrkaToken.Model.DTO.Hesap
{
    public class HesapEkleDTO
    {
        public TIC_HESAP_SEVIYELER? planTuru { get; set; }
        public TIC_KDV_ORANLAR? kdvOrani { get; set; }
        public string entegrekodu { get; set; }
        public string altBirim { get; set; }
        public bool hesapAktif { get; set; }
    }

    public class HesapEkleBasit : HesapEkleDTO
    {
        public string planKodu { get; set; }
        public string planAdi { get; set; }
        public TIC_PIN? pin { get; set; }
        public Grup Gruplar { get; set; }
        public TIC_DOVIZ_CINSLERI? paraBirimi { get; set; }
    }
}
