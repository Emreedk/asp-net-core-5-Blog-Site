using BlogProject_DataAccessLayer.Abstract;
using BlogProject_DataAccessLayer.Concrete;
using BlogProject_DataAccessLayer.Repository;
using BlogProject_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_DataAccessLayer.EntityFramework
{
    public class EfMessageRepository : GenericRepository<Message>, IMessageDal
    {
        public List<Message> GetListMessageByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Messages.Include(x => x.SenderUser).Where(x => x.ReceiverId == id).ToList();
            }
        }
    }
}
