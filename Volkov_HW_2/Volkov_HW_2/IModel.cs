using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_2
{
    internal interface IModel
    {
        StringBuilder currentplayer { get; set; }
        string[] board { get; set; }

        void Retry_Board();
        void Restart_Current_Player();

        bool Check_Draw();

        bool Check_Win(string[] board);

        bool Move();
    }
}
