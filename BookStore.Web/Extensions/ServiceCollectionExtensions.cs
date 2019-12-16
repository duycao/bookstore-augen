using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BookStore.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddScopedDynamic<TInterface>(this IServiceCollection services, IEnumerable<Type> types)
        {
            services.AddScoped<Func<string, TInterface>>(serviceProvider => service =>
            {
                var type = types.Where(x=>x.Name.Contains(service))
                                .FirstOrDefault();

                if (null == type)
                    throw new KeyNotFoundException("No instance found.");

                return (TInterface)serviceProvider.GetService(type);
            });
        }
    }
}
