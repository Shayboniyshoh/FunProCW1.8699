using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPro.CW1._8699.DAL
{
    public class Ticket
    {
        public int Ti_id { get; set; }
        public string Ti_summary { get; set; }
        public string Ti_description { get; set; }
        public int Ti_estimation { get; set; }
        public string Ti_priority { get; set; }
        public string Ti_status { get; set; }
        public int Ti_sprint { get; set; }
    }
}
