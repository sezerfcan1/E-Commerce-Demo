using ECommerceDemo.Application.Repositories;
using ECommerceDemo.Domain.Entities.Common;
using ECommerceDemo.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceDemo.Persistence.Repository
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ECommerceDemoPostgresqlContext _context;

        public ReadRepository(ECommerceDemoPostgresqlContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
            => Table.Where(expression);

        public Task<T> GetByIdAsync(string id)
            => Table.FirstOrDefaultAsync(q => q.Id == Guid.Parse(id));

        public Task<T> GetSingleAsync(Expression<Func<T, bool>> expression)
            => Table.FirstOrDefaultAsync(expression);


    }
}
