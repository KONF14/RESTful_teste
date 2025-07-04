using RESTful_teste.Models;
using RESTful_teste.Repository;

namespace RESTful_teste.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository repository)
        {
            _produtoRepository = repository;
        }

        public async Task AddAsync(Produto produto)
        {
            await _produtoRepository.AddAsync(produto);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _produtoRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Produto>> GetAllAsync()
        {
            return await _produtoRepository.GetAllAsync();
        }

        public async Task<Produto> GetByIdAsync(Guid id)
        {
            return await _produtoRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Produto produto)
        {
            await _produtoRepository.UpdateAsync(produto);
        }
    }
}
