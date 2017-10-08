namespace UnitTestingTraining.Models
{
    public class StudentSubjectMapping
    {
        public string StudentId { get; set; }

        public string SubjectId { get; set; }        

        public bool IsActive { get; set; }

        public double CurrentMarksOfStudent { get; set; }

        public bool IsFinalExamConductedForSubject { get; set; }
    }
}
