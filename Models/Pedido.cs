using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RESTful_teste.Models
{
    public class Pedido
    {
        [Key]
        public Guid Id { get; private set; } = Guid.NewGuid();

        [Required]
        public Guid ClienteId { get; set; }

        public DateTime DataPedido { get; private set; } = DateTime.UtcNow;

        [Required, MinLength(1, ErrorMessage = "O pedido deve conter pelo menos um item.")]
        public List<ItemPedido> Itens { get; set; } = new();

        public decimal TotalPedido => Itens.Sum(item => item.TotalItem);

        public override string ToString()
        {
            return $"Pedido: {Id} | Cliente: {ClienteId} | Data: {DataPedido} | Total: R${TotalPedido} | Itens: {Itens.Count}";
        }
    }
}
