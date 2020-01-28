using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type your code below
            QuestionAir(QuestionList(), AnswerList());
        }

        public static void QuestionAir(string[] questions, bool[] answers)
        {
            int askingIndex = 1;
            int scoringIndex = 1;
            int score = 0;
            string input;
            bool isBool = true;
            bool inputBool;

            bool[] responses = new bool[questions.Length];

            foreach (string question in questions)
            {
                Console.WriteLine($"question {askingIndex}/{questions.Length}");
                Console.WriteLine(question);
                Console.Write("true or false: ");
                input = Console.ReadLine();

                isBool = Boolean.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.Write("\nPlease respond with 'true' or 'false': ");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex - 1] = inputBool;
                askingIndex++;
            }

            Console.WriteLine();
            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex - 1];
                Console.WriteLine($"{scoringIndex}. Input: {response} | Answer: {answers[scoringIndex - 1]}");
                if (response == answers[scoringIndex - 1])
                {
                    score++;
                }
                scoringIndex++;
            }
            Console.WriteLine($"\nYou got {score} out of {questions.Length} correct!");
        }


        public static string[] QuestionList()
        {
            string[] questions = {
                "Is 5 larger then 2?",
                "Eggplants are a type of berry.",
                "I love coffee?",
                "Chrome is better then safari",
                "Is this program scale albe",
                "Cats or Dogs? haha just put true"};
            return questions;
        }

        public static bool[] AnswerList()
        {
            bool[] answers = {
                true,
                false,
                true,
                true,
                true,
                false};
            return answers;
        }

    }
}
