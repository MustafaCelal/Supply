namespace Entities.DTOs.CustomerDTos
{
    public class CustomerListDto:IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
