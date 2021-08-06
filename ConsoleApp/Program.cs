using ConsoleApp.Controllers;
using EmbedIO;
using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            using var application = AbpApplicationFactory.Create<AppModule>(options =>
            {
                options.UseAutofac();
            });

            application.Initialize();

            using var server = new WebServer("http://localhost:9696");
            server.WithWebApi("/api", m => m.RegisterController(() => application.ServiceProvider.GetRequiredService<DemoController>()));
            server.Start();

            Console.WriteLine("The EmbedIO demo with Abp is running!");
            Console.ReadLine();
        }
    }
}