using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IBaseRepository
    {
            int SaveChanges();


    }

    public interface IBaseRepository<TEntity> : IBaseRepository where TEntity : class
    {
        void Add(IEnumerable<TEntity> entities);
        void Add(TEntity entity);
        void Attach(TEntity entity);
        void Create(IEnumerable<TEntity> entities);
        int Create(TEntity entity);
        IList<TEntity> GetAll();
        int Delete(IEnumerable<TEntity> entities);
        int Delete(TEntity entity);

    }
}
