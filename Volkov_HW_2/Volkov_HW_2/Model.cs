using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_2
{
    internal class Model : IModel
    {
        public StringBuilder currentplayer { get; set; }
        public string[] board { get; set; }

        public Model()
        {
            board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            currentplayer = new StringBuilder();
            currentplayer.Append('X');
        }

        public bool Move()
        {
            Form1.buttons[Form1.indexClicked].BackgroundImage = Image.FromFile("Cross.png");
            Form1.buttons[Form1.indexClicked].Enabled = false;
            board[Form1.indexClicked] = "X";
            if (Check_Win(board) == true)
            {
                currentplayer[0] = 'X';
                MessageBox.Show($"{currentplayer} WIN!!!!!!", "Tic tac toe");
                for (int j = 0; j < Form1.buttons.Count; j++)
                {
                    Form1.buttons[j].Enabled = false;
                }
                Restart_Current_Player();
                Retry_Board();
                return true;
            }
            else if (Check_Draw() == true)
            {
                MessageBox.Show($"Draw!!!", "Tic tac toe");
                for (int j = 0; j < Form1.buttons.Count; j++)
                {
                    Form1.buttons[j].Enabled = false;
                }
                Restart_Current_Player();
                Retry_Board();
                currentplayer[0] = 'X';
                return true;
            }
            currentplayer[0] = 'O';
            return false;
            
        }

        public void Retry_Board()
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = Convert.ToString(i);
            }
        }

        public void Restart_Current_Player()
        {
            currentplayer[0] = 'X';
        }

        public bool Check_Draw()
        {
            foreach (string i in board)
            {
                if (i != "X" && i != "O")
                    return false;
            }
            return true;
        }

        public bool Check_Win(string[] board)
        {
            int[,] indexWin = new int[8, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };
            for (int i = 0; i < indexWin.GetLength(0); i++)
            {
                if (board[indexWin[i, 0]] == board[indexWin[i, 1]] && board[indexWin[i, 1]] == board[indexWin[i, 2]])
                {
                    return true;
                }
            }
            return false;
            
        }
    }
}
