using System;

namespace OrkaToken.Model.PUB
{
    public class PUB_KIMLIKLER
    {

        public int ID { get; set; }
        public int? pin { get; set; }
        public int konum { get; set; }
        public int? isaret { get; set; }
        public int? imgidx { get; set; }
        public Guid? toplu_islem_UQ { get; set; }
        public int? kimliktipi { get; set; }
        public double? orkaprogramno { get; set; }
        public int? orkayakintipi { get; set; }
        public string tckimliknr { get; set; }
        public string serino { get; set; }
        public string sirano { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string oncekisoyadi { get; set; }
        public string babaadi { get; set; }
        public string anaadi { get; set; }
        public int? cinsiyeti { get; set; }
        public string kangrubu { get; set; }
        public string dogumyeri { get; set; }
        public DateTime? dogumtarihi { get; set; }
        public DateTime? olumtarihi { get; set; }
        public int? yasi { get; set; }
        public int? medenihali { get; set; }
        public DateTime? evlenmetarihi { get; set; }
        public DateTime? bosanmatarihi { get; set; }
        public short? ulkekodu { get; set; }
        public string uyrugu { get; set; }
        public int? dogumilcekodu { get; set; }
        public string dogumil { get; set; }
        public string dogumilce { get; set; }
        public string dogummahallekoy { get; set; }
        public string ciltno { get; set; }
        public string ailesirano { get; set; }
        public string kutukno { get; set; }
        public string dini { get; set; }
        public string verildigiyer { get; set; }
        public string verilisnedeni { get; set; }
        public DateTime? kayittarihi { get; set; }
        public string kayitno { get; set; }
        public string emeklioldugukurum { get; set; }
        public DateTime? emekliliktarihi { get; set; }
        public string emeklino { get; set; }
        public string eskisgksicilno { get; set; }
        public string cd { get; set; }
        public int? vergidairekod { get; set; }
        public string vergidairesi { get; set; }
        public string vergino { get; set; }
        public DateTime? ehliyettarihi { get; set; }
        public string ehliyetno { get; set; }
        public string ehliyetsinifi { get; set; }
        public string askerlikdurumu { get; set; }
        public DateTime? askerlikbastarihi { get; set; }
        public DateTime? askerlikbittarihi { get; set; }
        public string not1 { get; set; }
        public string not2 { get; set; }
        public string resimdosyadi { get; set; }
        public bool? evsizemiait { get; set; }
        public DateTime? tasindiginiztarih { get; set; }
        public bool? aracinizvarmi { get; set; }
        public string aracplakasi { get; set; }
        public string sacrengi { get; set; }
        public string gozrengi { get; set; }
        public string beden { get; set; }
        public double? boyu { get; set; }
        public double? ayakkabino { get; set; }
        public double? kilo { get; set; }
        public double? bedenolcugogus { get; set; }
        public double? bedenolcubel { get; set; }
        public double? bedenolcubasen { get; set; }
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
        public DateTime? ilkgiristarihi { get; set; }
    }
}
