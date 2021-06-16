using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikiStandartChess.Figures
{
    public class Queen : Figure
    {
        
        //public string imageName;

        public Queen(FigureType _figureType, int _xPos, int _yPos) : base(_figureType, _xPos, _yPos)
        {
            name = "Q";           
        }
        public Queen(FigureType _figureType) : base(_figureType)
        {
            name = "Q";            
        }
        public Queen()
        {

        }
        public override string Name()
        {
            return name;
        }
    }
}
