using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Generic
{
  public  class GenericService<T> : IGenericService<T> where T:class
    {
        UserContext context;
        public GenericService()
        {
            context = new UserContext();
        }
        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }
        public List<T> GetTs()
        {
          return  context.Set<T>().ToList();
        }
        public T Edit(int id)
        {
           T obj=  context.Set<T>().Find(id);
            return obj;

        }
        public void Update(T obj)
        {
            context.Set<T>().Attach(obj);
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteById(int id)
        {
            T obj = context.Set<T>().Find(id);
            context.Set<T>().Remove(obj);
            context.SaveChanges();
        }

    }
}
