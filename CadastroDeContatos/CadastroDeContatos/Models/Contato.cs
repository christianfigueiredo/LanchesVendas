using System.ComponentModel.DataAnnotations;

namespace CadastroDeContatos.Models
{
    public class Contato
    {
        public int ContatoId { get; set; }

        [Required(ErrorMessage ="Digite o nome do contato")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Digite o email do contato")]
        [EmailAddress(ErrorMessage ="Email Invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Digite o celular")]
        [Phone(ErrorMessage ="Formato Invalido!")]
        public string Celular { get; set; }

    }
}
