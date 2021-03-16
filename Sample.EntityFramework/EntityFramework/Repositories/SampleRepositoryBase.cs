using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Sample.EntityFramework.Repositories
{
    public abstract class SampleRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SampleDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SampleRepositoryBase(IDbContextProvider<SampleDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SampleRepositoryBase<TEntity> : SampleRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SampleRepositoryBase(IDbContextProvider<SampleDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
