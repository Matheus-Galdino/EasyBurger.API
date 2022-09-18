using EasyBurger.API.Infra.Contexts;
using EasyBurger.API.Infra.Repositories;
using EasyBurger.API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace EasyBurger.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMyDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApiContext>(options =>
            {
                var conString = configuration.GetConnectionString("MySql");
                options.UseMySql(conString, ServerVersion.AutoDetect(conString));
            });

            return services;
        }

        public static IServiceCollection AddMyRepositories(this IServiceCollection services)
        {
            services.AddTransient<UserRepository>();
            services.AddTransient<ProductRepository>();

            return services;
        }

        public static IServiceCollection AddMyServices(this IServiceCollection services)
        {
            services.AddSingleton<TokenService>();

            return services;
        }

        public static IServiceCollection AddMyAuth(this IServiceCollection services, IConfiguration configuration)
        {
            var key = Encoding.ASCII.GetBytes(configuration["SECRET_KEY"]);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            return services;
        }
    }
}
