using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark, Answer[] answers, int rightAnswerId) : base(header, body, mark, answers, rightAnswerId)
        {
        }
        public override void Display()
        {
            Console.WriteLine($"{Body}");
            Console.WriteLine("1. True");
            Console.WriteLine("2. False");
        }
    }
}
