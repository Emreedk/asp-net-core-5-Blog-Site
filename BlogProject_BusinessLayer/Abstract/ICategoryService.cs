using BlogProject_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void CategoryAdd(Category category);
        void CategoryDelete(Category category);
        void CategoryUpdate(Category category);
        List<Category> GetList();
        Category GetById(int id);

        //IEnumerable<Category> Include(params Expression<Func<Category, object>>[] includes);
    }
}
