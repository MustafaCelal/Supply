using System;
using System.Collections.Generic;

namespace Entities.DTOs
{
    // for expanded view
    public class OrderDetailDTO : IDto
    {
        public int Id { get; set; }
        public ICollection<OrderDTO> Orders { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCompany { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
