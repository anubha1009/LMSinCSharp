using LMS.Interface;
using LMS.Model;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController: Controller
    {
        private readonly BookService bookService;

        public BookController(BookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        [ProducesResponseType(200 , Type = typeof(IEnumerable<Books>))]
        [ProducesResponseType(400)]
        public IActionResult GetAllBooks()
        {
            var allBooks = this.bookService.GetBooks();
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(allBooks);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(Books))]
        [ProducesResponseType(400)]
        public IActionResult GetBook(int id)
        {
            var book = this.bookService.GetBookById(id);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(book);

        }
    }
}
