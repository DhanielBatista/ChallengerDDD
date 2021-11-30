using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class Albums
    {
        [Column("Album_Id")]
        public int Id { get; set; }
        [Column("Album_Name")]
        public string Name { get; set; }
        [Column("Album_Year")]
        public DateTime Year { get; set; }

    }
}
