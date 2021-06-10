using NikiStandartChess;
using NikiStandartChess.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace NikiChessGame_V4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int clickX = 0;
        public static int clickY = 0;

        public static Image[] ChessImages = new Image[65];
        public static string[] ImageName = new string[65];

        public MainWindow()
        {
            InitializeComponent();
            StartTheSelectedGame();
        }
        public void StartTheSelectedGame()
        {
            //Chess Images
            {
                //for (int i = 1; i < 9; i++)
                //{
                //    ImageName[i] = "WPawn.png";
                //}

                //ImageName[9] = "WRook.png";
                //ImageName[10] = "WRook.png";
                //ImageName[11] = "WKnight.png";
                //ImageName[12] = "WKnight.png";
                //ImageName[13] = "WBishop.png";
                //ImageName[14] = "WBishop.png";
                //ImageName[15] = "WQueen.png";//done
                //ImageName[16] = "WKing.png";//done


                //for (int i = 17; i < 25; i++)
                //{
                //    ImageName[i] = "BPawn.png";
                //}

                //ImageName[25] = "BRook.png";
                //ImageName[26] = "BRook.png";
                //ImageName[27] = "BKnight.png";
                //ImageName[28] = "BKnight.png";
                //ImageName[29] = "BBishop.png";
                //ImageName[30] = "BBishop.png";
                //ImageName[31] = "BQueen.png";//done
                //ImageName[32] = "BKing.png";//done

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

                ChessImages[17] = Ix3y1;
                ChessImages[18] = Ix3y2;
                ChessImages[19] = Ix3y3;
                ChessImages[20] = Ix3y4;
                ChessImages[21] = Ix3y5;
                ChessImages[22] = Ix3y6;
                ChessImages[23] = Ix3y7;
                ChessImages[24] = Ix3y8;

                ChessImages[25] = Ix4y1;
                ChessImages[26] = Ix4y2;
                ChessImages[27] = Ix4y3;
                ChessImages[28] = Ix4y4;
                ChessImages[29] = Ix4y5;
                ChessImages[30] = Ix4y6;
                ChessImages[31] = Ix4y7;
                ChessImages[32] = Ix4y8;

                ChessImages[33] = Ix5y1;
                ChessImages[34] = Ix5y2;
                ChessImages[35] = Ix5y3;
                ChessImages[36] = Ix5y4;
                ChessImages[37] = Ix5y5;
                ChessImages[38] = Ix5y6;
                ChessImages[39] = Ix5y7;
                ChessImages[40] = Ix5y8;

                ChessImages[41] = Ix6y1;
                ChessImages[42] = Ix6y2;
                ChessImages[43] = Ix6y3;
                ChessImages[44] = Ix6y4;
                ChessImages[45] = Ix6y5;
                ChessImages[46] = Ix6y6;
                ChessImages[47] = Ix6y7;
                ChessImages[48] = Ix6y8;

                ChessImages[49] = Ix7y1;
                ChessImages[50] = Ix7y2;
                ChessImages[51] = Ix7y3;
                ChessImages[52] = Ix7y4;
                ChessImages[53] = Ix7y5;
                ChessImages[54] = Ix7y6;
                ChessImages[55] = Ix7y7;
                ChessImages[56] = Ix7y8;

                ChessImages[57] = Ix8y1;
                ChessImages[58] = Ix8y2;
                ChessImages[59] = Ix8y3;
                ChessImages[60] = Ix8y4;
                ChessImages[61] = Ix8y5;
                ChessImages[62] = Ix8y6;
                ChessImages[63] = Ix8y7;
                ChessImages[64] = Ix8y8;

                //StartGame();
            }

            //previous version of the game // Main window
            #region previous version

            List<NikiStandartChess.Figures.Figure> figures = new List<NikiStandartChess.Figures.Figure>();

            List<KeyValuePair<FigureType, Type>> figur1 = new List<KeyValuePair<FigureType, Type>>()
            {
                    new KeyValuePair<FigureType, Type>(FigureType.Black,typeof(King)),
                    new KeyValuePair<FigureType, Type>(FigureType.White,typeof(King)),
                    new KeyValuePair<FigureType, Type>(FigureType.White,typeof(Queen)),
                    new KeyValuePair<FigureType, Type>(FigureType.White,typeof(Rook)),
                    new KeyValuePair<FigureType, Type>(FigureType.White,typeof(Rook))
            };

            //ay sa eka voncvor te taza sarqac@
            //foreach (var item in figur1)
            //{
            //    CreateFigure(item.Value, item.Key);
            //}

            foreach (var item in figur1)
            {
                figures.Add(CreateFigure(item.Value, item.Key));
            }
            Board board1 = new Board();
            board1.board = new string[9, 9];
            //ConsoleKeyInfo input;
            DrawBoard(board1, figures);
            DrawingWPF(figures);
            #endregion
        }

        public void DrawingWPF(List<NikiStandartChess.Figures.Figure> figures)
        {
            foreach (var _figure in figures)
            {
                int chessImageNumber = 8 * _figure.xPos - (8 - _figure.yPos);
                Game.SetImage(ChessImages[chessImageNumber], _figure);
            }
        }

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
        }
        //1st region I think
        #region previouse game 1st section
        //Supporting methods(number 1) standart for any chess game
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

        public static bool CheckingKingSteps(NikiStandartChess.Figures.Figure figure, int PreviosPosX, int PreviosPosY)
        {
            int y = figure.yPos;
            int x = figure.xPos;
            if ((x - PreviosPosX == 1 || x - PreviosPosX == -1 || x - PreviosPosX == 0)
                && (y - PreviosPosY == 1 || y - PreviosPosY == -1 || y - PreviosPosY == 0)
                && ((x - PreviosPosX != 0 || y - PreviosPosY != 0)))
            {
                return false;
            }
            return true;
        }//ok

        public static bool CheckingQueenSteps(NikiStandartChess.Figures.Figure figure, int PreviosPosX, int PreviosPosY)
        {
            int nextPosY = figure.yPos;
            int nextPosX = figure.xPos;
            int tempX = PreviosPosX;
            int tempY = PreviosPosY;
            if (Math.Abs(PreviosPosX - nextPosX) == Math.Abs(PreviosPosY - nextPosY)
                || nextPosY - PreviosPosY == 0 || nextPosX - PreviosPosX == 0)
            {
                return false;
            }
            return true;
        }//ok

        public static bool CheckingRookSteps(NikiStandartChess.Figures.Figure figure, int PreviosPosX, int PreviosPosY)//ok
        {
            int nextPosY = figure.yPos;
            int nextPosX = figure.xPos;
            int tempX = PreviosPosX;
            int tempY = PreviosPosY;
            if (nextPosY - PreviosPosY == 0 || nextPosX - PreviosPosX == 0)
            {
                return false;
            }
            return true;
        }

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
                if (board.board[PreviosPosY, PreviosPosX] != "  " || (nextPosY == tempY && nextPosX == tempX))
                {
                    return true;
                }
            } while (nextPosX != PreviosPosX || nextPosY != PreviosPosY);
            return false;
        }//ok

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

        public static bool CheckingForOtherFigures(Board board, NikiStandartChess.Figures.Figure figure)
        {
            int j = figure.xPos;
            int i = figure.yPos;
            try
            {
                if (board.board[i, j] != figure.name && board.board[i, j] != default(string))
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

        //2nd part of the previouse game
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

        //3rd part of the previouse game
        #region 3rd part
        //drawing front(3)
        public static int count = 0;

        public static void FigureInitialPositions(Board _board, List<NikiStandartChess.Figures.Figure> figures)
        {
            int _i = _board.i;
            int _j = _board.j;
            foreach (var _figure in figures)
            {
                if (_i == 1 && _j == 4 && _figure is King && _figure.figureType == FigureType.Black)
                {
                    //ForegroundColor = ConsoleColor.Black;
                    _board.board[_i, _j] = "B" + _figure.Name();//Black King
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
                else if (_i == 8 && _j == 1 && _figure is Rook && _figure.figureType == FigureType.White && _figure.figureNumber == FigureNumber.Right)
                {
                    // ForegroundColor = ConsoleColor.Red;
                    _board.board[_i, _j] = "R" + _figure.Name();// Right Rook
                    _figure.xPos = _j;
                    _figure.yPos = _i;
                    //int chessImageNumber = 8 * _j - (8 - _i);
                    //Game.SetImage(ChessImages[chessImageNumber], _figure);
                    break;
                }
                else if (_i == 8 && _j == 3 && _figure is Queen && _figure.figureType == FigureType.White)
                {
                    //ForegroundColor = ConsoleColor.Red;
                    _board.board[_i, _j] = "W" + _figure.Name(); //White Queen
                    _figure.xPos = _j;
                    _figure.yPos = _i;
                    //int chessImageNumber = 8 * _j - (8 - _i);
                    //Game.SetImage(ChessImages[chessImageNumber], _figure);
                    break;
                }
                else if (_i == 8 && _j == 4 && _figure is King && _figure.figureType == FigureType.White)
                {
                    //ForegroundColor = ConsoleColor.Red;
                    _board.board[_i, _j] = "W" + _figure.Name(); // White King
                    _figure.xPos = _j;
                    _figure.yPos = _i;
                    //int chessImageNumber = 8 * _j - (8 - _i);
                    //Game.SetImage(ChessImages[chessImageNumber], _figure);
                    break;
                }
                else if (_i == 8 && _j == 8 && _figure is Rook && _figure.figureType == FigureType.White && _figure.figureNumber == FigureNumber.Left)
                {
                    //ForegroundColor = ConsoleColor.Red;
                    _board.board[_i, _j] = "L" + _figure.Name(); // Left Rook
                    _figure.xPos = _j;
                    _figure.yPos = _i;
                    //int chessImageNumber = 8 * _j - (8 - _i);
                    //Game.SetImage(ChessImages[chessImageNumber], _figure);
                    break;
                }
                else
                {
                    _board.board[_i, _j] = string.Empty;
                }
            }
        }

        public static void FigurePositions(Board _board, List<NikiStandartChess.Figures.Figure> figures)
        {
            int _i = _board.i;
            int _j = _board.j;
            if (count < 64)
            {
                FigureInitialPositions(_board, figures);
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

        public static void InitializeBoard(Board _board, List<NikiStandartChess.Figures.Figure> figures, ConsoleColor color1, ConsoleColor color2)
        {
            int _i = _board.i;
            int _j = _board.j;
            //char letter = 'A';
            //char initialLetter = ' ';
            //string letter1;
            //if (_i == 0)
            //{
            //    initialLetter = (char)(letter + _j - 1);
            //}
            //letter1 = " " + initialLetter;
            if (_j % 2 == 0 && _i != 0 && _j > 0)
            {
                //BackgroundColor = color1;
                FigurePositions(_board, figures);
                //Write(_board.board[_i, _j]);
            }
            else if (_i != 0 && _j % 2 != 0 && _j > 0)
            {
                //BackgroundColor = color2;
                FigurePositions(_board, figures);
                // Write(_board.board[_i, _j]);
            }
            //else if (_i == 0 && _j != 0)
            //{
            //    //ForegroundColor = ConsoleColor.Green;
            //    _board.board[_i, _j] = letter1;
            //    //Write(_board.board[_i, _j]);
            //   // ForegroundColor = ConsoleColor.Red;
            //}
            //else if (_j == 0 && _i == 0)
            //{
            //   // Write("  ");
            //}
            //else if (_j == 0 && _i != 0)
            //{
            //    //ResetColor();
            //    //ForegroundColor = ConsoleColor.Green;
            //    _board.board[_i, _j] = " " + _i.ToString();
            //    //Write(_board.board[_i, _j]);
            //    //ForegroundColor = ConsoleColor.Red;
            //}
        }

        public static void DrawBoard(Board _board, List<NikiStandartChess.Figures.Figure> figures)
        {
            for (int i = 1; i < 9; i++)
            {
                //if (i % 2 == 0)
                //{
                for (int j = 1; j < 9; j++)
                {
                    _board.i = i;
                    _board.j = j;
                    FigurePositions(_board, figures);
                    //InitializeBoard(_board, figures, ConsoleColor.White, ConsoleColor.Gray);
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

        public static NikiStandartChess.Figures.Figure CreateFigure(Type type, FigureType figureType)
        {
            NikiStandartChess.Figures.Figure figure = (NikiStandartChess.Figures.Figure)Activator.CreateInstance(type, figureType);
            return figure;
        }

        #endregion



        public static void StartGame()
        {
            int x, y;

            x = 1;
            y = 2;

            int type = Game.Peace.White.Pawn[0];

            Game.Base.ID[Game.GetBaseID(x, y)] = type;
            Game.SetImage(MainWindow.ChessImages[Game.GetBaseID(x, y)], type);
        }

        #region Click on Chess Button
        private void x1y1_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(1, 1);
        }

        private void x1y2_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(1, 2);
        }

        private void x1y3_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(1, 3);
        }

        private void x1y4_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(1, 4);
        }

        private void x1y5_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(1, 5);
        }

        private void x1y6_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(1, 6);
        }

        private void x1y7_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(1, 7);
        }

        private void x1y8_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(1, 8);
        }

        private void x2y1_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(2, 1);
        }

        private void x2y2_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(2, 2);
        }

        private void x2y3_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(2, 3);
        }

        private void x2y4_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(2, 4);
        }

        private void x2y5_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(2, 5);
        }

        private void x2y6_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(2, 6);
        }

        private void x2y7_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(2, 7);
        }

        private void x2y8_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(2, 8);
        }

        private void x3y1_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(3, 1);
        }

        private void x3y2_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(3, 2);
        }

        private void x3y3_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(3, 3);
        }

        private void x3y4_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(3, 4);
        }

        private void x3y5_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(3, 5);
        }

        private void x3y6_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(3, 6);
        }

        private void x3y7_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(3, 7);
        }

        private void x3y8_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(3, 8);
        }

        private void x4y1_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(4, 1);
        }

        private void x4y2_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(4, 2);
        }

        private void x4y3_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(4, 3);
        }

        private void x4y4_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(4, 4);
        }

        private void x4y5_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(4, 5);
        }

        private void x4y6_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(4, 6);
        }

        private void x4y7_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(4, 7);
        }

        private void x4y8_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(4, 8);
        }

        private void x5y1_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(5, 1);
        }

        private void x5y2_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(5, 2);
        }

        private void x5y3_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(5, 3);
        }

        private void x5y4_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(5, 4);
        }

        private void x5y5_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(5, 5);
        }

        private void x5y6_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(5, 6);
        }

        private void x5y7_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(5, 7);
        }

        private void x5y8_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(5, 8);
        }

        private void x6y1_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(6, 1);
        }

        private void x6y2_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(6, 2);
        }

        private void x6y3_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(6, 3);
        }

        private void x6y4_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(6, 4);
        }

        private void x6y5_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(6, 5);
        }

        private void x6y6_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(6, 6);
        }

        private void x6y7_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(6, 7);
        }

        private void x6y8_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(6, 8);
        }

        private void x7y1_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(7, 1);
        }

        private void x7y2_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(7, 2);
        }

        private void x7y3_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(7, 3);
        }

        private void x7y4_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(7, 4);
        }

        private void x7y5_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(7, 5);
        }

        private void x7y6_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(7, 6);
        }

        private void x7y7_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(7, 7);
        }

        private void x7y8_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(7, 8);
        }

        private void x8y1_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(8, 1);
        }

        private void x8y2_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(8, 2);
        }

        private void x8y3_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(8, 3);
        }

        private void x8y4_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(8, 4);
        }

        private void x8y5_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(8, 5);
        }

        private void x8y6_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(8, 6);
        }

        private void x8y7_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(8, 7);
        }

        private void x8y8_Click(object sender, RoutedEventArgs e)
        {
            Game.SelectBase(8, 8);
        }
        #endregion

        #region Black and White

        private void B1_Click(object sender, RoutedEventArgs e)
        {
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
        }

        private void B10_Click(object sender, RoutedEventArgs e)
        {
        }

        private void B11_Click(object sender, RoutedEventArgs e)
        {
        }

        private void B12_Click(object sender, RoutedEventArgs e)
        {
        }

        private void B13_Click(object sender, RoutedEventArgs e)
        {
        }

        private void B14_Click(object sender, RoutedEventArgs e)
        {
        }

        private void B15_Click(object sender, RoutedEventArgs e)
        {
        }

        private void W1_Click(object sender, RoutedEventArgs e)
        {
        }

        private void W2_Click(object sender, RoutedEventArgs e)
        {
        }

        private void W3_Click(object sender, RoutedEventArgs e)
        {
        }

        private void W4_Click(object sender, RoutedEventArgs e)
        {
        }

        private void W5_Click(object sender, RoutedEventArgs e)
        {
        }

        private void W6_Click(object sender, RoutedEventArgs e)
        {
        }

        private void W7_Click(object sender, RoutedEventArgs e)
        {
        }

        private void W8_Click(object sender, RoutedEventArgs e)
        {
        }

        private void W9_Click(object sender, RoutedEventArgs e)
        {
        }

        private void W10_Click(object sender, RoutedEventArgs e)
        {
        }

        private void W11_Click(object sender, RoutedEventArgs e)
        {
        }

        private void W12_Click(object sender, RoutedEventArgs e)
        {
        }

        private void W13_Click(object sender, RoutedEventArgs e)
        {
        }

        private void W14_Click(object sender, RoutedEventArgs e)
        {
        }

        private void W15_Click(object sender, RoutedEventArgs e)
        {
        }
        #endregion
    }
    public class Game
    {
        public static int PClickX = 0;
        public static int PClickY = 0;

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

        public static bool SetBase(int px, int py, int x, int y, List<NikiStandartChess.Figures.Figure> figures)
        {
            int type = GetType(px, py);
            int nType = GetType(x, y);
            if (nType > 0)
            {

            }

            Base.ID[GetBaseID(x, y)] = type;
            SetImage(MainWindow.ChessImages[GetBaseID(x, y)], type);
            SetImage(MainWindow.ChessImages[GetBaseID(px, py)], 0);
            //DrawingWPF()
            return true;
        }

        public static void SetImage(Image img, int type)
        {
            //img.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, (System.Threading.ThreadStart)delegate ()
            // {
            //     if (type < 1) img.Visibility = Visibility.Hidden;
            /* else*/
            img.Source = new BitmapImage(new Uri("\\Images\\" + MainWindow.ImageName[type], UriKind.Relative));
            //});
        }

        public static void SetImage(Image img, NikiStandartChess.Figures.Figure figure)
        {
            //img.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, (System.Threading.ThreadStart)delegate ()
            // {
            //     if (type < 1) img.Visibility = Visibility.Hidden;
            /* else*/
            img.Source = new BitmapImage(new Uri("\\Images\\" + figure.imageName, UriKind.Relative));
            //});
        }

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

        //----Select On ChessPeace
        public static void SelectBase(int x, int y)
        {
            MainWindow.clickX = x;
            MainWindow.clickY = y;
            System.Threading.Thread T = new System.Threading.Thread(Select);
            T.Start();
        }

        public static void Select()
        {
            if (myTurn)
            {
                if (clickable)
                {
                    //if (IsMoveable(PClickX, PClickY, MainWindow.clickX, MainWindow.clickY))
                    //{
                        //SetBase(PClickX, PClickY, MainWindow.clickX, MainWindow.clickY,figures);
                        clickable = false;
                    //}
                }
                else
                {
                    PClickX = MainWindow.clickX;
                    PClickY = MainWindow.clickY;
                    clickable = true;
                }
            }
        }
    }
}
