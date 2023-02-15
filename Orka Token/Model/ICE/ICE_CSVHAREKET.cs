using System;

namespace OrkaToken.Model.ICE
{
    public class ICE_CSVHAREKET
    {

        public int ID { get; set; }
        public int? pin { get; set; }
        public int konum { get; set; }
        public int? isaret { get; set; }
        public int? imgidx { get; set; }
        public Guid? baslik_UQ { get; set; }
        public int? IDfisbaslik { get; set; }
        public int portfoytipi { get; set; }
        public int IOPortfoy { get; set; }
        public int IDCSVgiris { get; set; }
        public int CSVHareketTipi { get; set; }
        public int IDplankodhrkt { get; set; }
        public string plankodhrkt { get; set; }
        public string karsi_plan_kod { get; set; }
        public long? bordrono { get; set; }
        public int? nitelik { get; set; }
        public DateTime kayittarihi { get; set; }
        public DateTime harekettarihi { get; set; }
        public int? yenihareketipi { get; set; }
        public double? devir_doviz_kuru { get; set; }
        public decimal? devir_tl_tutari { get; set; }
        public double? doviz_kuru { get; set; }
        public decimal? tl_tutari { get; set; }
        public decimal? kur_farki { get; set; }
        public string kur_farki_hesap { get; set; }
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
    }
}
