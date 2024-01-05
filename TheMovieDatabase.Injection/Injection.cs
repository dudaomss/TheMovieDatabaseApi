using Microsoft.Extensions.DependencyInjection;
using TheMovieDatabaseApi.Business;
using TheMovieDatabaseApi.Business.Interface;
using TheMovieDatabaseApi.Repository;
using TheMovieDatabaseApi.Repository.Interface;

namespace TheMovieDatabaseApi.Injection
{
    public static class Injection
    {
        public static void InjectDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioBusiness, UsuarioBusiness>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}