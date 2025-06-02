using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessProgram
{
    public abstract class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;
        protected static int _activityCount = 0;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}.");
            Console.WriteLine();
            Console.WriteLine(_description);
            Console.WriteLine();
            
            // Input validation for duration
            while (true)
            {
                Console.Write("How long, in seconds, would you like for your session? ");
                if (int.TryParse(Console.ReadLine(), out _duration) && _duration > 0)
                {
                    break;
                }
                Console.WriteLine("Please enter a positive number.");
            }
            
            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(3);
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!!");
            ShowSpinner(3);
            
            Console.WriteLine();
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
            _activityCount++;
            Console.WriteLine($"Total activities completed this session: {_activityCount}");
            ShowSpinner(3);
            Console.Clear();
        }

        public void ShowSpinner(int seconds)
        {
            List<string> animationStrings = new List<string> { "|", "/", "-", "\\", "*", "+" };
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            int i = 0;
            while (DateTime.Now < endTime)
            {
                string s = animationStrings[i];
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");

                i++;
                if (i >= animationStrings.Count)
                {
                    i = 0;
                }
            }
        }

        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public abstract void Run();
    }
}
