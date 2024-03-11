using BookCRUD.Models;

namespace BookCRUD.Repositories
{
    public interface IBookRepo
    {

        IEnumerable<Book> GetBooks();   
        Book GetBookById(int id);
        int AddBook(Book book);
        int UpdateBook(Book book);  
        int DeleteBook(int id); 
    }
}
