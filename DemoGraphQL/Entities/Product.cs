using System.ComponentModel.DataAnnotations;

namespace DemoGraphQL.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsSelling { get; set; }
        public string Description { get; set; }
    }
}
