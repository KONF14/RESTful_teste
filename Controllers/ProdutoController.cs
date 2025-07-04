using Microsoft.AspNetCore.Mvc;
using RESTful_teste.Models;
using RESTful_teste.Service;

namespace RESTful_teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> Get()
        {
            return Ok(await _produtoService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> Get(Guid id)
        {
            Produto produto = await _produtoService.GetByIdAsync(id);

            if (produto is null) return NotFound();
            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Produto produto)
        {
            await _produtoService.AddAsync(produto);
            return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Guid id, Produto produto)
        {
            if (id != produto.Id)
                return BadRequest();

            await _produtoService.UpdateAsync(produto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _produtoService.DeleteAsync(id);
            return NoContent();
        }
    }
}
