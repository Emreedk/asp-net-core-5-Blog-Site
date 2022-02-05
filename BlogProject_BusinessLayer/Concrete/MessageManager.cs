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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(Message obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message obj)
        {
            throw new NotImplementedException();
        }

        public Message GetByAuth(string mail)
        {
            throw new NotImplementedException();
        }

        public Message GetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> GetInboxListByWriter(int id)
        {
            return _messageDal.GetListMessageByWriter(id);
        }

        public List<Message> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Message> GetListAllById(int id)
        {
            return _messageDal.GetListAll(x => x.ReceiverId== id);
        }

        public void Update(Message obj)
        {
            throw new NotImplementedException();
        }
    }
}
