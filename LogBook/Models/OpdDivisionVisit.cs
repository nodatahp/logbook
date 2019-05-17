using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogBook.Models
{
    public class OpdDivisionVisit : DivisionVisit
    {
        public DateTime DateFollowUp { get; set; }
        public int MissFollowUp { get; set; }
        public YesNo INRInTarget { get; set; }
    }
}
