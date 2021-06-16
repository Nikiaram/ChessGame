using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikiStandartChess.Figures
{
    public class King : Figure
    {        
     
        // Parameterized constructor
        public King(FigureType _figureType, int _xPos, int _yPos) : base(_figureType, _xPos, _yPos)
        {
            name = "K";            
        }
        public King(FigureType _figureType) : base(_figureType)
        {
            name = "K";           
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
