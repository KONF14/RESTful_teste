using RESTful_teste.Models;
using RESTful_teste.Repository;

namespace RESTful_teste.Service
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository repository)
        {
            _pedidoRepository = repository;
        }

        public async Task AddAsync(Pedido pedido)
        {
            await _pedidoRepository.AddAsync(pedido);
        }

        //public async Task DeleteAsync(Guid id)
        //{
        //    await _pedidoRepository.DeleteAsync(id);
        //}

        public async Task<IEnumerable<Pedido>> GetAllAsync()
        {
            return await _pedidoRepository.GetAllAsync();
        }

        //public async Task<Pedido?> GetByIdAsync(Guid id)
        //{
        //    return await _pedidoRepository.GetByIdAsync(id);
        //}

        //public async Task UpdateAsync(Pedido pedido)
        //{
        //    await _pedidoRepository.UpdateAsync(pedido);
        //}
    }
}
