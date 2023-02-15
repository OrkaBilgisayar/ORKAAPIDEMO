using System.Collections.Generic;
using OrkaToken.Model.ORT;

namespace OrkaToken.Model.DTO.MuhasebeFisi
{
    public class MuhasebeFisListDTO
    {
        public string OrkaUQ { get; set; }
        public ORT_FISBASLIK ORT_FISBASLIK { get; set; }
        public List<ORT_FISSATIR> ORT_FISSATIR { get; set; }
    }
}
