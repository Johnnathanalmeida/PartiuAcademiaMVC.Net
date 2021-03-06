﻿using PartiuAcademia.Core.Repository.Abstract;
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
        
        public void Delete(string Id, string IdUser)
        {
            var entity = Query.First(c => c.Id == Id);
            Context.Entry(entity).State = EntityState.Deleted;
            Context.SaveChanges();
        }

        public void Insert(T entity, string IdUser)
        {
           
            entity.CreationUser = "Julio";
            entity.TerminationUser = "Julio";

            Context.Entry(entity).State = EntityState.Added;
            Context.SaveChanges();
        }



        public void Update(T entity)
        {
            entity.CreationDate = DateTime.Now;
            entity.TerminationDate = DateTime.Now;
            entity.CreationUser = "Julio";
            entity.TerminationUser = "Julio";

            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public T GetById(string Id)
        {
            return Query.FirstOrDefault(c => c.Id == Id);
        }

        public T InsertReturn(T entity, string IdUser)
        {
            entity.CreationDate = DateTime.Now;
            entity.TerminationDate = DateTime.Now;
            entity.CreationUser = "Julio";
            entity.TerminationUser = "Julio";

            Context.Entry(entity).State = EntityState.Added;
             Context.SaveChanges();

            return entity;

        }
    }
}
