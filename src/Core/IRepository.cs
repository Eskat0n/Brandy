namespace Brandy.Core
{
    using System.Collections.Generic;

    public interface IRepository<TEntity>
        where TEntity : class
    {
        void Add(TEntity entity);
        void Remove(TEntity entity);
        IEnumerable<TEntity> All();
        TEntity Get(int id);
    }
}