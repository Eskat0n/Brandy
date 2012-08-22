namespace Brandy.NHibernate
{
    public sealed class NHibernateRepository<TEntity> : NHibernateRepositoryBase<TEntity>
        where TEntity : class
    {
        public NHibernateRepository(ISessionProvider sessionProvider)
            : base(sessionProvider)
        {
        }
    }
}
