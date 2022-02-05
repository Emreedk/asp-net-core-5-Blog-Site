using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Add(T obj);
        void Delete(T obj);
        void Update(T obj);
        List<T> GetList();
        T GetById(int id);

        T GetByAuth(string mail);
        List<T> GetListAllById(int id);

    }
}
