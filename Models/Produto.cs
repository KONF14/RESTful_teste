using System.ComponentModel.DataAnnotations;

namespace RESTful_teste.Models
{
    public class Produto
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public String Nome { get; set; } 
       
        [Required, Range(0.01, Double.MaxValue, ErrorMessage = "Preço deve ser maior que zero")]
        public Decimal Preco { get; set; }
        [Required, Range(0, Int32.MaxValue, ErrorMessage = "Estoque não pode ser negativo")]
        public Int32 Estoque { get; set; }

        public Produto(String nome, Decimal preco, Int32 estoque)
        {
            Nome = nome;
            Preco = preco > 0 ? preco : throw new ArgumentException("Preço deve ser maior que zero");
            Estoque = estoque >= 0 ? estoque : throw new ArgumentException("Estoque não pode ser negativo");
        }
    }
}
