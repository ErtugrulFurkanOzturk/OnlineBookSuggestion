using Booksuggestion.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// İmplementasyon için 
namespace Booksuggestion.API.Data
{
    public class AppRepository : IAppRepository
    {
        private DataContext _context;

        public AppRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public Book GetBookByID(int bookid)
        {
            var book = _context.Books.FirstOrDefault(c => c.ID == bookid);
            return book;
        }

        public List<Book> GetBooks()
        {
            var books = _context.Books.ToList();
            return books;
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
