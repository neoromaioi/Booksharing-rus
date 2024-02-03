using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Persistance
{
    public class Genre
    {
        public int Id { get; set; }
        [Required, MaxLength(30)]
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}

/*
SET IDENTITY_INSERT [BookSharingDev].[dbo].[Genres] OFF;
INSERT INTO [BookSharingDev].[dbo].[Genres](Name)
VALUES
(N'Экономика'),
(N'Классика'),
(N'Зарубежная'),
(N'Русская'),
(N'Детская'),
(N'Детектив'),
(N'Фэнтези'),
(N'Фантастика'),
(N'Современная'),
(N'Ужасы'),
(N'Философия'),
(N'Психология'),
(N'Наука'),
(N'Поэзия'),
(N'Публицистика'),
(N'История')
 */
