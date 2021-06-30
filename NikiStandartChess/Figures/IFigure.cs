using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikiStandartChess.Figures
{
    public interface IFigure
    {
        public FigureType figureType { get; set; }
        public string Name { get; set; }
        public int xPos { get; set; }
        public int yPos { get; set; }   
    }
}
