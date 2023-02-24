using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace test2.EntityFramework.Repositories
{
    public abstract class test2RepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<test2DbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected test2RepositoryBase(IDbContextProvider<test2DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class test2RepositoryBase<TEntity> : test2RepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected test2RepositoryBase(IDbContextProvider<test2DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
