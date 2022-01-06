using BlogProject_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        void CommentDelete(Comment comment);
        void CommentUpdate(Comment comment);
        List<Comment> GetList(int id);
        Category GetById(int id);
    }
}
