using BlogProject_BusinessLayer.Abstract;
using BlogProject_DataAccessLayer.Abstract;
using BlogProject_DataAccessLayer.EntityFramework;
using BlogProject_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category obj)
        {
            _categoryDal.Insert(obj);
        }

        public void Delete(Category obj)
        {
            _categoryDal.Delete(obj);
        }

        public Category GetByAuth(string mail)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }

        public List<Category> GetListAllById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetListWithRelationship()
        {
            return _categoryDal.GetListWithRelationship();
        }

        public void Update(Category obj)
        {
            _categoryDal.Update(obj);
        }


        //Generic yapmadan önce
        //public void CategoryAdd(Category category)
        //{
        //    _categoryDal.Insert(category);
        //}

        //public void CategoryDelete(Category category)
        //{
        //    _categoryDal.Delete(category);

        //}

        //public void CategoryUpdate(Category category)
        //{
        //    _categoryDal.Update(category);

        //}

        //public Category GetById(int id)
        //{

        //    return _categoryDal.GetById(id);
        //}

        //public List<Category> GetList()
        //{
        //    return _categoryDal.GetListAll();

        //}

        //public IEnumerable<Category> Include(params Expression<Func<Category, object>>[] includes)
        //{
        //    return _categoryDal.Include(includes);

        //}  
    }
}
