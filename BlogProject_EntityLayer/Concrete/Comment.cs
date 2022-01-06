using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_EntityLayer.Concrete
{
    public class Comment
    {
        
        public int Id { get; set; }
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public int WriterId { get; set; }
        public Writer Writer { get; set; }



    }
}
