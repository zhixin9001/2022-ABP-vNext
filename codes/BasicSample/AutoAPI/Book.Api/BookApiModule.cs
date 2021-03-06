using AuthorApplication.Contract;
using AuthorApplicationService;
using BookApplicationService;
using Microsoft.OpenApi.Models;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Book.Api;

[DependsOn(typeof(AbpAspNetCoreMvcModule))]
[DependsOn(typeof(AbpAutofacModule))]
[DependsOn(typeof(BookApplicationModule))]
[DependsOn(typeof(AbpHttpClientModule))] 
// [DependsOn(typeof(AuthorApplicationModule))]
[DependsOn(typeof(AuthorApplicationContractModule))]
public class BookApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
    //创建动态客户端代理
    context.Services.AddHttpClientProxies(
        typeof(AuthorApplicationContractModule).Assembly
    );
        
        Configure<AbpAspNetCoreMvcOptions>(options =>
        {
            options.ConventionalControllers.Create(typeof(BookApplicationModule).Assembly);
            // options.ConventionalControllers.Create(typeof(AuthorApplicationModule).Assembly);
        });
        
        ConfigureSwaggerServices(context.Services);
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var app = context.GetApplicationBuilder();
        var env = context.GetEnvironment();

        app.UseRouting();
        app.UseMvcWithDefaultRouteAndArea();

        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "Book API");
        });
    }

    private void ConfigureSwaggerServices(IServiceCollection services)
    {
        services.AddSwaggerGen(
            options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Galaxy API", Version = "v0.3" });
                options.DocInclusionPredicate((docName, description) => true);
                options.CustomSchemaIds(type => type.FullName);
            }
        );
    }
}