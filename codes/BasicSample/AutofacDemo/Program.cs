// See https://aka.ms/new-console-template for more information

using Autofac;
using AutofacDemo;

var builder=new ContainerBuilder();
builder.RegisterType<DateWriter>().AsSelf().As<IDateWriter>();
var container=builder.Build();

using var scope=container.BeginLifetimeScope();
var writer=scope.Resolve<IDateWriter>();
writer.WriteDate();