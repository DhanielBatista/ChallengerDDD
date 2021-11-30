using Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dtos
{
    public class MusicsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GenreEnum Genre { get; set; }
        public DateTime ReleaseYear { get; set; }

    }
}
