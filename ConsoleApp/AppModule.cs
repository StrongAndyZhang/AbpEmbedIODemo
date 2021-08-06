using ConsoleApp.Controllers;
using ConsoleApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ConsoleApp
{
    [DependsOn(typeof(AbpAutofacModule))]
    public class AppModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddTransient<DemoController>();
            context.Services.AddTransient<IDemoService, DemoService>();
        }
    }
}