using System;

namespace Entities.Models
{
    public class OrderDetail:IEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual Order Order { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
