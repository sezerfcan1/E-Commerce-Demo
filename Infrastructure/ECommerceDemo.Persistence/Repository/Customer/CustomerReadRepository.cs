using ECommerceDemo.Application.Repositories;
using ECommerceDemo.Domain.Entities;
using ECommerceDemo.Persistence.Contexts;

namespace ECommerceDemo.Persistence.Repository
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ECommerceDemoPostgresqlContext context) : base(context)
        {
        }
    }
}
