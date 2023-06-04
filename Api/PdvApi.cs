using Azure;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
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
    }


}
