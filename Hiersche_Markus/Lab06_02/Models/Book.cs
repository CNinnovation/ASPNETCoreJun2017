using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab06_02.Models
{
    public class ListOfBooks
    {
        public static int anz = 0;
        public int Anz { get { return anz; } }
        public List<Book> LoB;
        public ListOfBooks()
        {
            LoB = new List<Book>();
        }
        public void ListOfBooksAddBook(Book book)
        {
            anz++;
            LoB.Add(book);
        }
    }
    public class Book
    {
        public static int anzahl = 0;

        public int Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int Anzahl { get { return anzahl; } }

        public Book(string Title = "", string Publisher = "")
        {
            anzahl++;
            Id = anzahl;
            this.Title = Title;
            this.Publisher = Publisher;
        }
    }
}
