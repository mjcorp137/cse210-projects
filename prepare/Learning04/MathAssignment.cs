public class MathAssignment : Assignment{
    private string _textbookSection;
    private string _problems;
    //SETTERS
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
    : base(studentName, topic){
        _textbookSection = textbookSection;
        _problems = problems;
    }
    //GETTERS
    public string GetHomeWorkList(){
        return $"Section {_textbookSection} Problems {_problems}";
    }
}