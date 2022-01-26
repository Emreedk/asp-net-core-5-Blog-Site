using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_EntityLayer.Concrete
{
    public class Writer
    {
        
        public int Id { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterUserName { get; set; }
        public string WriterMail { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }

        public List<Blog> Blogs { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Like> Likes { get; set; }

        public virtual ICollection<Message> WriterSender { get; set; }
        public virtual ICollection<Message> WriterReceiver { get; set; }



    }
}
