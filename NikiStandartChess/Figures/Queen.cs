using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikiStandartChess.Figures
{
    public class Queen : IFigure
    {
        public FigureType figureType { get; set; }

        public string Name { get; set; }

        public int xPos { get; set; }

        public int yPos { get; set; }

        public Queen(FigureType _figureType, int _xPos, int _yPos)
        {
            Name = "Q";
        }

        public Queen(FigureType _figureType)
        {
            Name = "Q";
            figureType = _figureType;
        }

        public Queen()
        {

        }        
    }
}
