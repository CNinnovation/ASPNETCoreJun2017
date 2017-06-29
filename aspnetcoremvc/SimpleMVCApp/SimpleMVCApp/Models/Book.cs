using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMVCApp.Models
{
    public class Book
    {
        
        public int BookId { get; set; }

        [StringLength(40)]
        public string Title { get; set; }
        public string Publisher { get; set; }
        public override string ToString() => Title;
    }
}
