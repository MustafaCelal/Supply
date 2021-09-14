namespace Entities.Models
{
    public class OrderPayDetail:IEntity
    {
        public int Id { get; set; }
        public int OrderDetailId { get; set; }
        public decimal RecievedMoney { get; set; }
        public decimal PreviousDept { get; set; }
        public decimal LastDept { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
    }
}
