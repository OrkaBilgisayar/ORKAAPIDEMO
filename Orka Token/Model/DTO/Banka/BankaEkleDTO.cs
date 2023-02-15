using System.Collections.Generic;
using static OrkaToken.Class.Enums;

namespace OrkaToken.Model.DTO.Banka
{
    public class BankaEkleDTO
    {
        
        public TIC_PIN pin { get; set; }
        public string bankaKodu { get; set; }
        public int siraNo { get; set; }
        public TIC_DOVIZ_CINSLERI paraCinsi { get; set; }
        public TIC_BANKA_MEVDUAT_CINSLERI mevduatTipi { get; set; }
        public string subeKodu { get; set; }
        public string subeAdi { get; set; }
        public string hesapNo { get; set; }
        public string musteriNo { get; set; }
        public string IBAN { get; set; }
        public TIC_FATURADA_BANKA_GOSTER? efaturadaGoster { get; set; }
        public bankaBaglihesaplar baglantilar { get; set; }
        public List<bankaPosBaglantilari> posTanimlari { get; set; }
        public List<bankaKrediKartBaglantilari> krediKartTanimlari { get; set; }
        public List<bankaKrediBaglantilari> krediTanimlari { get; set; }
	}
    public class bankaBaglihesaplar
    {
        public bool tahsileCekVeriliyor { get; set; }
        public bool teminataCekVeriliyor { get; set; }
        public bool tahsileSenetVeriliyor { get; set; }
        public bool teminataSenetVeriliyor { get; set; }
    }
    public class bankaPosBaglantilari
    {
        public TIC_BANKA_POS_TURLERI? posTipi { get; set; }
        public TIC_BANKA_VADEGUN_TIPLERI? vadeGunTipi { get; set; }
        public int vadeGunu { get; set; }
    }
    public class bankaKrediKartBaglantilari
    {
        public TIC_BANKA_KREDIKART_TURLERI? krediKartTipi { get; set; }
        public int krediKartisiraNo { get; set; }
        public TIC_BANKA_VADEGUN_TIPLERI? vadeGunTipi { get; set; }
        public int vadeGunu { get; set; }
    }
    public class bankaKrediBaglantilari
    {
        public string kredihesapNo { get; set; }
        public string hesapAciklamasi { get; set; }
        public int krediSiraNo { get; set; }
    }

}
