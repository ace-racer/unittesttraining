using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingTraining.Models
{
    public class StudentSubjectMapping
    {
        public string StudentId { get; set; }

        public string SubjectId { get; set; }        

        public bool IsActive { get; set; }

        public double CurrentMarksOfStudent { get; set; }
    }
}
