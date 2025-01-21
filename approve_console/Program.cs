using System;
using System.Threading;
using System.Threading.Tasks;

namespace approve_console
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ApiService apiService = new ApiService();

            while (true)
            {
                await apiService.FetchAndDisplayData();
                Thread.Sleep(5000); // Wait for 5 seconds
            }
        }
    }
}
