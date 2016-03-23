namespace CodeWars._5kyuTicTacToe
{
    // If we were to set up a Tic-Tac-Toe game, we would want to know whether the board's current state is solved, 
    // wouldn't we? Our goal is to create a function that will check that for us!
    // Assume that the board comes in the form of a 3x3 array, where the value is 0 if a spot is empty, 1 if it is an X, or 2 if it is an O, like so:
    // [[0,0,1],
    //  [0,1,2],
    //  [2,1,0]]
    // We want our function to return -1 if the board is not solved yet, 1 if X won, 2 if O won, or 0 if it's a cat's game(i.e.a draw).
    // { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } }
    public class Task
    {
        public class TicTacToe
        {
            public static int GetVertical(int i, int[,] board, int player)
            {
                return board[0, i] == player && board[1, i] == player && board[2, i] == player ? 3 : 0;
            }

            public static int GetHorizontal(int i, int[,] board, int player)
            {
                return board[i, 0] == player && board[i, 1] == player && board[i, 2] == player ? 3 : 0;
            }

            public static int GetSlash(int[,] board, int player)
            {
                return board[0, 2] == player && board[1, 1] == player && board[2, 0] == player ? 3 : 0;
            }

            public static int GetBackSlash(int[,] board, int player)
            {
                return board[0, 0] == player && board[1, 1] == player && board[2, 2] == player ? 3 : 0;
            }

            public static int GetEmptyValues(int i, int[,] board)
            {
                return board[i, 0] == 0 || board[i, 1] == 0 || board[i, 2] == 0 ? 1 : 0;
            }

            public static int IsSolved(int[,] board)
            {
                // Position meaning: 0 = |, 1 = -, 2 = /, 3 = \
                int[] x = new int[4]; // 1
                int[] o = new int[4]; // 2
                int emptyVals = 0;

                for (int i = 0; i < 3; i++)
                {
                    x[0] += GetVertical(i, board, 1);
                    o[0] += GetVertical(i, board, 2);

                    x[1] += GetHorizontal(i, board, 1);
                    o[1] += GetHorizontal(i, board, 2);

                    emptyVals += GetEmptyValues(i, board);
                }

                x[2] = GetSlash(board, 1);
                o[2] = GetSlash(board, 2);

                x[3] = GetBackSlash(board, 1);
                o[3] = GetBackSlash(board, 2);

                bool isX = x[0] == 3 || x[1] == 3 || x[2] == 3 || x[3] == 3;
                bool isO = o[0] == 3 || o[1] == 3 || o[2] == 3 || o[3] == 3;
                bool isTableCompleted = emptyVals == 0;

                if ((isX && isO) || isTableCompleted) return 0;
                if (isX) return 1;
                if (isO) return 2;
                return -1;
            }

            // myjinxin2015
            //public int IsSolved(int[,] b)
            //{
            //    var c012 = new int[] { 0, 1, 2 };
            //    var s = string.Join(",", c012.Select(x => string.Join("", c012.Select(y => b[x, y])))) + ","
            //         + string.Join(",", c012.Select(x => string.Join("", c012.Select(y => b[y, x])))) + ","
            //         + string.Join("", c012.Select(x => b[x, x])) + ","
            //         + string.Join("", c012.Select(x => b[2 - x, x]));
            //    return s.Contains("111") ? 1 : s.Contains("222") ? 2 : !s.Contains("0") ? 0 : -1;
            //}

            // Seprum
            //public int IsSolved(int[,] board)
            //{
            //    int d1 = 1, d2 = 1;
            //    bool empty = false;
            //    for (int i = 0; i < 3; i++)
            //    {
            //        d1 *= board[i, i];
            //        d2 *= board[2 - i, i];
            //        int row = 1, col = 1;
            //        for (int j = 0; j < 3; j++)
            //        {
            //            row *= board[i, j];
            //            col *= board[j, i];
            //        }
            //        if (row == 1 || col == 1) return 1;
            //        if (row == 8 || col == 8) return 2;
            //        if (row == 0 || col == 0) empty = true;
            //    }
            //    if (d1 == 1 || d2 == 1) return 1;
            //    if (d1 == 8 || d2 == 8) return 2;
            //    if (empty) return -1;
            //    return 0;
            //}

            // Bwaffles
            //public int IsSolved(int[,] board)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        if (board[i, 0] == 2 && board[i, 1] == 2 && board[i, 2] == 2) return 2;
            //        if (board[i, 0] == 1 && board[i, 1] == 1 && board[i, 2] == 1) return 1;

            //        if (board[0, i] == 1 && board[1, i] == 1 && board[2, i] == 1) return 1;
            //        if (board[0, i] == 2 && board[1, i] == 2 && board[2, i] == 2) return 2;
            //    }

            //    if (board[0, 0] == 1 && board[1, 1] == 1 && board[2, 2] == 1) return 1;
            //    if (board[0, 0] == 2 && board[1, 1] == 2 && board[2, 2] == 2) return 2;
            //    if (board[0, 2] == 1 && board[1, 1] == 1 && board[2, 0] == 1) return 1;
            //    if (board[0, 2] == 2 && board[1, 1] == 2 && board[2, 0] == 2) return 2;

            //    foreach (int i in board) if (i == 0) return -1;
            //    return 0;
            //}
        }
    }
}
