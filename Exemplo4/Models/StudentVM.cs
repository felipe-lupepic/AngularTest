using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exemplo4.Models
{
    public class StudentVM
    {
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string Class { get; set; }
        public string ClassTeacher { get; set; }
    }
}