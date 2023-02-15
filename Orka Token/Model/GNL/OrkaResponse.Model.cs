using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrkaToken.Model
{
    public class OrkaResponseModel<T>
    {
        public int? RecordSize { get; set; }
        public T Data { get; set; }
        public int? PageItemCount { get; set; }
        public int? PageSize { get; set; }
        public int? PageNumber { get; set; }
        public int? ItemsCount { get; set; }
        public int? PageCount { get; set; }
        public string ErrorMessage { get; set; }
        public string Message { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorCodeDescription { get; set; }
	}
}
