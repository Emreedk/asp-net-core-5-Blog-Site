using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject_EntityLayer.ValueObjects
{
    public class LoginViewModel
    {

        //Login işlemi için Entities.User kullanmak saçma bir durum çünkü bütün özellikler gelir ama giriş için username ve password yeterlidir. Bu sebeple kullanıcı giriş entity(model) için oluşturuldu.

        [DisplayName("Kullanıcı adı"), Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        public string Username { get; set; }

        [DisplayName("Şifre"),
         Required(ErrorMessage = "{0} alanı boş geçilemez."),
         DataType(DataType.Password),
         StringLength(25, ErrorMessage = "{0} max. {1} karakter olmalı.")]
        public string Password { get; set; }
    }
}
