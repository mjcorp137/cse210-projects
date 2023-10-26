public class WritingAssignment : Assignment{
    private string _title;
    //SETTERS
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic){
            _title = title;
        }
        //GETTER
        public string GetWritingInformation(){
            string studentName = GetStudentName();

            return $"{_title} by {studentName}";
        }
}