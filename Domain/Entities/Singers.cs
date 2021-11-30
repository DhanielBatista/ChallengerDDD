using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class Singers
    {
        [Column("Singer_Id")]
        public int Id { get; set; }
        [Column("Singer_Name")]
        public string Name { get; set; }
    }
}
