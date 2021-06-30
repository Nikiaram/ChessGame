using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NikiStandartChess.Figures
{
    public class King : IFigure
    {
        public FigureType figureType { get; set ; }

        public string Name { get; set; }

        public int xPos { get ; set ; }

        public int yPos { get ; set ; }

        public King(FigureType _figureType, int _xPos, int _yPos)
        {
            Name = "K";
        }

        public King(FigureType _figureType)
        {
            Name = "K";
            figureType = _figureType;
        }

        public King()
        {

        }       
    }
}
