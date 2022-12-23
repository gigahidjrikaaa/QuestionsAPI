namespace QuestionsAPI.Models
{
    public class Questions
    {
        public int id { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public string name { get; set; }
        public Questions()
        {

        }
        public Questions(int id, string question, string answer, string name)
        {
            this.id = id;
            this.question = question;
            this.answer = answer;
            this.name = name;
        }
    }
}
