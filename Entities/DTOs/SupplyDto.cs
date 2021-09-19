using System;

namespace Entities.DTOs
{
    public class SupplyDto :IDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        /// <summary>
        /// Returns (CustomerCompanyname + customerName)
        /// </summary>
        public string Customer { get; set; }
        public DateTime SupplyDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
