﻿using Microsoft.Extensions.DependencyInjection;
using System;
using Tti.Estate.Data.Repositories;

namespace Tti.Estate.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IPropertyRepository, PropertyRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}