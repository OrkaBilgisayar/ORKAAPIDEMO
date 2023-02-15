using System;

namespace OrkaToken.Model.ICE
{
    public class ICE_EGITIMKIMLIK
    {

        public int ID { get; set; }
        public int? pin { get; set; }
        public int konum { get; set; }
        public int? isaret { get; set; }
        public int? imgidx { get; set; }
        public bool? aktif { get; set; }
        public int? fatura_kime { get; set; }
        public long ogrencino { get; set; }
        public string mebkutukno { get; set; }
        public string plankod { get; set; }
        public string planadi { get; set; }
        public string adisoyadi { get; set; }
        public string tckimliknr { get; set; }
        public string dogumyeri { get; set; }
        public DateTime? dogumtarihi { get; set; }
        public bool? cinsiyet { get; set; }
        public string geldigiokul { get; set; }
        public string anneadi { get; set; }
        public string annemeslek { get; set; }
        public string anneeposta { get; set; }
        public string anneceptel { get; set; }
        public string annetckimlikno { get; set; }
        public string babaadi { get; set; }
        public string babameslek { get; set; }
        public string babaeposta { get; set; }
        public string babaceptel { get; set; }
        public string babatckimlikno { get; set; }
        public short? velisi { get; set; }
        public string acilyakinadi { get; set; }
        public string acilyakinlik { get; set; }
        public string acilyakinceptel { get; set; }
        public string acilyakintckimlikno { get; set; }
        public string kayityapanadisoyadi { get; set; }
        public DateTime? kayittarihi { get; set; }
        public short? okulcikisteslim { get; set; }
        public string teslimyakinadi { get; set; }
        public string teslimyakinlik { get; set; }
        public string teslimceptel { get; set; }
        public int? indirimgurubu1 { get; set; }
        public int? indirimgurubu2 { get; set; }
        public int? indirimgurubu3 { get; set; }
        public int? indirimgurubu4 { get; set; }
        public int? indirimgurubu5 { get; set; }
        public decimal? indiroran1 { get; set; }
        public decimal? indiroran2 { get; set; }
        public decimal? indiroran3 { get; set; }
        public decimal? indiroran4 { get; set; }
        public decimal? indiroran5 { get; set; }
        public Guid kayitdamga { get; set; }
        public byte[] tarihdamga { get; set; }
        public Guid? baglidamga { get; set; }
        public int? IDtranskayit { get; set; }
        public int? priority { get; set; }
        public int? firmnmbr { get; set; }
        public int? firmyear { get; set; }
        public string firstuser { get; set; }
        public DateTime? firstdate { get; set; }
        public string edituser { get; set; }
        public DateTime? editdate { get; set; }
    }
}
