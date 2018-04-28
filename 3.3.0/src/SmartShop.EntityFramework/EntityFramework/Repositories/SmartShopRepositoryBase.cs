using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SmartShop.EntityFramework.Repositories
{
    public abstract class SmartShopRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SmartShopDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SmartShopRepositoryBase(IDbContextProvider<SmartShopDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SmartShopRepositoryBase<TEntity> : SmartShopRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SmartShopRepositoryBase(IDbContextProvider<SmartShopDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
