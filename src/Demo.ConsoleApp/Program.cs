using Demo.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Demo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");
            var services = new ServiceCollection();

            services.AddHttpClient<IReaderService, ReaderService>(x => x.BaseAddress = new Uri("http://webapi/"));
            services.AddHttpClient<IWriterService, WriterService>(x => x.BaseAddress = new Uri("http://webapi/"));
            services.AddScoped<App>();

            var provider = services.BuildServiceProvider();

            MainAsync(provider).Wait();
        }

        static async Task MainAsync(ServiceProvider provider)
        {
            var app = provider.GetService<App>();

            while (true)
            {
                await Task.Delay(500);
                app.Run();
            }
        }
    }
}
