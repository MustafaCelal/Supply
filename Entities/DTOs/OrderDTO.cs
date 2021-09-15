namespace Entities.DTOs
{
    // for using in orderDetail
    public class OrderDTO : IDto
    {
        public int Id { get; set; }
        //public int OrderDetailId { get; set; }
        public int ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }
}
