using ECommerceDemo.Application.Repositories;
using ECommerceDemo.Domain.Entities;
using ECommerceDemo.Persistence.Contexts;

namespace ECommerceDemo.Persistence.Repository
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ECommerceDemoPostgresqlContext context) : base(context)
        {
        }
    }
}
