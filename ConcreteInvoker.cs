using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    class ConcreteInvoker : IInvoker
    {
        ICommand TurnOnCommand;
        ICommand TurnOffCommand;

        public void SetCommand(ICommand comTurnOn, ICommand comTurnOff)
        {

            TurnOffCommand = comTurnOff;
            TurnOnCommand = comTurnOn;

        }

        public void TurnOff()
        {
            TurnOffCommand.Execute();
        }

        public void TurnOn()
        {
            TurnOnCommand.Execute();
        }
    }
}
