using Microsoft.AspNetCore.Mvc;
using RESTful_teste.Models;
using RESTful_teste.Service;

namespace RESTful_teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
       private readonly IClienteService _clienteService;
       public ClienteController(IClienteService clienteService)=> _clienteService = clienteService;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> Get()
        {
            return Ok(await _clienteService.GetAllAsync());
        }
        [HttpGet("{id}")]

        public async Task<ActionResult<Cliente>> Get(Guid id)
        {
            Cliente cliente = await _clienteService.GetByIdAsync(id);

            if (cliente is null) return NotFound();
            return Ok(cliente);

        }

        [HttpPost]
        public async Task<ActionResult> Post(Cliente cliente) 
        {
            await _clienteService.AddAsync(cliente);
            return CreatedAtAction(nameof(Get), new {id = cliente.Id});
        }
        [HttpPut]

        public async Task<IActionResult> Put(Guid id,Cliente cliente) 
        {
            if (id != cliente.Id) 
            {
                return BadRequest();
            }
            await _clienteService.UpdateAsync(cliente);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id) 
        {
          await _clienteService.DeleteAsync(id); return NoContent();
        }

    }
}
