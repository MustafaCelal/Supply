using System;

namespace Entities.DTOs.PaymentDetailDTOs
{
    public class PaymentDetailDto:IDto
    {
        public int Id { get; set; }
        // If wants to go to the Supply detail, the supplyId should be returned.
        public int SupplyId { get; set; }
        public DateTime SupplyDate { get; set; }
        public decimal Price { get; set; }
        public decimal PreviousDept { get; set; }
        public decimal RecievedMoney { get; set; }
        public decimal RemainingDept { get; set; }

    }
}
