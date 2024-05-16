using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserEditingDTO
    {
        public UserEditingDTO(string firstName="Default", string lastName="Defaultt", string userName="default", string email="default@mail.ru", string password = "", string newPassword = "")
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Email = email;
            Password = password;
            NewPassword = newPassword;
        }

        [Required(ErrorMessage = "{0} обязательное")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} длина должна быть от 3 до 50 символов")]
        [RegularExpression(@"[\p{L}]*", ErrorMessage = "{0} должно содержать только буквы и цифры")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} обязательное")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} длина должна быть от 3 до 50 символов")]
        [RegularExpression(@"[\p{L}]*", ErrorMessage = "{0} должно содержать только буквы и цифры")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "{0} обязательное")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} длина должна быть от 3 до 50 символов")]
        [RegularExpression(@"[a-zA-Z0-9]*", ErrorMessage = "{0} должно содержать только буквы и цифры")]
        [Display(Name = "Никнейм")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} обязательное")]
        [StringLength(255, ErrorMessage = "{0} длина не должна превышать 255 символов")]
        [EmailAddress(ErrorMessage = "Неверный адрес электронной почты")]
        [Display(Name = "Электронная почта")]
        public string Email { get; set; }

        /*[StringLength(255, MinimumLength = 8, ErrorMessage = "{0} длина должна быть от 8 до 255 символов")]
        [RegularExpression(@"[a-zA-Z0-9]*", ErrorMessage = "{0} должно содержать только буквы и цифры")]*/
        [Display(Name = "Пароль (опционально)")]
        public string Password { get; set; }

        /*[StringLength(255, MinimumLength = 8, ErrorMessage = "{0} длина должна быть от 8 до 255 символов")]
        [RegularExpression(@"[a-zA-Z0-9]*", ErrorMessage = "{0} должно содержать только буквы и цифры")]*/
        [Display(Name = "Новый пароль (опционально)")]
        public string NewPassword { get; set; }
    }
}
