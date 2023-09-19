using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_2
{
    internal interface ITicTacToeView
    {
        event EventHandler<EventArgs> TacToeEventOneToOne;
        event EventHandler<EventArgs> TacToeEventEasyBot;
        event EventHandler<EventArgs> TacToeEventHardBot;
    }
}
