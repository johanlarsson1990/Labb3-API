using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Labb3Models
{
    public class Link
    {
        [Key]
        public int LinkId { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string URL { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int HobbyId { get; set; }
        public Hobby Hobby { get; set; }


    }
}