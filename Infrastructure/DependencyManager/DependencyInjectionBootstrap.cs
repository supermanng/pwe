using Application.Common.Interfaces.Repository;
using FluentValidation;
using Infrastructure.Factories;
using Infrastructure.Persistence.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Infrastructure.DependencyManager
{
    public static class DependencyInjectionBootstrap
    {
        public static IServiceCollection InjectService(this IServiceCollection services, IConfiguration configuration)
        {
            //Supress FluentValidation for route parameter
            //services.Configure<ApiBehaviorOptions>(options => options.SuppressInferBindingSourcesForParameters = true);

            services.AddDbContext<ProfileDbContext>(options =>
            {
                var conString = configuration.GetValue<string>("DefaultConnection");
                options.UseSqlServer(conString);
            });
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddTransient<IProfileRepository, ProfileRepository>();
        
            
            services.AddTransient<IUnitOfWork, UoW>();


            return services;
        }
    }
}
