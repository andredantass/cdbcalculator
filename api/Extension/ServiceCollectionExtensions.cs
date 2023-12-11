using CDBCalculation.Application.Abastraction;
using CDBCalculation.Application.Services;

namespace CDBCalculation.Application.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICDBCalculationService, CDBCalculationService>();
            return services;
        }
    }
}
