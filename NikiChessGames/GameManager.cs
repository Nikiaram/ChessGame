using NikiStandartChess;
using NikiStandartChess.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikiChessGames
{
    public class GameManager
    {
        StandartBoardManager standartBoard = new StandartBoardManager();

        StandartGameManager standartGameManager = new StandartGameManager();

        List<KeyValuePair<FigureType, Type>> GameFigures;

        Board board;

        public static int clickX = 0;

        public static int clickY = 0;

        public static int PClickX = 0;

        public static int PClickY = 0;

        public int figureNumber;

        public bool gameCount = true;

        public bool GameManagerCount()
        {
            return gameCount;
        }

        bool figureOrEmpty;

        public void SelectFirstGameTypeFigures()
        {
            GameFigures = new List<KeyValuePair<FigureType, Type>>()
            {
                    new KeyValuePair<FigureType, Type>(FigureType.Black,typeof(King)),
                    new KeyValuePair<FigureType, Type>(FigureType.White,typeof(King)),
                    new KeyValuePair<FigureType, Type>(FigureType.White,typeof(Queen)),
                    new KeyValuePair<FigureType, Type>(FigureType.White,typeof(Rook)),
                    new KeyValuePair<FigureType, Type>(FigureType.White,typeof(Rook))
            };
        }

        public void DrawGame(string gameType)
        {
            if (gameType == "1st game")
            {
                SelectFirstGameTypeFigures();
            }
            standartBoard.DrawFinalBoard(GameFigures);
        }

        public List<Tuple<Point, string, string>> FigurePositions()
        {
            Point points = new Point();

            List<Tuple<Point, string, string>> pos = new List<Tuple<Point, string, string>>();

            board = standartBoard.ReturnFigureList();

            foreach (var item in board.figuresList)
            {
                Tuple<Point, string, string> manyItems;
                string figureType = string.Empty;

                points.X = item.xPos;
                points.Y = item.yPos;

                if (item.figureType == FigureType.White)
                    figureType = "White";
                else if (item.figureType == FigureType.Black)
                    figureType = "Black";

                manyItems = new Tuple<Point, string, string>(points, figureType, item.Name);
                pos.Add(manyItems);
            }
            return pos;
        }

        public void SelectBase(int x, int y)
        {
            figureOrEmpty = CheckingPosition(x, y);
            clickX = x;
            clickY = y;
            SelectFigure();
        }

        public bool CheckingPosition(int x, int y)
        {
            if (gameCount)
            {
                figureNumber = 0;
            }
            int count = 0;
            foreach (var figure in board.figuresList)
            {
                if (figure.xPos == x && figure.yPos == y)
                {
                    count++;
                    break;
                }
                if (gameCount)
                    figureNumber++;
            }
            if (count == 0)
                return false;
            else
                return true;
        }

        public void SelectFigure()
        {
            Point nextPoint = new Point();
            nextPoint.X = clickX;
            nextPoint.Y = clickY;
            if (gameCount && figureOrEmpty)
            {
                PClickX = clickX;
                PClickY = clickY;
                gameCount = false;
            }
            else if (gameCount == false && figureOrEmpty == false)
            {
                updateFigurePositions(nextPoint);
                standartBoard.DrawBoard(board.figuresList);
                gameCount = true;
            }
        }

        public void updateFigurePositions(Point nextPoint)
        {
            if (CheckingAvailability(nextPoint))
            {
                board.figuresList[figureNumber].xPos = clickX;
                board.figuresList[figureNumber].yPos = clickY;
            }
        }

        public bool CheckingAvailability(Point nextPoint)
        {
            return standartGameManager.CallingFigureTypeMethod(nextPoint, board, figureNumber);
        }
    }
}

