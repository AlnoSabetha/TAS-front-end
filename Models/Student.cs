using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TASfe.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public DateTime enrollmentDate { get; set; }
    }
}