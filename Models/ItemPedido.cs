using System.ComponentModel.DataAnnotations;

namespace RESTful_teste.Models
{
    public class ItemPedido
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
     
        public Guid ProdutoId { get; set; }

        [Required, Range(1, Int32.MaxValue, ErrorMessage = "Quantidade deve ser maior que zero")]
        public Int32 Quantidade { get; set; }

        [Required, Range(0.01, Double.MaxValue, ErrorMessage = "Preço unitário inválido")]
        public Decimal PrecoUnitario { get; set; }

        public Decimal TotalItem => PrecoUnitario * Quantidade;

        public override String ToString()
        {
            return $"Produto: {ProdutoId} | Qtd: {Quantidade} | Unit: R${PrecoUnitario} | Total: R${TotalItem}";
        }
    }
}
