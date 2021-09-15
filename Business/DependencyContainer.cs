//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Business
//{
//    class DependencyContainer
//    {
//    }
//}



//using AutoMapper;
//using AutoMapper.Extensions.ExpressionMapping;
using Business.ServiceInterfaces;
//using Business.Profiles;
using Business.Services;
using DataAccess.RepositoryInterfaces;
using DataAccess.Repositories;
using DataAccess;
using Entities.Models;
//using ETicaret.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class DependencyContainer
    {
        public static void AddDependencies(this IServiceCollection services)
        {

            //services.AddDbContext<AppDbContext>(options =>
            //options.UseSqlServer(configuration.GetConnectionString("Default"))
            //.UseLazyLoadingProxies());

           // services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
           //.AddEntityFrameworkStores<AppDbContext>();

            //services.AddScoped<IUnitofWork, UnitofWork>();

            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
            
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            
            services.AddScoped<IOrderDetailService, OrderDetailService>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            
            services.AddScoped<IOrderPayDetailService, OrderPayDetailService>();
            services.AddScoped<IOrderPayDetailRepository, OrderPayDetailRepository>();

        }
    }
}
