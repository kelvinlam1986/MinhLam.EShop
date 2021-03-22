using MinhLam.EShop.Data.Enums;

namespace MinhLam.EShop.Data.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public StatusEnum Status { get; set; }
    }
}
