using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace approve_console
{
    internal class ApiService
    {
        private readonly HttpClient _client;

        public ApiService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7082/")
            };
        }

        public async Task FetchAndDisplayData()
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync("api/Request");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                List<ApiResponse> apiResponses = JsonConvert.DeserializeObject<List<ApiResponse>>(responseBody);

                foreach (var item in apiResponses)
                {
                    Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Status: {item.Status}, Timestamp: {item.Timestamp}, IsChecked: {item.IsChecked}");
                    Console.WriteLine($"RequestDate: {item.RequestDate}, RequestFor: {item.RequestFor}, RequestType: {item.RequestType}, AccessType: {item.AccessType}");
                    Console.WriteLine($"RequestId: {item.RequestId}, BulkRequestId: {item.BulkRequestId}, RequestStatus: {item.RequestStatus}");
                    Console.WriteLine($"AccType: {item.AccType}, ApplicationName: {item.ApplicationName}, Env: {item.Env}");
                    Console.WriteLine($"Role: {item.Role}, Group: {item.Group}");
                    Console.WriteLine("------------------------------------------------------");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
