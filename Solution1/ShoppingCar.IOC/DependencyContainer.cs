using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShoppincCart.data.Context;
using ShoppincCart.data.Repositories;
using Shoppingcart.domain.Interfaces;
using ShoppingCart.application.Interfaces;
using ShoppingCart.application.Services;
using System;
using System.Collections.Generic;
using System.Text;


namespace ShoppingCar.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ShoppingCartDbContext>(options =>
                  options.UseSqlServer(connectionString));

            services.AddScoped<IProductsRepository, ProductsRepositorycs>();
            services.AddScoped<IProductService, ProductsService>();
        }
    }
}
