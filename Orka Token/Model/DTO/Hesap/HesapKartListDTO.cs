using OrkaToken.Model.ICE;
using OrkaToken.Model.ORT;

namespace OrkaToken.Model.DTO.Hesap
{
    public class HesapKartListDTO
    {
        public string OrkaUQ { get; set; }
        public string hesapKodu { get; set; }
        public ORT_PLAN ORT_PLAN { get; set; }
        public ICE_CARIKART ICE_CARIKART { get; set; }
        public ICE_CARIADRES ICE_CARIADRES { get; set; }
        public ICE_EGITIMKIMLIK ICE_EGITIMKIMLIK { get; set; }
    }
}
