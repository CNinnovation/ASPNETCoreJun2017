using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04_01.Models
{
    public class Books
    {
        private int _Seiten;

        public int Seiten
        {
            get { return _Seiten; }
            set { _Seiten = value; }
        }
        private string _Titel;

        public string Titel
        {
            get { return _Titel; }
            set { _Titel = value; }
        }

        private string _Autor;

        public string Autor
        {
            get { return _Autor; }
            set { _Autor = value; }
        }

        public Books(int Seiten, string Titel, string Autor)
        {
            this.Seiten = Seiten;
            this.Titel = Titel;
            this.Autor = Autor;
        }
    }
}
