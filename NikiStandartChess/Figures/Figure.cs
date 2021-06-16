using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikiStandartChess.Figures
{
    public class Figure
    {
        public FigureType figureType { get; set; }
        
        public string name = string.Empty;//sa "  " hanem 
        public int xPos;
        public int yPos;
        public Figure(FigureType _figureType)
        {
            figureType = _figureType;
        }
        public Figure(FigureType _figureType, int _xPos, int _yPos)
        {
            figureType = _figureType;
            xPos = _xPos;
            yPos = _yPos;
        }
        public Figure()
        {

        }
        public virtual string Name()
        {
            return name;
        }

    }
}
