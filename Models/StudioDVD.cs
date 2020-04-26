using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EveresetVideoLib.Models
{
    public class StudioDVD
    {
        [Key]
        public int Id { get; set; }
        public int StudioId { get; set; }
        public int DVDId { get; set; }
        [ForeignKey("StudioId")]
        public virtual Studio Studios { get; set; }
        [ForeignKey("DVDId")]
        public virtual DVDDetail DVDDetails { get; set; }
    }
}