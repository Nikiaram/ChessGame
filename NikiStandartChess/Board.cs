﻿using NikiStandartChess.Figures;
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
        public int i;

        public int j;

        public string[,] gameBoard;

        public Board()
        {

        }

        public List<IFigure> figuresList = new List<IFigure>();
    }
}
