using DemoGraphQL.Entities;
using DemoGraphQL.Exceptions;

namespace DemoGraphQL.Mutations
{
    public class OrderMutation
    {
        public async Task AddOrderAsync(Order order)
        {

        }

        //[UseMutationConvention]

        [Error(typeof(UserNameTakenException))]
        [Error(typeof(InvalidUserNameException))]
        public Customer? UpdateCustomerNameAsync([ID] Guid userId, string username)
        {
            //...
            return null;
        }
    }
}
