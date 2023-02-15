namespace OrkaToken.Model.DTO.Gruplar
{
    public class Grup
    {
        public int? grpadres { get; set; }
        public int? grpcari { get; set; }
        public int? grpdepartman { get; set; }
        public int? grpdepoyeri { get; set; }
        public int? grpgelirler { get; set; }
        public int? grpgenel { get; set; }
        public int? grpistatistik { get; set; }
        public int? grpkatalog { get; set; }
        public int? grpliste { get; set; }
        public int? grpnakliye { get; set; }
        public int? grppersonel { get; set; }
        public int? grpplasiyer { get; set; }
        public int? grpprojehizmet { get; set; }

    }

    public class GRUPLARFATURABaseModel
    {
        public int? IDhazirlayanpersonel { get; set; }
        public int? IDyukleyenpersonel { get; set; }
        public int? IDsiparisalanpersonel { get; set; }

    }

    public class GRUPLARSTOKBaseModel
    {
        public int? grpdepoyeri { get; set; }
        public int? grpstok { get; set; }
        public int? grpsatisyeri { get; set; }
        public int? grpkatalog { get; set; }
        public int? grpliste { get; set; }

    }
}
