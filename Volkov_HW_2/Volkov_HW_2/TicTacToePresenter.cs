using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_2
{
    internal class TicTacToePresenter
    {
        private readonly IModel model;
        private readonly ITicTacToeView view;

        public TicTacToePresenter(IModel model, ITicTacToeView view)
        {
            this.model = model;
            this.view = view;
            this.view.TacToeEventOneToOne += new EventHandler<EventArgs>(One_To_One);
            this.view.TacToeEventEasyBot += new EventHandler<EventArgs>(Easy_Bot);
            this.view.TacToeEventHardBot += new EventHandler<EventArgs>(Hard_Bot);
        }

        private void One_To_One(object sender, EventArgs e)
        {
            if (model.currentplayer[0] == 'X')
            {
                model.Move();
            }
            else if (model.currentplayer[0] == 'O')
            {
                Form1.buttons[Form1.indexClicked].BackgroundImage = Image.FromFile("Zero.png");
                Form1.buttons[Form1.indexClicked].Enabled = false;
                model.board[Form1.indexClicked] = "O";
                if (model.Check_Win(model.board) == true)
                {
                    MessageBox.Show($"{model.currentplayer} WIN!!!!!!", "Tic tac toe");
                    for (int j = 0; j < Form1.buttons.Count; j++)
                    {
                        Form1.buttons[j].Enabled = false;
                    }
                }
                else if (model.Check_Draw())
                {
                    MessageBox.Show($"Draw!!!", "Tic tac toe");
                    for (int j = 0; j < Form1.buttons.Count; j++)
                    {
                        Form1.buttons[j].Enabled = false;
                    }
                }
                model.currentplayer[0] = 'X';
            }
        }

        private void Easy_Bot(object sender, EventArgs e)
        {
            // список доступных индексов 
            // получить рандомное число от 0 до 9
            // проверить является ли данное число в доступных индексах
            // если нет то заново рандомное число
            ///////////////////////////////////////////////////////////////////////
            // запись в массив всех свободных индексов в поле
            // рандомная генерация индекса массива который хранит индексы свободных полей
            if(model.Move() == false)
            {
                List<int> freeIndex = new List<int>();
                for (int i = 0; i < model.board.Length; i++)
                {
                    if (int.TryParse(model.board[i], out int number) == true)
                    {
                        freeIndex.Add(i);
                    }
                }
                int randStep = new Random().Next(freeIndex.Count);
                model.board[freeIndex[randStep]] = "O";
                Form1.buttons[freeIndex[randStep]].BackgroundImage = Image.FromFile("Zero.png");
                Form1.buttons[freeIndex[randStep]].Enabled = false;
                if (model.Check_Win(model.board))
                {
                    MessageBox.Show($"{model.currentplayer} WIN!!!!!!", "Tic tac toe");
                    for (int j = 0; j < Form1.buttons.Count; j++)
                    {
                        Form1.buttons[j].Enabled = false;
                        model.Retry_Board();
                        model.Restart_Current_Player();
                    }
                }
                else if (model.Check_Draw())
                {
                    MessageBox.Show($"Draw!!!", "Tic tac toe");
                    for (int j = 0; j < Form1.buttons.Count; j++)
                    {
                        Form1.buttons[j].Enabled = false;
                        model.Retry_Board();
                        model.Restart_Current_Player();
                    }
                }
            }
        }


        private void Hard_Bot(object sender, EventArgs e)
        {
            if (model.Move() == false)
            {
                List<int> indexFree = new List<int>();


                for (int i = 0; i < model.board.Length; i++) // цикл добавления свободных ячеек в лист
                {
                    if (int.TryParse(model.board[i], out int number) == true)
                    {
                        indexFree.Add(i);
                    }
                }


                int[] comp_steps = new int[9] { 4, 0, 2, 6, 8, 1, 3, 5, 7 }; // массив приоритетных ячеек
                int index = 0; // хранит последний индекс


                for (int i = 0; i < model.board.Length; i++) // цикл для проверки если есть выигрышь для нолика чтобы он туда сразу подставил
                {
                    string[] temp = new string[model.board.Length];
                    for (int j = 0; j < temp.Length; j++) // цикл для добавление в копию поля
                    {
                        temp[j] = model.board[j];
                    }
                    if (temp[indexFree[index]] != "X" && temp[indexFree[index]] != "O") // проверка есть ли на этой ячейке крестик или нолик
                    {
                        temp[indexFree[index]] = "O";
                    }
                    if (model.Check_Win(temp) == true) // если есть выигрышь то он подставляет туда нолик и происходит выигрышь
                    {
                        model.board[indexFree[index]] = "O";
                        Form1.buttons[indexFree[index]].BackgroundImage = Image.FromFile("Zero.png");
                        MessageBox.Show($"{model.currentplayer} WIN!!!!!!", "Tic tac toe");
                        model.Retry_Board();
                        model.Restart_Current_Player();
                        for (int j = 0; j < Form1.buttons.Count; j++)
                        {
                            Form1.buttons[j].Enabled = false;
                        }
                        return;
                    }
                    else
                    {
                        if (index != indexFree.Count - 1)
                        {
                            index++;
                        }
                    }
                }


                index = 0;
                for (int i = 0; i < model.board.Length; i++) // тот же цикл только для перекрытия крестика чтобы он не выиграл
                {
                    string[] temp = new string[model.board.Length];
                    for (int j = 0; j < temp.Length; j++)
                    {
                        temp[j] = model.board[j];
                    }
                    if (temp[indexFree[index]] != "X" && temp[indexFree[index]] != "O")
                    {
                        temp[indexFree[index]] = "X";
                    }
                    if (model.Check_Win(temp) == true)
                    {
                        model.board[indexFree[index]] = "O";
                        Form1.buttons[indexFree[index]].BackgroundImage = Image.FromFile("Zero.png");
                        return;
                    }
                    else
                    {
                        if(index != indexFree.Count - 1)
                        {
                            index++;
                        }
                    }
                }



                foreach (int i in comp_steps) // если нету выигрышных комбинаций срабатывает этот цикл и идет сравнение если приоритетная ячейка свободна подставляет туда нолик
                {
                    foreach (int j in indexFree)
                    {
                        if (i == j)
                        {
                            model.board[j] = "O";
                            Form1.buttons[j].BackgroundImage = Image.FromFile("Zero.png");
                            Form1.buttons[j].Enabled=false;
                            if (model.Check_Win(model.board) == true)
                            {
                                model.board[i] = "O";
                                Form1.buttons[i].BackgroundImage = Image.FromFile("Zero.png");
                                MessageBox.Show($"{model.currentplayer} WIN!!!!!!", "Tic tac toe");
                                model.Retry_Board();
                                model.Restart_Current_Player();
                                for (int g = 0; g < Form1.buttons.Count; g++)
                                {
                                    Form1.buttons[g].Enabled = false;
                                }
                                return;
                            }
                            else if (model.Check_Draw())
                            {
                                MessageBox.Show($"Draw!!!", "Tic tac toe");
                                for (int g = 0; g < Form1.buttons.Count; g++)
                                {
                                    Form1.buttons[g].Enabled = false;
                                    model.Retry_Board();
                                    model.Restart_Current_Player();
                                }
                                return;
                            }
                            return;
                        }
                    }
                }
            }
        }
    }
}
