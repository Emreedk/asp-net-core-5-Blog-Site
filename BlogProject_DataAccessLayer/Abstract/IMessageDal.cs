using BlogProject_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_DataAccessLayer.Abstract
{
    public interface IMessageDal:IGenericDal<Message>
    {
        List<Message> GetListMessageByWriter(int id);
    }
}
