using NikiChessGames;
//using NikiStandartChess;
//using NikiStandartChess.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
//using System.Drawing;


namespace NikiChessGame_V4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        GameManager gameManager = new GameManager();

        public static int clickX = 0;
        public static int clickY = 0;

        public static Image[] ChessImages = new Image[65];
        //public static string[] ImageName = new string[12];


        public KeyValuePair<Tuple<string, string>, string>[] ImageName = new KeyValuePair<Tuple<string, string>, string>[12];



        public MainWindow()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            StartChessGame();
        }

        public void SetImageCoordinates()
        {
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
        }

        public void SetFigureImages()
        {
            ImageName[0] = new KeyValuePair<Tuple<string, string>, string> (new Tuple<string,string>("Black", "K"), "BKing.png");
            ImageName[1] = new KeyValuePair<Tuple<string, string>, string> (new Tuple<string,string>("Black", "Q"), "BQueen.png");
            ImageName[2] = new KeyValuePair<Tuple<string, string>, string> (new Tuple<string,string>("Black", "B"), "BBishop.png");
            ImageName[3] = new KeyValuePair<Tuple<string, string>, string> (new Tuple<string,string>("Black", "R"), "BRook.png");
            ImageName[4] = new KeyValuePair<Tuple<string, string>, string> (new Tuple<string,string>("Black", "Kn"), "BKnighte.png");
            ImageName[5] = new KeyValuePair<Tuple<string, string>, string> (new Tuple<string,string>("Black", "P"), "BPawn.png");
            ImageName[6] = new KeyValuePair<Tuple<string, string>, string> (new Tuple<string,string>("White", "K"), "WKing.png");
            ImageName[7] = new KeyValuePair<Tuple<string, string>, string> (new Tuple<string,string>("White", "Q"), "WQueen.png");
            ImageName[8] = new KeyValuePair<Tuple<string, string>, string> (new Tuple<string,string>("White", "B"), "WBishop.png");
            ImageName[9] = new KeyValuePair<Tuple<string, string>, string> (new Tuple<string,string>("White", "R"), "WRook.png");
            ImageName[10] = new KeyValuePair<Tuple<string, string>, string> (new Tuple<string,string>("White", "Kn"), "WKnighte.png");
            ImageName[11] = new KeyValuePair<Tuple<string, string>, string> (new Tuple<string,string>("White", "P"), "WPawn.png");
        }

        public void StartChessGame()
        {
            SetImageCoordinates();
            SetFigureImages();
            //if (StartTheGame.Text == "1st game")
            gameManager.DrawGame(StartTheGame.Text);
            DrawingWPF();
        }




        public void DrawingWPF()
        {
            List<Tuple<System.Drawing.Point, string, string>> figurePoints;
            figurePoints = gameManager.FigurePositions();
            foreach (var pos in figurePoints)
            {
                //int chessImageNumber = 8 * _figure.xPos - (8 - _figure.yPos);
                // Game.SetImage(ChessImages[chessImageNumber], _figure);

                int chessImageNumber = 8 * pos.Item1.X - (8 - pos.Item1.Y);

                foreach (var image in ImageName)
                {
                    if(image.Key.Item1==pos.Item2&& image.Key.Item2== pos.Item3)
                    {
                        SetImage(ChessImages[chessImageNumber], image.Value);
                    }                    
                }
            }
        }        

        public static void SetImage(Image img, string figureImageName)
        {
            //img.Dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Normal, (System.Threading.ThreadStart)delegate ()
            // {
            //     if (type < 1) img.Visibility = Visibility.Hidden;
            /* else*/
            img.Source = new BitmapImage(new Uri("\\Images\\" + figureImageName, UriKind.Relative));
            //});
        }







        //public static void StartGame()
        //{
        //    int x, y;

        //    x = 1;
        //    y = 2;

        //    int type = Game.Peace.White.Pawn[0];

        //    Game.Base.ID[Game.GetBaseID(x, y)] = type;
        //    Game.SetImage(MainWindow.ChessImages[Game.GetBaseID(x, y)], type);
        //}

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
