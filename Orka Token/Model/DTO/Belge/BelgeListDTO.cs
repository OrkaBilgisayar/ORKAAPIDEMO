using System.Collections.Generic;
using OrkaToken.Model.ICE;
using OrkaToken.Model.ORT;
using OrkaToken.Model.STK;

namespace OrkaToken.Model.DTO.Belge
{
    public class BelgeListDTO
    {
        public string OrkaUQ { get; set; }
        public STK_STOKBASLIK STK_STOKBASLIK { get; set; }
        public List<STK_STOKSATIR> STK_STOKSATIR { get; set; }
        public ICE_CARIKART ICE_CARIKART { get; set; }
        public ICE_CARIADRES ICE_CARIADRES { get; set; }
        public ICE_ODEMEBASLIK ICE_ODEMEBASLIK { get; set; }
       
        public ORT_PLAN ORT_PLAN { get; set; }

    }
}
