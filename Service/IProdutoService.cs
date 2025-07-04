using RESTful_teste.Models;

namespace RESTful_teste.Service
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> GetAllAsync();       // Lista os produtos
        Task<Produto> GetByIdAsync(Guid id);            // Busca um produto específico
        Task AddAsync(Produto produto);                 // Cria produto
        Task UpdateAsync(Produto produto);              // Atualiza produto
        Task DeleteAsync(Guid id);                      // Apaga produto
    }
}
