using System.Collections.Generic;
using OrkaToken.Model.ICE;
using OrkaToken.Model.ORT;
using static OrkaToken.Class.Enums;

namespace OrkaToken.Model.DTO.Odemeler
{
    public class OdemelerListDTO
    {
        public TIC_ODEME_TIPLERI odemeTuru
        {
            get => (TIC_ODEME_TIPLERI)ICE_ODEMEBASLIK?.odemetipi;

        }

        public string hesapKodu
        {
            get => ICE_ODEMEBASLIK?.plankod;

        }

        public string OrkaUQ
        {
            get => ORT_PLAN?.kayitdamga.ToString();

        }

        public string kayitUQ
        {
            get => ICE_ODEMEBASLIK?.kayitdamga.ToString();

        }

        public ICE_ODEMEBASLIK ICE_ODEMEBASLIK { get; set; }
        public odemelerCekSenet cekSenetDetail { get; set; }
        public ICE_CARIKART ICE_CARIKART { get; set; }
        public ORT_PLAN ORT_PLAN { get; set; }


        public ORT_PLAN ORT_PLAN_karsihesap { get; set; }
        //
        public sealed class odemelerCekSenet
        {
            public ICE_CSVGIRIS ICE_CSVGIRIS { get; set; }
            public List<ICE_CSVHAREKET> ICE_CSVHAREKET { get; set; }

        }

    }

}
