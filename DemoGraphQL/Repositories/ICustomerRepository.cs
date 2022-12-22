using DemoGraphQL.DB;

namespace DemoGraphQL.Repositories
{
    public interface ICustomerRepository
    {
    }

    public class CustomerRepository: ICustomerRepository
    {
        private readonly SellingDBContext _db;

        public CustomerRepository(SellingDBContext db)
        {
            _db = db;
        }
    }
}
