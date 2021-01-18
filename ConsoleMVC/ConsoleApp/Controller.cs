using MVCExample.Common;

namespace MVCExample.ConsoleApp
{
    public class Controller : IController
    {
        private readonly Counter counter;

        public Controller(Counter counter)
        {
            this.counter = counter;
        }

        public void IncrementAction()
        {
            counter.IncrementCount();
        }

        public void Run(ConsoleView view)
        {

        }

        public void Quit()
        {

        }
    }
}