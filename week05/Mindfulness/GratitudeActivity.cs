using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    public class GratitudeActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "What are three things you're grateful for today?",
            "Who in your life are you most thankful for and why?",
            "What experiences from this past year are you grateful for?",
            "What aspects of your health are you thankful for?",
            "What opportunities are you grateful to have had?"
        };

        public GratitudeActivity() : base("Gratitude Activity",
            "This activity will help you cultivate gratitude by reflecting on the positive aspects of your life. Practicing gratitude can improve your mood and overall well-being.")
        {
        }

        public override void Run()
        {
            DisplayStartingMessage();

            Console.WriteLine("Reflect deeply on the following:");
            Console.WriteLine();
            Console.WriteLine($" --- {GetRandomPrompt()} ---");
            Console.WriteLine();
            Console.WriteLine("Take your time to really think about your answer.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            Console.WriteLine("Spend this time in quiet reflection on what you're grateful for...");
            Console.WriteLine();

            while (DateTime.Now < endTime)
            {
                Console.Write("Reflecting on gratitude ");
                ShowSpinner(8);
                Console.WriteLine();
            }

            Console.WriteLine("Take a moment to carry this feeling of gratitude with you.");
            ShowSpinner(3);

            DisplayEndingMessage();
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }
    }
}