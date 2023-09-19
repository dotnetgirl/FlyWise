using FlyWise.Domain.Commons;
using FlyWise.Data.IRepositories;

namespace FlyWise.Data.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
{

    public Task<bool> DeleteAsync(long id)
    {
        
        throw new NotImplementedException();
    }

    public Task<TEntity> InsertAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TEntity>> SelectAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> SelectByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
