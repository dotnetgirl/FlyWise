namespace FlyWise.Data.IRepositories;

public interface IRepository<TEntity>
{
    public Task<bool> DeleteAsync(long id);
    public Task<TEntity> SelectByIdAsync(long id);
    public Task<bool> InsertAsync(TEntity entity);
    public Task<bool> UpdateAsync(TEntity entity);
    public Task<IEnumerable<TEntity>> SelectAllAsync();
}
