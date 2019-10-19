using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TurkiyeOku.Core.Entities;

namespace TurkiyeOku.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository <T>:IQueryableRepository<T> where T:class, IEntity,new()
    {
        private DbContext _context;
        private DbSet<T> _entities;

        public EfQueryableRepository(DbContext context)
        {
            _context = context;

        }
        public IQueryable<T> Table => this.Entities;

        protected virtual DbSet<T> Entities
        {
            get
            {
                if(_entities == null)
                {
                    return _context.Set<T>();
                }
                return _entities;
            }
        }
    }
}
