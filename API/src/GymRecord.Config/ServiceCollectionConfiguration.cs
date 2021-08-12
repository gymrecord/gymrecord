using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace GymRecord.Config
{
    public static class ServiceCollectionConfiguration
    {
        public static void AddGymRecordServiceCollection(this IServiceCollection services)
        {
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}