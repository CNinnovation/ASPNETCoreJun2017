using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIService.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [MaxLength(60)]
        [Required()]
        public string Title { get; set; }

        [MaxLength(20)]
        public string Publisher { get; set; }
    }
}
