using Microsoft.EntityFrameworkCore;
using RESTful_teste.Data;
using RESTful_teste.Models;

namespace RESTful_teste.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ClienteContext _context;
        public ClienteRepository(ClienteContext context)=> this._context = context;
        public async Task AddAsync(Cliente cliente)
        {
         await _context.Clientes.AddAsync(cliente);
         await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            Cliente clienteId = await _context.Clientes.FindAsync(id);

            if (clienteId != null)
            {
                _context.Clientes.Remove(clienteId);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> GetByIdAsync(Guid id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task UpdateAsync(Cliente cliente)
        {
           _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }
    }
}
