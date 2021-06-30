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

                    default:
                        break;
                }
            }

            return availableStep;
        }

        //1st region I think

        #region previouse game 1st section
        //Supporting methods(number 1) standart for any chess game

        //Sa el aktuar chi
        /*
        public static (int, int) CheckingBlackKingInputs(List<NikiStandartChess.Figures.Figure> figures, int previousBlackKingX, int previousPosY)//CheckingInputs
        {
            try
            {
                int blackKingPositionX = figures[0].xPos;
                int blackKingPositionY = figures[0].yPos;

                //int whiteQueenPositionX = figures[2].xPos;
                //int whiteQueenPositionY = figures[2].yPos;

                //int leftRookPositionX = figures[3].xPos;
                //int leftRookPositionY = figures[3].yPos;

                //int rightRookPositionX = figures[4].xPos;
                //int rightRookPositionY = figures[4].yPos;

                //int[] numbersArray = new int[3];
                //KeyValuePair<int, Figure>[] numbersAndFigures = new KeyValuePair<int, Figure>[3];
                //numbersAndFigures[0] = new KeyValuePair<int, Figure>(Math.Abs(previousBlackKingX - whiteQueenPositionX), figures[2]);
                //numbersAndFigures[1] = new KeyValuePair<int, Figure>(Math.Abs(previousBlackKingX - leftRookPositionX), figures[3]);
                //numbersAndFigures[2] = new KeyValuePair<int, Figure>(Math.Abs(previousBlackKingX - rightRookPositionX), figures[4]);
                //numbersAndFigures[0] = new KeyValuePair<int, Figure>(whiteQueenPositionX, figures[2]);
                //numbersAndFigures[1] = new KeyValuePair<int, Figure>(leftRookPositionX, figures[3]);
                //numbersAndFigures[2] = new KeyValuePair<int, Figure>(rightRookPositionX, figures[4]);
                //numbersAndFigures[0] = new KeyValuePair<int, Figure>(figures[2].xPos, figures[2]);
                //numbersAndFigures[1] = new KeyValuePair<int, Figure>(figures[3].xPos, figures[3]);
                //numbersAndFigures[2] = new KeyValuePair<int, Figure>(figures[4].xPos, figures[4]);
                //for (int i = 0; i < numbersAndFigures.Length; i++)
                //{
                //    numbersArray[i] = numbersAndFigures[i].Key;
                //}
                //Array.Sort(numbersArray);
                //int minNumber = numbersArray[0];
                int leftTempX = 0;//leftTempX
                int rightTempX = 0;//rightTempX
                int leftPosX = 1;
                int rightPosX = 8;

                for (int i = 0; i < 3; i++)
                {
                    if (figures[i + 2].xPos < figures[0].xPos)
                    {
                        leftTempX = figures[2].xPos;
                        if (leftPosX < leftTempX)
                        {
                            leftPosX = leftTempX;
                        }
                    }
                    else if (figures[i + 2].xPos > figures[0].xPos)
                    {
                        rightTempX = figures[i + 2].xPos;
                        if (rightPosX < rightTempX)
                        {
                            rightPosX = rightTempX;
                        }
                    }
                }

                //for (int i = 0; i < numbersAndFigures.Length; i++)
                //{
                //    if(numbersAndFigures[i].Value.xPos< blackKingPositionX)
                //    {
                //        leftTempX = numbersAndFigures[i].Key;
                //        if (leftPosX < leftTempX)
                //        {
                //            leftPosX = leftTempX;
                //        }                        
                //    }
                //    else if(numbersAndFigures[i].Value.xPos > blackKingPositionX)
                //    {
                //        rightTempX = numbersAndFigures[i].Key;
                //        if (rightPosX < rightTempX)
                //        {
                //            rightPosX = rightTempX;
                //        }                       
                //    }
                //}
                //foreach (var item in numbersAndFigures)
                //{
                //    if (item.Key == minNumber)
                //    {
                //        if(item.Value.xPos< blackKingPositionX)
                //        {
                //            leftPosX = item.Value.xPos;
                //        }
                //        else
                //        {
                //            rightPosX = item.Value.xPos;
                //        }                                              
                //    }
                //}

                if (blackKingPositionX < leftPosX || blackKingPositionX > rightPosX)
                {
                    //WriteLine("Wrong character"); komenteci

                    //blackKingX = 9;

                    //WriteLine("Please firstly enter right charackters from a to h"); komenteci
                }
                else if (blackKingPositionY < 1 || blackKingPositionY > 8)
                {
                    //WriteLine("Wrong number"); komenteci

                    //blackKingX = 9;

                    //WriteLine("Please enter right numbers from 1 to 8"); komenteci
                }
                return (blackKingPositionX, blackKingPositionY);
            }
            catch (ArgumentOutOfRangeException)
            {
                //WriteLine("Wrong length"); komenteci

                //WriteLine("Please enter onle one letter and number"); komenteci
                return (9, 0);
            }
        }
        */

        // sa aktual chi
        /*
        public static (int, int) CheckingInputs(string coordinates, List<NikiStandartChess.Figures.Figure> figures)
        {
            try
            {
                var z = TakingOutCoordinates(coordinates);
                int y = z.Item1;
                int x = z.Item2;
                if (coordinates.Length != 2)
                {
                    //WriteLine("Wrong length");komenteci
                    y = 9;
                    //WriteLine("Please enter onle one letter and number");komenteci
                }
                else if (y < 1 || y > 8)
                {
                    //WriteLine("Wrong character");komenteci
                    y = 9;
                    //WriteLine("Please firstly enter right charackters from a to h");komenteci
                }
                else if (x < 1 || x > 8)
                {
                    //WriteLine("Wrong number");komenteci
                    y = 9;
                    //WriteLine("Please enter right numbers from 1 to 8");komenteci
                }
                return (y, x);
            }
            catch (ArgumentOutOfRangeException)
            {
                //WriteLine("Wrong length");komenteci
                //WriteLine("Please enter onle one letter and number");komenteci
                return (9, 0);
            }
        }//ok
        */

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
        }//ok

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
        }//ok

        public static bool CheckingRookSteps(IFigure figure, Point nextPoint)//ok
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
        //sa el voncvor te aktuar chi
        /*
        public static bool CheckingForOtherFigures(Board board, NikiStandartChess.Figures.Figure figure, int PreviosPosX, int PreviosPosY)
        {
            int nextPosY = figure.yPos;
            int nextPosX = figure.xPos;
            //int x = PreviosPosX;
            //int y = PreviosPosY;
            int tempX = PreviosPosX;
            int tempY = PreviosPosY;
            do
            {
                if (nextPosX > PreviosPosX)
                {
                    int i = PreviosPosX + 1;
                    //x = i;
                    PreviosPosX = i;
                }
                else if (nextPosX < PreviosPosX)
                {
                    int i = PreviosPosX - 1;
                    //x = i;
                    PreviosPosX = i;
                }
                if (nextPosY > PreviosPosY)
                {
                    int i = PreviosPosY + 1;
                    //y = i;
                    PreviosPosY = i;
                }
                else if (nextPosY < PreviosPosY)
                {
                    int i = PreviosPosY - 1;
                    //y = i;
                    PreviosPosY = i;
                }
                //WriteLine(board.board[y, x] + "A");
                if (board.gameBoard[PreviosPosY, PreviosPosX] != "  " || (nextPosY == tempY && nextPosX == tempX))
                {
                    return true;
                }
            } while (nextPosX != PreviosPosX || nextPosY != PreviosPosY);
            return false;
        }//ok
        */
        //sa aktuar chi
        /*
        public static (int, int) TakingOutCoordinates(string coordinates)
        {
            if (coordinates.Length == 2)
            {
                char letter = coordinates[0];
                int y = 0;
                switch (letter)
                {
                    case 'a':
                        y = 1;
                        break;
                    case 'b':
                        y = 2;
                        break;
                    case 'c':
                        y = 3;
                        break;
                    case 'd':
                        y = 4;
                        break;
                    case 'e':
                        y = 5;
                        break;
                    case 'f':
                        y = 6;
                        break;
                    case 'g':
                        y = 7;
                        break;
                    case 'h':
                        y = 8;
                        break;
                }
                char number = coordinates[1];
                int x = 0;
                switch (number)
                {
                    case '1':
                        x = 1;
                        break;
                    case '2':
                        x = 2;
                        break;
                    case '3':
                        x = 3;
                        break;
                    case '4':
                        x = 4;
                        break;
                    case '5':
                        x = 5;
                        break;
                    case '6':
                        x = 6;
                        break;
                    case '7':
                        x = 7;
                        break;
                    case '8':
                        x = 8;
                        break;
                }
                return (x, y);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Wrong length");
            }
        }
        */

        //sa der zargacnela petk linelu
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
        #endregion



    }
}
