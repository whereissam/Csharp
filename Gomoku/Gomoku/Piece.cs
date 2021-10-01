using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Gomoku
{
    abstract class Piece : PictureBox 
    {
        private static readonly int IMAGE_WIDTH = 50;
        public Piece(int x, int y)
        {
            this.BackColor = Color.Transparent;
            this.Location = new Point(x - IMAGE_WIDTH /2, y - IMAGE_WIDTH/2);
            this.Size = new Size(IMAGE_WIDTH, IMAGE_WIDTH);
            Console.WriteLine(this.Location);
        }

        public abstract PieceType GetPieceType();
    }
}
