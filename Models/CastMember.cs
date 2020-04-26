using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EveresetVideoLib.Models
{
    public class CastMember
    {
        [Key]
        public int Id { get; set; }
        public int CastId { get; set; }
        public int DVDId { get; set; }
        [ForeignKey("CastId")]
        public virtual Cast Casts { get; set; }
        [ForeignKey("DVDId")]
        public virtual DVDDetail DVDDetails { get; set; }
    }
}