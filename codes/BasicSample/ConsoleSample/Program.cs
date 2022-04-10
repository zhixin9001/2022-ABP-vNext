// See https://aka.ms/new-console-template for more information

using ConsoleSample;
using Volo.Abp;
using Microsoft.Extensions.DependencyInjection;


using var application = AbpApplicationFactory.Create<ConsoleModule>();
application.Initialize();
var helloService = application.ServiceProvider.GetService<HelloAbpService>();
helloService?.SayHello();