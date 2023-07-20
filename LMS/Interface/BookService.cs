using LMS.Model;

namespace LMS.Interface
{
    public interface BookService
    {
        ICollection<Books> GetBooks();
        Books GetBookById(int id);
        bool BookExists(int id);

    }
}
