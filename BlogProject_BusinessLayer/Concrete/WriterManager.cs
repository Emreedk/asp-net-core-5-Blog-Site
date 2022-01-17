using BlogProject_BusinessLayer.Abstract;
using BlogProject_DataAccessLayer.Abstract;
using BlogProject_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void Add(Writer obj)
        {
            _writerDal.Insert(obj);
        }

        public void Delete(Writer obj)
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetListAllById(int id)
        {
            return _writerDal.GetListAll(x=> x.Id == id);
        }

        public void Update(Writer obj)
        {
            throw new NotImplementedException();
        }

     
    }
}
