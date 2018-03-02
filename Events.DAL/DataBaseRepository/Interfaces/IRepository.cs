using System;
using System.Collections.Generic;
using System.Text;

namespace Events.DAL.DataBaseRepository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Insert(T entity);
        T Update(T entity);
        void Delete(T entity);
        T GetOne(Guid id);
        List<T> GetAll();
    }
}
