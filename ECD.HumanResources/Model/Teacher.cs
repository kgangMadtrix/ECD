using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECD.HumanResources.Model
{
    [Table("Teachers")]
    public class Teacher
    {
        [Key]
        public int TeacherId { get; private set; }
        [Required, StringLength(100)]
        public string FirstName { get; private set; }
        [Required, StringLength(100)]
        public string Surname { get; private set; }

        [Required, StringLength(13)]
        public string IdNumber { get; private set; }

        [StringLength(10)]
        public string EmployeeNumber { get; set; }

        public string FullName 
        { 
            get{return FirstName + " " + Surname;}
        }

        public string FullNameReverse
        {
            get { return Surname + ", " + FirstName; }
        }
    }
}
