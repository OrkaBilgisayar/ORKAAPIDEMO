using System;
using System.Collections.Generic;
using OrkaToken.Model.DTO.Gruplar;
using OrkaToken.Model.DTO.Indirimler;
using static OrkaToken.Class.Enums;

namespace OrkaToken.Model.DTO.Belge
{

    //Tüm ticari belge (sipariş-fatura vb.) bu modeli kullanabilirsiniz . 

    #region Belge Başlıkları

    public class BelgeBase
    {

        public TIC_IODURUM alisSatis { get; set; }


        public TIC_EBELGE_TURU? ebelgeTuru { get; set; }


        public TIC_EBELGE_SENARYOLAR? ebelgeSenaryo { get; set; }


        public TIC_BELGE_TIPLERI? belgeTipi { get; set; }


        public string cariKodu { get; set; }

        public string cariEkAdres { get; set; }


        public string belgeSeriNo { get; set; }


        public long? belgeNo { get; set; }


        public DateTime belgeTarihi { get; set; }


        public string belgeAciklamasi { get; set; }


        public Guid belgeUQ { get; set; }

        public string belgeReferans { get; set; }




    }

    public class BelgeEkle : BelgeBase { }

    public class BelgeEkleBasit : BelgeEkle
    {
        public IList<BelgeSatirlariBase> Satirlar { get; set; }
        public IList<BelgeNotlari> Notlar { get; set; }
    }

    public class BelgeEkleDetayli : BelgeEkle
    {


        public int? konum { get; set; }

        public DateTime? vadeTarihi { get; set; }

        public DateTime? teslimatTarihi { get; set; }

        public DateTime? kayitTarihi { get; set; }

        //

        public TIC_KDVBELGE_TURU? kdvBelgeTipi { get; set; }
        //

        public TIC_PIN? pin { get; set; }
        //

        public TIC_DOVIZ_CINSLERI? paraCinsi { get; set; }
        //

        public decimal? dovizKuru { get; set; }
        //
        public string kayitYapanAdiSoyadi { get; set; }
        //
        public Grup Gruplar { get; set; }
        //
        public GRUPLARFATURABaseModel personelGruplari { get; set; }
        //

        public List<BelgeSatirlariDetayli> Satirlar { get; set; }
        //
        public List<BelgeNotlari> Notlar { get; set; }



    }

    #endregion

    #region Belge Satirlari

    // Belge Satirlari için gönderilmesi gereken Model
    public class BelgeSatirlariBase
    {

        public string stokKodu { get; set; }


        public string stokAdi { get; set; }


        public double miktar { get; set; }


        public double? oivMiktar { get; set; }



        public int? satirTevkifatAlanKod { get; set; }


        public int? satirTevkifatTuru { get; set; }


        public decimal? otvOran { get; set; }

        public decimal? otvMiktar { get; set; }


        public TIC_STOK_BIRIMLERI stokBirim { get; set; }


        public decimal fiyat { get; set; }


        public TIC_FIYAT_TIPI? fiyatTipi { get; set; }


        public TIC_KDV_ORANLAR kdvOrani { get; set; }

        public TIC_MUHTASAR_KOD? MuhtasarKod { get; set; }



    }

    public class BelgeSatirlariDetayli : BelgeSatirlariBase
    {

        public string ekstraAciklama { get; set; }


        public decimal? dovizFiyat { get; set; }


        public Grup Gruplar { get; set; }

        public Indirim Indirim { get; set; }

        //


    }

    #endregion

    #region Belge Notları

    // Not Eklemek için kullanılan Model
    public class BelgeNotlari
    {
        public string baslik { get; set; }
        public string aciklama { get; set; }

    }

    #endregion

}
