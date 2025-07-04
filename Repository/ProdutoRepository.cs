using Microsoft.EntityFrameworkCore;
using RESTful_teste.Data;
using RESTful_teste.Models;

namespace RESTful_teste.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ClienteContext _context;

        public ProdutoRepository(ClienteContext context) => this._context = context;

        public async Task AddAsync(Produto produto)
        {
            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Produto>> GetAllAsync()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> GetByIdAsync(Guid id)
        {
            return await _context.Produtos.FindAsync(id);
        }

        public async Task DeleteAsync(Guid id)
        {
            Produto produto = await _context.Produtos.FindAsync(id);

            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(Produto produto)
        {
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
        }
    }
}
