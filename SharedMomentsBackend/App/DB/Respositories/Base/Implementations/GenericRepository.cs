using Microsoft.EntityFrameworkCore;
using SharedMomentsBackend.App.DB.Respositories.Base.Interfaces;
using SharedMomentsBackend.App.Extensions;
using SharedMomentsBackend.App.Models.DTOs;
using SharedMomentsBackend.App.Models.Entities;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SharedMomentsBackend.App.DB.Respositories.Base.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected GenericRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<T> GetById(Guid id, string includeProperties = "")
        {
            IQueryable<T> query = _unitOfWork.Context.Set<T>();

            // Aplicar los includes
            foreach (var includeProperty in includeProperties.Split
                   (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
            return await query.FirstOrDefaultAsync(x => (x as BaseEntity).Id == id);
        }
        public async Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter, string includeProperties = "")
        {
            IQueryable<T> query = _unitOfWork.Context.Set<T>();

            // Aplicar los includes
            foreach (var includeProperty in includeProperties.Split
                   (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
            
            return await query.FirstOrDefaultAsync(filter);
        }
        public async Task<IEnumerable<T>> GetAll(
            Expression<Func<T, bool>> filter=null,
            PaginateParams paginateParams=null, string includeProperties = ""
            )
        {
            IQueryable<T> query = _unitOfWork.Context.Set<T>();

            // Aplicar los includes
            foreach (var includeProperty in includeProperties.Split
                   (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            // Aplicar el filtro
            if (filter != null)
            {
                query = query.Where(filter);
            }

            // Aplicar la paginación
            if(paginateParams is not null)
            {
                query = query.Skip((paginateParams.PageNumber - 1) * paginateParams.PageSize)
                         .Take(paginateParams.PageSize);
            }

            return await query.ToListAsync();
        }
        public async Task<PaginateResponse<T>> GetPaginate(Expression<Func<T, bool>> filter,
            PaginateParams paginateParams, string includeProperties = "")
        {
            PaginateResponse<T> paginateResult = new PaginateResponse<T>();
            paginateResult.PageSize = paginateParams.PageSize;
            paginateResult.PageNumber = paginateParams.PageNumber;

            paginateResult.PageNumber = paginateParams.PageNumber;
            paginateResult.PageSize = paginateParams.PageSize;
            int totalRecords = await Count(filter);
            int totalPages = (int)Math.Ceiling(totalRecords / (double)paginateParams.PageSize);
            paginateResult.TotalRecords = totalRecords;
            paginateResult.TotalPages = totalPages;

            paginateResult.List = await GetAll(filter, paginateParams, includeProperties);
            return paginateResult;

        }
        public async Task<int> Count(Expression<Func<T, bool>> filter)
        {
            return await _unitOfWork.Context.Set<T>().CountAsync(filter);
        }
        public async Task Add(T entity)
        {
            await _unitOfWork.Context.Set<T>().AddAsync(entity);
            await _unitOfWork.Commit();
        }

        public async Task Update(T entity)
        {
            _unitOfWork.Context.Set<T>().Update(entity);
            await _unitOfWork.Commit();
        }

        public async Task Delete(Guid id)
        {
            var entity = await GetById(id);
            _unitOfWork.Context.Set<T>().Remove(entity);
            await _unitOfWork.Commit();
        }

        public async Task DeleteRange(IEnumerable<T> data)
        {
            _unitOfWork.Context.Set<T>().RemoveRange(data);
            await _unitOfWork.Commit();
        }

        public async Task<bool> Exists(Expression<Func<T, bool>> expression)
        {
            return await _unitOfWork.Context.Set<T>().AnyAsync(expression);
        }

        public async Task CreateRange(IEnumerable<T> Data)
        {
            await _unitOfWork.Context.Set<T>().AddRangeAsync(Data);
            await _unitOfWork.Commit();
        }

        public async Task UpdateRange(IEnumerable<T> Data)
        {
            _unitOfWork.Context.Set<T>().UpdateRange(Data);
            await _unitOfWork.Commit();
        }

        public async Task DeleteAll()
        {
            _unitOfWork.Context.Set<T>().RemoveRange(_unitOfWork.Context.Set<T>());
            await _unitOfWork.Commit();
        }
    }
}
