using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_EntityLayer.Concrete
{
    public class Like
    {
        [Key]
        public int Id { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public int WriterId { get; set; }
        public Writer Writer { get; set; }
    }
}
