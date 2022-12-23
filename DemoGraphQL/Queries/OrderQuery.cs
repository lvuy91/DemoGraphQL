using DemoGraphQL.Entities;
using DemoGraphQL.Enums;

namespace DemoGraphQL.Queries
{
    public class OrderQuery
    {
        public Order GetOrder() =>
            new()
            {
                CreatedDate = DateTime.Now,
                CustomerId = Guid.NewGuid(),
                Id = Guid.NewGuid(),
                OrderStatus = OrderStatus.New,
                PaymentStatus = PaymentStatus.PayLatter,
                ProductIds = new List<Guid> { Guid.NewGuid() },
            };
    }

    //public class Query
    //{
    //    public Book GetBook() =>
    //        new Book
    //        {
    //            Title = "C# in depth.",
    //            Author = new Author
    //            {
    //                Name = "Jon Skeet"
    //            }
    //        };
    //}
}
