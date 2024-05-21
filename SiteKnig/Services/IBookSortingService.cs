using SiteKnig.Interfaces;
using SiteKnig.Models;

namespace SiteKnig.Services
{
    public class BookSortingService : IBookSortingService
    {
        public IQueryable<Book> SortBooks(IQueryable<Book> books, string sort)
        {
            switch (sort)
            {
                case "Author":
                    return books = books.OrderBy(b => b.Author);
                    
                case "Title":
                    return books = books.OrderBy(b => b.Title);
                   
                case "Date":
                    return books = books.OrderBy(b => b.DatePublication);
                    
                default:
                    return books = books.OrderBy(b => b.Id);
                    
            }
        }
    }
}
