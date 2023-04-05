using Newtonsoft.Json;

namespace imobiliariaLocacao.Service
{
    public class CepService
    {
        private string url = "https://viacep.com.br/ws/";

        public Endereco BuscarEndereco(string cep)
        {
            using (HttpClient client = new HttpClient())
            {
                string enderecoUrl = $"{url}{cep}/json/";

                HttpResponseMessage response = client.GetAsync(enderecoUrl).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    Endereco endereco = JsonConvert.DeserializeObject<Endereco>(json);

                    return endereco;
                }
                else
                {
                    return null;
                }
            }
        }
    }
    public class Endereco
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Ibge { get; set; }
        public string Gia { get; set; }
        public string Ddd { get; set; }
        public string Siafi { get; set; }
    }
}
