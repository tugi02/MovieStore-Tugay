﻿using MovieStore.Models.Configurations;

namespace MovieStore.ServiceExtensions
{
    public static class ServiceConfigurationsExtensions
    {
        public static IServiceCollection AddConfigurations(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            return services.Configure<MongoDbConfiguration>(
                configuration.GetSection(nameof(MongoDbConfiguration)));
        }
    }
}
