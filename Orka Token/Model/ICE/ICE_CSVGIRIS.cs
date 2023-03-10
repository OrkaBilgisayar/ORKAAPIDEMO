using System;

namespace OrkaToken.Model.ICE
{
    public class ICE_CSVGIRIS
    {

        public int ID { get; set; }
        public int? pin { get; set; }
        public int konum { get; set; }
        public int? isaret { get; set; }
        public int? imgidx { get; set; }
        public Guid? baslik_UQ { get; set; }
        public Guid? toplu_islem_UQ { get; set; }
        public int IOPortfoy { get; set; }
        public int portfoytipi { get; set; }
        public int? IDfisbaslik { get; set; }
        public int? IDCSVsonhareket { get; set; }
        public int IDPlankod { get; set; }
        public string plankod { get; set; }
        public int portfoykebir { get; set; }
        public string portfoykod { get; set; }
        public int IDPortfoykod { get; set; }
        public int IDIlkPortfoykod { get; set; }
        public string Ilkportfoykod { get; set; }
        public string bankahesapkodu { get; set; }
        public int? nitelik { get; set; }
        public bool? devirgirisi { get; set; }
        public DateTime? giristarihi { get; set; }
        public string belgeserino { get; set; }
        public long? bordrono { get; set; }
        public long serino { get; set; }
        public DateTime vadetarihi { get; set; }
        public DateTime? kayittarihi { get; set; }
        public string bankakodu { get; set; }
        public int? hesapsirano { get; set; }
        public int? subeno { get; set; }
        public string subeadi { get; set; }
        public long? hesapno { get; set; }
        public string kefiladi { get; set; }
        public string aciklama { get; set; }
        public string referans { get; set; }
        public string borcluunvan { get; set; }
        public decimal? dvtutar { get; set; }
        public short? dvcinsi { get; set; }
        public decimal? dovizkuru { get; set; }
        public decimal tltutar { get; set; }
        public short? abcinsi { get; set; }
        public decimal? abtutar { get; set; }
        public int? IDfisnotu { get; set; }
        public bool? kendiceki { get; set; }
        public int? vergidairekod { get; set; }
        public string vergidairesi { get; set; }
        public string vergino { get; set; }
        public string tckimliknr { get; set; }
        public int? grpadres { get; set; }
        public int? grpcari { get; set; }
        public int? grpdepartman { get; set; }
        public int? grpgelirler { get; set; }
        public int? grpgenel { get; set; }
        public int? grpistatistik { get; set; }
        public int? grpkatalog { get; set; }
        public int? grpliste { get; set; }
        public int? grpnakliye { get; set; }
        public int? grppersonel { get; set; }
        public int? grpplasiyer { get; set; }
        public int? grpprojehizmet { get; set; }
        public Guid? UQ_caribanka { get; set; }
        public bool? cekisaret { get; set; }
        public int? durumu { get; set; }
        public int? r_dvcins { get; set; }
        public double? r_dvkuru { get; set; }
        public decimal? r_deger1 { get; set; }
        public decimal? r_deger2 { get; set; }
        public decimal? r_deger3 { get; set; }
        public decimal? r_deger4 { get; set; }
        public decimal? r_deger5 { get; set; }
        public bool? kontrol0 { get; set; }
        public bool? kontrol1 { get; set; }
        public bool? kontrol2 { get; set; }
        public bool? kontrol3 { get; set; }
        public bool? kontrol4 { get; set; }
        public long? IDexpimp1 { get; set; }
        public long? IDexpimp2 { get; set; }
        public long? IDexpimp3 { get; set; }
        public long? IDexpimp4 { get; set; }
        public long? IDexpimp5 { get; set; }
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
        public int? grpdepoyeri { get; set; }
        public int? grpsatisyeri { get; set; }
    }
}
