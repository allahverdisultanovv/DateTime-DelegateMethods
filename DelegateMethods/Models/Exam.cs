namespace DelegateMethods.Models
{
    internal class Exam
    {
        public string Subject { get; set; }
        public double ExamDuration { get; set; }
        public DateTime StartTime { get; set; }
        private DateTime _endTime;
        public DateTime EndTime { get; set; }


        public Exam(string subject, DateTime startTime, double examDuration)
        {
            Subject = subject;
            StartTime = startTime;
            ExamDuration = examDuration;
            EndTime = startTime.AddHours(ExamDuration);
        }
    }
}
