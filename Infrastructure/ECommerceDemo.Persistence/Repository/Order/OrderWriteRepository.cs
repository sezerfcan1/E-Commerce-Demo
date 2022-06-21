using ECommerceDemo.Application.Repositories;
using ECommerceDemo.Domain.Entities;
using ECommerceDemo.Persistence.Contexts;

namespace ECommerceDemo.Persistence.Repository
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ECommerceDemoPostgresqlContext context) : base(context)
        {
        }
    }
}
