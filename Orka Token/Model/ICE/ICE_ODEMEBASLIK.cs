using System;

namespace OrkaToken.Model.ICE
{
    public class ICE_ODEMEBASLIK
    {

         public int ID { get; set; }
        public int? pin { get; set; }
        public int konum { get; set; }
        public int? isaret { get; set; }
        public int? imgidx { get; set; }
        public Guid? toplu_islem_UQ { get; set; }
        public short IOdurum { get; set; }
        public short odemetipi { get; set; }
        public int? IDfisbaslik { get; set; }
        public int IDplankod { get; set; }
        public string plankod { get; set; }
        public int IDkarsiplankod { get; set; }
        public string karsiplankod { get; set; }
        public long? bordrono { get; set; }
        public string belgeserino { get; set; }
        public long? odemeserino { get; set; }
        public long belgeno { get; set; }
        public DateTime belgetarihi { get; set; }
        public DateTime? vadetarihi { get; set; }
        public DateTime kayittarihi { get; set; }
        public short? belgeisaret { get; set; }
        public string belgereferans { get; set; }
        public string belgeaciklamasi { get; set; }
        public int? IDbelgenitelik { get; set; }
        public int? IDcarikod { get; set; }
        public int? IDekadres { get; set; }
        public int? IDajanda { get; set; }
        public int? IDnotdefteri { get; set; }
        public decimal belgetutar { get; set; }
        public decimal? doviztutar { get; set; }
        public short? dovizcinsi { get; set; }
        public decimal? dovizkuru { get; set; }
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

        public Guid? baglidamga { get; set; }
        public int? IDtranskayit { get; set; }
        public int? priority { get; set; }
        public int? firmnmbr { get; set; }
        public int? firmyear { get; set; }
        public string firstuser { get; set; }
        public DateTime? firstdate { get; set; }
        public string edituser { get; set; }
        public DateTime? editdate { get; set; }
        public string adi_grpadres { get; set; }
        public string adi_grpcari { get; set; }
        public string adi_grpdepartman { get; set; }
        public string adi_grpgelirler { get; set; }
        public string adi_grpgenel { get; set; }
        public string adi_grpistatistik { get; set; }
        public string adi_grpkatalog { get; set; }
        public string adi_grpliste { get; set; }
        public string adi_grpnakliye { get; set; }
        public string adi_grppersonel { get; set; }
        public string adi_grpplasiyer { get; set; }
        public string adi_grpprojehizmet { get; set; }
        public string adi_grpdepoyeri { get; set; }
    }
}
