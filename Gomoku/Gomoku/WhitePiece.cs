using System;
using System.Collections.Generic;
using System.Text;

namespace Gomoku
{
    class WhitePiece : Piece
    {
        public WhitePiece(int x, int y) : base(x, y)
        {
            this.Image = Properties.Resources.white;
        }

        public override PieceType GetPieceType()
        {
            return PieceType.WHITE;
        }
    }
}
