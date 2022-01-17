using BlogProject_DataAccessLayer.Abstract;
using BlogProject_DataAccessLayer.Concrete;
using BlogProject_DataAccessLayer.Repository;
using BlogProject_EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategoryByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Where(x=> x.WriterId ==id).ToList();
            }
        }

        public List<Blog> GetListWithRelationship()
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).Include(v=> v.Writer).Include(c=> c.Comments).Include(v => v.Likes).ToList();               
            }  
        }     
    }
}
