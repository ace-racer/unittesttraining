using System.Collections.Generic;
using UnitTestingTraining.Models;

namespace DataStoreOperations.Interfaces
{
    public interface IStudentOperationsInDataSource
    {
        /// <summary>
        /// Gets the student details by class details identifier.
        /// </summary>
        /// <param name="classDetailsId">The class details identifier.</param>
        /// <returns>All the students for the class</returns>
        List<StudentDetails> GetStudentDetailsByClassDetailsId(string classDetailsId);

        /// <summary>
        /// Gets the student subject mapping details for student by student identifier.
        /// </summary>
        /// <param name="studentId">The student identifier.</param>
        /// <returns>All student subject mappings for the student</returns>
        List<StudentSubjectMapping> GetStudentSubjectMappingDetailsForStudentByStudentId(string studentId);
    }
}
