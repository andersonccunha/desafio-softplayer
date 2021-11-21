using Microsoft.Extensions.DependencyInjection;
using softplayer.application.Interfaces;
using softplayer.application.Services;
using softplayer.domain.Interfaces; 
using softplayer.infra.data.Repository;

namespace softplayer.infra.crosscutting
{
    public class SimpleInjectorBootStrapper
    {
        public static void RegisterService(IServiceCollection services)
        {
            //Application - Domain
            services.AddScoped<IJurosService, JurosService>();
            //Domain - Data
            services.AddScoped<IJurosRepository, JurosRepository>();
        }
    }
}
