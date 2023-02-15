using OrkaToken.Model.ORT;
using System.Collections.Generic;

namespace OrkaToken.Model.DTO.Banka
{
    public class BankaListDTO
    {
        public string OrkaUQ { get; set; }
        public string hesapKodu { get; set; }
        public ORT_BANKAHESAP ORT_BANKAHESAP { get; set; }
        public List<ORT_HESAPBAGLANTI> ORT_HESAPBAGLANTI { get; set; }
        public ORT_PLAN ORT_PLAN { get; set; }
        public List<ORT_PLAN> muhasebeKodlari { get; set; }
	}
}
