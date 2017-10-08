using DataStoreOperations;
using DataStoreOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTestingTraining.DataStoreOperations;
using UnitTestingTraining.Models;

namespace UnitTestingTraining.BusinessLogics
{
    public class StudentOperationsContainer
    {
        /// <summary>
        /// The general operations container
        /// </summary>
        private static IGeneralOperationsInDataSource generalOperationsInDataSourceContainer;

        /// <summary>
        /// The student operations container
        /// </summary>
        private static IStudentOperationsInDataSource studentOperationsInDataSourceContainer;

        /// <summary>
        /// Initializes a new instance of the <see cref="StudentOperationsContainer"/> class.
        /// </summary>
        /// <param name="generalOperationsContainer">The general operations container.</param>
        /// <param name="studentOperationsContainer">The student operations container.</param>
        public StudentOperationsContainer(IGeneralOperationsInDataSource generalOperationsContainer = null, IStudentOperationsInDataSource studentOperationsContainer = null)
        {
            StudentOperationsContainer.generalOperationsInDataSourceContainer = generalOperationsContainer;
            StudentOperationsContainer.studentOperationsInDataSourceContainer = studentOperationsContainer;
        }

        /// <summary>
        /// Gets the current percent score of student.
        /// </summary>
        /// <param name="studentId">The student identifier.</param>
        /// <returns>The percent attained by the student</returns>
        /// <exception cref="System.ArgumentNullException">studentId</exception>
        public double GetCurrentPercentScoreOfStudent(string studentId)
        {
            if(!string.IsNullOrWhiteSpace(studentId))
            {
                try
                {
                    if (generalOperationsInDataSourceContainer != null && studentOperationsInDataSourceContainer != null)
                    {
                        var allSubjectScoresMappingOfStudent = studentOperationsInDataSourceContainer.GetStudentSubjectMappingDetailsForStudentByStudentId(studentId);
                        if (allSubjectScoresMappingOfStudent != null && allSubjectScoresMappingOfStudent.Any())
                        {
                            double currentTotalStudentMarks = 0;
                            double currentTotalApplicableMarks = 0;
                            foreach (var subjectScoreMapping in allSubjectScoresMappingOfStudent)
                            {
                                if (subjectScoreMapping.IsFinalExamConductedForSubject)
                                {
                                    var subjectDetails = generalOperationsInDataSourceContainer.GetSubjectDetailsBySubjectId(subjectScoreMapping.SubjectId);
                                    if (subjectDetails != null)
                                    {
                                        currentTotalApplicableMarks += subjectDetails.TotalMarks;
                                        currentTotalStudentMarks += subjectScoreMapping.CurrentMarksOfStudent;
                                    }
                                }
                            }

                            var ratio = currentTotalStudentMarks / currentTotalApplicableMarks;
                            return ratio * 100;
                        }
                    }
                }
                catch(Exception ex)
                {
                    // TODO: Log exception
                    throw;
                }
            }

            throw new ArgumentNullException("studentId");
        }

        /// <summary>
        /// Gets all students by standard and section.
        /// </summary>
        /// <param name="standard">The standard.</param>
        /// <param name="section">The section.</param>
        /// <returns>All students by standard and section</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public List<StudentDetails> GetAllStudentsByStandardAndSection(int standard, char section)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the student details of student receiving maximum overall marks percent in class.
        /// </summary>
        /// <param name="standard">The standard.</param>
        /// <param name="section">The section.</param>
        /// <returns>The students who received the maximum overall marks percent in class</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public List<StudentDetails> GetStudentDetailsOfStudentsReceivingMaximumOverallMarksPercentInClass(int standard, char section)
        {
            throw new NotImplementedException();
        }
    }
}
