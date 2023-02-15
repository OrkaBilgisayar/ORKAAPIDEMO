using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrkaToken.Model.PUB;

namespace OrkaToken.Model.DTO.Personel
{
    public class PersonelIzinListDTO
    {
        public PUB_KIMLIKLER Kimlik { get; set; }
        public List<object> Izinler { get; set; }
    }
}
