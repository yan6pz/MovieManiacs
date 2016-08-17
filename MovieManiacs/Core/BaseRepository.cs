using Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Core
{
    public abstract class BaseRepository : IBaseRepository
    {
        private MovieManiacsContext _context;

        public MovieManiacsContext Context
        {
            get { return _context; }
            set { _context = value; }
        }

        public BaseRepository(MovieManiacsContext context)
        {
            _context = context;
        }

        public virtual int SaveChanges()
        {
            return this.Context.SaveChanges();
        }

        public virtual Task<int> SaveChangesAsync()
        {
            return this.Context.SaveChangesAsync();
        }

    }

    public abstract class BaseRepository<TEntity> : BaseRepository, IBaseRepository<TEntity> where TEntity : class
    {
        public BaseRepository(MovieManiacsContext context)
            : base(context)
        { }

        private DbSet<TEntity> objectSet;

        private DbSet<TEntity> ObjectSet
        {
            get
            {
                if (this.objectSet == null)
                {
                    this.objectSet = this.Context.Set<TEntity>();
                }

                return this.objectSet;
            }
        }

        public virtual void Add(TEntity entity)
        {
            this.ObjectSet.Add(entity);
        }

        public virtual void Add(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                this.ObjectSet.Add(entity);
            }
        }

        public virtual void Attach(TEntity entity)
        {
            var localEntity = this.ObjectSet.Local.FirstOrDefault();
            this.ObjectSet.Attach(entity);
        }


        public virtual int Create(TEntity entity)
        {
            this.ObjectSet.Add(entity);

            return this.SaveChanges();
        }

        public virtual Task<int> CreateAsync(TEntity entity)
        {
            this.ObjectSet.Add(entity);

            return this.SaveChangesAsync();
        }


        public virtual void Create(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                this.ObjectSet.Add(entity);
            }

            this.SaveChanges();
        }

        public IList<TEntity> GetAll()
        {
            return this.ObjectSet.ToList();
        }

        public int Delete(TEntity entity)
        {
            DeleteWithoutSave(entity);
            return this.SaveChanges();
        }

        public int Delete(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                DeleteWithoutSave(entity);
            }
            
            return this.SaveChanges();
        }

        public virtual void DeleteWithoutSave(TEntity entity)
        {
            this.ObjectSet.Remove(entity);
        }
    }
}





