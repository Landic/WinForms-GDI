using System.Drawing;
using System.Windows.Forms;

namespace Volkov_HW_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics graphic = e.Graphics)
            {
                using (SolidBrush brush = new SolidBrush(Color.Blue))
                {
                    for (int i = 0; i <= 8; i++)
                    {
                        for (int j = 0; j <= 8; j++)
                        {
                            graphic.FillRectangle(brush, i * 50, j * 50, 50, 50);
                        }
                    }
                }
            }
        }
    }
}