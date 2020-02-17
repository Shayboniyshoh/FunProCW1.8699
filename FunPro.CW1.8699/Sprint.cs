using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPro.CW1._8699
{
    class Sprint
    {
        public int Sp_id { get; set; }
        public string Sp_name { get; set; }
        public DateTime Sp_date { get; set; }
        public string Sp_no_of_developers { get; set; }
        public string Sp_status { get; set; }
        public Ticket Ticket { get; set; }
    }
    /*public Sprint() 
    {

    }
    public Sprint(string sp_name, DateTime sp_date, string sp_no_of_developers, string sp_status, Ticket ticket)
    {
        Sp_name = sp_name;
        Sp_date = sp_date;
        Sp_no_of_developers = sp_no_of_developers;
        Sp_status = sp_status;
        Ticket = ticket;

    }
    */
}
