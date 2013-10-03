using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Puzzle
{
    class BoardLayout
    {
        private int[] board;

        public BoardLayout()
        {
            board =  new int[]{3,6,7,8,1,-1,2,5,4};
        }

        public bool Equals(BoardLayout compareBoard)
        {
            for (int i = 0; i < 8; i++)
            {
                if (this.board[i] != compareBoard.board[i]) return false;
            }
            return true;
        }
    }
}
