using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorServer.Data;

namespace BlazorServer.Services
{
    public partial class ApiService
    {
        public HttpClient _httpClient;

        public ApiService(HttpClient client)
        {
            _httpClient = client;
            _httpClient.DefaultRequestHeaders.Authorization = 
                new AuthenticationHeaderValue("Basic","YWRtaW46cGFzc3dvcmQ=");
        }

        Uri uri = new Uri("http://10.138.20.249/api/v2/job_templates/40/launch/");

        //
        public async Task<HttpResponseMessage> Unlock(Extra_vars extraVars)
        {
            UnlockAccount unlockAccount = new UnlockAccount();
            unlockAccount.extra_vars = extraVars;
            var stringData = JsonSerializer.Serialize(unlockAccount);
            var httpContent = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(uri, httpContent);
            //response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
            var responseStream = await response.Content.ReadAsStreamAsync();
            UnlockRespond unlockRespond = JsonSerializer.DeserializeAsync<UnlockRespond>(response.);
            Console.WriteLine(responseStream);
            return await JsonSerializer.DeserializeAsync<HttpResponseMessage>(responseStream);
            }
            return null;
        }

    }
    
}