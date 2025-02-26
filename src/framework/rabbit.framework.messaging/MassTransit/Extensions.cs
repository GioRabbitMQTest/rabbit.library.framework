using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace rabbit.framework.messaging.MassTransit;
public static class Extensions
{
  public static IServiceCollection AddMessageBroker
  (this IServiceCollection services, IConfiguration configuration, Assembly? assembly = null)
  {
    services.AddMassTransit(config =>
    {
      config.SetKebabCaseEndpointNameFormatter();
      if (assembly != null)
        config.AddConsumers(assembly);

      config.UsingRabbitMq((context, configurator) =>
      {
        configurator.Host(new Uri(configuration["MessageBroker:Host"]!), hots =>
        {
          hots.Username(configuration["MessageBroker:UserName"]!);
          hots.Password(configuration["MessageBroker:Password"]!);
        });
        configurator.ConfigureEndpoints(context);
      });
    });
    return services;
  }
}