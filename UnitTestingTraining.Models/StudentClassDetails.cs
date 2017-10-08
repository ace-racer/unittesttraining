namespace UnitTestingTraining.Models
{
    public class StudentClassDetails
    {
        /// <summary>
        /// Gets or sets the standard.
        /// </summary>
        /// <value>
        /// The standard.
        /// </value>
        public int Standard { get; set; }

        /// <summary>
        /// Gets or sets the section.
        /// </summary>
        /// <value>
        /// The section.
        /// </value>
        public char Section { get; set; }

        /// <summary>
        /// Gets or sets the class teacher identifier. This is the School staff details ID.
        /// </summary>
        /// <value>
        /// The class teacher identifier.
        /// </value>
        public string ClassTeacherId { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        public bool IsActive { get; set; }
    }
}
