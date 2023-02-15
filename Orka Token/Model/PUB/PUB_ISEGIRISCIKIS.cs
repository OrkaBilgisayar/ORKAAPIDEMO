using System;

namespace OrkaToken.Model.PUB
{
    public class PUB_ISEGIRISCIKIS
    {

        public int ID { get; set; }
        public int? pin { get; set; }
        public int konum { get; set; }
        public int? isaret { get; set; }
        public int? imgidx { get; set; }
        public bool? secim { get; set; }
        public Guid? toplu_islem_UQ { get; set; }
        public int? giristipi { get; set; }
        public Guid personel_kayitdamga { get; set; }
        public string personelkartno { get; set; }
        public string bolumplankod { get; set; }
        public string personelplankod { get; set; }
        public int? profil_no { get; set; }
        public string belbilkodu { get; set; }
        public string tabsigkodu { get; set; }
        public DateTime? tesvikbaslatarihi { get; set; }
        public string yenitabsigkodu { get; set; }
        public decimal? sgktavanmatrahkatsayisi { get; set; }
        public DateTime? isegiristarihi { get; set; }
        public bool? girisbildirimiyap { get; set; }
        public DateTime? isdencikistarihi { get; set; }
        public string nakilgelenisyerisgkkodu { get; set; }
        public bool? cikisbildirimiyap { get; set; }
        public int? sgkisdencikis { get; set; }
        public int? iskurisdencikis { get; set; }
        public int? calbolisdencikis { get; set; }
        public string nakilisyerisgkkodu { get; set; }
        public int? sgkgiriscikisktrl { get; set; }
        public bool? gelirvergisinetabi { get; set; }
        public bool? damgavergisinetabi { get; set; }
        public DateTime? devirkumulatifvergidonemi { get; set; }
        public decimal? devirkumulatifvergimatrahi { get; set; }
        public int? calismayeri { get; set; }
        public int? argedoktoratipi { get; set; }
        public int? sakatlikind { get; set; }
        public decimal? sabitozelgelirvergiorani { get; set; }
        public int? tesvikgrubu { get; set; }
        public decimal? sakatlikorani { get; set; }
        public int? gelirdagitimtipi { get; set; }
        public int? muhtasarkod { get; set; }
        public int? agihesaptipi { get; set; }
        public decimal? isegirisdonemindeodenenagi { get; set; }
        public bool? agitutaritasinsinmi { get; set; }
        public int? aylik_ucret_gelirkodu { get; set; }
        public bool? agidahilnetucretuygula { get; set; }
        public bool? ozelucretteagidahilnetucretuygula { get; set; }
        public int? ucrettipi { get; set; }
        public decimal? aylikucreti { get; set; }
        public short? dovizcinsi { get; set; }
        public int? ucretcinsi { get; set; }
        public int? aylikmesaidagitimtipi { get; set; }
        public decimal? aylikmesaitutari { get; set; }
        public double? aylikmesaisaati { get; set; }
        public string mesaiorangrubu { get; set; }
        public int? maxicra_ucretalani { get; set; }
        public decimal? maxicraorani { get; set; }
        public DateTime? sonmuayenehanetarihi { get; set; }
        public int? puantajtipi { get; set; }
        public int? vardiyakaynak { get; set; }
        public int? vardiyagrup { get; set; }
        public int? vardiyano { get; set; }
        public int? calismaduzenigrup { get; set; }
        public int? calismaduzenikodu { get; set; }
        public bool? pdkslistecikar { get; set; }
        public int? pdksmesaiaktarimtipi { get; set; }
        public DateTime? kidembaslatarihi { get; set; }
        public int? kidemtazminatgunu { get; set; }
        public int? tazminatistirahatgun_gecenyil { get; set; }
        public int? tazminatistirahatgun_buyil { get; set; }
        public int? tazminatistirahatgun_sonrakiyil { get; set; }
        public string sgkmeslekkodu { get; set; }
        public string iskurmeslekkodu { get; set; }
        public int? meslekgrubu { get; set; }
        public string isgorevtanimi { get; set; }
        public int? sgkgorevkodu { get; set; }
        public int? sozlesmedurumu { get; set; }
        public DateTime? sozlesmebitistarihi { get; set; }
        public decimal? ucreti { get; set; }
        public int? denemesuresi { get; set; }
        public int? kanunidurumu { get; set; }
        public int? istihdamdurumu { get; set; }
        public int? kismicalismagunu { get; set; }
        public bool? yeraltindacalisan { get; set; }
        public bool? ozelguvenlik { get; set; }
        public decimal? mesaidahilaylikucreti { get; set; }
        public int? grpadres { get; set; }
        public int? grpcari { get; set; }
        public int? grpdepartman { get; set; }
        public int? grpdepoyeri { get; set; }
        public int? grpgelirler { get; set; }
        public int? grpgenel { get; set; }
        public int? grpistatistik { get; set; }
        public int? grpkatalog { get; set; }
        public int? grpliste { get; set; }
        public int? grpnakliye { get; set; }
        public int? grppersonel { get; set; }
        public int? grpplasiyer { get; set; }
        public int? grpprojehizmet { get; set; }
        public int? grpsatisyeri { get; set; }
        public int? teknopark_proje_dagilim_grubu { get; set; }
        public string teknoparkprojegorevi { get; set; }
        public string firmabankaplankod { get; set; }
        public int? bankahesapID { get; set; }
        public string bankakod { get; set; }
        public string bankasubenr { get; set; }
        public string bankasubeadi { get; set; }
        public string bankahesapnr { get; set; }
        public string bankaibanno { get; set; }
        public Guid? sendikakayitdamga { get; set; }
        public int? sendikagelirgrubu { get; set; }
        public int? sendikaucretgrubu { get; set; }
        public int? sendikaihbargrubu { get; set; }
        public int? sendikaizingrubu { get; set; }
        public DateTime? sendika_uye_basla_tarihi { get; set; }
        public DateTime? sendika_uye_bitis_tarihi { get; set; }
        public string uyeoldugusendika { get; set; }
        public DateTime? izinkidem_tarihi { get; set; }
        public DateTime? izinhesap_tarihi { get; set; }
        public int? izinhesap_calyil { get; set; }
        public int? izinhesap_calgun { get; set; }
        public double? gecenyilkullanilmayanyillikizingunu { get; set; }
        public double? izinhesap_buyilhakedizin { get; set; }
        public double? izinhesap_hakedilenizin { get; set; }
        public double? izinhesap_kullanilanizin { get; set; }
        public double? izinhesap_kalanizin { get; set; }
        public double? ekizinhakki_340 { get; set; }
        public DateTime? zbes_basla { get; set; }
        public DateTime? zbes_bitis { get; set; }
        public int? zbes_hesaplamatipi { get; set; }
        public decimal? r_deger1 { get; set; }
        public decimal? r_deger2 { get; set; }
        public decimal? r_deger3 { get; set; }
        public decimal? r_deger4 { get; set; }
        public decimal? r_deger5 { get; set; }
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
        public decimal? zbes_orani { get; set; }
    }
}
