using Microsoft.Extensions.DependencyInjection;
using RentACar.Interfaces;
using RentACar.Services;

namespace RentACar.DependencyInjection
{
    public static class ConfigureServicesInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<HashService>();
            services.AddScoped<IRegisterService, RegisterService>();

            return services;
        }
    }
}
