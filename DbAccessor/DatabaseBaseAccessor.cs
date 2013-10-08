using Collabowrite.Shared.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Collabowrite.ResourceAccess.DbAccessor
{
    public abstract class DatabaseBaseAccessor<TEntity> where TEntity : DatabaseBase, new() 
    {
        #region Create
        public virtual TEntity Create(TEntity entity)
        {
            using (var db = new Db())
            {
                entity.UUID = (Guid.NewGuid().ToString());
                db.Set<TEntity>().Add(entity);
                db.SaveChanges();
            }

            return entity;
        }

        public virtual void CreateMany(TEntity[] entities)
        {
            using (var db = new Db())
            {
                foreach (var t in entities)
                {
                    db.Set<TEntity>().Add(t);
                }
                db.SaveChanges();
            }
        }
        #endregion

        #region Read
        public virtual TEntity[] FindAll()
        {

            using (var db = new Db())
            {
                return db.Set<TEntity>().ToArray();
            }
        }

        public virtual TEntity Find(string uuid)
        {
            using (var db = new Db())
            {
                return db.Set<TEntity>().Find(uuid);
            }
        }
        #endregion

        #region Update
        public virtual void Update(TEntity entity)
        {
            using (var db = new Db())
            {
                db.Entry(entity).State = System.Data.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public virtual TEntity UpdateOrCreate(TEntity entity)
        {
            TEntity existing;

            using (var db = new Db())
            {
                existing = db.Set<TEntity>().Find(entity.UUID);
            }

            if (existing == null)
            {
                //-- Insert --
                entity = Create(entity);
            }
            else
            {
                Update(entity);
            }

            return entity;
        }
        #endregion

        #region Delete
        public virtual TEntity Delete(TEntity entity)
        {
            using (var db = new Db())
            {
                db.Set<TEntity>().Remove(entity);
                db.SaveChanges();
            }
            return entity;
        }
        #endregion
    }
}
