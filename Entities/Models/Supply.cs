using System;

namespace Entities.Models
{
    public class Supply : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime SupplyDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
