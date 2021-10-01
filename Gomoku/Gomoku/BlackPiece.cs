using System;
using System.Collections.Generic;
using System.Text;

namespace Gomoku
{
    class BlackPiece : Piece
    {
        public BlackPiece(int x, int y) : base(x, y)
        {
            this.Image = Properties.Resources.black;
        }

        public override PieceType GetPieceType()
        {
            return PieceType.BLACK;
        }
    }
}
