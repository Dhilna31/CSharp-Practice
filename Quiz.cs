using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApplication
{
    internal class Quiz
    {
        private Question[] questions;
        private int score;

        public Quiz(Question[] questions)
        {
           this.questions = questions;
            score = 0;
        }

            public void StartQuiz()
        {
            Console.WriteLine("welcome to the quiz!");
            int questionNumber = 1;//to display question numbers

            foreach(Question question in questions)
            {
                Console.WriteLine($"Question {questionNumber++}");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if(question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("correct");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! the correct answer was:{question.Answers[question.CorrectAnswerIndex]}");
                }
            }
        }

        private void DisplayResults()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Question");
            Console.ResetColor();

            Console.WriteLine("Quiz Finished.Your score is: {score} out of {questions.Length}");
            double percentage = (double)score / questions.Length;
            if(percentage>=0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("excellent work!");
            }
            else if(percentage>=0.5)
                {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("good work!");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep Practicing");
            }
            Console.ResetColor();


        }
        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Question");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);

            for(int i=0;i < question.Answers.Length;i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;//changes the text color
                Console.Write("  ");
                Console.Write(i + 1);
                Console.ResetColor(); //resets the foreground text color
                Console.WriteLine($". {question.Answers[i]}");
            }

          
        }
            private int GetUserChoice()
        {
            Console.Write("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;
            while(!int.TryParse(input,out choice) || choice<1 || choice>4)
            {
                Console.WriteLine("invalid choice.please enter a number between 1 and 4:");
                input = Console.ReadLine();
            }

            return choice -1; //adjust to -0 indexed array
        }
    }
}
