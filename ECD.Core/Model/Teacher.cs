using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECD.Core.Model
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Required, StringLength(100)]
        public string FirstName { get; set; }
        [Required, StringLength(100)]
        public string SecondName { get; set; }
        [Required, StringLength(100)]
        public string Surname { get; set; }

        [Required, StringLength(13)]
        public string IdNumber { get; set; }

        public string test { get; set; }
    }
}
