using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ResponsePendingRequestDTO
    {
        public int Id { get; set; }
        [RegularExpression(@"^[а-яА-Яa-zA-Z]{2,15}(?: [а-яА-Яa-zA-Z]{2,15})$")]
        public string Author { get; set; }
    }
}
