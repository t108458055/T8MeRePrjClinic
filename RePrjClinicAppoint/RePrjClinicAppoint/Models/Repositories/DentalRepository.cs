using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RePrjClinicAppoint.Models.Repositories
{
    /// <summary>
    /// 診所儲存庫
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DentalRepository<T> : IRepository<T>, IDisposable where T :class
    {
        /// <summary>
        /// 資料庫的東東 - Data Field
        /// </summary>
        private readonly DentalDbContext _dentalDbContext;
        /// <summary>
        ///  注入 - DI
        /// </summary>
        public DentalRepository(DentalDbContext dentalDbContext)
        {
            this._dentalDbContext = dentalDbContext;
        }
        /// <summary>
        /// 單一物件加入
        /// </summary>
        public void Add(T entity)
        {
            try
            {
                _dentalDbContext.Set<T>().Add(entity);
                _dentalDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 單一物件加入
        /// </summary>
        public async Task AddAsync(T entity)
        {
            try
            {
                await  _dentalDbContext.Set<T>().AddAsync(entity);
                await  _dentalDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 單一物件刪除
        /// </summary>
        public void Delete(T entity)
        {
            try
            {
                var entry = _dentalDbContext.Set<T>().DefaultIfEmpty(entity);
                if (entry != null) 
                {
                    _dentalDbContext.Set<T>().Remove(entity);
                    _dentalDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 單一物件刪除
        /// </summary>
        public async Task DeleteAsync(T entity)
        {
            try
            {
                var entry = _dentalDbContext.Set<T>().DefaultIfEmpty(entity);
                if (entry != null)
                {
                     _dentalDbContext.Set<T>().Remove(entity);
                    await _dentalDbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// 執行刪除 (sqlQuery)
        /// </summary>
        public int ExecuteSqlDelete(string sqlQuery, params object[] parameters)
        {
            try
            {
                int affectedRows =_dentalDbContext.Database.ExecuteSqlRaw(sqlQuery, parameters);
                return affectedRows;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        /// <summary>
        /// 執行刪除 (sqlQuery)
        /// </summary>
        public int ExecuteSqlDelete(FormattableString sqlQuery)
        {
            try
            {
                int affectedRows = _dentalDbContext.Database.ExecuteSqlInterpolated(sqlQuery);
                return affectedRows;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int ExecuteSqlUpdate(string sqlQuery, params object[] parameters)
        {
            try
            {
                int affectedRows = _dentalDbContext.Database.ExecuteSqlRaw(sqlQuery, parameters);
                return affectedRows;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int ExecuteSqlUpdate(FormattableString sqlQuery)
        {
            try
            {
                int affectedRows = _dentalDbContext.Database.ExecuteSqlInterpolated(sqlQuery);
                return affectedRows;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        /// <summary>
        /// 查詢資料 - ALL
        /// </summary>
        public IQueryable<T> FindAll()
        {
            try
            {
                 return _dentalDbContext.Set<T>();
            }
            catch (Exception)
            {
                 return Enumerable.Empty<T>().AsQueryable();
            }
        }
        /// <summary>
        /// 查詢資料 - ALL
        /// </summary>
        public IEnumerable<T> FindAllQ()
        {
            try
            {
                return _dentalDbContext.Set<T>();
            }
            catch (Exception)
            {
                return Enumerable.Empty<T>().AsQueryable();
            }
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
                try
                {
                           return _dentalDbContext.Set<T>().Where(expression);
                }
                catch (Exception)
                {
                            throw;
                }
        }

        public List<T> GetAll()
        {
            try
            {
                return _dentalDbContext.Set<T>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T GetValue(int id)
        {
            try
            {
                return _dentalDbContext.Set<T>().Find(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public T GetValue(Func<T, bool> predicate)
        {
            try
            {
                return _dentalDbContext.Set<T>().FirstOrDefault(predicate);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<T> GetValueAsync(int id)
        {
            try
            {
                return await _dentalDbContext.Set<T>().FindAsync(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<T> GetValueAsync(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return await _dentalDbContext.Set<T>().FirstOrDefaultAsync(predicate);
            }
            catch (Exception)
            {
                return null;                
            }
        }

        public bool IsExecuteSqlInsert(string sqlQuery, params object[] parameters)
        {
            try
            {
                 _dentalDbContext.Database.ExecuteSqlRaw(sqlQuery, parameters);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsExecuteSqlInsert(FormattableString sqlQuery)
        {
            try
            {
                _dentalDbContext.Database.ExecuteSqlInterpolated(sqlQuery);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool IsExists(Expression<Func<T, bool>> condition)
        {
            return _dentalDbContext.Set<T>().Any(condition);
        }

        public async Task<bool> IsExistsAsync(Expression<Func<T, bool>> condition)
        {
            return await _dentalDbContext.Set<T>().AnyAsync(condition);
        }

        public void Save()
        {
            try
            {
                _dentalDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task SaveAsync()
        {
            try
            {
                await _dentalDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(T entity)
        {
            try
            {
                _dentalDbContext.Entry(entity).State = EntityState.Modified;
                _dentalDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
               _dentalDbContext.Entry(entity).State = EntityState.Modified;
                await   _dentalDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
                if (disposing && _dentalDbContext != null)
                {
                    _dentalDbContext.Dispose();
                }
        }


    }
}
