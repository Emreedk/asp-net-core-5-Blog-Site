using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        List<T> GetListAll();
        void Insert(T obj);
        void Delete(T obj);
        void Update(T obj);
        T GetById(int id);
        List<T> GetListAll(Expression<Func<T, bool>> filter);

        //IEnumerable<T> Include(params Expression<Func<T, object>>[] includes);
    }
}
