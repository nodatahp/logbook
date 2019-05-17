using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LogBook.Models
{
    public abstract class DivisionVisit
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string DivisionName { get; set; }
        public string UserName { get; set; }
        [Required]
        public Visit Visit { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
