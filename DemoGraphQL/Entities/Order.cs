using DemoGraphQL.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoGraphQL.Entities
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        [Required]
        [ForeignKey("CustomerId")]
        public Guid CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public List<Guid> ProductIds { get; set; }
    }
}
