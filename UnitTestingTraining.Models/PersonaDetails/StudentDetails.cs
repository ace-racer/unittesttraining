using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingTraining.Models
{
    public class StudentDetails : PersonalDetails
    {
        public string ParentPhoneNumber { get; set; }

        public string Hobbies { get; set; }

        public string HistoricalFeedback { get; set; }

        public DateTime AdmissionDate { get; set; }

        public List<string> ClassesAssociatedWith { get; set; }

        public string ClassDetailsId { get; set; }
    }
}
