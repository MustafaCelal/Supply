namespace Entities.Models
{
    public class Order:IEntity
    {
        public int Id { get; set; }
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        //public virtual Product Product { get; set; }
        //public virtual OrderDetail OrderDetail { get; set; }
    }

    //public class Order:IEntity
    //{
    //    public int Id { get; set; }
    //    public int OrderDetailId { get; set; }
    //    public int ProductId { get; set; }
    //    public int Quantity { get; set; }
    //    public decimal Price { get; set; }
    //    //public virtual Product Product { get; set; }
    //    //public virtual OrderDetail OrderDetail { get; set; }
    //}
}
