using PartiuAcademia.Core.Repository.Abstract;
using PartiuAcademia.Core.Repository.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiuAcademia.Core.Repository.Concrete
{
    class BaseRepository<T> : IRepository<T> where T : Entities.EntityBase
    {
        protected PartiuAcademiaContext Context;


        public BaseRepository(PartiuAcademiaContext contextParam)
        {
            Context = contextParam;
        }

        public IQueryable<T> Query { 
           get {
               return from c in Context.Set<T>() select c;
           }            
        }        
        
        public void Delete(string id)
        {
            var entity = Query.First(c => c.id == id);
            Context.Entry(entity).State = EntityState.Deleted;
            Context.SaveChanges();
        }

        public void Insert(T entity)
        {
            entity.CreationDate = DateTime.Now;
            Context.Entry(entity).State = EntityState.Added;
            Context.SaveChanges();
        }

        public void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public T GetById(string id)
        {
            return Query.FirstOrDefault(c => c.id == id);
        }
    }
}
