using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EveresetVideoLib.Models
{
    public class Studio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }

        public string Email { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        public virtual IEnumerable<DVDDetail> DVDDetails { get; set; }
    }
}