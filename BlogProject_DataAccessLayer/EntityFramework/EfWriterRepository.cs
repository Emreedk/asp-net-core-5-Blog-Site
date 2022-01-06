using BlogProject_DataAccessLayer.Abstract;
using BlogProject_DataAccessLayer.Repository;
using BlogProject_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_DataAccessLayer.EntityFramework
{
    public class EfWriterRepository:GenericRepository<Writer>,IWriterDal
    {
    }
}
