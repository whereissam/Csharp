using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{

    public partial class 五子棋 : Form
    {
        private Board board = new Board();

        private PieceType NextPieceType = PieceType.BLACK;
        private bool isBlack = true;
        public 五子棋()
        {
            InitializeComponent();

        }

        private void 五子棋_Load(object sender, EventArgs e)
        {

        }

        private void 五子棋_MouseDown(object sender, MouseEventArgs e)
        {
            if (isBlack)
            {
                Piece piece = board.PlaceAPiece(e.X, e.Y, NextPieceType);

                if (piece != null)
                {
                    this.Controls.Add(piece);
                    if (NextPieceType == PieceType.BLACK)
                        NextPieceType = PieceType.WHITE;
                    else if (NextPieceType == PieceType.WHITE)
                        NextPieceType = PieceType.BLACK;
                }
            }
        }

        private void 五子棋_MouseMove(object sender, MouseEventArgs e)
        {
            if(board.CanBePlaced(e.X, e.Y))
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
