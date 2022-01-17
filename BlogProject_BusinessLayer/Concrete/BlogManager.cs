using BlogProject_BusinessLayer.Abstract;
using BlogProject_DataAccessLayer.Abstract;
using BlogProject_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog obj)
        {
            _blogDal.Insert(obj);
        }

        public void Delete(Blog obj)
        {
            _blogDal.Delete(obj);
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterId == id);
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetListWithRelationship()
        {
            return _blogDal.GetListWithRelationship();
        }

        public List<Blog> GetListWithCategoryByWriter(int id)
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }

        public void Update(Blog obj)
        {
            _blogDal.Update(obj);
        }

        public List<Blog> GetListAllById(int id)
        {
            return _blogDal.GetListAll(x => x.Id == id);
        }


        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetListAll().Take(3).ToList();
        }
        

    }
}
