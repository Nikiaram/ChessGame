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

        //List<Figure> figuresPosition;

        Board board;

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
            //List<Figure> figuresPosition;
            List<Tuple<Point, string, string>> pos = new List<Tuple<Point, string, string>>();
            board = standartBoard.ReturnFigureList();
            //figuresPosition = board.figuresList;
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

                manyItems = new Tuple<Point, string, string>(points, figureType, item.Name); // ste name er sarqeci Name
                pos.Add(manyItems);
            }
            return pos;
        }

        //public static NikiStandartChess.Figures.Figure CreateFigure(Type type, FigureType figureType)
        //{
        //    NikiStandartChess.Figures.Figure figure = (NikiStandartChess.Figures.Figure)Activator.CreateInstance(type, figureType);
        //    return figure;
        //}

        //sa el aktual chi
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

        #region 2nd part of the previouse game
        //specially this game(2)
        /*
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
        
        */
        #endregion


        public static int clickX = 0;
        public static int clickY = 0;


        public static int PClickX = 0;
        public static int PClickY = 0;

        //sa el petk chi
        #region from UI
        /*
        public static int black = 1;
        public static int white = 2;

        public static bool myTurn = true;
        public static bool clickable = false;

        /// <summary>
        /// Peace variables
        /// </summary>
        public static class Peace
        {
            public static class White
            {
                public static int[] Pawn = { 1, 2, 3, 4, 5, 6, 7, 8 };
                public static int[] Rook = { 9, 10 };
                public static int[] Knite = { 11, 12 };
                public static int[] Bishop = { 13, 14 };
                public static int Queen = 15;
                public static int King = 16;
            }

            public static class Black
            {
                public static int[] Pawn = { 17, 18, 19, 20, 21, 22, 23, 24 };
                public static int[] Rook = { 25, 26 };
                public static int[] Knite = { 27, 28 };
                public static int[] Bishop = { 29, 30 };
                public static int Queen = 31;
                public static int King = 32;
            }
        }

        //Base
        public static class Base
        {
            public static int[] ID = new int[65];
            public static int[] X = new int[65];
            public static int[] Y = new int[65];

        }

        public static int GetBaseID(int x, int y)
        {
            return ((x - 1) * 8) + y;
            //return ((x) * 8) + y;
        }

        //Move
        public static bool IsMoveable(int px, int py, int nx, int ny)
        {
            int ptype = GetType(px, py);
            int ntype = GetType(nx, ny);

            int pmodel = GetModel(px, py);
            int nmodel = GetModel(nx, ny);

            double Distance = GetDistance(px, py, nx, ny);
            int way = GetWay(px, py, nx, ny);

            if (GetTypeName(px, py) == "Pawn")
            {
                if (pmodel == white)
                {
                    if (Distance == 1 && way == Way.Up && ntype == 0)
                        return true;
                    if (Distance == 2 && way == Way.Up && ntype == 0 && py == 2)
                        return true;
                    if (Distance == 1)
                    {
                        if (way == Way.UpLeft || way == Way.UpRight)
                            if (ntype > 0 && pmodel != nmodel) return true;
                    }
                }
                if (pmodel == black)
                {
                    if (Distance == 1 && way == Way.Down && ntype == 0)
                        return true;
                    if (Distance == 2 && way == Way.Down && ntype == 0 && py == 7)
                        return true;
                    if (Distance == 1)
                    {
                        if (way == Way.DownLeft || way == Way.DownRight)
                            if (ntype > 0 && pmodel != nmodel) return true;
                    }
                }
            }
            return true;
        }

        public static class Way
        {
            public static int Up = 1;
            public static int Down = 2;
            public static int Right = 3;
            public static int Left = 4;
            public static int UpRight = 5;
            public static int UpLeft = 6;
            public static int DownRight = 7;
            public static int DownLeft = 8;
        }

        public static int GetWay(int px, int py, int nx, int ny)
        {
            int ix = (int)(double)Math.Sqrt(Math.Pow(px - nx, 2));
            int iy = (int)(double)Math.Sqrt(Math.Pow(py - ny, 2));


            if (px == nx)
            {
                if (ny > py) return Way.Up;
                if (ny < py) return Way.Down;
            }
            else if (py == ny)
            {
                if (nx > px) return Way.Right;
                if (nx < px) return Way.Left;
            }
            else if (ix == iy)
            {
                if (ny > py && nx > px) return Way.UpRight;
                if (ny > py && nx < px) return Way.UpLeft;
                if (ny < py && nx > px) return Way.DownRight;
                if (ny < py && nx < px) return Way.DownLeft;
            }

            return 0;
        }

        public static double GetDistance(int px, int py, int nx, int ny)
        {
            return (double)(Math.Sqrt(Math.Pow(px - nx, 2) + Math.Pow(py - ny, 2)));
        }

        public static string GetTypeName(int x, int y)
        {
            int type = Base.ID[GetBaseID(x, y)];

            if (Peace.White.Pawn.Contains(type) && Peace.Black.Pawn.Contains(type)) return "Pawn";
            if (Peace.White.Knite.Contains(type) && Peace.Black.Knite.Contains(type)) return "Knite";
            if (Peace.White.Bishop.Contains(type) && Peace.Black.Bishop.Contains(type)) return "Bishop";
            if (Peace.White.Rook.Contains(type) && Peace.Black.Rook.Contains(type)) return "Rook";

            if (type == Peace.White.Queen || type == Peace.Black.Queen) return "Queen";
            if (type == Peace.White.King || type == Peace.Black.King) return "King";

            return "";
        }

        //public static bool SetBase(int px, int py, int x, int y, List<NikiStandartChess.Figures.Figure> figures)
        //{
        //    int type = GetType(px, py);
        //    int nType = GetType(x, y);
        //    if (nType > 0)
        //    {

        //    }

        //    Base.ID[GetBaseID(x, y)] = type;
        //    SetImage(MainWindow.ChessImages[GetBaseID(x, y)], type);
        //    SetImage(MainWindow.ChessImages[GetBaseID(px, py)], 0);
        //    //DrawingWPF()
        //    return true;
        //}

        //public static void SetImage(Image img, int type)
        //{
        //    //img.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, (System.Threading.ThreadStart)delegate ()
        //    // {
        //    //     if (type < 1) img.Visibility = Visibility.Hidden;
        //    /* else*/
        //    img.Source = new BitmapImage(new Uri("\\Images\\" + MainWindow.ImageName[type], UriKind.Relative));
        //    //});
        //}

        //public static void SetImage(Image img, NikiStandartChess.Figures.Figure figure)
        //{
        //    //img.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, (System.Threading.ThreadStart)delegate ()
        //    // {
        //    //     if (type < 1) img.Visibility = Visibility.Hidden;
        //    /* else*/
        //    img.Source = new BitmapImage(new Uri("\\Images\\" + figure.imageName, UriKind.Relative));
        //    //});
        //}
        /*
        public static int GetModel(int x, int y)
        {
            int model = Base.ID[GetBaseID(x, y)];
            if (model > 0 && model < 17) return white;
            if (model > 16) return black;
            return -1;
        }

        public static int GetType(int x, int y)
        {
            if (x < 1 || x > 8) return 0;
            if (x < 1 || y > 8) return 0;

            return Base.ID[GetBaseID(x, y)];
        }
        */
        #endregion


        //----Select On ChessPeace
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
            if (gameCount&& figureOrEmpty)
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

