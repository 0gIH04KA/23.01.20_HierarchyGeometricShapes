using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._01._20_HierarchyGeometricShapes
{
    class MoveFigure
    {
        #region ---===   Point   ===---

        public static void MovePoint(Point point, Action action)
        {
            switch (action)
            {
                case Action.PressRight:
                    if (Point.IsCorrectX(point, action))
                    {
                        point.Move(1, 1, action);
                    }
                    break;
                case Action.PressLeft:
                    if (Point.IsCorrectX(point, action))
                    {
                        point.Move(1, 1, action);
                    }
                    break;
                case Action.PressUp:
                    if (Point.IsCorrectY(point, action))
                    {
                        point.Move(1, 1, action);
                    }
                    break;
                case Action.PressDown:
                    if (Point.IsCorrectY(point, action))
                    {
                        point.Move(1, 1, action);
                    }
                    break;
                case Action.NoAction:
                    break;
            }
        }

        #endregion

        #region ---===   Line   ===---

        #endregion

        #region ---===   Square   ===---

        #endregion
    }
}
