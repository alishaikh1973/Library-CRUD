using BookCRUD.Data;
using BookCRUD.Models;

namespace BookCRUD.Repositories
{
    public class BookRepo : IBookRepo
    {
         private readonly ApplicationDbContext db;
        public BookRepo(ApplicationDbContext db) 
        {
            this.db = db;
        }
        public int AddBook(Book book)
        {
            db.Books.Add(book);
            int res=db.SaveChanges();
            return res;

        }

        public int DeleteBook(int id)
        {
            int res = 0;
            var result = db.Books.Where(x => x.Id == id).FirstOrDefault();
            if(result != null)
            {
                db.Books.Remove(result);
                res = db.SaveChanges();

            }
            return res;
        }

        public Book GetBookById(int id)
        {
           var result=db.Books.Where(x=>x.Id==id).SingleOrDefault();
            return result;
        }

        public IEnumerable<Book> GetBooks()
        {
            var result = from b in db.Books
                         select b;
            return result;

        }

        public int UpdateBook(Book book)
        {
            int res = 0;
            var result = db.Books.Where(x => x.Id == book.Id).FirstOrDefault();
            if(result != null)
            {
                result.Name = book.Name;
                result.Author = book.Author;
                result.Price = book.Price;
                res = db.SaveChanges();
            }
            return res;
        }
    }
}
