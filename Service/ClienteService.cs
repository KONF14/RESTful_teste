using RESTful_teste.Models;
using RESTful_teste.Repository;

namespace RESTful_teste.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository repository)=> _clienteRepository = repository;
        public async Task AddAsync(Cliente cliente)
        {
          await _clienteRepository.AddAsync(cliente);
        }

        public async Task DeleteAsync(Guid id)
        {
           await _clienteRepository.DeleteAsync(id);
           
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
           return await _clienteRepository.GetAllAsync();
        }

        public async Task<Cliente> GetByIdAsync(Guid id)
        {
            return await _clienteRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Cliente cliente)
        {
           await _clienteRepository.UpdateAsync(cliente);
        }
    }
}
