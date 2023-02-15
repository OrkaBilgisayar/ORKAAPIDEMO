using System;
using System.Collections.Generic;
using OrkaToken.Model.STK;

namespace OrkaToken.Model.DTO.Stoklar
{
    public class StokListDTO
    {
        public Guid UQ { get; set; }
        public STK_STOKKART STK_STOKKART { get; set; }
        public List<STK_STOKFIYAT> STK_STOKFIYAT { get; set; }
    }
}
