using System;
using System.Threading;

namespace MindfulnessProgram
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Activity", 
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        public override void Run()
        {
            DisplayStartingMessage();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("Breathe in...");
                ShowBreathingAnimation(true, 4);
                Console.WriteLine();
                
                Console.Write("Now breathe out...");
                ShowBreathingAnimation(false, 6);
                Console.WriteLine();
                Console.WriteLine();
            }

            DisplayEndingMessage();
        }

        private void ShowBreathingAnimation(bool breathingIn, int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                if (breathingIn)
                {
                    Console.Write(" O");
                }
                else
                {
                    Console.Write(" o");
                }
                Thread.Sleep(1000);
            }
        }
    }
}