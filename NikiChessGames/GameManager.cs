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

        List<KeyValuePair<FigureType, Type>> GameFigures;

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

            //previous version of the game // Main window
            #region previous version
            //FigureList figureList = new FigureList();
            //figureList.figures            

            if (gameType == "1st game")
            {
                SelectFirstGameTypeFigures();
            }
            standartBoard.DrawFinalBoard(GameFigures);
            //    List<KeyValuePair<FigureType, Type>> figur1 = new List<KeyValuePair<FigureType, Type>>()
            //{
            //        new KeyValuePair<FigureType, Type>(FigureType.Black,typeof(King)),
            //        new KeyValuePair<FigureType, Type>(FigureType.White,typeof(King)),
            //        new KeyValuePair<FigureType, Type>(FigureType.White,typeof(Queen)),
            //        new KeyValuePair<FigureType, Type>(FigureType.White,typeof(Rook)),
            //        new KeyValuePair<FigureType, Type>(FigureType.White,typeof(Rook))
            //};

            //ay sa eka voncvor te taza sarqac@
            //foreach (var item in figur1)
            //{
            //    CreateFigure(item.Value, item.Key);
            //}

            //foreach (var item in GameFigures)
            //{
            //    board.figuresList.Add(CreateFigure(item.Value, item.Key));
            //}
            //Board board1 = new Board();
            //board1.board = new string[9, 9];
            ////ConsoleKeyInfo input;
            //DrawBoard(board1, figures);
            //DrawingWPF(figures);
            #endregion
        }

        public List<Tuple<Point, string, string>> FigurePositions()
        {
            Point points = new Point();
            List<Figure> figuresPosition;
            List<Tuple<Point, string, string>> pos = new List<Tuple<Point, string, string>>();
            figuresPosition = standartBoard.ReturnFigureList();
            foreach (var item in figuresPosition)
            {
                Tuple<Point, string, string> manyItems;
                string figureType = string.Empty;

                points.X = item.xPos;
                points.Y = item.yPos;

                if (item.figureType == FigureType.White)
                    figureType = "White";
                else if (item.figureType == FigureType.Black)
                    figureType = "Black";

                manyItems = new Tuple<Point, string, string>(points, figureType, item.name);
                pos.Add(manyItems);
            }
            return pos;
        }

        //public static NikiStandartChess.Figures.Figure CreateFigure(Type type, FigureType figureType)
        //{
        //    NikiStandartChess.Figures.Figure figure = (NikiStandartChess.Figures.Figure)Activator.CreateInstance(type, figureType);
        //    return figure;
        //}

        /*
        public void StartInitialGame(Board board1, List<NikiStandartChess.Figures.Figure> figures)
        {
            do
            {
                //ResetColor();komenteci

                //ay sa taza sarqacna
                //BlackKingPosition(board1, figur1);// Sa el pti inikati unecvi
                //WhiteKingPosition(board1, figur1);//sa pti mtcvi algoritmi mej
                //WhiteQueenPosition(board1, figur1);//sa pti mtcvi algoritmi mej
                //LeftRookPosition(board1, figur1);//sa pti mtcvi algoritmi mej
                //RightRookPosition(board1, figur1);//sa pti mtcvi algoritmi mej

                BlackKingPosition(board1, figures);// Sa el pti inikati unecvi
                WhiteKingPosition(board1, figures);//sa pti mtcvi algoritmi mej
                WhiteQueenPosition(board1, figures);//sa pti mtcvi algoritmi mej
                LeftRookPosition(board1, figures);//sa pti mtcvi algoritmi mej
                RightRookPosition(board1, figures);//sa pti mtcvi algoritmi mej

                //Clear(); komenteci

                //ForegroundColor = ConsoleColor.Red;
                DrawBoard(board1, figures);

                //WriteLine();komenteci

                //ResetColor();komenteci

                //WriteLine("\nPlease press escape to out or else to continue\n"); komenteci

                //input = ReadKey(); komenteci

                //WriteLine(); komenteci
            } while (true); /*input.Key != ConsoleKey.Escape*/ //komenteci);
                                                               //}


        //2nd part of the previouse game
        /*
        #region 2nd part of the previouse game
        //specially this game(2)

        public static void BlackKingPosition(Board board, List<NikiStandartChess.Figures.Figure> figures)
        {
            bool check = false;
            string moveKing = "K";//ay ste prosto mi ban greci
            int previousPosX = figures[0].xPos;
            int previousPosY = figures[0].yPos;
            board.board[previousPosY, previousPosX] = "  ";
            bool checkingCorrectness = false;
            do
            {
                check = false;
                checkingCorrectness = false;
                //ResetColor();komenteci
                //WriteLine("\nPlease enter the cell coordinates, where the black King will move");komenteci
                //moveKing = ReadLine().ToLower();komenteci sranov er input stanum
                var z = CheckingInputs(moveKing, figures);
                figures[0].xPos = z.Item2;
                figures[0].yPos = z.Item1;
                if (checkingCorrectness != CheckingKingSteps(figures[0], previousPosX, previousPosY))
                {
                    checkingCorrectness = true;
                    //WriteLine("The King can make only one step to right-left or top-bottom");komenteci
                    //WriteLine("Please enter valid coordinates");komenteci
                }
                if (check != CheckingForOtherFigures(board, figures[0]))
                {
                    check = true;
                    //WriteLine("Please enter valid coordinates");komenteci
                }
                if (figures[0].xPos < 0 || checkingCorrectness == false || check == false)//ay ste ay es paymanic heto stugum enq 
                {
                    CheckingBlackKingInputs(figures, previousPosX, previousPosY);
                }


            } while (figures[0].xPos < 0 || checkingCorrectness || check);
            //ForegroundColor = ConsoleColor.Black;
            board.board[figures[0].yPos, figures[0].xPos] = "B" + figures[0].Name();
        }

        public static void WhiteKingPosition(Board board, List<NikiStandartChess.Figures.Figure> figures)
        {
            bool check = false;
            string moveKing = "K";//mi ankap ban greci
            int previousPosX = figures[1].xPos;
            int previousPosY = figures[1].yPos;
            board.board[previousPosY, previousPosX] = "  ";
            bool checkingCorrectness = false;
            do
            {
                check = false;
                checkingCorrectness = false;
                //ResetColor();komenteci
                //WriteLine("\nPlease enter the cell coordinates, where the white King will move");komenteci
                //moveKing = ReadLine().ToLower();komenteci
                var z = CheckingInputs(moveKing, figures);
                figures[1].xPos = z.Item2;
                figures[1].yPos = z.Item1;
                if (checkingCorrectness != CheckingKingSteps(figures[1], previousPosX, previousPosY))
                {
                    checkingCorrectness = true;
                    //WriteLine("The King can make only one step to right-left or top-bottom");komenteci
                    //WriteLine("Please enter valid coordinates");komenteci
                }
                if (check != CheckingForOtherFigures(board, figures[1]))
                {
                    check = true;
                    //WriteLine("Please enter valid coordinates");komenteci
                }
            } while (figures[1].xPos < 0 || checkingCorrectness || check);
            //ForegroundColor = ConsoleColor.Red;
            board.board[figures[1].yPos, figures[1].xPos] = "W" + figures[1].Name();
        }

        public static void WhiteQueenPosition(Board board, List<NikiStandartChess.Figures.Figure> figures)
        {
            bool check = false;
            string moveKing = "K";
            int previousPosX = figures[2].xPos;
            int previousPosY = figures[2].yPos;
            int tempX = previousPosX;
            int tempY = previousPosY;
            board.board[previousPosY, previousPosX] = "  ";
            bool checkingCorrectness = false;
            do
            {
                previousPosX = tempX;
                previousPosY = tempY;
                check = false;
                checkingCorrectness = false;
                //ResetColor();
                //WriteLine("\nPlease enter the cell coordinates, where the white Queen will move");
                //moveKing = ReadLine().ToLower();
                var z = CheckingInputs(moveKing, figures);
                figures[2].xPos = z.Item2;
                figures[2].yPos = z.Item1;
                if (checkingCorrectness != CheckingForOtherFigures(board, figures[2], previousPosX, previousPosY))
                {
                    checkingCorrectness = true;
                    //WriteLine("The Queen can not jump through other figures or stay in the same position");
                    //WriteLine("Please enter valid coordinates");
                }
                if (check != CheckingQueenSteps(figures[2], previousPosX, previousPosY))
                {
                    check = true;
                    //WriteLine("Please enter valid coordinates");
                }
            } while (figures[2].xPos < 0 || checkingCorrectness || check);
            board.board[figures[2].yPos, figures[2].xPos] = "W" + figures[2].Name();
        }

        public static void LeftRookPosition(Board board, List<NikiStandartChess.Figures.Figure> figures)
        {
            bool check = false;
            string moveKing = "K";
            int previousPosX = figures[3].xPos;
            int previousPosY = figures[3].yPos;
            board.board[previousPosY, previousPosX] = "  ";
            bool checkingCorrectness = false;
            do
            {
                check = false;
                checkingCorrectness = false;
                //ResetColor();
                //WriteLine("\nPlease enter the cell coordinates, where the Left Rook will move");
                //moveKing = ReadLine().ToLower();
                var z = CheckingInputs(moveKing, figures);
                figures[3].xPos = z.Item2;
                figures[3].yPos = z.Item1;
                if (checkingCorrectness != CheckingRookSteps(figures[3], previousPosX, previousPosY))
                {
                    checkingCorrectness = true;
                    //WriteLine("The Rook can make steps only to right-left or top-bottom");
                    //WriteLine("Please enter valid coordinates");
                }
                if (check != CheckingForOtherFigures(board, figures[3], previousPosX, previousPosY))
                {
                    check = true;
                    //WriteLine("Please enter valid coordinates");
                }
            } while (figures[3].xPos < 0 || checkingCorrectness || check);
            board.board[figures[3].yPos, figures[3].xPos] = "L" + figures[3].Name();
        }

        public static void RightRookPosition(Board board, List<NikiStandartChess.Figures.Figure> figures)
        {
            bool check = false;
            string moveKing = "K";
            int previousPosX = figures[4].xPos;
            int previousPosY = figures[4].yPos;
            board.board[previousPosY, previousPosX] = "  ";
            bool checkingCorrectness = false;
            do
            {
                check = false;
                checkingCorrectness = false;
                //ResetColor();
                //WriteLine("\nPlease enter the cell coordinates, where the Right Rook will move");
                //moveKing = ReadLine().ToLower();
                var z = CheckingInputs(moveKing, figures);
                figures[4].xPos = z.Item2;
                figures[4].yPos = z.Item1;
                if (checkingCorrectness != CheckingRookSteps(figures[4], previousPosX, previousPosY))
                {
                    checkingCorrectness = true;
                    //WriteLine("The Rook can make steps only to right-left or top-bottom");
                    //WriteLine("Please enter valid coordinates");
                }
                if (check != CheckingForOtherFigures(board, figures[4], previousPosX, previousPosY))
                {
                    check = true;
                    //WriteLine("Please enter valid coordinates");
                }
            } while (figures[4].xPos < 0 || checkingCorrectness || check);
            board.board[figures[4].yPos, figures[4].xPos] = "R" + figures[4].Name();
        }
        #endregion
        */

    }
}
