using static OrkaToken.Class.Enums;

namespace OrkaToken.Model.DTO.Stoklar
{
    public class StokListFilterDTO
    {
        public int? ID { get; set; }
        public int[] IDlist { get; set; }

        public string barKodu { get; set; }
        public string[] barKoduList { get; set; }

        public string stokKodu { get; set; }
        public string[] stokKoduList { get; set; }

        public TIC_STOK_BIRIMLERI? stokbirim { get; set; }
        public TIC_STOK_BIRIMLERI[] stokbirimList { get; set; }

        public TIC_STOK_CINSLERI? stokCinsi { get; set; }
        public TIC_STOK_CINSLERI[] stokCinsiList { get; set; }

        public string stokAdi { get; set; }
        public string[] stokAdiList { get; set; }

        public string kayitdamga { get; set; }

        public bool sadeceFiyatiolanlariListe { get; set; }
    }
}
