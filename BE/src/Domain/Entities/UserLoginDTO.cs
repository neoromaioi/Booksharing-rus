using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class UserLoginDTO
    {
        [Required(ErrorMessage = "{0} обязательное")]
        [Display(Name = "Никнейм")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} обязательное")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}
