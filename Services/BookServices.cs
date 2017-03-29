using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Repository;
using DAL.Model;

namespace Services
{
    public static class BookServices
    {
        private static BookShopContext _context = new BookShopContext();
        private static BaseRepository<Book> _db = new BaseRepository<Book>(_context);

        public static ICollection<Book> ListBook()
        {
            return _db.GetAll();
        }

        public static string AddBook(Book entity)
        {
            try
            {
                _db.Add(entity);

                return "Ok";
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public static Book GetBookById(int Id)
        {
            return _db.GetById(Id);
        }

        public static string UpdateBook(Book entity)
        {
            Book book = GetBookById(entity.Id);
            if (book != null)
            {
                try
                {
                    book.Name = entity.Name;
                    book.Description = entity.Description;
                    book.Price = entity.Price;
                    _db.Update(entity);
                    return "Ok";
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            else { return "Book do not exists"; }
        }
    }
}
