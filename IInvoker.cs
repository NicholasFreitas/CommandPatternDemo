using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternDemo
{
    interface IInvoker
    {

        void SetCommand(ICommand comTurnOn,ICommand comTurnOff);

        void TurnOn();
        void TurnOff();

    }
}
