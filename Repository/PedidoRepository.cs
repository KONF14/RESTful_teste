using Microsoft.EntityFrameworkCore;
using RESTful_teste.Data;
using RESTful_teste.Models;

namespace RESTful_teste.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ClienteContext _context;

        public PedidoRepository(ClienteContext context) => this._context = context;

        public async Task AddAsync(Pedido pedido)
        {
            await _context.Pedidos.AddAsync(pedido);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Pedido>> GetAllAsync()
        {
            return await _context.Pedidos
                                 .Include(p => p.Itens)
                                 .ToListAsync();
        }

        //public async Task<Pedido?> GetByIdAsync(Guid id)
        //{
        //    return await _context.Pedidos
        //                         .Include(p => p.Itens)
        //                         .FirstOrDefaultAsync(p => p.Id == id);
        //}

        //public async Task DeleteAsync(Guid id)
        //{
        //    var pedido = await _context.Pedidos.FindAsync(id);

        //    if (pedido != null)
        //    {
        //        _context.Pedidos.Remove(pedido);
        //        await _context.SaveChangesAsync();
        //    }
        //}

        //public async Task UpdateAsync(Pedido pedido)
        //{
        //    _context.Pedidos.Update(pedido);
        //    await _context.SaveChangesAsync();
        //}
    }
}
