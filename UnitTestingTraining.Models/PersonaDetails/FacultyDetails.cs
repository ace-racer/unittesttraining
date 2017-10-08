using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingTraining.Models
{
    public class FacultyDetails : PersonalDetails
    {
        public string PhoneNumber { get; set; }

        public DateTime JoiningDate { get; set; }
    }
}
