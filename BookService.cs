using BookCRUD.Models;
using BookCRUD.Repositories;

namespace BookCRUD.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepo repo;
        public BookService(IBookRepo repo) 
        {
            this.repo=repo;
        }
        public int AddBook(Book book)
        {
           return repo.AddBook(book);
        }

        public int DeleteBook(int id)
        {
            return repo.DeleteBook(id);
        }

        public Book GetBookById(int id)
        {
            return repo.GetBookById(id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return repo.GetBooks();
        }

        public int UpdateBook(Book book)
        {
            return repo.UpdateBook(book);
        }
    }
}
