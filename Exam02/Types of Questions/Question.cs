using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] Answers { get; set; }
        public int RightAnswerId { get; set; }       
        public Question(string header, string body, int mark, Answer[] answers, int rightAnswerId)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            RightAnswerId = rightAnswerId;
        }
        public abstract void Display();
    }
}
