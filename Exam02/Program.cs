namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Type Of Exam (1 For Practical | 2 For final): ");
            int ExamType = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the time For Exam From (30 min to 180 min): ");
            int ExamTime = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Number Of questions: ");
            int NumberOfQuestions = int.Parse(Console.ReadLine());
            Console.Clear();

            Exam Exam = null;
            if (ExamType == 1)
            {
                Exam = new PracticalExam(ExamTime, NumberOfQuestions);
            }
            else if (ExamType == 2)
            {
                Exam = new FinalExam(ExamTime, NumberOfQuestions);
            }

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                int QuestionType;
                if (ExamType == 1)
                {
                    QuestionType = 1;
                }
                else
                {
                    Console.WriteLine("Enter Type Of Question (1 for MCQ | 2 For True | False): ");
                    QuestionType = int.Parse(Console.ReadLine());
                    Console.Clear();
                }

                if (QuestionType == 1)
                {
                    Console.WriteLine("MCQ Question");
                    Console.WriteLine("Please Enter Question Body: ");
                    string Body = Console.ReadLine();

                    Console.WriteLine("Please Enter Question Mark: ");
                    int Mark = int.Parse(Console.ReadLine());

                    Answer[] Answers = new Answer[3];
                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Please Enter Choice Number {j + 1}: ");
                        string AnswerText = Console.ReadLine();
                        Answers[j] = new Answer(j + 1, AnswerText);
                    }

                    Console.WriteLine("Please Enter the right Answer id: ");
                    int RightAnswerId = int.Parse(Console.ReadLine());

                    var McqQuestion = new MCQQuestion("MCQ", Body, Mark, Answers, RightAnswerId);

                    Exam.Questions[i] = McqQuestion;
                }
                else if (QuestionType == 2)
                {
                    Console.WriteLine("True/False Question");
                    Console.WriteLine("Please Enter Question Body: ");
                    string Body = Console.ReadLine();

                    Console.WriteLine("Please Enter Question Mark: ");
                    int Mark = int.Parse(Console.ReadLine());

                    Answer[] Answers = new Answer[]
                    {
                    new Answer(1, "True"),
                    new Answer(2, "False")
                    };

                    Console.WriteLine("Please Enter the right Answer id (1 for True | 2 For False): ");
                    int RightAnswerId = int.Parse(Console.ReadLine());

                    var TFQuestion = new TrueFalseQuestion("True/False", Body, Mark, Answers, RightAnswerId);

                    Exam.Questions[i] = TFQuestion;
                }
                Console.Clear();
            }

            Console.WriteLine("DO You Want To Start Exam (Y|N): ");
            string StartExam = Console.ReadLine();

            Exam.StartTime = DateTime.Now;

            if (StartExam.ToUpper() == "Y")
            {
                Exam.ShowExam();
            }
            else if(StartExam.ToUpper() == "N")
            {
                Console.WriteLine("Whyyyy ): ): ):");
            }
        }
    }
}
