using System.Linq;

namespace RePrjClinicAppoint.Models.DAL
{
    public abstract class DataAccessLayer<T> where T : DentalEntityAbstract
    {
        //DATA Field
        private protected readonly DentalDbContext _dbContext;
        //DI
        public DataAccessLayer(DentalDbContext dentalDbContext)
        {
            this._dbContext = dentalDbContext;
        }
        /// <summary>
        /// 獲取實體查詢
        /// </summary>
        /// <param name="isTracking"></param>
        /// <returns></returns>
        public abstract IQueryable<T> GetEntitiesQuery(bool isTracking = true);
    }
}
