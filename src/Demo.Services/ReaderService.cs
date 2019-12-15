using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class ReaderService : IReaderService
    {
        HttpClient _httpClient;

        public ReaderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> ReadMessage()
        {
            return await _httpClient.GetAsync($"/api/message").Result.Content.ReadAsStringAsync();
        }
    }
}
