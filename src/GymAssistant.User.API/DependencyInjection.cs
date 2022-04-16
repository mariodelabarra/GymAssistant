using GymAssistant.Common.Repository;
using GymAssistant.User.Repository;
using GymAssistant.User.Service;

namespace GymAssistant.User.API
{
    public static class DependencyInjection
    {
        public static void ConfigureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            RegisterConfigutarion(services);
            RegisterServices(services);
            RegisterRepositories(services);
        }

        public static void RegisterConfigutarion(IServiceCollection services)
        {
            //Connection to MySQL
            services.AddSingleton<DapperContext>();
        }

        public static void RegisterServices(IServiceCollection services)
        {
            //Mapper

            //Services
            services.AddScoped<IUserService, UserService>();

            //Validators
        }

        public static void RegisterRepositories(IServiceCollection services)
        {
            //BaseRepositories
            //services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            //Repositories
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
