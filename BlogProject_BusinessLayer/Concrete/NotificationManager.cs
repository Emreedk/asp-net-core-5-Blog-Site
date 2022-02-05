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
    public class NotificationManager : INotificationService
    {
        INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void Add(Notification obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Notification obj)
        {
            throw new NotImplementedException();
        }

        public Notification GetByAuth(string mail)
        {
            throw new NotImplementedException();
        }

        public Notification GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetList()
        {
            return _notificationDal.GetListAll();
        }

        public List<Notification> GetListAllById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Notification obj)
        {
            throw new NotImplementedException();
        }
    }
}
