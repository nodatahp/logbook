using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LogBook.Models
{
    public class WardpPreDivisionVisit : DivisionVisit
    {
        [StringLength(30)]
        public string WardName { get; set; }
        public DateTime TimeWardArrive { get; set; }
        public  string Diagnosis { get; set; }
    }
}
