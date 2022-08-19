using System;
using System.Collections.Generic;
using System.Linq;

namespace Recursion
{
    public class NQueensProblem
    {
        
            public List<List<string>> Solutions = new List<List<string>>();
            private List<List<int>> ChessBoard = new List<List<int>>();
            private readonly int TotalNumberOfQueens;
            public NQueensProblem(int numOfQueens)
            {
                TotalNumberOfQueens = numOfQueens;
                //create board schema  
                for (int i = 0; i < TotalNumberOfQueens; i++)
                {
                    List<int> row = Enumerable.Repeat(0, TotalNumberOfQueens).ToList();
                    ChessBoard.Add(row);
                }
                //start placing queen  
                TryPlaceQueen();
            }
            //try place 0th queen by default  
            void TryPlaceQueen(int nthQueen = 0)
            {
                //check for out of range  
                if (TotalNumberOfQueens <= nthQueen)
                    return;

                //iterate over every cell  
                for (int i = 0; i < TotalNumberOfQueens; i++)
                {
                    //skip when no more queen can be added to this board  
                    if (ChessBoard[nthQueen][i] != 0)
                        continue;

                    //place the queen and update board  
                    ChessBoard[nthQueen][i] = -1;
                    UpdateBoard(nthQueen, i, 1);

                    //this board is valid when last queen is added to last row  
                    if (nthQueen == TotalNumberOfQueens - 1)
                        AddBoardToSolutions();
                    //try again adding more queens  
                    else
                        TryPlaceQueen(nthQueen + 1);

                    //remove the queen we just added  
                    ChessBoard[nthQueen][i] = 0;
                    UpdateBoard(nthQueen, i, -1);
                }
            }
            void UpdateBoard(int i, int j, int value)
            {
                for (int k = 0; k < i; k++)
                    ChessBoard[k][j] += value;

                //for down  
                for (int k = i + 1; k < TotalNumberOfQueens; k++)
                    ChessBoard[k][j] += value;

                //for left  
                for (int k = 0; k < j; k++)
                    ChessBoard[i][k] += value;

                //for Right  
                for (int k = j + 1; k < TotalNumberOfQueens; k++)
                    ChessBoard[i][k] += value;

                //for up-left  
                for (int m = i - 1, n = j - 1; m >= 0 && n >= 0; m--, n--)
                    ChessBoard[m][n] += value;

                //for up-right  
                for (int m = i - 1, n = j + 1; m >= 0 && n < TotalNumberOfQueens; m--, n++)
                    ChessBoard[m][n] += value;

                //for down-left  
                for (int m = i + 1, n = j - 1; m < TotalNumberOfQueens && n >= 0; m++, n--)
                    ChessBoard[m][n] += value;

                //for down-right  
                for (int m = i + 1, n = j + 1; m < TotalNumberOfQueens && n < TotalNumberOfQueens; m++, n++)
                    ChessBoard[m][n] += value;
            }
            void AddBoardToSolutions()
            {
                List<string> newBoard = new List<string>();
                for (int k = 0; k < TotalNumberOfQueens; k++)
                {
                    string row = string.Empty;
                    for (int j = 0; j < TotalNumberOfQueens; j++)
                        row += ChessBoard[k][j] == -1 ? "Q" : "O";
                    newBoard.Add(row);
                }
                //add current board as a solution  
                Solutions.Add(newBoard);
            }
        }
}
