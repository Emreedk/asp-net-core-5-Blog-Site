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
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDal
    {
        public List<Category> GetListWithRelationship()
        {
            using (var c = new Context())
            {
                return c.Categories.Include(v => v.Blogs).ToList();
            }
        }
    }
}
