using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrkaToken.Class
{
    public class Enums
    {
		#region Genel Tanımlar

		public enum TIC_EBELGE_TURU : int
		{

			[Description("E-Fatura")]
			eFatura = 1,
			[Description("E-Arşiv Fatura")]
			eArsivFatura = 2,
			[Description("E-İrsaliye")]
			eIrsayeli = 4,
			[Description("E-Müstahsil")]
			eMustahsil = 5,
			[Description("E-SMMM")]
			eSMMM = 6,
		}
		public enum TIC_EBELGE_SENARYOLAR : int
		{
			[Description("Temel Fatura")]
			TemelFatura = 10,
			[Description("Ticari Fatura")]
			TicariFatura = 20,
			[Description("İhracat Fatura")]
			İhracatFatura = 30,
			[Description("Yolcu Beraber Fatura")]
			YolcuBeraberFatura = 40
		}
		public enum TIC_KDVBELGE_TURU : int
		{
			[Description("Fatura")]
			Fatura = 1,
			[Description("E-Fatura")]
			eFatura = 2,
			[Description("E-Arşiv Fatura")]
			eArsivFatura = 3,
			[Description("E-Bilet")]
			eBilet = 4,
			[Description("Perakende Satış Fişi")]
			PerakendeSatisFisi = 5,
			[Description("SMMM Makbuzu")]
			SerbestMeslekMakbuzu = 6,
			[Description("İrsaliyeli Fatura")]
			IrsaliyeliFatura = 7,
			//Dipkoçanlı Yolcu Taşıma Bileti = 9,
			//Kıymetli Maden Satım Belgesi = 10,
			//Döviz ve Kıymetli Maden Satım Belgesi = 11,
			[Description("Noter Makbuzu")]
			NoterMakbuzu = 12,

			//Döner Sermaye Alındı Belgesi = 13,
			//Z-Raporu / ÖKC Fişi = 14,
			//Gider Pusulası = 15,
			//Gün Sonu Hasılatı = 16,
			[Description("E-SMMM Makbuzu")]
			ESerbestMeslekMakbuzu = 17,
			//Tevsiki Zaruri Olmayan Gelir/Gider = 18,
			//Serbest Meslek Makbuzu (POS)   =19,
			//Müstahsil Makbuzu = 20,
			[Description("E-Müstahsil Makbuzu")]
			eMustahsilMakbuzu = 21,

		}
		public enum TIC_BELGE_TIPLERI : int
		{
			[Description("Teklif")]
			_Teklif_ = 4,
			[Description("Sipariş")]
			_Siparis_ = 6,
			[Description("İrsaliye")]
			_Irsaliye_ = 7,
			[Description("Fatura")]
			_Fatura_ = 20,
			[Description("İade Fatura")]
			_IadeFatura_ = 21,
			[Description("İskonto")]
			_IskontoFatura_ = 22,
			[Description("Fiyat Farkı")]
			_FiyatFarkFatura_ = 23,
			[Description("Gider")]
			_GiderDepartman_ = 24,
			[Description("Proje hizmet")]
			_HizmetProje_ = 25,
			[Description("Stok Fişi")]
			_StokFisi_ = 26,
			[Description("Komisyon Fatura")]
			_KomisyonFatura_ = 27,
			[Description("Vade Farkı")]
			_VadeFarkFatura_ = 28,
			[Description("Kur Farkı")]
			_KurFarkiFatura_ = 29,
			[Description("Yurtdışı Fatura")]
			_YurtDisiFatura_ = 30,
			[Description("Fire")]
			_FireBelge_ = 31,
			[Description("Maliyet")]
			_MaliyetBelge_ = 32,
			[Description("Tevkifatlı")]
			_TevkifatliFatura_ = 33,
			[Description("Müstahsil Makbuzu")]
			_MustahsilMakbuzu_ = 34,
			[Description("S.M.M. Makbuzu")]
			_SerbestMeslekMakbuzu_ = 35,
			[Description("Hal Makbuzu")]
			_HalMakbuzu_ = 36,
			[Description("Dönemsel Fatura")]
			_DonemselFatura_ = 37,
			[Description("İhraç kayıtlı")]
			_IhracKayitliFatura_ = 38,
			[Description("İstisna")]
			_IstisnaliFatura_ = 39,
			[Description("Özel Matrah")]
			_OzelMatrahFatura_ = 40,
			[Description("Yurt Dışı Hizmet")]
			_YurtDisiHizmet_ = 41,
			[Description("Yurt Dışı Transit")]
			_YurtDisiTransit_ = 42,
			[Description("Tam Tevkifatlı ÖTV Fatura")]
			_TamTevkifatOTVFatura_ = 43,
			[Description("Yazar Kasa e-Arşiv")]
			_YazarKasa_EArsiv_ = 44,
			[Description("Çek")]
			_CekForm_ = 45,
			[Description("Senet")]
			_SenetForm_ = 46,
			[Description("Slip")]
			_VSlipForm_ = 47,
			[Description("Çek")]
			_CekBordro_ = 50,
			[Description("Senet")]
			_SenetBordro_ = 51,
			[Description("Kredi Kartı")]
			_KrediKartSlip_ = 53,
			[Description("Dekont")]
			_Dekont_ = 54,
			[Description("Makbuz")]
			_Makbuz_ = 55,
			[Description("Gider Pusulası")]
			_GiderPusula_ = 56,
			[Description("Gider Fiş")]
			_GiderFis_ = 57,
			[Description("Fiş Genel")]
			_FisGenel_ = 58,
			[Description("Havale")]
			_BankaHavale_ = 60,
			[Description("Fiş Para")]
			_FisParaForm_ = 61,
			[Description("Ödeme Emri")]
			_OdemeEmri_ = 62,
			_PortfoyIslemi_ = 85,
			[Description("Havale")]
			_HavaleIslemi_ = 86,
			[Description("Fiş Para")]
			_FisParaIslemi_ = 87,
			[Description("Yazar Kasa Fişi")]
			_YazarKasaFisi_ = 88,
			[Description("Z-Raporu")]
			_ZKasaRaporu_ = 89,
			[Description("Hammadde - Yari Mamül")]
			_Ure_Hammadde_YariMamul_ = 90,
			[Description("Yari Mamül - Tam Mamül")]
			_Ure_YariMamul_TamMamul_ = 91,
			[Description("Hammadde - Tam Mamül")]
			_Ure_Hammadde_TamMamul_ = 92,
			[Description("Birleştirme")]
			_Ure_Birlestirme_ = 93,
			[Description("Sökme")]
			_Ure_Sokme_ = 94,
			[Description("Ücret Bordrosu Belgesi")]
			_UcretBordrosuBelgesi_ = 95,
			[Description("Sigorta Poliçesi")]
			_SigortaPolicesi_ = 96,
			[Description("Yolcu Taşıma Bileti")]
			_YolcuTasimaBileti_ = 97,
			[Description("Kira Kayıtları")]
			_KiraKayitlari_ = 145,
			[Description("Teminat Mektubu")]
			_TeminatMektubu_ = 146,
			//
			[Description("Amortisman")]
			_Amortisman_ = 400,
			[Description("Gider Yerin")]
			_GiderYerin_ = 401,
			[Description("Özel Fonlar")]
			_OzelFonlar_ = 402,
			[Description("Demirbaş Kar")]
			_DemirbasKar_ = 403,
			[Description("Demirbaş Zarar")]
			_DemirbasZarar_ = 404,
			[Description("Demirbaş Kasko Gider")]
			_DemirbasKaskoGider_ = 405,
			[Description("Demirbaş Vergi Gider")]
			_DemirbasVergiGider_ = 406,
			[Description("Demirbaş Diğer Gider")]
			_DemirbasDigerGider_ = 407,
			[Description("Demirbaş Gider Tahakkuk")]
			_DemirbasGiderTahakuk_ = 408,
			[Description("Demirbaş Özel Ek Maliyetler")]
			_DemirbasOzelEkMaliyetler_ = 409,
			[Description("Demirbaş Zimmetler")]
			_DemirbasZimmetler_ = 410,
			[Description("Demirbaş Enflasyon Muhasebesi")]
			_DemirbasEnflasyonMuh_ = 411,
			[Description("Demirbaş Eksi Maliyet")]
			_DemirbasEksiMaliyet_ = 412,
			[Description("Demirbaş Satış Fatura")]
			_DemirbasSatisFatura_ = 413,
			[Description("Demirbaş Satış Maliyet")]
			_DemirbasSatisMaliyet_ = 414,
			//
			[Description("Blg_MuhasebeFişi")]
			_Blg_MuhasebeFisi_ = 415,
			[Description("Blg_PerakendeSatış")]
			_Blg_PerakendeSatis_ = 416,
			[Description("Demirbaş KKEG")]
			_DemirbasKKEG_ = 417
		}
		public enum TIC_ODEME_TIPLERI : int
		{
			[Description("Nakit")]
			Nakit = 0,
			[Description("Havale")]
			Havale = 6,
			[Description("Dekont")]
			Dekont = 5,
			[Description("Fiş Para")]
			FisPara = 7,
			[Description("Çek")]
			Cek = 1,
			[Description("Senet")]
			Senet = 3,
			[Description("Kredi Kartı")]
			KrediKart = 2,
			[Description("Vadeli Slip")]
			VadeliSlip = 4,
			[Description("Havale Emirleri")]
			HavaleEmirleri = 8,
			[Description("Banka Talimatı")]
			BankaTalimati = 9,
		}
		public enum TIC_IODURUM : int
		{
			[Description("Alış/Tediye")]
			Alis = 1,
			[Description("Satış/Tahsilat")]
			Satis = -1
		}
		public enum TIC_PIN : int
		{
			[Description("Ex")]
			Ex = -1,
			[Description("Ok")]
			Ok = 0
		}
		public enum TIC_HESAP_SEVIYELER : int
		{
			Kebir = 4,
			Grup = 5,
			Detay = 6
		}
		public enum TIC_HESAP_ACMA_TURU : int
		{
			MuhasebeHesabi = 1,
			CariKart = 2,
		}
		public enum TIC_CARI_KODTIPI
		{
			Bos = 0,
			hesapKodu = 1,
			tcKimlik_vergiKimlik = 2,
			ogrenciNo = 3,
			OrkaUQ = 4
		}
		public enum TIC_HESAP_KODTIPI
		{
			hesapKodu = 1,
			OrkaUQ = 4
		}
		public enum TIC_FIYAT_TIPI : int
		{
			[Description("Kdv Hariç Fiyat")]
			Kdv_Haric_Fiyat = 1,
			[Description("Kdv Dahil Fiyat")]
			Kdv_Dahil_Fiyat = -1,
			[Description("Kdv Hariç Tutar")]
			Kdv_Haric_Tutar = 5,
			[Description("Kdv Dahil Tutar")]
			Kdv_Dahil_Tutar = -5,
			[Description("Serbest Tutar")]
			Serbest = 0,
		}
		public enum TIC_MUHTASAR_KOD : int
		{
			[Description("Ticaret Borsalarında Tescil Ettirilerek Satın Alınan Hayvanlar ve Bunların Mahsulleri ile Kara ve Su Avcılığı Mahsulleri İçin Yapılan Ödemeler (GVK Md. 94/11-a-i)")]
			Tescil_Avcılık = 91,
			[Description("Ticaret Borsalarında Tescil Ettirilmeksizin Satın Alınan Hayvanlar ve Bunların Mahsulleri ile Kara ve Su Avcılığı Mahsulleri İçin Yapılan Ödemeler (GVK Md. 94/11-a-ii)")]
			Tescilsiz_Avcılık = 92,
			[Description("Ticaret Borsalarında Tescil Ettirilerek SatınAlınan Diğer Zirai Mahsuller İçin Yapılan Ödemeler (GVK Md. 94/11-b-i) (**)")]
			Tescil_Zirai = 93,
			[Description("Ticaret Borsalarında Tescil Ettirilmeksizin Satın Alınan Diğer Zirai Mahsuller İçin Yapılan Ödemeler (GVK Md. 94/11-b-ii)  (***)")]
			Tescilsiz_Zirai = 94,
		}
		public enum TIC_OIV_KOD : int
		{
			[Description("Mobil telefon aboneliğinin ilk tesisinde alınan")]
			Mobil_Tesis = 5,
		}
		public enum TIC_FATURADA_BANKA_GOSTER : int
		{
			YOK = 0,
			Her_Faturada_Goster = 1,
			Fatura_Doviz_Cinsine_Gore_Goster = 2,
		}
		public enum TIC_BELGE_NITELIK : int
		{
			ALIS__Fatura_ = 153001,
			ALIS_IadeFatura_ = 153010,
			ALIS_IskontoFatura_ = 153011,
			ALIS_FiyatFarkFatura_ = 153003,
			ALIS_GiderDepartman_ = 153002,
			ALIS_HizmetProje_ = 153002,
			ALIS_StokFisi_ = 153090,
			ALIS_KomisyonFatura_ = 153001,
			ALIS_VadeFarkFatura_ = 153100,
			ALIS_KurFarkiFatura_ = 153100,
			ALIS_FireBelge_ = 153001,
			ALIS_MaliyetBelge_ = 153001,
			ALIS_Diger = 153001,
			SATIS_Fatura_ = 600001,
			SATIS_IadeFatura_ = 610001,
			SATIS_IskontoFatura_ = 611001,
			SATIS_FiyatFarkFatura_ = 600003,
			SATIS_GiderDepartman_ = 600002,
			SATIS_HizmetProje_ = 600002,
			SATIS_StokFisi_ = 600090,
			SATIS_KomisyonFatura_ = 600002,
			SATIS_VadeFarkFatura_ = 600100,
			SATIS_KurFarkiFatura_ = 600100,
			SATIS_FireBelge_ = 600001,
			SATIS_MaliyetBelge_ = 621001,
			SATIS_Diger = 600001
		}
		public enum TIC_KDV_ORANLAR : int
		{

			[DefaultValue(1)]
			Oran18 = 18,
			[DefaultValue(2)]
			Oran08 = 8,
			[DefaultValue(3)]
			Oran01 = 1,
			[DefaultValue(4)]
			Oran00 = 0,
		}
		public enum TIC_MUH_BORCALACAK : int
		{
			Borc = -1,
			Alacak = 1,
		}
		public enum TIC_DOVIZ_CINSLERI : int
		{

			TL = 0,
			USD = 1,
			EUR = 2,
			JPY = 3,
			CHF = 4,
			GBP = 5,
			RUB = 6,
			CNY = 7,
			SAR = 8,
			CAD = 9,
			SEK = 10,
			BGN = 11,
			AUD = 12,
			DKK = 13,
			KWD = 14,
			NOK = 15,
			RON = 16,
			IRR = 17,
			PKR = 18,
			AZN = 19,
			AED = 20,
			SGD = 21,
			CFA = 22,
		}
		public enum TIC_RISK_TIPLERI : int
		{
			Risk_RiskYok = 0,
			Risk_CariBorc = 1,
			Risk_CariBorc_Stok = 2,
			Risk_CariBorc_Portfoy = 3,
			Risk_CariBorc_Stok_Portfoy = 4,
		}
		/// <summary>
		/// Dosya eklemek için ORT_DOSYALAR ve ORKARESIMLER.DOSYALAR tablosundaki TABLO NO alanı için eklenmiştir.
		/// </summary>
		public enum TIC_MODUL_TABLONO : int
		{
			StokKart = 1,
			HesapPlan = 2,
			CariKart = 3,
			StokBelge = 4,
			Fisler = 5,
			Odemeler = 6,
			Gruplar = 7,
			Firma = 8,
			Demirbas = 9,
			OzlukDosyasi = 10,
			Grp_Genel = 11,
			Grp_Adres = 12,
			Grp_Cari = 13,
			Grp_Plasiyer = 14,
			Grp_Personel = 15,
			Grp_Nakliyeci = 16,
			Grp_Gelirler = 17,
			Grp_Departman = 18,
			Grp_ProjeHizmet = 19,
			Grp_Istatistik = 20,
			Grp_StokGrup = 21,
			Grp_DepoYeri = 22,
			Grp_SatisYeri = 23,
			Grp_KatalogYeri = 24,
			Grp_ListeYeri = 25,
			Grp_FirmaSektor = 26,
			Personel = 27,
			Uretim = 28,
			CSVGiris = 29,
			ZimmetKart = 30

		}
		public enum TIC_FIRMA_EBELGE_TURU : int
		{
			yok = 0,
			efatura = 1,
			efatura_earsiv = 2,
			efatura_earsiv_eirsaliye = 4

		}
		public enum TIC_EDONUSUM_KOD : int
		{
			DTP = 20,
			EDM = 50,
			SUP = 60,
		}

		public enum TIC_BELGE_ISLEM_TIP : int
		{
			Yeni = 0,
			Kopya = 1,
			Donusum = 2

		}
		#endregion

		#region Fis Tanımları

		public enum TIC_FIS_TIPLERI : int
		{
			[Description("Fiş Özel")]
			_FisTipOzel_ = -01,
			[Description("Açılış")]
			_FisTipAcilis_ = 01,
			[Description("Tahsilat")]
			_FisTipTahsilat_ = 02,
			[Description("Tediye")]
			_FisTipTediye_ = 03,
			[Description("Mahsup")]
			_FisTipMahsup_ = 04,
			[Description("Virman")]
			_FisTipVirman_ = 05,
			[Description("Kapanış")]
			_FisTipKapanis_ = 06
		}
		public enum TIC_FISOLUSMATIPLERI : int
		{
			[Description("Fiş Kayıt")]
			_FisKayittan_ = 00,
			[Description("Portföy")]
			_PortfoyKayittan_ = 01,
			[Description("Entegre")]
			_EntegreKayitlardan_ = 02,
			[Description("Stok Sistemi")]
			_StokSisteminden_ = 03,
			[Description("Ödemeler")]
			_OdemeSisteminden_ = 04,
			[Description("Oto Fiş")]
			_FisRobotundan_ = 05,
			[Description("Yansıtmalar")]
			_Yansitmalardan_ = 06,
			[Description("Demirbaş")]
			_DemirbasSisteminden_ = 07,
			[Description("Transfer")]
			_TransferSisteminden_ = 08,
			[Description("Büro Modülü")]
			_BuroYonetiminden_ = 09,
			[Description("DOS")]
			_DOS_Orka_Kayitlardan_ = 10,
			[Description("Üretim")]
			_UretimSisteminden_ = 11,
			[Description("Ücret Bordro")]
			_BordroSisteminden_ = 12,
			[Description("Stok Sayımı")]
			_StokSayimIsleminden_ = 13,
			[Description("Excel Fiş")]
			_ExcelFisGirisinden_ = 14,
			[Description("Bilanço Stok Sistemi")]
			_BilStokSisteminden_ = 15,
			[Description("İstasyon")]
			_IstasyonVardiyadan_ = 16,
			[Description("Portföy Giriş")]
			_DevirPortfoyGiris_ = 17,
			[Description("Portföy Hareket")]
			_DevirPortfoyHareket_ = 18,

		}

		#endregion

		#region Rapor Tanımları

		public enum TIC_ACIKHESAP_RAPORKAYNAGI : int
		{
			Otomatik = 01,
			Tablodan = 02,
			BelgeKapatmaSisteminden = 03
		}
		public enum TIC_MIZAN_SEVIYELER : int
		{
			TumSeviyeler = 00,
			Kebir = 01,
			KebirGrup = 02,
			KebirDetay = 03,
			Detay = 04,
			BilancoKebir = 05
		}

		#endregion

		#region Eğitim Modülü Tanımları

		public enum TIC_EGITIM_CINSIYET
		{
			[Description("Kız")]
			Kiz = 0,
			[Description("Erkek")]
			Erkek = 1
		}
		public enum TIC_EGITIM_VELI : int
		{
			Anne = 0,
			Baba = 1,
			DigerYakin = 3
		}
		public enum TIC_EGITIM_FATURAKIME : int
		{
			[Description("Öğrenci")]
			Ogrenci = 1,
			[Description("Veli")]
			Veli = 2,
			[Description("Cari")]
			Cari = 3
		}
		public enum TIC_OKULA_GELIS : int
		{
			[Description("Servis")]
			Servis = 0,
			[Description("Kendisi")]
			Kendi = 1,
			[Description("Yakınıyla")]
			Yakin = 2
		}

		#endregion

		#region Banka Tanımları

		public enum TIC_BANKA_BAGLIHESAP_ISLEM_TURLERI : int
		{
			PosHesaplari = 1080,
			KrediHesaplari = 3000,
			KartHesaplari = 3001
		}
		public enum TIC_BANKA_VADEGUN_TIPLERI : int
		{
			GunArttir = 0, // (.. Gün Arttırır)
			IsGunuArttir = 1, // (.. İş Günü Arttırır)
			HerAySeciliGunu = 2, // (Her ayın .. Günü)
		}
		public enum TIC_BANKA_POS_TURLERI : int
		{

			ADVANTAGE = 1,
			AXESS = 2,
			BONUS = 3,
			CARDFINANS = 4,
			FAMILY = 5,
			MAXIMUM = 6,
			PARAF = 7,
			WORLDCARD = 8
		}
		public enum TIC_BANKA_KREDIKART_TURLERI : int
		{

			AEXP = 1, // Amerikan Express
			DINR = 2, // DinnerClub
			Electron = 3, // Elektron(VISA)
			MAST = 4, // Master
			VISA = 5 // Visa
		}
		public enum TIC_BANKA_MEVDUAT_CINSLERI : int
		{
			Vadesiz = 1,
			Vadeli = 2
		}

		#endregion

		#region Stok Tanımları

		public enum TIC_STOK_BIRIMLERI : short
		{
			Adet = 1,
			Paket = 2,
			Kasa = 3,
			Karton_koli = 4,
			Kilo = 5,
			Gram = 6,
			Miligram = 7,
			Litre = 8,
			Santilitre = 9,
			Mililitre = 10,
			Metrekup = 11,
			Desimetrekup = 12,
			Santimetrekup = 13,
			Milimetrekup = 14,
			Metrekare = 15,
			Desimetrekare = 16,
			Santimetrekare = 17,
			Milimetrekare = 18,
			Metre = 19,
			Desimetre = 20,
			Santimetre = 21,
			Milimetre = 22,
			Cuval = 23,
			Poset = 24,
			Plastik_Kap = 25,
			File = 26,
			Kucuk_aliminyum_kutu = 27,
			Kavanoz = 28,
			BagDemet = 29,
			Sise = 30,
			Teneke = 31,
			Plastik_Bidon = 32,
			Varil = 33,
			Palet = 34,
			Konteyner = 35,
			Ton = 36,
			Cift = 37,
			Deste = 38,
			Duzine = 39,
			Kalori = 40,
			Kilowatt = 41,
			Watt = 42,
			Kilokalori = 43,
			Karat = 45,
			Ay = 46,
			Gun = 47,
			Saat = 48,
			Hafta = 49,
			Metre_Tul = 50,
			Plaka = 51,
			Takim = 52,
			Metre_Kup = 53

		}
		public enum TIC_STOK_CINSLERI : short
		{
			[Description("Mal")]
			Mal = 0,
			[Description("Proje ve Hizmet")]
			ProjeHizmet = 1,
			[Description("Gider")]
			Gider = 2,
			[Description("Ham madde")]
			Hammadde = 3,
			[Description("Yarı mamül")]
			YariMamul = 4,
			[Description("Mamül")]
			Mamul = 5,
			[Description("Fire")]
			Fire = 6,
			[Description("Ambalaj")]
			Ambalaj = 7,
			[Description("Depozito")]
			Depozito = 8,
			[Description("Demirbaş")]
			Demirbas = 9,
			[Description("Yazı")]
			Yazi = 10,
			[Description("Promosyon")]
			Promosyon = 11,
			[Description("Kesinti (-)")]
			Kesinti = 20,
			[Description("Eklenti (+)")]
			Eklenti = 21
		}
		public enum TIC_STOK_TUTARHESAPLAMA_MODELI : int
		{
			[Description("AdetxFiyat")]
			AdetxFiyat = 1,

			[Description("Ön Birim x İçerik x Fiyat")]
			OnBirimxIcerikxFiyat = 2,

			[Description("(B1 x B2) x Fiyat")]
			B1xB2xFiyat = 4,

			[Description("(B1 x B2 x B3) x Fiyat")]
			B1xB2xB3xFiyat = 5,

			[Description("(Brüt - Dara) x Fiyat")]
			Brut_DaraxFiyat = 6,

			[Description("Saat")]
			Saat = 7,

			[Description("(B1 x B2 x İçerik) x Fiyat ")]
			B1xB2xIcerikxFiyat = 8,

			[Description("(B1 x B2 x B3 x İçerik) x Fiyat ")]
			B1xB2xB3xIcerikxFiyat = 9

		}

		#endregion

		#region Bordro tanımları

		public enum TIC_PUB_ODEMETIP : int
		{
			Verilen = -1,
			Gelen = 1
		}

		public enum TIC_PUB_KESINTITIP : int
		{
			Avans = 30,
			Borc = 31,
			//Personel_Kasakesinti_ = 32,
			//Personel_Nafaka_ = 33,
			//Personel_Sendika_ = 34,
			//Personel_Icra_ = 35,
			//Personel_Yemekbilet_ = 36,
			//Personel_Biremekisveod_ = 37,
			//Personel_Ayniyardimlar_ = 38,
			//Personel_Bankaodemesi_ = 40,
			//Personel_Ozelodemesi_ = 41,
			//Personel_Nakitodemeler_ = 50,
		}

        public enum TIC_PUB_CALISMATIP : int
        {
            [Description("Boş")]
            Bos = 0,
			[Description("Çalışılan")]
            Calisilan = 100,
			[Description("Hafta Tatili")]
            HaftaTatili = 200,
            [Description("Arefe Günü")]
            Arefe = 205,
            [Description("Resmi Tatil")]
            ResmiTatil = 210,
            [Description("Bayram Tatil")]
            Bayram = 220,
            [Description("İdari Tatil")]
            Idari = 230,
			[Description("Yıllık İzin")]
            Yillik = 300,
            [Description("Mazeret İzin")]
            Mazeret = 310,
            [Description("Ücretli İstirahat")]
            UcretliIstirahat = 320,
            [Description("Ücretli Denkleştirme")]
            UcretliDenklestir = 330,
			[Description("Ücretsiz İzin")]
            UcretsizIzin = 600,
            [Description("Gelmediği Gün")]
            Gelmedigi = 610,
            [Description("Ücretsiz İstirahat")]
            Istirahat = 620,
            [Description("Çalışmadığı Gün")]
            Calismadigi = 630,
            [Description("Ücretsiz Denkleştirme")]
            UcretsizDenklestir = 640
		}

		#endregion



	}
}
