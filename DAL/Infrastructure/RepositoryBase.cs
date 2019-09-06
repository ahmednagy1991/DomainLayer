using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace DAL.Infrastructure
{
    public abstract class RepositoryBase<T> where T : class
    {
        #region Properties
        private StoreEntities dataContext;
        IUnitOfWork _unitOfWork;
        private readonly IDbSet<T> dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected StoreEntities DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }
        #endregion

        protected RepositoryBase(IDbFactory dbFactory, IUnitOfWork unitOfWork)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<T>();
            _unitOfWork = unitOfWork;


        }

        #region Implementation
        public virtual T Add(T entity)
        {
            var model = dbSet.Add(entity);
            _unitOfWork.Commit();
            return model;
        }

        public virtual T UpdateItem(T entity)
        {
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
          
            return entity;
        }

        public virtual void DeleteItem(T entity)
        {
            dbSet.Remove(entity);
           
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbSet.Remove(obj);
          
        }

        public virtual T GetId(long id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).ToList();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault<T>();
        }

        #endregion

    }
}
