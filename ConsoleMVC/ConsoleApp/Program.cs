using System;
using MVCExample.Common;

namespace MVCExample.ConsoleApp
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            int count;

            if ((args?.Length ?? 0) > 0 && int.TryParse(args[0], out count))
            {
                Counter counter = new Counter(count);
                Controller controller = new Controller(counter);
                ConsoleView view = new ConsoleView(controller, counter);

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
