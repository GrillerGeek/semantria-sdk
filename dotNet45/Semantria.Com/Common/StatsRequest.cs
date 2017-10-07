using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semantria.Com.Common
{
    public class StatsRequest
    {
        public StatsMethod Method { get; set; }
        public string ConfigId { get; set; }
        public StatsInterval Interval { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string GroupBy { get; set; }
    }
}
