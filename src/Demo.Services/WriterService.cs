using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class WriterService : IWriterService
    {
        HttpClient _httpClient;
        public WriterService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task WriteMessage(string message)
        {
            await _httpClient.PostAsync($"/api/message", new StringContent(JsonConvert.SerializeObject(message), Encoding.UTF8, "application/json"));
        }
    }
}
