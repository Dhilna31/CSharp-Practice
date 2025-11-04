namespace QuizApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("what is the capital of germany",//question text
                new string[]{"paris","berlin","london","madrid"},//answers array
                1//correctanswerindex
                ),
                 new Question("what is 2+2",//question text
                new string[]{"3","4","1","5"},//answers array
                1//correctanswerindex
                ),
                  new Question("what wrote 'Hamblet'",//question text
                new string[]{"Goethe","Shakespeare","Austen","Dickens"},//answers array
                2//correctanswerindex
                ),
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
            Console.ReadLine();
        }
    }
}
