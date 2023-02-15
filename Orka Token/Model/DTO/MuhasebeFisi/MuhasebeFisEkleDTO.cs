using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrkaToken.Model.DTO.Gruplar;
using static OrkaToken.Class.Enums;

namespace OrkaToken.Model.DTO.MuhasebeFisi
{
    #region Fis Ekle

    public class MuhasebeFisEkleDTO : MuhasebeFisBase { }

    public class MuhasebeFisBasitEkleDTO : MuhasebeFisEkleDTO
    {
        public List<MuhasebeFisSatirBase> satirlar { get; set; }
    }

    public class MuhasebeFisDetayliEkleDTO : MuhasebeFisEkleDTO
    {
        public Grup Gruplar { get; set; }
        public List<MuhasebeFisSatirDetay> satirlar { get; set; }
        public TIC_DOVIZ_CINSLERI? fisParaCinsi { get; set; }
        public decimal? fisDovizKur { get; set; }
        public TIC_FISOLUSMATIPLERI? fisOlusmaTipi { get; set; }
        public DateTime? fisVadeTarihi { get; set; }
        public int? tevkifatTipi { get; set; }
        public int? tevkifatTuruKodu { get; set; }
    }

    #endregion
    
    #region Fiş Başlık

    public class MuhasebeFisBase
    {

        public TIC_PIN? pin { get; set; }
        public TIC_FIS_TIPLERI? fisTipi { get; set; }
        public TIC_BELGE_TIPLERI? belgeTipi { get; set; }
        public TIC_KDVBELGE_TURU? kdvBelgeTipi { get; set; }
        public string karsiHesapKodu { get; set; }
        public DateTime fisTarihi { get; set; }
        public string fisaciklama { get; set; }
        public Guid fisGuid { get; set; }
        public DateTime? belgeTarihi { get; set; }
        public string seriNo { get; set; }
        public long? belgeNo { get; set; }

    }

    #endregion
    
    #region Fiş Satır

    public class MuhasebeFisSatirBase
    {
        public DateTime? belgeTarihi { get; set; }
        public string hesapKodu { get; set; }
        public string hesapAdi { get; set; }
        public string seriNo { get; set; }
        public TIC_BELGE_TIPLERI? belgeTipi { get; set; }
        public long? belgeNo { get; set; }
        public TIC_KDV_ORANLAR? kdvOrani { get; set; }
        public string belgeaciklama { get; set; }
        public TIC_MUH_BORCALACAK? borcAlacak { get; set; }
        public decimal tutar { get; set; }
    }

    public class MuhasebeFisSatirDetay : MuhasebeFisBase
    {
        public Grup Gruplar { get; set; }
        public DateTime? vadeTarihi { get; set; }
        public string belgeaciklamareferans { get; set; }
        public int? tevkifatTipi { get; set; }
        public int? tevkifatTuruKodu { get; set; }
        public decimal? dovizKuru { get; set; }
        public decimal? dovizTutar { get; set; }
        public TIC_DOVIZ_CINSLERI? paraCinsi { get; set; }

    }

    #endregion

}
