using APIService.Models;
using APIService.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIService.Controllers
{
    [Produces("application/json", "application/xml")]
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly IBooksService _booksService;
        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _booksService.GetBooks();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _booksService.GetBook(id);
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]Book value)
        //{
        //    Book newBook = _booksService.AddBook(value);
        //}

        [HttpPost]
        public IActionResult PostBook([FromBody]Book value)
        {
            Book newBook = _booksService.AddBook(value);
            return Created($"api/Books/{newBook.BookId}", newBook);
        }

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
