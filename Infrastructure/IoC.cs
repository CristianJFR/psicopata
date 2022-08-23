using Application.Common.Interfaces.Products;
using Application.Common.Interfaces.Sellers;
using Application.Common.Interfaces.Users;
using Infrastructure.Services.Products;
using Infrastructure.Services.Sellers;
using Infrastructure.Services.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class IoC
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ISellerService, SellerService>();
            services.AddTransient<IProductService, ProductService>();
            return services;
        }
    }
}
