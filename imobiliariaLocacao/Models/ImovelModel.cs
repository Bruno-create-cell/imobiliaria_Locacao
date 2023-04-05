namespace imobiliariaLocacao.Models
{
    public class ImovelModel
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public decimal ValorAluguel { get; set; }

    }
}
