using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, Answer[] answers, int rightAnswerId) : base(header, body, mark, answers, rightAnswerId)
        {
        }
        public override void Display()
        {
            Console.WriteLine($"{Body}");
            for (int i = 0; i < Answers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Answers[i].AnswerText}");
            }
        }
    }
}
