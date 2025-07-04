using Microsoft.AspNetCore.Mvc;
using RESTful_teste.Models;
using RESTful_teste.Service;

namespace RESTful_teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pedido>>> Get()
        {
            return Ok(await _pedidoService.GetAllAsync());
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<Pedido>> Get(Guid id)
        //{
        //    var pedido = await _pedidoService.GetByIdAsync(id);
        //    if (pedido is null) return NotFound();
        //    return Ok(pedido);
        //}

        [HttpPost]
        public async Task<ActionResult> Post(Pedido pedido)
        {
            await _pedidoService.AddAsync(pedido);
            return CreatedAtAction(nameof(Get), new { id = pedido.Id }, pedido);
        }

        //[HttpPut]
        //public async Task<IActionResult> Put(Guid id, Pedido pedido)
        //{
        //    if (id != pedido.Id)
        //        return BadRequest();

        //    await _pedidoService.UpdateAsync(pedido);
        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public async Task<ActionResult> Delete(Guid id)
        //{
        //    await _pedidoService.DeleteAsync(id);
        //    return NoContent();
        //}
    }
}
