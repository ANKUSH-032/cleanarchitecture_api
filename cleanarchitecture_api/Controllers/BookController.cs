using Application.Services.BookServices.BookById;
using Application.Services.BookServices.GetBook;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cleanarchitecture_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetBookList()
        {
            var book = await Sender.Send(new GetBookQuery());
            return Ok(book);
        }
        [HttpGet("{id}")]

        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var blog = await Sender.Send(new GetBookById() { Id = id });
            if (blog == null)
            {
                return NotFound();
            }
            return Ok(blog);
        }
    }
}