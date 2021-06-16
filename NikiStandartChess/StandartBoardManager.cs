using NikiStandartChess.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikiStandartChess
{
    public class StandartBoardManager
    {
        public Board board = new Board();

        public static int count = 0;

        public void DrawFinalBoard(List<KeyValuePair<FigureType, Type>> GameFigures)
        {
            foreach (var item in GameFigures)
            {
                board.figuresList.Add(CreateFigure(item.Value, item.Key));
            }

            board.gameBoard = new string[9, 9];
            //ConsoleKeyInfo input;
            DrawBoard(board);
            //DrawingWPF(figures);
        }

        public static Figure CreateFigure(Type type, FigureType figureType)
        {
            Figure figure = (Figure)Activator.CreateInstance(type, figureType);
            return figure;
        }

        public static void DrawBoard(Board _board)
        {
            InitializeBoard(_board);
            for (int i = 1; i < 9; i++)
            {
                //if (i % 2 == 0)
                //{
                for (int j = 1; j < 9; j++)
                {
                    _board.i = i;
                    _board.j = j;
                    FigurePositions(_board);
                }
                //}
                //else
                //{
                //    for (int j = 0; j < 9; j++)
                //    {
                //        _board.i = i;
                //        _board.j = j;
                //        InitializeBoard(_board, figures, ConsoleColor.Gray, ConsoleColor.White);
                //    }
                //}
                //WriteLine();
            }
        }

        public static void FigureInitialPositions(Board _board)
        {
            int _i = _board.i;
            int _j = _board.j;
            foreach (var _figure in _board.figuresList)
            {
                if (_i == 1 && _j == 4 && _figure is King && _figure.figureType == FigureType.Black && _board.gameBoard[_i, _j] == string.Empty)
                {
                    //ForegroundColor = ConsoleColor.Black;
                    _board.gameBoard[_i, _j] = "B" + _figure.Name();//Black King
                    _figure.xPos = _j;
                    _figure.yPos = _i;
                    //int chessImageNumber = 8 * _j - (8 - _i);
                    //Game.SetImage(ChessImages[chessImageNumber], _figure);

                    /*
                     ChessImages[1] = Ix1y1;
                ChessImages[2] = Ix1y2;
                ChessImages[3] = Ix1y3;
                ChessImages[4] = Ix1y4;
                ChessImages[5] = Ix1y5;
                ChessImages[6] = Ix1y6;
                ChessImages[7] = Ix1y7;
                ChessImages[8] = Ix1y8;

                ChessImages[9] = Ix2y1;
                ChessImages[10] = Ix2y2;
                ChessImages[11] = Ix2y3;
                ChessImages[12] = Ix2y4;
                ChessImages[13] = Ix2y5;
                ChessImages[14] = Ix2y6;
                ChessImages[15] = Ix2y7;
                ChessImages[16] = Ix2y8;
                    */
                    break;
                }
                else if (_i == 8 && _j == 1 && _figure is Rook && _figure.figureType == FigureType.White && _board.gameBoard[_i, _j] == string.Empty)
                {
                    // ForegroundColor = ConsoleColor.Red;
                    _board.gameBoard[_i, _j] = "R" + _figure.Name();// Right Rook
                    _figure.xPos = _j;
                    _figure.yPos = _i;
                    //int chessImageNumber = 8 * _j - (8 - _i);
                    //Game.SetImage(ChessImages[chessImageNumber], _figure);
                    break;
                }
                else if (_i == 8 && _j == 3 && _figure is Queen && _figure.figureType == FigureType.White && _board.gameBoard[_i, _j] == string.Empty)
                {
                    //ForegroundColor = ConsoleColor.Red;
                    _board.gameBoard[_i, _j] = "W" + _figure.Name(); //White Queen
                    _figure.xPos = _j;
                    _figure.yPos = _i;
                    //int chessImageNumber = 8 * _j - (8 - _i);
                    //Game.SetImage(ChessImages[chessImageNumber], _figure);
                    break;
                }
                else if (_i == 8 && _j == 4 && _figure is King && _figure.figureType == FigureType.White && _board.gameBoard[_i, _j] == string.Empty)
                {
                    //ForegroundColor = ConsoleColor.Red;
                    _board.gameBoard[_i, _j] = "W" + _figure.Name(); // White King
                    _figure.xPos = _j;
                    _figure.yPos = _i;
                    //int chessImageNumber = 8 * _j - (8 - _i);
                    //Game.SetImage(ChessImages[chessImageNumber], _figure);
                    break;
                }
                else if (_figure.xPos==0 && _figure.yPos==0 && _i == 8 && _j == 8 && _figure is Rook && _figure.figureType == FigureType.White && _board.gameBoard[_i, _j] == string.Empty /*_figure.figureNumber == FigureNumber.Left*/)
                {
                    //ForegroundColor = ConsoleColor.Red;
                    _board.gameBoard[_i, _j] = "L" + _figure.Name(); // Left Rook
                    _figure.xPos = _j;
                    _figure.yPos = _i;
                    //int chessImageNumber = 8 * _j - (8 - _i);
                    //Game.SetImage(ChessImages[chessImageNumber], _figure);
                    break;
                }
                //else
                //{
                //    _board.gameBoard[_i, _j] = string.Empty;
                //}
            }
        }

        public static void FigurePositions(Board _board)
        {
            if (count < 64)
            {
                FigureInitialPositions(_board);
                count++;
            }
            //if (_i == figures[0].yPos && _j == figures[0].xPos && count > 63)
            //{
            //    //ForegroundColor = ConsoleColor.Black;
            //    //_board.board[_i, _j] = "B" + figures[0].Name();//Black King
            //    //figures[0].xPos = _j;
            //    //figures[0].yPos = _i;
            //}
            //else if (_i == figures[1].yPos && _j == figures[1].xPos && count > 63)
            //{
            //    //ForegroundColor = ConsoleColor.Red;
            //    //_board.board[_i, _j] = "W" + figures[1].Name();//White King
            //    //figures[1].xPos = _j;
            //    //figures[1].yPos = _i;
            //}
            //else if (_i == figures[2].yPos && _j == figures[2].xPos && count > 63)
            //{
            //    ForegroundColor = ConsoleColor.Red;
            //    //_board.board[_i, _j] = "W" + figures[2].Name();//White Queen
            //    //figures[2].xPos = _j;
            //    //figures[2].yPos = _i;
            //}
            //else if (_i == figures[3].yPos && _j == figures[3].xPos && count > 63)
            //{
            //    ForegroundColor = ConsoleColor.Red;
            //    //_board.board[_i, _j] = "L" + figures[3].Name();//Left Rook
            //    //figures[3].xPos = _j;
            //    //figures[3].yPos = _i;
            //}
            //else if (_i == figures[4].yPos && _j == figures[4].xPos && count > 63)
            //{
            //    ForegroundColor = ConsoleColor.Red;
            //    //_board.board[_i, _j] = "R" + figures[4].Name();//Right Rook
            //    //figures[4].xPos = _j;
            //    //figures[4].yPos = _i;
            //}
        }

        public static void InitializeBoard(Board _board)
        {
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    _board.i = i;
                    _board.j = j;
                    _board.gameBoard[i, j] = string.Empty;
                }
            }
        }

        public List<Figure> ReturnFigureList()
        {
            return board.figuresList ;
        }
    }
}
