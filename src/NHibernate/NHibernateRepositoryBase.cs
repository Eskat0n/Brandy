namespace Brandy.NHibernate
{
    using System.Collections.Generic;
    using System.Linq;
    using Core;
    using global::NHibernate;

    public abstract class NHibernateRepositoryBase<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private readonly ISessionProvider sessionProvider;

        protected NHibernateRepositoryBase(ISessionProvider sessionProvider)
        {
            this.sessionProvider = sessionProvider;
        }

        protected ISession Session
        {
            get { return sessionProvider.CurrentSession; }
        }

        #region IRepository<TEntity> Members

        public virtual void Add(TEntity entity)
        {
            Session.Save(entity);
        }

        public virtual void Remove(TEntity entity)
        {
            Session.Delete(entity);
        }

        public IEnumerable<TEntity> All()
        {
            return Session.QueryOver<TEntity>().List()
                .AsEnumerable();
        }

        public virtual TEntity Get(int id)
        {
            return Session.Get<TEntity>(id);
        }

        #endregion
    }
}
