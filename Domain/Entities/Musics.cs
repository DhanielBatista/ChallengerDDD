using Domain.Entities.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Musics
    {

        [Column("Music_Id")]
        public int Id { get; set; }
        [Column("Music_Name")]
        public string Name { get; set; }
        [Column("Music_Genre")]
        public GenreEnum Genre { get; set; }
        [Column("Music_release")]
        public DateTime ReleaseYear { get; set; }
        [Column("Music_Time")]
        public decimal Duration { get; set; }

    }
}
