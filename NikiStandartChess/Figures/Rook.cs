using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikiStandartChess.Figures
{
    public class Rook : IFigure
    {

        public FigureType figureType { get; set; }
        public string Name { get; set; }
        public int xPos { get; set; }
        public int yPos { get; set; }

        public Rook(FigureType _figureType, int _xPos, int _yPos)
        {
            Name = "R";
        }
        public Rook(FigureType _figureType)
        {
            Name = "R";
            figureType = _figureType;
        }
        public Rook()
        {

        }

        /*
        public Rook(FigureType _figureType, int _xPos, int _yPos) : base(_figureType, _xPos, _yPos)
        {
            name = "R";            
        }

        public Rook(FigureType _figureType) : base(_figureType)
        {
            name = "R";            
        }

        public Rook()        {

        }

        public override string Name()
        {
            return name;
        }
       */
    }
}
