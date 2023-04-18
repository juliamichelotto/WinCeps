using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CEPBLLs
{
    public class ConsultaCEP
    {
        private readonly HttpClient _httpClient;
        public ConsultaCEP()
            {
             _httpClient = new HttpClient();
            }
        public CEP Consultar(string CepConsulta)
        {
      
            return _httpClient.GetFromJsonAsync<CEP>($"https://viacep.com.br/ws/{CepConsulta}/json/").Result;
            

        }
    }
}
