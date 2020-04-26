using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EveresetVideoLib.Models
{
    public class ProducerDVD
    {
        [Key]
        public int Id { get; set; }
        public int ProducerId { get; set; }
        public int DVDId { get; set; }
        [ForeignKey("ProducerId")]
        public virtual Producer Producers { get; set; }
        [ForeignKey("DVDId")]
        public virtual DVDDetail DVDDetails { get; set; }
    }
}