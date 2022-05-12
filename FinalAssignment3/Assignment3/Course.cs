using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }  
        public string CourseName { get; set; }
        public string Fees { get; set; }    
        public DateTime ClassStartDate { get; set; }  
        public int TotalNumberOfClass { get; set; }
        public List<Topic> Topics { get; set; }

    }
}
