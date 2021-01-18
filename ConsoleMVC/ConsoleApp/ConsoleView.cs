using System;
using MVCExample.Common;

namespace MVCExample.ConsoleApp
{
    public class ConsoleView : IConsoleView
    {
        private readonly IController controller;

        public ConsoleView(IController controller, Counter counter)
        {
            this.controller = controller;
            counter.HitMaxCount += UpdateMessage;
        }

        public void Start()
        {
            Console.WriteLine("=== Welcome to the MVC Example ===");
            Console.WriteLine();
            Console.WriteLine(
                "\tPress [Space] to increment counter, [Esc] to exit");
        }

        public void GetInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.Spacebar:
                        controller.IncrementAction();
                        break;
                    case ConsoleKey.Escape:
                        controller.Quit();
                        break;
                    default:
                        Console.WriteLine("\tUnknown option!");
                        break;
                }
            }
        }

        public void Finish()
        {
            Console.WriteLine("\n=== Bye! ===");
        }

        private void UpdateMessage()
        {
            Console.WriteLine("\t => Hit max presses!");
        }
    }
}