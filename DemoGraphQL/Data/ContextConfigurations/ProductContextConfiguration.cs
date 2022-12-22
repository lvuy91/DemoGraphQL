using DemoGraphQL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoGraphQL.Data.ContextConfigurations
{
    public class ProductContextConfiguration : IEntityTypeConfiguration<Product>
    {
        private Guid[] _ids;

        public ProductContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var currentTime = DateTime.UtcNow;
            builder
                .HasData(
                new Product
                {
                    CreatedDate = currentTime,
                    Id = Guid.NewGuid(),
                    IsSelling = true,
                    Name = "Pink Skirt",
                    Price = 12,
                    Description = string.Empty,
                    Currency = "VND"
                },
                new Product
                {
                    CreatedDate = currentTime,
                    Id = Guid.NewGuid(),
                    IsSelling = true,
                    Name = "Blue Skirt",
                    Price = 12,
                    Description = string.Empty,
                    Currency = "VND"
                },
                new Product
                {
                    CreatedDate = currentTime,
                    Id = Guid.NewGuid(),
                    IsSelling = true,
                    Name = "Blue Beanie",
                    Price = 12,
                    Description = string.Empty,
                    Currency = "VND"
                }
                );
        }
    }
}
