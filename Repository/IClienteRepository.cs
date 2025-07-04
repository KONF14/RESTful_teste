using RESTful_teste.Models;

namespace RESTful_teste.Repository
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetAllAsync();//Lista os clientes
        Task<Cliente> GetByIdAsync(Guid id);//Busca um cliente especifico
        Task AddAsync(Cliente cliente);//Criar cliente
        Task UpdateAsync(Cliente cliente);//Atualiza cliente
        Task DeleteAsync(Guid id);//Apaga cliente
    }
}
