using Newtonsoft.Json;
using System.Globalization;
using Newtonsoft.Json.Converters;

namespace OrkaToken.Class
{
    public static class  Tools
    {
        // Json okunabilir olsun diye kullanıyoruz 
        public static string ToJson<T>(this T t) where T : class => JsonConvert.SerializeObject(t, Newtonsoft.Json.Formatting.Indented, oConverter.Settings_C);
    }

	// Json ayarları 
	public class oConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            DefaultValueHandling = DefaultValueHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            DateFormatHandling = DateFormatHandling.IsoDateFormat,

            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal },


            },
        };

        public static readonly JsonSerializerSettings Settings_C = new JsonSerializerSettings
        {

            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            NullValueHandling = NullValueHandling.Ignore,
            DateFormatString = "yyyy-MM-dd hh:mm:ss",
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            Converters = {
                new IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" }

            },
        };

    }
}
