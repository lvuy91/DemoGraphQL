using DemoGraphQL.DB;

namespace DemoGraphQL.Repositories
{
    public interface IOrderRepository
    {
    }

    public class OrderRepository: IOrderRepository
    {
        private readonly SellingDBContext _db;

        public OrderRepository(SellingDBContext db)
        {
            _db = db;
        }
    }
}
