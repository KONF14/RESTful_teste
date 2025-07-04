using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;


#region Ideias dessa classe:
//Campo não nulo no id 
//Metodo ToString para formatar
//Deve salvar essa classe 
 
#endregion
namespace RESTful_teste.Models
{
    public class Cliente
    {

        [Key,NotNull]
        public Guid Id { get; private set; } = Guid.NewGuid();

        [Required]
        public String Nome { get; set; }

        [Required]
        public String Cpf { get; set; }

        [Required, EmailAddress]
        public String Email {  get; set; }

        public DateTime DataCadastro { get;private set; } = DateTime.UtcNow;//garantindo uma melhoria ao carregar a data 
       
        //A parte a baixo é mais para caso queira testar se a Classe criou os campos certinhos
        public override string ToString()
        {
            return $"{Nome} ({Cpf}) - {Email}";
        }

    }
}
