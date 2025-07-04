using RESTful_teste.Models;

namespace RESTful_teste.Service
{
    public interface IPedidoService
    {
        Task<IEnumerable<Pedido>> GetAllAsync();       // Lista todos os pedidos
        //Task<Pedido?> GetByIdAsync(Guid id);           // Busca um pedido específico
        Task AddAsync(Pedido pedido);                  // Cria pedido
      //  Task UpdateAsync(Pedido pedido);               // Atualiza pedido
        //Task DeleteAsync(Guid id);                     // Apaga pedido
    }
}
