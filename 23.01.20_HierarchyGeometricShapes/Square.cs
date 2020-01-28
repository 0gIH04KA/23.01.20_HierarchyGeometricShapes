using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._01._20_HierarchyGeometricShapes
{
    class Square : Line
    {
        #region ---===    Protected    ===---

        protected Line _first;   //первая линия
        protected Line _second;  //вторая    
        protected Line _third;      //третья
        protected Line _fourth;      //четвертая
        protected Line _diagonal; //диагональ

        #endregion

        #region ---===    Get / Set    ===---

        public Line FirstLine
        {
            get
            {
                return _first = new Line(Begin, End);
            }
            set
            {
                _first = value;
            }
        }

        public Line SecondLine
        {
            get
            {
                return _second;
            }
            set
            {
                _second = value;
            }
        }

        public Line ThirdLine
        {
            get
            {
                return _third;
            }
            set
            {
                _third = value;
            }
        }

        public Line FourthLine
        {
            get
            {
                return _fourth;
            }
            set
            {
                _fourth = value;
            }
        }

        public Line Diagonal
        {
            get
            {
                return _diagonal = new Line(Begin, End);
            }
            set
            {
                _diagonal = value;
            }
        }

        #endregion

        #region ---===    Constructor    ===---

        public Square(Point p1, Point p2, Point p3, Point p4)
           : base(p1, p2)
        {
            SecondLine = new Line(p2, p3);
            ThirdLine = new Line(p3, p4);
            FourthLine = new Line(p4, p1);
        }

        public Square(Point p1, Point p2)
            : base(p1, p2)
        {
            FirstLine = new Line(p1, p1.PosX, p2.PosY);
            SecondLine = new Line(p1.PosX, p2.PosY, p2);
            ThirdLine = new Line(p2, p2.PosX, p1.PosY);
            FourthLine = new Line(p1.PosX, p2.PosY, p1);
        }

        public Square(Point p1, Line diagonal)
            :base(diagonal)
        {
            FirstLine = new Line(p1, diagonal.Begin.PosX, diagonal.End.PosY);
            SecondLine = new Line(diagonal.Begin.PosX, diagonal.End.PosY, diagonal.End);
            ThirdLine = new Line(diagonal.End, diagonal.End.PosX, diagonal.Begin.PosY);
            FourthLine = new Line(diagonal.End.PosX, diagonal.Begin.PosY, p1);
        }

        public Square(Square square)
            : this(square.FirstLine, square.SecondLine,
                 square.ThirdLine, square.FourthLine)
        { 
        }

        #endregion






        #region ---===    Override Method    ===---

        public override void Show()
        {
            UI.PrintSquaree(this);
        }

        public override void Hide()
        {
            UI.PrintSquaree(this, Console.BackgroundColor);
        }

        #endregion

    }
}
