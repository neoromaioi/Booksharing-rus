using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Persistance
{
    public class Language
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
/*
SET IDENTITY_INSERT [BookSharingDev].[dbo].[Languages] OFF;
INSERT INTO [BookSharingDev].[dbo].[Languages](Name)
VALUES
(N'Русский'),
(N'Английский'),
(N'Белорусский'),
(N'Украинский'),
(N'Французский'),
(N'Немецкий'),
(N'Испанский'),
(N'Итальянский'),
(N'Португальский'),
(N'Польский'),
(N'Норвежский'),
(N'Арабский'),
(N'Японский'),
(N'Китайский'),
(N'Корейский') 
 */