// See https://aka.ms/new-console-template for more information

using ConsoleSample;
using Volo.Abp;
using Microsoft.Extensions.DependencyInjection;


using var application = AbpApplicationFactory.Create<ConsoleModule>(options =>
{
    options.UseAutofac();
});
application.Initialize();
var helloService = application.ServiceProvider.GetService<IHelloAbpService>();
helloService.SayHello();
// var helloService1 = application.ServiceProvider.GetService<BookApplicationService.BookApplicationService>();
// Console.WriteLine(helloService1?.GetAsync(1));