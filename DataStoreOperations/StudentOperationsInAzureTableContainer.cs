using System.Collections.Generic;
using UnitTestingTraining.Models;

namespace UnitTestingTraining.DataStoreOperations
{
    public class StudentOperationsInAzureTableContainer
    {
        public List<StudentDetails>  GetStudentDetailsByClassDetailsId(string classDetailsId)
        {
            // get students with current class details Id as the value provided
            return new List<StudentDetails>()
            {
                new StudentDetails()
                {
                    Name = "John Doe",
                    Id = "1",
                    IsActive = true
                },
                new StudentDetails()
                {
                    Name = "Don Doe",
                    Id = "2",
                    IsActive = true
                },
                new StudentDetails()
                {
                    Name = "Alice Rice",
                    Id = "3",
                    IsActive = true
                },
                new StudentDetails()
                {
                    Name = "Ron Harley",
                    Id = "4",
                    IsActive = true
                },
                new StudentDetails()
                {
                    Name = "Brad Harris",
                    Id = "5",
                    IsActive = true
                },new StudentDetails()
                {
                    Name = "John Doe",
                    Id = "1",
                    IsActive = true
                }
            };
        }

        public List<StudentSubjectMapping> GetStudentSubjectMappingDetailsForStudentByStudentId(string studentId)
        {
            return new List<StudentSubjectMapping>()
            {
                new StudentSubjectMapping()
                {
                    StudentId = "1",
                    SubjectId = "1",
                    IsActive = true,
                    CurrentMarksOfStudent = 30,
                    IsFinalExamConductedForSubject = true
                },
                new StudentSubjectMapping()
                {
                    StudentId = "1",
                    SubjectId = "2",
                    IsActive = true,
                    CurrentMarksOfStudent = 50,
                    IsFinalExamConductedForSubject = true
                },
                new StudentSubjectMapping()
                {
                    StudentId = "1",
                    SubjectId = "3",
                    IsActive = true,
                    CurrentMarksOfStudent = 50,
                    IsFinalExamConductedForSubject = true
                },
                new StudentSubjectMapping()
                {
                    StudentId = "1",
                    SubjectId = "4",
                    IsActive = true,
                    CurrentMarksOfStudent = 60,
                    IsFinalExamConductedForSubject = true
                }
            };
        }
    }
}
