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
        //GameManager gameManager = new GameManager();

        public static bool gameStartCount = true;

        public static Image[] ChessImages = new Image[65];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            if (gameStartCount)
            {
                SetImageCoordinates();
                StartChessGame(StartTheGame, ChessImages);
                gameStartCount = false;
            }
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

        #region Click on Chess Button

        /*
        private void x1y1_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(1, 1);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x1y2_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(1, 2);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x1y3_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(1, 3);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x1y4_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(1, 4);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x1y5_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(1, 5);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x1y6_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(1, 6);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x1y7_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(1, 7);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x1y8_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(1, 8);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x2y1_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(2, 1);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x2y2_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(2, 2);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x2y3_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(2, 3);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x2y4_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(2, 4);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x2y5_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(2, 5);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x2y6_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(2, 6);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x2y7_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(2, 7);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x2y8_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(2, 8);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x3y1_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(3, 1);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x3y2_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(3, 2);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x3y3_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(3, 3);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x3y4_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(3, 4);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x3y5_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(3, 5);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x3y6_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(3, 6);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x3y7_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(3, 7);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x3y8_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(3, 8);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }
        */
        private void anyGrid_Click(object sender, RoutedEventArgs e)
        {
            StartTheGameWithFigures(sender);
        }

        public void StartTheGameWithFigures(object sender)
        {
            var clickCoordinates = TakingOutClickCoordinates(sender);

            SelectBase(clickCoordinates.Item1, clickCoordinates.Item2);

            DrawUI();
        }

        public void DrawUI()
        {
            bool gameNumber = GameCount();
            if (gameNumber)
                DrawingWPF(ChessImages);
        }

        public (int,int) TakingOutClickCoordinates(object sender)
        {
            Button button = (Button)sender;
            string name = button.Name;
            int x = name[1] - 48;
            int y = name[3] - 48;
            return (x, y);
        }

        /*
        private void x4y2_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(4, 2);

            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x4y3_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(4, 3);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x4y4_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(4, 4);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x4y5_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(4, 5);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x4y6_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(4, 6);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x4y7_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(4, 7);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x4y8_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(4, 8);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x5y1_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(5, 1);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x5y2_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(5, 2);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x5y3_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(5, 3);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x5y4_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(5, 4);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x5y5_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(5, 5);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x5y6_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(5, 6);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x5y7_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(5, 7);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x5y8_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(5, 8);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x6y1_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(6, 1);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x6y2_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(6, 2);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x6y3_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(6, 3);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x6y4_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(6, 4);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x6y5_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(6, 5);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x6y6_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(6, 6);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x6y7_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(6, 7);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x6y8_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(6, 8);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x7y1_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(7, 1);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x7y2_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(7, 2);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x7y3_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(7, 3);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x7y4_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(7, 4);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x7y5_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(7, 5);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x7y6_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(7, 6);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x7y7_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(7, 7);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x7y8_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(7, 8);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x8y1_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(8, 1);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x8y2_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(8, 2);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x8y3_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(8, 3);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x8y4_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(8, 4);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x8y5_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(8, 5);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x8y6_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(8, 6);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x8y7_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(8, 7);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }

        private void x8y8_Click(object sender, RoutedEventArgs e)
        {
            SelectBase(8, 8);
            int number = GameCount();
            if (number < 1)
                DrawingWPF(ChessImages);
        }
        */
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

        #region from UI Class


        //public static string[] ImageName = new string[12];

        public bool GameCount()
        {
            return gameManager.GameManagerCount();
        }

        public KeyValuePair<Tuple<string, string>, string>[] ImageName = new KeyValuePair<Tuple<string, string>, string>[12];
        List<Tuple<System.Drawing.Point, string, string>> figurePoints;

        public void SelectBase(int x, int y)
        {
            gameManager.SelectBase(x, y);
        }

        public void SetFigureImages()
        {
            ImageName[0] = new KeyValuePair<Tuple<string, string>, string>(new Tuple<string, string>("Black", "K"), "BKing.png");
            ImageName[1] = new KeyValuePair<Tuple<string, string>, string>(new Tuple<string, string>("Black", "Q"), "BQueen.png");
            ImageName[2] = new KeyValuePair<Tuple<string, string>, string>(new Tuple<string, string>("Black", "B"), "BBishop.png");
            ImageName[3] = new KeyValuePair<Tuple<string, string>, string>(new Tuple<string, string>("Black", "R"), "BRook.png");
            ImageName[4] = new KeyValuePair<Tuple<string, string>, string>(new Tuple<string, string>("Black", "Kn"), "BKnighte.png");
            ImageName[5] = new KeyValuePair<Tuple<string, string>, string>(new Tuple<string, string>("Black", "P"), "BPawn.png");
            ImageName[6] = new KeyValuePair<Tuple<string, string>, string>(new Tuple<string, string>("White", "K"), "WKing.png");
            ImageName[7] = new KeyValuePair<Tuple<string, string>, string>(new Tuple<string, string>("White", "Q"), "WQueen.png");
            ImageName[8] = new KeyValuePair<Tuple<string, string>, string>(new Tuple<string, string>("White", "B"), "WBishop.png");
            ImageName[9] = new KeyValuePair<Tuple<string, string>, string>(new Tuple<string, string>("White", "R"), "WRook.png");
            ImageName[10] = new KeyValuePair<Tuple<string, string>, string>(new Tuple<string, string>("White", "Kn"), "WKnighte.png");
            ImageName[11] = new KeyValuePair<Tuple<string, string>, string>(new Tuple<string, string>("White", "P"), "WPawn.png");
        }

        public void StartChessGame(ComboBox StartTheGame, Image[] ChessImages)
        {
            SetFigureImages();
            //if (StartTheGame.Text == "1st game")
            gameManager.DrawGame(StartTheGame.Text);
            DrawingWPF(ChessImages);
        }

        public void DrawingWPF(Image[] ChessImages)
        {
            ResetAllPicturePostitions();
            figurePoints = gameManager.FigurePositions();
            foreach (var pos in figurePoints)
            {
                //int chessImageNumber = 8 * _figure.xPos - (8 - _figure.yPos);
                // Game.SetImage(ChessImages[chessImageNumber], _figure);

                int chessImageNumber = 8 * pos.Item1.X - (8 - pos.Item1.Y);

                foreach (var image in ImageName)
                {
                    if (image.Key.Item1 == pos.Item2 && image.Key.Item2 == pos.Item3)
                    {
                        SetImage(ChessImages[chessImageNumber], image.Value);
                    }
                }
            }
        }

        public void ResetAllPicturePostitions()
        {
            for (int i = 1; i < 65; i++)
            {
                SetImage(ChessImages[i], string.Empty);
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

        #endregion

    }
}