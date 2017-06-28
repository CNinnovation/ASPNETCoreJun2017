using Microsoft.AspNetCore.Mvc;
using SimpleMVCApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleMVCApp.ViewComponents
{
    [ViewComponent(Name ="BooksList")]
    public class BooksViewComponent : ViewComponent
    {
        private readonly IBooksService _booksService;

        public BooksViewComponent(IBooksService booksService)
        {
            _booksService = booksService;
        }

        public Task<IViewComponentResult> InvokeAsync(string publisher)
        {
            var books = _booksService.GetBooks();
            var selectedBooks = books.Where(b => b.Publisher == publisher);
            return Task.FromResult(View(selectedBooks) as IViewComponentResult);
        }
    }
}
