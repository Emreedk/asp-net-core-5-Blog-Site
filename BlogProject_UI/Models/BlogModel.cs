using BlogProject_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_UI.Models
{
    public class BlogModel
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 20, ErrorMessage = "Blog Başlığı en az 20 karakter olmalıdır.")]
        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz")]
        public string BlogTitle { get; set; }
        //public string BlogThumbnailImage { get; set; }

        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz")]

        public string BlogImage { get; set; }

        [Required(ErrorMessage = "Bu alanı boş geçemezsiniz")]
        [StringLength(500, MinimumLength = 50, ErrorMessage = "Blog Başlığı en az 50 karakter olmalıdır.")]

        public string BlogContent { get; set; }

        public int CategoryId { get; set; }

    }
}
