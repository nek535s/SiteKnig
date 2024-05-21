using Microsoft.AspNetCore.Mvc;
using SiteKnig.Data;
using SiteKnig.Interfaces;
using SiteKnig.Models;
using SiteKnig.Services;

namespace SiteKnig.Controllers
{
    public class BooksMVCController : Controller
    {
       
        private readonly DbBooksContext _context;
       private readonly IBookSortingService _bookSortingService;

        public BooksMVCController (DbBooksContext context, IBookSortingService bookSortingService)
            {
                _context = context;
                _bookSortingService = bookSortingService;
           
            }

        [HttpPost]
        public IActionResult BuyBook(int id)
        {
            var book = _context.Books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        
         }
        [HttpGet]
        public IActionResult Index(string sort)
        {
            var books = _bookSortingService.SortBooks(_context.Books, sort);

            return View(books.ToList());
            

        }
    }

}
    

