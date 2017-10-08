using UnitTestingTraining.Models;

namespace DataStoreOperations
{
    public class GeneralOperationsInAzureTableContainer
    {
        public StudentClassDetails GetStudentClassDetailsFromStandardAndSection(int standard, char section)
        {
            return new StudentClassDetails()
            {
                Section = 'B',
                Standard = 5,
                ClassTeacherId = "1",
                IsActive = true,
                Id = "5B"
            };
        }

        /// <summary>
        /// Gets the subject details by subject identifier.
        /// </summary>
        /// <param name="subjectId">The subject identifier.</param>
        /// <returns>The student subject details</returns>
        public StudentSubject GetSubjectDetailsBySubjectId(string subjectId)
        {
            switch(subjectId)
            {
                case "1":
                    return new StudentSubject()
                    {
                        Name = "Maths",
                        Id = "1",
                        Standard = 5,
                        TotalMarks = 100
                    };
                case "2":
                    return new StudentSubject()
                    {
                        Name = "Physical Science",
                        Id = "2",
                        Standard = 5,
                        TotalMarks = 50
                    };
                default:
                    return null;
            }            
        }
    }
}
