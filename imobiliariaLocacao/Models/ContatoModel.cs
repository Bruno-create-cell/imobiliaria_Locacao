using System.ComponentModel.DataAnnotations;

namespace imobiliariaLocacao.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Digite o nome do contato.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Digite o e-mail do contato.")]
        [EmailAddress(ErrorMessage = "O e-mail digitado não é valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o celular do contato.")]
        [Phone(ErrorMessage ="O telefone digitado não é valido")]
        public string Celular { get; set; }

        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public decimal ValorAluguel { get; set; }
    }
}
