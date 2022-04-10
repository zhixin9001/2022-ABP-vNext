using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace ConsoleSample;

public class ConsoleModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var services = context.Services;
        services.AddTransient<HelloAbpService>();
        base.ConfigureServices(context);
    }
}