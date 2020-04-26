using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EveresetVideoLib.Models
{
    public class MemberCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int TotalLoans { get; set; }
        [Required]
        public int FinePerDay { get; set; }
        
        public virtual IEnumerable<Member> Members { get; set; }

    }
}