using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EveresetVideoLib.Models
{
    public class DVDDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Length { get; set; }
        [NotMapped]
        public HttpPostedFile CoverImage { get; set; }
        public string CoverImagePath { get; set; }

        public virtual IEnumerable<Loan> Loans { get; set; }
        public virtual IEnumerable<Studio> Studios { get; set; }
        public virtual IEnumerable<Cast> Casts { get; set; }
        public virtual IEnumerable<Producer> Producers { get; set; }
    }
}