using NikiStandartChess.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikiStandartChess
{
    public class StandartGameManager
    {
        public bool CallingFigureTypeMethod(Point nextPoint, Board board, int figureNumber)
        {
            bool freeGridCheck = CheckingForOtherFigures(board, nextPoint);

            bool availableStep = false;

            if (freeGridCheck)
            {
                switch (board.figuresList[figureNumber])
                {
                    case King:
                        {
                            availableStep = CheckingKingSteps(board.figuresList[figureNumber], nextPoint);
                            break;
                        }
                    case Rook:
                        {
                            availableStep = CheckingRookSteps(board.figuresList[figureNumber], nextPoint);
                            break;
                        }
                    case Queen:
                        {
                            availableStep = CheckingQueenSteps(board.figuresList[figureNumber], nextPoint);
                            break;
                        }
                }
            }

            return availableStep;
        }

        public static bool CheckingKingSteps(IFigure figure, Point nextPoint)
        {
            int y = nextPoint.Y;
            int x = nextPoint.X;
            if ((x - figure.xPos == 1 || x - figure.xPos == -1 || x - figure.xPos == 0)
                && (y - figure.yPos == 1 || y - figure.yPos == -1 || y - figure.yPos == 0)
                && ((x - figure.xPos != 0 || y - figure.xPos != 0)))
            {
                return true;
            }
            return false;
        }

        public static bool CheckingQueenSteps(IFigure figure, Point nextPoint)
        {
            int nextPosY = nextPoint.Y;
            int nextPosX = nextPoint.X;
            int tempX = figure.xPos;
            int tempY = figure.yPos;
            if (Math.Abs(figure.xPos - nextPosX) == Math.Abs(figure.yPos - nextPosY)
                || nextPosY - figure.yPos == 0 || nextPosX - figure.xPos == 0)
            {
                return true;
            }
            return false;
        }

        public static bool CheckingRookSteps(IFigure figure, Point nextPoint)
        {
            int nextPosY = nextPoint.Y;
            int nextPosX = nextPoint.X;
            int tempX = figure.xPos;
            int tempY = figure.yPos;
            if (nextPosY - figure.yPos == 0 || nextPosX - figure.xPos == 0)
            {
                return true;
            }
            return false;
        }
        
        public static bool CheckingForOtherFigures(Board board, Point nextPoint)
        {
            try
            {
                if (board.gameBoard[nextPoint.Y, nextPoint.X] == string.Empty)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return true;
            }
            return false;
        }
    }
}
