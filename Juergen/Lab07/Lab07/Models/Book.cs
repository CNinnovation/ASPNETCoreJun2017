using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab06.Models
{
    public class Book
    {
        public int BookID { get; set; }

        public string Title { get; set; }

        public string Publisher { get; set; }

        public string Author { get; set; }
    }
}
