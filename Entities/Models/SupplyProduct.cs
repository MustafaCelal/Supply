namespace Entities.Models
{
    public class SupplyProduct : IEntity
    {
        public int Id { get; set; }
        public int SupplyId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
