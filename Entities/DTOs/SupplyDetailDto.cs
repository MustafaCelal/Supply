using System;

namespace Entities.DTOs
{
    public class SupplyDetailDto:IDto
    {
        public int Id { get; set; }

        public int SupplyId { get; set; }
        public DateTime SupplyDate { get; set; }
        
        public int ProductId { get; set; }      
        public string ProductName { get; set; }
        
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
