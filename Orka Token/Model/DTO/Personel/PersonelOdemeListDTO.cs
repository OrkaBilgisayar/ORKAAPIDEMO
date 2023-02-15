using System.Collections.Generic;
using OrkaToken.Model.PUB;

namespace OrkaToken.Model.DTO.Personel
{
    public class PersonelOdemeListDTO
    {
        public PUB_KIMLIKLER Kimlik { get; set; }
        public List<PUB_ISEGIRISCIKIS> IseGirisCikislar { get; set; }
        public PUB_ODEMEBASLIK OdemeBaslik { get; set; }
        public PUB_ODEMESATIR OdemeSatir { get; set; }
    }
}
