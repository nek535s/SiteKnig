using SiteKnig.Models;
using SiteKnig.Services;

namespace SiteKnig.Interfaces
{
    
        public interface IBookSortingService
        {
            IQueryable<Book> SortBooks(IQueryable<Book> books, string sort);
        }
   
}
