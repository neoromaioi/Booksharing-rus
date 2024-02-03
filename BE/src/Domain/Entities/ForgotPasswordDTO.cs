using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ForgotPasswordDTO
    {
        [Required(ErrorMessage = "{0} обязательное")]
        [StringLength(255, ErrorMessage = "{0} длина не должна превышать 255 символов")]
        [EmailAddress(ErrorMessage = "Неверный адрес электронной почты")]
        [Display(Name = "Электронная почта")]
        public string Email { get; set; }
    }
}
