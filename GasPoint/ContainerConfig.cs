using Autofac;
using GasPoint.Core.Interfaces;
using GasPoint.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace GasPoint
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<FormMain>();
            builder.RegisterType<AppInit>().As<IAppInit>();
            builder.RegisterType<EnablerService>().As<IEnablerService>();
            builder.Register<IHttpClientFactory>(_ =>
            {
                var services = new ServiceCollection();
                services.AddHttpClient();
                var provider = services.BuildServiceProvider();
                return provider.GetRequiredService<IHttpClientFactory>();
            }); 
            builder.RegisterType<CloudService>().As<ICloudService>();
            //builder.Register(c => c.Resolve<IHttpClientFactory>().CreateClient())
            //.As<HttpClient>().SingleInstance();


            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
            //    .Where(t => t.Namespace.Contains("Utilities"))
            //    .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));



            return builder.Build();
        }
    }
}
