﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Teacher
    {
        
        public int Id { get; set; }
        public string Name { get; set; }  
        public string UserName { get; set; }
        public string Password { get; set; }
       // public string CourseId { get; set; }


        

        //public virtual ICollection<Student> Students { get; set; }
        //public virtual Admin Admin { get; set; }
        

    }
}
