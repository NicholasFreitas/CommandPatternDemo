using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    /* 
        If you know strategy you likely know command. The difference is in intent.
        Command patterns are for things that must be done. Usually the command will have a 
        generic method with a method call inside.

        To contrast against the strategy pattern, the strategy pattern is about choosing our behavior,
        inserting certain behavior into an algorithm before we call it.

        Invoker ----> Command
                         ^
                         |
                         |
        Receiver <--- ConcreteCommand
                     ~Execute()   <- receiver->Action()
                     -State

         
         */



    class Program
    {
        static void Main(string[] args)
        {

            var turnoff = new ConcreteObjectTurnOff();
            var turnon = new ConcreteObjectTurnOn();

            var invoker = new ConcreteInvoker();

            invoker.SetCommand(turnon,turnoff);


            invoker.TurnOn();
            invoker.TurnOff();

        }
    }
}
