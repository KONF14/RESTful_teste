using RESTful_teste.Models;
using RESTful_teste.Service;

namespace RESTful_teste.Service
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetAllAsync();//Lista os clientes
        Task<Cliente> GetByIdAsync(Guid id);//Busca um cliente especifico
        Task AddAsync(Cliente cliente);//Criar cliente
        Task UpdateAsync(Cliente cliente);//Atualiza cliente
        Task DeleteAsync(Guid id);//Apaga cliente
    }
}
