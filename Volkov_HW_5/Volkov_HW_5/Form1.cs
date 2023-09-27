using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Volkov_HW_5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graph = e.Graphics;
            graph.Clear(Color.White);
            DateTime now = DateTime.Now;
            int centerX = 100;
            int centerY = 100;
            int width = 4;
            graph.DrawEllipse(Pens.Black, 10, 10, 180, 180);
            Matrix transformMatrix = new Matrix();
            graph.Transform = transformMatrix;
            for (int i = 1; i <= 12; i++)
            {
                double angle = (i - 3) * 30 * Math.PI / 180;
                int x = centerX + (int)(80 * Math.Cos(angle));
                int y = centerY + (int)(80 * Math.Sin(angle));
                graph.DrawString(i.ToString(), new Font("Arial", 12), Brushes.Black, x - 10, y - 10);
            }
            for (int i = 0; i < 60; i++)
            {
                double g = i * 6 * Math.PI / 180;
                int x1 = centerX + (int)(90 * Math.Cos(g));
                int y1 = centerY + (int)(90 * Math.Sin(g));
                int x2 = centerX + (int)(100 * Math.Cos(g));
                int y2 = centerY + (int)(100 * Math.Sin(g));

                if (i % 5 == 0) 
                {
                    int dx = x2 - x1;
                    int dy = y2 - y1;
                    int offsetX = dx / 2 - width / 2;
                    int offsetY = dy / 2 - width / 2;
                    graph.FillRectangle(Brushes.Black, x1 + offsetX, y1 + offsetY, width, width);
                }
                else 
                {
                    graph.DrawLine(Pens.Black, x1, y1, x2, y2);
                }
            }
            DrawClockHand(graph, centerX, centerY, 60, (360 / 12) * (now.Hour % 12 + now.Minute / 60.0));
            DrawClockHand(graph, centerX, centerY, 80, (360 / 60) * now.Minute);
            DrawClockHand(graph, centerX, centerY, 80, (360 / 60) * now.Second, true);
        }

        private void DrawClockHand(Graphics graph, int x, int y, int length, double a, bool red = false)
        {
            Matrix originalMatrix = graph.Transform.Clone();
            graph.TranslateTransform(x, y);
            graph.RotateTransform((float)a);
            graph.TranslateTransform(-x, -y);

            if (red)
                graph.DrawLine(new Pen(Color.Red, 2), x, y, x, y - length);
            else
                graph.DrawLine(Pens.Black, x, y, x, y - length);

            graph.Transform = originalMatrix;
        }
    }
}