using OrkaToken.Model.DTO.Gruplar;
using System;
using static OrkaToken.Class.Enums;

namespace OrkaToken.Model.DTO.Stoklar
{
    public class StokEkleDTO
    {
        public long? barKodu { get; set; }
        public string ekKodu { get; set; }
        public string ekAdi { get; set; }
        public TIC_STOK_BIRIMLERI? birim { get; set; }
        public TIC_STOK_CINSLERI? cinsi { get; set; }
        public TIC_STOK_TUTARHESAPLAMA_MODELI? tutarHesaplamaModeli { get; set; }
        public int? icerik { get; set; }
        public int? muhasebeTablosu { get; set; }
        public int grpstokkod { get; set; }
        public bool? aktif { get; set; }
    }

    public class StokEkleBasit : StokEkleDTO
    {

        public string stokKodu { get; set; }
        public string stokAdi { get; set; }
        public TIC_KDV_ORANLAR? kdvOrani { get; set; }
        public Guid stokUQ { get; set; }
        public int? muhasebeTabloKodu { get; set; }
        public GRUPLARSTOKBaseModel Gruplar { get; set; }


    }
}
