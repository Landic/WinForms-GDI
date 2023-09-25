using System.Drawing;
using System.Windows.Forms;

namespace Volkov_HW_4
{
    public partial class Form1 : Form
    {
        bool temp = false;
        public Form1()
        {
            InitializeComponent();
            Height = 639;
            Width = 615;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = CreateGraphics())
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        g.FillRectangle(Color(), j * 75, i * 75, 75, 75);
                        if (j != 7)
                        {
                            temp = !temp;
                        }
                    }
                }
                for(int i = 0; i < 8; i++)
                {
                    g.DrawImage(Image.FromFile("Pawn.png"), i * 79, 85);
                    g.DrawImage(Image.FromFile("Pawn_Black.png"), i * 79, 460);
                }
                g.DrawImage(Image.FromFile("Rook_Black.png"), 0, 545);
                g.DrawImage(Image.FromFile("Rook_Black.png"), 545, 545);
                g.DrawImage(Image.FromFile("Horse_black.png"), 465, 545);
                g.DrawImage(Image.FromFile("Horse_black.png"), 85, 545);
                g.DrawImage(Image.FromFile("bishop_black.png"), 385, 545);
                g.DrawImage(Image.FromFile("bishop_black.png"), 165, 545);
                g.DrawImage(Image.FromFile("King_Black.png"), 235, 545);
                g.DrawImage(Image.FromFile("Queen_Black.png"), 315, 545);
                g.DrawImage(Image.FromFile("Rook.png"), 0, 15);
                g.DrawImage(Image.FromFile("Rook.png"), 545, 15);
                g.DrawImage(Image.FromFile("Horse.png"), 465, 15);
                g.DrawImage(Image.FromFile("Horse.png"), 85, 15);
                g.DrawImage(Image.FromFile("bishop.png"), 385, 15);
                g.DrawImage(Image.FromFile("bishop.png"), 165, 15);
                g.DrawImage(Image.FromFile("King.png"), 235, 15);
                g.DrawImage(Image.FromFile("Queen.png"), 315, 15);
            }
        }

        public Brush Color()
        {
            switch (temp)
            {
                case true:
                    return Brushes.PeachPuff;
                case false:
                    return Brushes.Chocolate;
            }
        }
    }
}