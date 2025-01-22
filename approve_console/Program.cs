using System;
using System.Threading;

namespace approve_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApiService apiService = new ApiService();

            while (true)
            {
                apiService.FetchAndDisplayData(); // No await needed
                Thread.Sleep(5000); // Wait for 5 seconds
            }
        }
    }
}
