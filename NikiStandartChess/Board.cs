using NikiStandartChess.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikiStandartChess
{
    public class Board
    {
        Point coordinates = new Point();
        
        public int i;
        public int j;
        public string[,] gameBoard;
        public Board()
        {

        }

        public List<Figure> figuresList = new List<Figure>();


    }
}
