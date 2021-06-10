using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikiStandartChess.Figures
{
    public class Rook : Figure
    {
        
        //public string imageName;
        public static int whiteRookTypeNumber;
        public static int blackRookTypeNumber;

        public Rook(FigureType _figureType, int _xPos, int _yPos) : base(_figureType, _xPos, _yPos)
        {
            name = "R";
            if (_figureType.Equals(FigureType.White))
            {
                imageName = "WRook.png";

                if (whiteRookTypeNumber > 0)
                {
                    figureNumber = FigureNumber.Left;
                }
                else
                {
                    figureNumber = FigureNumber.Right;
                }

                whiteRookTypeNumber++;
            }
            else
            {
                imageName = "BRook.png";

                if (blackRookTypeNumber > 0)
                {
                    figureNumber = FigureNumber.Left;
                }
                else
                {
                    figureNumber = FigureNumber.Right;
                }

                blackRookTypeNumber++;
            }
        }
        public Rook(FigureType _figureType) : base(_figureType)
        {
            name = "R";
            if (_figureType.Equals(FigureType.White))
            {
                imageName = "WRook.png";

                if(whiteRookTypeNumber>0)
                {
                    figureNumber = FigureNumber.Left;
                }
                else
                {
                    figureNumber = FigureNumber.Right;
                }

                whiteRookTypeNumber++;
            }
            else
            {
                imageName = "BRook.png";

                if (blackRookTypeNumber > 0)
                {
                    figureNumber = FigureNumber.Left;
                }
                else
                {
                    figureNumber = FigureNumber.Right;
                }

                blackRookTypeNumber++;
            }
        }
        public Rook()
        {

        }
        public override string Name()
        {
            return name;
        }
    }
}
