using BlogProject_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_BusinessLayer.Abstract
{
    public interface IMessageService:IGenericService<Message>
    {
        List<Message> GetInboxListByWriter(string p);
    }
}
