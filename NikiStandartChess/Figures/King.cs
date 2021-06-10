using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikiStandartChess.Figures
{
    public class King : Figure
    {

        
        //public string imageName;

        // Parameterized constructor
        public King(FigureType _figureType, int _xPos, int _yPos) : base(_figureType, _xPos, _yPos)
        {
            name = "K";
            if (_figureType.Equals(FigureType.White))
                imageName = "WKing.png";
            else
                imageName = "BKing.png";
        }
        public King(FigureType _figureType) : base(_figureType)
        {
            name = "K";
            if (_figureType.Equals(FigureType.White))
                imageName = "WKing.png";
            else
                imageName = "BKing.png";
        }
        public King()
        {

        }
        public override string Name()
        {
            return name;
        }

    }
}
