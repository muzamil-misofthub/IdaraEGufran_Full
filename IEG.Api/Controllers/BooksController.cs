using IEG.Application.DTOs.Books;
using IEG.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace IEG.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _service;
        public BooksController(IBookService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 20, [FromQuery] string? q = null)
        {
            var items = await _service.GetAllBooksAsync(page, pageSize, q);
            return Ok(items);
        }
        [HttpGet("{id:int}", Name = nameof(GetById))]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _service.GetBookByIdAsync(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBookDto dto)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _service.CreateBookAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateBookDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != dto.Id) return BadRequest();
            await _service.UpdateBookAsync(dto);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }

    }
}
