namespace Entities.Models
{
    public class PaymentDetail : IEntity
    {
        public int Id { get; set; }
        public int SupplyId { get; set; }
        public decimal PreviousDept { get; set; }
        public decimal RecievedMoney { get; set; }
        public decimal RemainingDept { get; set; }
        // when i want to see the history
        // i might change the supplyId to supplyTotalprice and supplyDate        
    }
}
