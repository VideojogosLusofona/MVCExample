using MVCExample.Common;

namespace MVCExample.ConsoleApp
{
    public class Controller : IController
    {
        private readonly Counter counter;
        private bool running;

        public Controller(Counter counter)
        {
            this.counter = counter;
        }

        public void IncrementAction()
        {
            counter.IncrementCount();
        }

        public void Run(IConsoleView view)
        {
            running = true;
            view.Start();
            while (running)
            {
                view.GetInput();
            }
            view.Finish();
        }

        public void Quit()
        {
            running = false;
        }
    }
}