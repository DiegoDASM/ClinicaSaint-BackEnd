using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cititrans.TMS.ServiceModel.HelpDTOs
{
    public class PaginationResponse<T>
    (
        List<T> data,
        int totalRecords,
        int? page = 1,
        int? pageSize = 10
    )
    {
        public List<T> Data { get; set; } = data;
        public int Total { get; set; } = data.Count;
        public int Page { get; set; } = page ?? 1;
        public int PageSize { get; set; } = pageSize ?? 10;
        public int TotalPages { get; set; } = (int)Math.Ceiling((double)totalRecords / pageSize ?? 10);
        public int TotalRecords { get; set; } = totalRecords;
    }

    public class PaginatedData<T>
    {
        public List<T> Data { get; set; } = [];
        public int Total { get; set; }
    }

}


//{
//    public class PagedData<T>
//    {
//        public List<T> Data { get; set; } = [];
//        public int Total { get; set; }
//        public int TotalPages { get; set; }

//    }
//}
