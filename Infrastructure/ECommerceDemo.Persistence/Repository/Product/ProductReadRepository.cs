using ECommerceDemo.Application.Repositories;
using ECommerceDemo.Domain.Entities;
using ECommerceDemo.Persistence.Contexts;

namespace ECommerceDemo.Persistence.Repository
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ECommerceDemoPostgresqlContext context) : base(context)
        {
        }
    }
}
