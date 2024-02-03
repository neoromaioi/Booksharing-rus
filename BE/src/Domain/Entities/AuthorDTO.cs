using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class AuthorDTO
    {
        [Required(ErrorMessage = "Обязательное")]
        [RegularExpression("^([а-яА-Яa-zA-Z0-9 .&'-]+)$", ErrorMessage = "Неверное имя")]
        public string FullName { get; set; }
    }
}
