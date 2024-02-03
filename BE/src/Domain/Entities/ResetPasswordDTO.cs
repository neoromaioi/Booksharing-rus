using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ResetPasswordDTO
    {
        [Required(ErrorMessage = "{0} обязательное")]
        [StringLength(255, ErrorMessage = "{0} длина не должна превышать 255 символов")]
        [EmailAddress(ErrorMessage = "Неверный адрес электронной почты")]
        [Display(Name = "Электронная почта")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} обязательное")]
        [StringLength(255, MinimumLength = 8, ErrorMessage = "{0} длина должна быть от 8 до 255 символов")]
        [RegularExpression(@"[a-zA-Z0-9]*", ErrorMessage = "{0} должно содержать только буквы и цифры")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Пароль", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
        public string Token { get; set; }
    }
}
