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

            DrawBoard(board);
        }

        public static IFigure CreateFigure(Type type, FigureType figureType)
        {
            IFigure figure = (IFigure)Activator.CreateInstance(type, figureType);
            return figure;
        }

        public void DrawBoard(Board _board)
        {
            InitializeBoard(_board);
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    _board.i = i;
                    _board.j = j;
                    FigurePositions(_board);
                }
            }
        }

        public void DrawBoard(List<IFigure> figures)
        {
            InitializeBoard(board);
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    board.i = i;
                    board.j = j;
                    FigurePositions(board);
                }
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
                    _board.gameBoard[_i, _j] = "B" + _figure.Name;
                    _figure.xPos = _j;
                    _figure.yPos = _i;
                    break;
                }
                else if (_i == 8 && _j == 1 && _figure is Rook && _figure.figureType == FigureType.White && _board.gameBoard[_i, _j] == string.Empty)
                {
                    _board.gameBoard[_i, _j] = "R" + _figure.Name;
                    _figure.xPos = _j;
                    _figure.yPos = _i;
                    break;
                }
                else if (_i == 8 && _j == 3 && _figure is Queen && _figure.figureType == FigureType.White && _board.gameBoard[_i, _j] == string.Empty)
                {
                    _board.gameBoard[_i, _j] = "W" + _figure.Name; 
                    _figure.xPos = _j;
                    _figure.yPos = _i;
                    break;
                }
                else if (_i == 8 && _j == 4 && _figure is King && _figure.figureType == FigureType.White && _board.gameBoard[_i, _j] == string.Empty)
                {
                    _board.gameBoard[_i, _j] = "W" + _figure.Name;
                    _figure.xPos = _j;
                    _figure.yPos = _i;
                    break;
                }
                else if (_figure.xPos == 0 && _figure.yPos == 0 && _i == 8 && _j == 8 && _figure is Rook && _figure.figureType == FigureType.White && _board.gameBoard[_i, _j] == string.Empty)
                {
                    _board.gameBoard[_i, _j] = "L" + _figure.Name; 
                    _figure.xPos = _j;
                    _figure.yPos = _i;
                    break;
                }
            }
        }

        public void FigurePositions(Board _board)
        {
            if (count < 64)
            {
                FigureInitialPositions(_board);
                count++;
            }
            else
            {
                FigurePositionsDuringTheGame(_board);
            }
        }

        public void FigurePositionsDuringTheGame(Board _board)
        {
            int _i = _board.i;

            int _j = _board.j;

            foreach (var figure in _board.figuresList)
            {
                if (_i == figure.yPos && _j == figure.xPos && count > 63 && figure.figureType == FigureType.Black)
                {
                    _board.gameBoard[_i, _j] = "B" + figure.Name;
                }
                else if (_i == figure.yPos && _j == figure.xPos && count > 63 && figure.figureType == FigureType.White)
                {
                    _board.gameBoard[_i, _j] = "W" + figure.Name;
                }
            }
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

        public Board ReturnFigureList()
        {
            return board;
        }
    }
}
