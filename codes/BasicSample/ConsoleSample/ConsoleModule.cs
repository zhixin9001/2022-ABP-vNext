using BookApplicationService;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace ConsoleSample;

[DependsOn(typeof(BookApplicationModule))]
public class ConsoleModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var services = context.Services;
        // services.AddTransient<HelloAbpService>();
        // services.AddTransient<BookApplicationService.BookApplicationService>();
        base.ConfigureServices(context);
    }
}