using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrkaToken.Class;
using static OrkaToken.Class.Enums;

namespace OrkaToken.Model.DTO.Personel
{
    public class PersonelIzinEkleDTO
    {
        
        public string tcKimlikNo { get; set; }
        public string isegiriscikis_kayitdamga { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime WorkStartingDate { get; set; }
        public decimal DayCount { get; set; }
        public TIC_PUB_CALISMATIP WorkType { get; set; }
    }
}
