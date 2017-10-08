using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingTraining.Models
{
    public class StudentSubject
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the standard.
        /// </summary>
        /// <value>
        /// The standard.
        /// </value>
        public int Standard { get; set; }

        /// <summary>
        /// Gets or sets the total marks.
        /// </summary>
        /// <value>
        /// The total marks.
        /// </value>
        public double TotalMarks { get; set; }

        /// <summary>
        /// Gets or sets the faculty ids taking subject.
        /// </summary>
        /// <value>
        /// The faculty ids taking subject.
        /// </value>
        public List<string> FacultyIdsTakingSubject { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }
    }
}
