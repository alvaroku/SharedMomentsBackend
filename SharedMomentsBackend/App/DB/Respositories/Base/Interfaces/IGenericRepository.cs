using SharedMomentsBackend.App.Models.DTOs;
using System.Linq.Expressions;

namespace SharedMomentsBackend.App.DB.Respositories.Base.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task<T> GetById(Guid id, string includeProperties = "");
        Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter, string includeProperties = "");
        Task<IEnumerable<T>> GetAll(
            Expression<Func<T, bool>> filter = null,
            PaginateParams paginateParams = null, string includeProperties = ""
            );
        Task<PaginateResponse<T>> GetPaginate(Expression<Func<T, bool>> filter,
            PaginateParams paginateParams, string includeProperties = "");
        Task<int> Count(
            Expression<Func<T, bool>> filter
            );
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(Guid id);
        Task Delete(T entity);
        Task DeleteRange(IEnumerable<T> data);
        Task<bool> Exists(Expression<Func<T, bool>> expression);
        Task CreateRange(IEnumerable<T> Data);
        Task UpdateRange(IEnumerable<T> Data);
        Task DeleteAll();
    }
}
