using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.API.Data;
using BookStore.API.DTOs;
using BookStore.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly IBookRepository _bookRep;

        public BookController(IBookRepository bookRep)
        {
            _bookRep = bookRep;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var books = await _bookRep.GetBooks();
            return Ok(books.ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if(id == 0) return Ok(new BookForRegistration());
            
            return Ok("value");
        }

        // POST api/values
        [HttpPost]
        public async Task<Book> Post(BookForRegistration bookForReg)
        {
            var book = await _bookRep.AddOrUpdate(bookForReg.Convert());

            return book;

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
