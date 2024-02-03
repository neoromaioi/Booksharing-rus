using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class WishBookDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Book Title Required")]
        [RegularExpression(@"^([\s.]*([^\s.][\s.]*){3,100})$",ErrorMessage = "Некорректное название")]
        public string BookTitle { get; set; }
        [Required(ErrorMessage ="Book Author Required")]
        [RegularExpression("^[а-яА-Яa-zA-Z]{2,15}(?: [а-яА-Яa-zA-Z]{2,15})$", ErrorMessage = "Некорректное имя")]
        public string BookAuthor { get; set; }
        public virtual ICollection<string> Users { get; set; }
    }
}
