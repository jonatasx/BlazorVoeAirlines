using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Newtonsoft.Json;

namespace VoeAirlinesBlazor.Data
{
    public class Login
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("Usuario")]
        public string? Usuario { get; set; }

        [JsonProperty("DataCriacao")]
        public DateTime DataCriacao { get ; set; }

        [JsonProperty("DataAtual")]
        public DateTime DataAtual { get; set; } = DateTime.Now;

        [JsonProperty("Senha")]
        public string? Senha { get; set; }
    }
}