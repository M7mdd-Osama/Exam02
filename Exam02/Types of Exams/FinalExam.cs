using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }
        public override void ShowExam()
        {
            int TotalMarks = 0;
            int ObtainedMarks = 0;

            string[] UserAnswers = new string[Questions.Length];
            string[] RightAnswers = new string[Questions.Length];
            foreach (Question question in Questions)
            {
                question.Display();
                Console.Write("Please Enter The Answer Id: ");
                int answerId = int.Parse(Console.ReadLine());

                Answer SelectedAnswer = Array.Find(question.Answers, ans => ans.AnswerId == answerId);

                UserAnswers[Array.IndexOf(Questions, question)] = SelectedAnswer.AnswerText;
                RightAnswers[Array.IndexOf(Questions, question)] = question.Answers[question.RightAnswerId - 1].AnswerText;
                Console.Clear();

                Console.WriteLine($"{question.Body}");
                Console.WriteLine($"Your Answer => {SelectedAnswer.AnswerText}");
                Console.WriteLine($"Right Answer => {question.Answers[question.RightAnswerId - 1].AnswerText}");

                if (answerId == question.RightAnswerId)
                {
                    ObtainedMarks += question.Mark;
                }
                TotalMarks += question.Mark;
            }
            Console.Clear();
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Question {i + 1} : {Questions[i].Body}");
                Console.WriteLine($"Your Answer => {UserAnswers[i]}");
                Console.WriteLine($"Right Answer => {RightAnswers[i]}");
            }
            Console.WriteLine($"Your Grade is {ObtainedMarks} from {TotalMarks}");
            Console.WriteLine($"Time = {DateTime.Now - StartTime}");
            Console.WriteLine("Thank You");
        }
    }
}
