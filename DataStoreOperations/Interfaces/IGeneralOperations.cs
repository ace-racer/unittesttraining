using UnitTestingTraining.Models;

namespace DataStoreOperations.Interfaces
{
    public interface IGeneralOperations
    {
        /// <summary>
        /// Gets the student class details from standard and section.
        /// </summary>
        /// <param name="standard">The standard.</param>
        /// <param name="section">The section.</param>
        /// <returns>The details of the student class details</returns>
        StudentClassDetails GetStudentClassDetailsFromStandardAndSection(int standard, char section);

        /// <summary>
        /// Gets the subject details by subject identifier.
        /// </summary>
        /// <param name="subjectId">The subject identifier.</param>
        /// <returns>The subject details of the student</returns>
        StudentSubject GetSubjectDetailsBySubjectId(string subjectId);
    }
}
