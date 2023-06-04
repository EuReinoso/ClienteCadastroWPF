using Azure;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClienteCadastroWPF.Api
{
    public class PdvApi
    {
        private HttpClient _api;

        private string _endereco;

        public PdvApi()
        {

        }

        public void Init(string enderecoBase)
        {
            _endereco = "http://" + enderecoBase + "/pdvapi/api/public/";

            _api = new HttpClient() { BaseAddress = new Uri(_endereco)};
        }

        public async Task<bool> Login(string usuario, string senha)
        {

            var parametrosLogin = new { Usuario = usuario, Senha = senha };

            var loginContent = Util.ToStringContent(parametrosLogin);

            try
            {
                var response = await _api.PostAsync("login", loginContent);

                var responseBody = await response.Content.ReadAsStringAsync();

                string token = JObject.Parse(responseBody)["Token"].ToString();

                _api.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<Dictionary<object, object>>> GetClientes(int pagina = 1, int tamanhoPagina = 50, bool todos = true)
        {
            var clientes = new List<Dictionary<object, object>> { };

            bool temProximaPagina = false;

            do
            {
                string consulta = $"clientes?pagina={pagina}&tamanhoPagina={tamanhoPagina}";

                var response = await _api.GetAsync(consulta);

                var conteudo = await response.Content.ReadAsStringAsync();

                var resultado = JsonConvert.DeserializeObject<Dictionary<object, object>>(conteudo);

                if (!resultado.ContainsKey("Registros"))
                {

                    var listaVazia = new List<Dictionary<object, object>> { };

                    return await Task.FromResult(listaVazia);
                }

                var registros = JsonConvert.DeserializeObject<List<Dictionary<object, object>>>(resultado["Registros"].ToString());

                temProximaPagina = bool.Parse(JsonConvert.DeserializeObject<Dictionary<object, object>>(resultado["PaginacaoInfo"].ToString())["TemProximaPagina"].ToString());

                foreach (var reg in registros)
                {
                    clientes.Add(reg);
                }

                pagina += 1;

            } while (temProximaPagina && todos);

            return await Task.FromResult(clientes);
        }
    }


}
