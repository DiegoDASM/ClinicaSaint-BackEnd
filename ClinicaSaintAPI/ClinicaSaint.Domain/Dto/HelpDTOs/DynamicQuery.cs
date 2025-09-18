using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cititrans.TMS.ServiceModel.HelpDTOs
{
    public class DynamicQuery
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? OrderBy { get; set; }
        public string? Filter { get; set; }
        public string? Search { get; set; }
    }
}
