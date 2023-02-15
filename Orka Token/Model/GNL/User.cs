using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrkaToken.Model
{
    public class User
    {
		//public string KullaniciAdi { get; set; }
		//public string Sifre { get; set; }
		//public string Token { get; set; }
		//public string Connection { get; set; }
		//public string FirmaKodu { get; set; }
		//public string kayitdamga { get; set; }
		//public string EntegreApp { get; set; }
		//public string EntegreUserName { get; set; }

		public string Key { get; set; }
		public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Token { get; set; }
        public string FirmaKodu { get; set; }
        public string Connection { get; set; }
		public string EntegreApp { get; set; }
        public string EntegreUserName { get; set; }
		public Guid SessionGuid { get; set; }
		public object FirmaTanim { get; set; }
	}
}
