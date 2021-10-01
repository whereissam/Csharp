using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Gomoku
{
    class Board
    {
        public static readonly int NODE_COUNT = 9;
        private static readonly Point NO_MATCH_NODE = new Point(-1, -1);
        private static readonly int OFFSET = 75;
        private static readonly int NODE_RADIUS = 10;
        private static readonly int NODE_DISTANCE = 75;

        private Piece[,] pieces = new Piece[NODE_COUNT, NODE_COUNT];

        private Point lastPlacedNode = NO_MATCH_NODE;
        public Point LastPlacedNode { get { return lastPlacedNode; } }

        public PieceType GetPieceType(int nodeIdX, int nodeIdY)
        {
            if (pieces[nodeIdX, nodeIdY] == null)
                return PieceType.NONE;
            else
                return pieces[nodeIdX, nodeIdY].GetPieceType();
        }
        public bool CanBePlaced(int x, int y)
        {
            //找出最近的節點
            Point nodeId = FindTheClosetNode(x, y);

            //如果沒有回傳false
            if (nodeId == NO_MATCH_NODE)
                return false;

            //有的話檢查上面是否有棋子
            return true;
        }

        public Piece PlaceAPiece(int x, int y, PieceType type)
        {
            //找出最近的節點
            Point nodeId = FindTheClosetNode(x, y);

            //如果沒有回傳 null
            if (nodeId == NO_MATCH_NODE)
                return null; //回傳null = 沒有物件

            //有的話檢查上面是否有棋子
            if (pieces[nodeId.X, nodeId.Y] != null)
                return null;


            //根據 type 產生對應的棋子
            Point formPos = convertToFromPosition(nodeId);
            if (type == PieceType.BLACK)
                pieces[nodeId.X, nodeId.Y] = new BlackPiece(formPos.X, formPos.Y);
            else if (type == PieceType.WHITE)
                pieces[nodeId.X, nodeId.Y] = new WhitePiece(formPos.X, formPos.Y);

            //紀錄最後下棋位置
            lastPlacedNode = nodeId;

            return pieces[nodeId.X, nodeId.Y];
        }

        private Point convertToFromPosition(Point nodeId)
        {
            Point formPosition = new Point();
            formPosition.X = nodeId.X * NODE_DISTANCE + OFFSET;
            formPosition.Y = nodeId.Y * NODE_DISTANCE + OFFSET;

            return formPosition;
        }

        //二維判斷座標
        private Point FindTheClosetNode(int x, int y)
        {
            int nodeIdX = FindTheClosetNode(x);
            if (nodeIdX == -1 || nodeIdX >= NODE_COUNT)
                return NO_MATCH_NODE;

            int nodeIdY = FindTheClosetNode(y);
            if (nodeIdY == -1 || nodeIdX >= NODE_COUNT)
                return NO_MATCH_NODE;

            return new Point(nodeIdX, nodeIdY);
        }
     
        //一維判斷座標，依照點座標長度來判斷
        private int FindTheClosetNode(int pos)
        {
            if (pos < OFFSET - NODE_RADIUS)
                return -1;

            pos -= OFFSET;

            int quotient = pos / NODE_DISTANCE;
            int reminder = pos % NODE_DISTANCE;

            if (reminder <= NODE_RADIUS)
                return quotient;
            else if (reminder >= NODE_DISTANCE - NODE_RADIUS)
                return quotient + 1;
            else
                return -1;
        }
    }
}
