using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._01._20_HierarchyGeometricShapes
{
    class Line : Point
    {
        #region ---===    Protected    ===---

        protected Point _begin;
        protected Point _end;

        #endregion

        #region ---===    Get / Set    ===---

        public Point Begin
        {
            get
            {
                return _begin = new Point(_positionX, _positionY);   //ToDo: Add return copy()
            }
            set
            {
                _begin = value;
            }
        }

        public Point End
        {
            get
            {
                return _end;    //ToDo: Add return copy()
            }
            set
            {
                _end = value;
            }
        }

        #endregion

        #region ---===    Constructor    ===---

        public Line(Point begin, Point end)
            :base(begin)
        {
            End = new Point(end.PosX, end.PosY, end.Symbol, end.Color);
        }

        public Line(Point begin, int endX, int endY)
            : base(begin)
        {
            End = new Point(endX, endY, begin.Symbol);
        }

        public Line(int beginX, int beginY, Point end)
            : base(beginX, beginY, end.Symbol)
        {
            End = end;
        }

        public Line(int x1, int y1, int x2, int y2)
            : base(x1, y1)
        {
            End = new Point(x2, y2);
        }

        public Line(Line line)
            : this(line.Begin, line.End)
        { 
        
        }

        #endregion

        #region ---===    Override Method    ===---

        public override void Show()
        {
            UI.PrintLine(this);
        }

        public override void Hide()
        { 
            UI.PrintLine(this, Console.BackgroundColor);
        }

        #endregion

    }
}
