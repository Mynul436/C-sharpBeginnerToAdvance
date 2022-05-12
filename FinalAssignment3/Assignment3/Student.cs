using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Student
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        //public string Username { get; set; }
        //public int Password { get; set; }

        public double Cgpa { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
