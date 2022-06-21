using ECommerceDemo.Application.Repositories;
using ECommerceDemo.Domain.Entities;
using ECommerceDemo.Persistence.Contexts;

namespace ECommerceDemo.Persistence.Repository
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ECommerceDemoPostgresqlContext context) : base(context)
        {
        }
    }
}
