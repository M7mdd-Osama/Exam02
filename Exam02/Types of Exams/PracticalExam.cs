using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            foreach (Question question in Questions)
            {
                question.Display();
                Console.Write("Please Enter The Answer Id: ");
                int answerId = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine($"{question.Body}");
                Console.WriteLine($"Your Answer => {question.Answers[answerId - 1].AnswerText}");
                Console.WriteLine($"Right Answer => {question.Answers[question.RightAnswerId - 1].AnswerText}");
            }
            Console.WriteLine("Thank You");
        }
    }
}
