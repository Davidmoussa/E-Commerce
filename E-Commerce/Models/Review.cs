using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public class Review
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Product")]
        public int ProducId { get; set; }
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Customer")]
        public string CustomerId { get; set; }
        public ApplicationUser Customer { get; set; }
        public Product Product { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}