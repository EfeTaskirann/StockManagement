using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity, Tcontext> where TEntity : class, new() where Tcontext : DbContext,new()
     {
        public void Delete(TEntity t) { 
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }
        public TEntity GetById(int id)
        {
            using var c = new Context();
            return c.Set<TEntity>().Find(id);
        }
        public List<TEntity> ListAll()
        {
            using var c = new Context();
            return c.Set<TEntity>().ToList();
        }
        public void insert(TEntity t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }
        public void Update(TEntity t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
