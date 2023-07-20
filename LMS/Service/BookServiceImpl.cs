using LMS.Data;
using LMS.Interface;
using LMS.Model;

namespace LMS.Service
{
    public class BookServiceImpl : BookService
    {
        private readonly DataContext context;
        public BookServiceImpl(DataContext context)
        {
            this.context = context;
        }

        public bool BookExists(int id)
        {
            return this.context.Books.Any(b=> b.Id == id);
        }

        public ICollection<Books> GetBooks()
        {
           return this.context.Books.ToList();
        }

        public Books GetBookById(int id)
        {
            return this.context.Books.Where(b => b.Id == id).FirstOrDefault();
        }
    }
}
