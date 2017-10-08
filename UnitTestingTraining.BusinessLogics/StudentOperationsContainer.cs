using DataStoreOperations;
using DataStoreOperations.Interfaces;
using System;
using System.Linq;
using UnitTestingTraining.DataStoreOperations;

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
    }
}
