using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab06_01.Models
{
    public class Book
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string publisher;

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public Book(int id, string title, string publisher)
        {
            this.Id = id;
            this.Title = title;
            this.Publisher = publisher;
        }
    }
}
