using System;
using System.Collections.Generic;
using OrkaToken.Model.DTO.Hesap;

namespace OrkaToken.Model.DTO.Cari
{
    public class CariEkstreDTO : HesapKartListDTO
    {
        public List<Ekstre> Ekstre;
    }

    public class Ekstre
    {
        public int GrupNo { get; set; }
        public int? sirano { get; set; }
        public int? kayittipi { get; set; }
        public string veritabanikodu { get; set; }
        public int? firmayil { get; set; }
        public int? firmano { get; set; }
        public int? pin { get; set; }
        public int? konum { get; set; }
        public int? IDFisbaslik { get; set; }
        public int? IDFissatir { get; set; }
        public int? fisolusmatipi { get; set; }
        public int? fisniteligi { get; set; }
        public DateTime? fistarihi { get; set; }
        public int? fistipi { get; set; }
        public int? fisno { get; set; }
        public int? fisyevmiyeno { get; set; }
        public string fisaciklama { get; set; }
        public string hesapkodu { get; set; }
        public string hesapadi { get; set; }
        public DateTime? donem { get; set; }
        public int? fisbelgetipi { get; set; }
        public string fisbelgetarihi { get; set; }
        public DateTime? fisbelgevadesi { get; set; }
        public string belgeserino { get; set; }
        public string fisbelgeno { get; set; }
        public string fisbelgereferans { get; set; }
        public string fisaciklamasi { get; set; }
        public string karsihesapkodu { get; set; }
        public decimal? tlborctutar { get; set; }
        public decimal? tlalactutar { get; set; }
        public decimal? tlbakiye { get; set; }
        public decimal? hesapabborctutar { get; set; }
        public decimal? hesapabalactutar { get; set; }
        public decimal? hesapabbakiye { get; set; }
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
        public int? ilkdeger { get; set; }
        public int? sondeger { get; set; }
        public int? aradeger { get; set; }
        public int? puan { get; set; }
        public int? puanbakiye { get; set; }
        public int? tevkifattipi { get; set; }
        public int? kdvoran { get; set; }
        public decimal? KDVtutari { get; set; }
        public int? yuklenadet { get; set; }
        public int? yuklenKDVtutari { get; set; }
        public int? ithalmaliyet { get; set; }
        public int? GEC_belge_kdvtutari { get; set; }
        public string bilstokkod { get; set; }
        public string bilstokadi { get; set; }
        public decimal? abmiktar { get; set; }
        public decimal? tlfiyat { get; set; }
        public decimal? abborctutar { get; set; }
        public decimal? abalactutar { get; set; }
        public decimal? abbakiye { get; set; }
        public int? dovizcinsi { get; set; }
        public decimal? dovizkuru { get; set; }
        public decimal? dvmiktar { get; set; }
        public decimal? dvfiyat { get; set; }
        public decimal? dvborctutar { get; set; }
        public decimal? dvalactutar { get; set; }
        public decimal? dvbakiye { get; set; }
    }
}
