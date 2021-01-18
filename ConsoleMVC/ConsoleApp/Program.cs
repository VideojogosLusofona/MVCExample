using System;
using MVCExample.Common;

namespace MVCExample.ConsoleApp
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            if ((args?.Length ?? 0) > 0 && int.TryParse(args[0], out int count))
            {
                Counter counter = new Counter(count);
                Controller controller = new Controller(counter);
                IConsoleView view = new ConsoleView(controller, counter);

                controller.Run(view);
            }
            else
            {
                Console.WriteLine(
                    "Invalid options. First parameter needs to be action count.");
            }
        }
    }
}
