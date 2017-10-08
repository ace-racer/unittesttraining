using DataStoreOperations;
using System;
using System.Linq;
using UnitTestingTraining.DataStoreOperations;

namespace UnitTestingTraining.BusinessLogics
{
    public class StudentOperationsContainer
    {
        public double GetCurrentPercentScoreOfStudent(string studentId)
        {
            if(!string.IsNullOrWhiteSpace(studentId))
            {
                try
                {
                    var studentOperationsContainer = new StudentOperationsInAzureTableContainer();
                    var generalOperationsContainer = new GeneralOperationsInAzureTableContainer();
                    var allSubjectScoresMappingOfStudent = studentOperationsContainer.GetStudentSubjectMappingDetailsForStudentByStudentId(studentId);
                    if(allSubjectScoresMappingOfStudent != null && allSubjectScoresMappingOfStudent.Any())
                    {
                        double currentTotalStudentMarks = 0;
                        double currentTotalApplicableMarks = 0;
                        foreach (var subjectScoreMapping in allSubjectScoresMappingOfStudent)
                        {
                            if (subjectScoreMapping.IsFinalExamConductedForSubject)
                            {
                                var subjectDetails = generalOperationsContainer.GetSubjectDetailsBySubjectId(subjectScoreMapping.SubjectId);
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
