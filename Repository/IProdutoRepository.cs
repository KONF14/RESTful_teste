using RESTful_teste.Models;

namespace RESTful_teste.Repository
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetAllAsync();       // Lista todos os produtos
        Task<Produto> GetByIdAsync(Guid id);            // Busca um produto específico
        Task AddAsync(Produto produto);                 // Cria produto
        Task UpdateAsync(Produto produto);              // Atualiza produto
        Task DeleteAsync(Guid id);                      // Apaga produto
    }
}
