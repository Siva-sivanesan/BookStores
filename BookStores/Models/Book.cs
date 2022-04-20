using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStores.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "The title length should be between 2 and 20.", MinimumLength=2)]
        public string Title { get; set; }
        public string Genre { get; set; }
        public List<string> Authors{ get; set; }
        public decimal Price { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
