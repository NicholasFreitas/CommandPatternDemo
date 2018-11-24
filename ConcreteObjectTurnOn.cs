using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    class ConcreteObjectTurnOn : ICommand
    {
        public void Execute()
        {
            TurnOn();
        }


        void TurnOn()
        {
            Console.WriteLine("On");
        }
    }
}
