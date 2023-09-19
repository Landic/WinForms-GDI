using System.CodeDom.Compiler;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

namespace Volkov_HW_2
{
    public partial class Form1 : Form, ITicTacToeView
    {
        public static List<Button> buttons { get; set; }

        public static int indexClicked { get; set; }

        public event EventHandler<EventArgs> TacToeEventOneToOne;
        public event EventHandler<EventArgs> TacToeEventEasyBot;
        public event EventHandler<EventArgs> TacToeEventHardBot;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            buttons = new List<Button>() { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            indexClicked = buttons.IndexOf(clicked);
            if (radioButton3.Checked)
            {
                TacToeEventOneToOne?.Invoke(this, EventArgs.Empty);
            }
            if (radioButton4.Checked)
            {
                if (radioButton1.Checked)
                {
                    TacToeEventEasyBot?.Invoke(this, EventArgs.Empty);
                }
                if (radioButton2.Checked)
                {
                    TacToeEventHardBot?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void Button_Retry_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Enabled = true;
                buttons[i].BackgroundImage = null;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                groupBox1.Enabled = false;
            }
            if (radioButton4.Checked)
            {
                groupBox1.Enabled = true;
            }
        }
    }
}