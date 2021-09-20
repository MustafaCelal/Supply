using Business.ServiceInterfaces;
using Business.Services;
using DataAccess.RepositoryInterfaces;
using DataAccess.Repositories;
using DataAccess;
using Entities.Models;
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

            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
            
            services.AddScoped<ISupplyService, SupplyService>();
            services.AddScoped<ISupplyRepository, SupplyRepository>();
            
            services.AddScoped<ISupplyDetailService, SupplyDetailService>();
            services.AddScoped<ISupplyDetailRepository, SupplyDetailRepository>();
            
            services.AddScoped<IPaymentDetailService, PaymentDetailService>();
            services.AddScoped<IPaymentDetailRepository, PaymentDetailRepository>();

        }
    }
}
