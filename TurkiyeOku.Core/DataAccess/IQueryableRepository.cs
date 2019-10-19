using System;
using System.Linq;
using TurkiyeOku.Core.Entities;

namespace TurkiyeOku.Core.DataAccess
{
    public interface IQueryableRepository<T> where T:class, IEntity,new()
    {
        IQueryable<T> Table { get; }
    }
}
