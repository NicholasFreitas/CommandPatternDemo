using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    class ConcreteObjectTurnOff : ICommand
    {
        public void Execute()
        {
            TurnOFf();
        }


        public void TurnOFf()
        {
            Console.WriteLine("Off");
        }
    }
}
