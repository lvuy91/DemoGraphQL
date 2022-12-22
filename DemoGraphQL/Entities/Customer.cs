using System.ComponentModel.DataAnnotations;

namespace DemoGraphQL.Entities
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string IdentityId { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
