using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RePrjClinicAppoint.Models.Repositories
{
    public interface IRepository<T> : IDisposable  where T : class
    {
        /// <summary>
        /// 全部撈取
        /// </summary>
        List<T> GetAll();
        /// <summary>
        ///  條件撈取 - IQueryable
        ///  具有延遲加載和更豐富的查詢能力，適用於需要進行進一步查詢和篩選的場景。
        /// </summary>
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        /// <summary>
        ///  條件撈取 -   IEnumerable
        ///  一個簡單的可枚舉序列，適用於簡單的數據訪問和遍歷。
        /// </summary>
        IEnumerable<T> FindAllQ();
        /// <summary>
        ///  撈取參數
        /// </summary>
        T GetValue(int id);
        Task<T> GetValueAsync(int id);
        /// <summary>
        ///  撈取參數 條件
        /// </summary>
        Task<T> GetValueAsync(Expression<Func<T, bool>> predicate);      
        /// <summary>
        ///  新增
        /// </summary>
        void Add(T entity);
        Task AddAsync(T entity);
        bool IsExecuteSqlInsert(string sqlQuery, params object[] parameters);
        bool IsExecuteSqlInsert(FormattableString sqlQuery);
        /// <summary>
        ///  更新
        /// </summary>
        void Update(T entity);
        Task UpdateAsync(T entity);
        int ExecuteSqlUpdate(string sqlQuery, params object[] parameters);
        int ExecuteSqlUpdate(FormattableString sqlQuery);
        /// <summary>
        ///  刪除
        /// </summary>
        void Delete(T entity);
        Task DeleteAsync(T entity);
        int ExecuteSqlDelete(string sqlQuery, params object[] parameters);
        int ExecuteSqlDelete(FormattableString sqlQuery);
        /// <summary>
        ///  儲存
        /// </summary>
        void Save();
        Task SaveAsync();
        bool IsExists(Expression<Func<T, bool>> condition);
        Task<bool> IsExistsAsync(Expression<Func<T, bool>> condition);
        
    }
}
