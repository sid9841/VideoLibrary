using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EveresetVideoLib.Models
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime IssuedDate { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int FineAmount { get; set; }
        public int MemberId { get; set; }
        public int DVDId { get; set; }
        public int LoanTypeId { get; set; }
        [ForeignKey("MemberId")]
        public virtual Member Members { get; set; }
        [ForeignKey("DVDId")]
        public virtual DVDDetail DVDDetails { get; set; }
        [ForeignKey("LoanTypeId")]
        public virtual LoanType LoanTypes { get; set; }


    }
}