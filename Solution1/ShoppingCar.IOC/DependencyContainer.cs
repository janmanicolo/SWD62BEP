using Microsoft.Extensions.DependencyInjection;
using ShoppincCart.data.Repositories;
using Shoppingcart.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace ShoppingCar.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IProductsRepository, ProductsRepositorycs>();
        }
    }
}
