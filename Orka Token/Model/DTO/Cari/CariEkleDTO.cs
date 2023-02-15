using OrkaToken.Model.DTO.Hesap;

namespace OrkaToken.Model.DTO.Cari
{
    public class CariEkleDTO : HesapEkleBasit
    {

        public string vergino { get; set; }

        public string tckimliknr { get; set; }
        public int? vergidairekod { get; set; }
        public CariBilgiBase CARIKART { get; set; }
        public CariAdresBase CARIADRES { get; set; }
        internal string vergidairesi { get; set; }
    }

    public class CariBilgiBase
    {
        public string ilgilikisi { get; set; }
        public int? indirimgrubu { get; set; }
        public decimal? sabitindirimorani { get; set; }
        public int? vadegunsayisi { get; set; }
        public decimal? teminattutar { get; set; }
        public decimal? kredilimiti { get; set; }
        public int? tevkifatno { get; set; }
        public int? fiyatgrubu { get; set; }

        public bool efaturayatabi { get; set; }
        public int efaturasenaryo { get; set; }
        public int earsivgonderimyontemi { get; set; }
        public int? ulkeKod { get; set; }
    }

    public class CariAdresBase
    {
        public string adres1 { get; set; }
        public string adres2 { get; set; }
        public string semt { get; set; }
        public string binano { get; set; }
        public string kapino { get; set; }
        public string binaadi { get; set; }
        public string ilce { get; set; }
        public string il { get; set; }
        public string gsm { get; set; }
        public string tel { get; set; }
        public string eposta { get; set; }
        public string web { get; set; }
    }
}
