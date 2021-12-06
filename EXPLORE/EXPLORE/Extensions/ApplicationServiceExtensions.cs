using EXPLORE.Data;
using EXPLORE.Interfaces;
using EXPLORE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXPLORE.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenServices, TokenService>();

            services.AddDbContextPool<DataContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));


            });
            return services;
        }
            }
}
