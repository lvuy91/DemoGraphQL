using DemoGraphQL.DB;

namespace DemoGraphQL.Repositories
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : IProductRepository
    {
        private readonly SellingDBContext _db;

        public ProductRepository(SellingDBContext db)
        {
            _db = db;
        }
    }
}
