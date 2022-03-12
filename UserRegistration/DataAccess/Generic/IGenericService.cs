using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Generic
{
  public  interface IGenericService<T> where T:class
    {
        void Insert(T obj);
        List<T> GetTs();
        T Edit(int id);
        void Update(T obj);
        void DeleteById(int id);
    }
}
