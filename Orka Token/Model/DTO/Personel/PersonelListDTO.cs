using System.Collections.Generic;
using OrkaToken.Model.PUB;

namespace OrkaToken.Model.DTO.Personel
{
    public class PersonelListDTO
    {
        public PUB_KIMLIKLER Kimlik { get; set; }
        public List<PUB_ISEGIRISCIKIS> IseGirisCikislar { get; set; }
        public PUB_ADRESLER Adres { get; set; }
        public byte[] PersonelResim { get; set; }
    }
}
