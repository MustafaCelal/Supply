using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Seeds
{
    public class CustomerSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            builder.HasData(
                    new Customer
                    {
                        Id = 1,
                        Name = "Customer1",
                        CompanyName = "Adıyaman Çiğköfte Noktası",
                        PhoneNumber = "05550002233",
                        Address = "Address data 1"
                    },
                    new Customer
                    {
                        Id = 2,
                        Name = "Customer2",
                        CompanyName = "Çiğköfte Ltd Şti",
                        PhoneNumber = "05551116611",
                        Address = "Address data 2"
                    }
                ); 
        }
    
    }
    
}
