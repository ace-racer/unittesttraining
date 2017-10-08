using DataStoreOperations.Interfaces.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingTraining.BusinessLogics;
using UnitTestingTraining.DataStoreOperations.Fakes;
using UnitTestingTraining.Models;

namespace UnitTestingTraining.Tests
{
    [TestClass]
    public class StudentOperationsUnitTests
    {
        [TestMethod]
        public void GetCurrentPercentScoreOfStudent_ReturnsCorrectPercentScoreForDifferentScoresAndMaximumMarks()
        {
            // Provide your own implementation for the dependencies
            StubIGeneralOperationsInDataSource generalOperationsInDataStoreContainer = new StubIGeneralOperationsInDataSource();
            generalOperationsInDataStoreContainer.GetSubjectDetailsBySubjectIdString = (subjectId) =>
            {
                switch (subjectId)
                {
                    case "11":
                        return new StudentSubject()
                        {
                            Name = "Geography",
                            Id = "11",
                            Standard = 5,
                            TotalMarks = 100
                        };
                    case "12":
                        return new StudentSubject()
                        {
                            Name = "Biological Science",
                            Id = "12",
                            Standard = 5,
                            TotalMarks = 50
                        };                    
                    default:
                        return null;
                }
            };

            StubIStudentOperationsInDataSource studentOperationsInDataSourceContainer = new StubIStudentOperationsInDataSource();
            studentOperationsInDataSourceContainer.GetStudentSubjectMappingDetailsForStudentByStudentIdString = (studentId) =>
            {
                return new List<StudentSubjectMapping>()
            {
                new StudentSubjectMapping()
                {
                    StudentId = "11",
                    SubjectId = "11",
                    IsActive = true,
                    CurrentMarksOfStudent = 80,
                    IsFinalExamConductedForSubject = true
                },
                new StudentSubjectMapping()
                {
                    StudentId = "11",
                    SubjectId = "12",
                    IsActive = true,
                    CurrentMarksOfStudent = 30,
                    IsFinalExamConductedForSubject = true
                }
            };
            };


            var studentOperationsContainer = new StudentOperationsContainer(generalOperationsInDataStoreContainer, studentOperationsInDataSourceContainer);
            var actualPercentMarks = studentOperationsContainer.GetCurrentPercentScoreOfStudent("11");
            double expectedPercentMarks = ((double)110 / 150) * 100;
            Assert.AreEqual(expectedPercentMarks, actualPercentMarks);            
        }

        [TestMethod]
        public void GetCurrentPercentScoreOfStudent_ReturnsCorrectPercentScoreForDifferentScoresMaximumMarksAndFinalExamsForSomeSubjectsAreNotConductedYet()
        {
            // Provide your own implementation for the dependencies
            StubIGeneralOperationsInDataSource generalOperationsInDataStoreContainer = new StubIGeneralOperationsInDataSource();
            generalOperationsInDataStoreContainer.GetSubjectDetailsBySubjectIdString = (subjectId) =>
            {
                switch (subjectId)
                {
                    case "11":
                        return new StudentSubject()
                        {
                            Name = "Geography",
                            Id = "11",
                            Standard = 5,
                            TotalMarks = 100
                        };
                    case "12":
                        return new StudentSubject()
                        {
                            Name = "Biological Science",
                            Id = "12",
                            Standard = 5,
                            TotalMarks = 50
                        };
                    case "13":
                        return new StudentSubject()
                        {
                            Name = "Computer basics",
                            Id = "13",
                            Standard = 5,
                            TotalMarks = 50
                        };
                    default:
                        return null;
                }
            };

            StubIStudentOperationsInDataSource studentOperationsInDataSourceContainer = new StubIStudentOperationsInDataSource();
            studentOperationsInDataSourceContainer.GetStudentSubjectMappingDetailsForStudentByStudentIdString = (studentId) =>
            {
                return new List<StudentSubjectMapping>()
            {
                new StudentSubjectMapping()
                {
                    StudentId = "11",
                    SubjectId = "11",
                    IsActive = true,
                    CurrentMarksOfStudent = 80,
                    IsFinalExamConductedForSubject = true
                },
                new StudentSubjectMapping()
                {
                    StudentId = "11",
                    SubjectId = "12",
                    IsActive = true,
                    CurrentMarksOfStudent = 30,
                    IsFinalExamConductedForSubject = true
                },
                 new StudentSubjectMapping()
                {
                    StudentId = "11",
                    SubjectId = "13",
                    IsActive = true,
                    CurrentMarksOfStudent = 25,
                    IsFinalExamConductedForSubject = false
                },
            };
            };


            var studentOperationsContainer = new StudentOperationsContainer(generalOperationsInDataStoreContainer, studentOperationsInDataSourceContainer);
            var actualPercentMarks = studentOperationsContainer.GetCurrentPercentScoreOfStudent("11");
            double expectedPercentMarks = ((double)110 / 150) * 100;
            Assert.AreEqual(expectedPercentMarks, actualPercentMarks);
        }

        [TestMethod]
        // TODO: Make this test pass!!
        public void GetAllStudentsByStandardAndSection_ReturnsAllStudentsinTheStandardAndSection()
        {
            var studentOperationsContainer = new StudentOperationsContainer();
            Assert.IsNotNull(studentOperationsContainer.GetAllStudentsByStandardAndSection(5, 'a'));
        }

        [TestMethod]
        // TODO: Make this test pass!!
        public void GetAllStudentsByStandardAndSection_ReturnsNoStudentsForInvalidStandardOrSection()
        {
            var studentOperationsContainer = new StudentOperationsContainer();
            Assert.IsNull(studentOperationsContainer.GetAllStudentsByStandardAndSection(21, 'a'));
        }

        [TestMethod]
        // TODO: Make this test pass!!
        public void GetStudentDetailsOfStudentReceivingMaximumOverallMarksPercentInClass_ReturnsOneStudentWhenThereIsOneMaximum()
        {
            var studentOperationsContainer = new StudentOperationsContainer();
            var studentsReceivingMaximumPercentInClass = studentOperationsContainer.GetStudentDetailsOfStudentsReceivingMaximumOverallMarksPercentInClass(5, 'a');
            Assert.AreEqual(1, studentsReceivingMaximumPercentInClass.Count);
        }

        [TestMethod]
        // TODO: Make this test pass!!
        public void GetStudentDetailsOfStudentReceivingMaximumOverallMarksPercentInClass_Returns3StudentsWhenThereAre3Maximums()
        {
            var studentOperationsContainer = new StudentOperationsContainer();
            var studentsReceivingMaximumPercentInClass = studentOperationsContainer.GetStudentDetailsOfStudentsReceivingMaximumOverallMarksPercentInClass(5, 'a');
            Assert.AreEqual(3, studentsReceivingMaximumPercentInClass.Count);
        }
    }
}
