using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab06_02.Models
{
    public class Book
    {
        public static int anzahl = 0;

        public int Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }

        public Book(string Title = "", string Publisher = "")
        {
            anzahl++;
            Id = anzahl;
            this.Title = Title;
            this.Publisher = Publisher;
        }
    }
}
