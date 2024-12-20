namespace poster_site.DAL.Interfaces;

interface IRepository<T> : IDisposable where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
    Task<int> GetTotalCountAsync();
}