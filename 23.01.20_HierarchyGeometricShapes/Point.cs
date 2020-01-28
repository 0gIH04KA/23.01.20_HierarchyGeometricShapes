using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._01._20_HierarchyGeometricShapes
{
    class Point : Figure
    {
        #region ---===    Protected    ===---

        protected int _positionX;
        protected int _positionY;

        #endregion

        #region ---===    Get / Set    ===---

        public int PosX
        {
            get 
            {
                return _positionX;
            }
            set 
            {
                if (value < 0 || value > Constant.MAX_WIDTH)
                {
                    throw new MyException($"Incorrectly set X = {value}");
                }

                _positionX = value;
            }
        }

        public int PosY
        {
            get
            {
                return _positionY;
            }
            set
            {
                if (value < 0 || value > Constant.MAX_HEIGHT)
                {
                    throw new MyException($"Incorrectly set Y = {value}");
                }

                _positionY = value;
            }
        }

        #endregion

        #region ---===    Constructor    ===---

        public Point(int x, int y, char sym, ConsoleColor color)
           : base(sym, color)
        {
            PosX = x;
            PosY = y;
        }

        public Point(int x, int y , char sym = (char)Pen.Standart)
            : base(sym)
        { 
            PosX = x;
            PosY = y;
        }        

        public Point(Point point)
            : this(point.PosX, point.PosY, point.Symbol, point.Color)
        {
            
        }


        #endregion

        #region ---===   Override Method   ===---

        public override void Move(Action action)
        {
            Hide();
            MoveFigure.MovePoint(this , action); // ToDo: Не работает движение поинта
        }

        public override void Show()
        {
            UI.PrintPoint(this);
        }

        public override void Hide()
        {
           UI.PrintPoint(this, Console.BackgroundColor);
        }

        #endregion

        #region ---===    Method    ===---

        public void Move(int dx, int dy, Action action)
        {
            switch (action)
            {
                case Action.PressRight:
                    PosX += dx;
                    break;
                case Action.PressLeft:
                    PosX -= dx;
                    break;
                case Action.PressUp:
                    PosY -= dy;
                    break;
                case Action.PressDown:
                    PosY += dy;
                    break;

                default:
                case Action.NoAction:
                    PosX += 0;
                    PosY += 0;
                    break;
            }
        }

        public static bool IsCorrectX(Point point, Action action)
        {
            return IsCorrectActionRight(point, action)
                || IsCorrectActionLeft(point, action);
        }

        public static bool IsCorrectY(Point point, Action action)
        {
            return IsCorrectActionDown(point, action)
                || IsCorrectActionUp(point, action);
        }

        private static bool IsCorrectActionRight(Point point, Action action)
        {
            return (action == Action.PressRight)
                && (point.PosX + 1 < Constant.MAX_WIDTH);
        }

        private static bool IsCorrectActionLeft(Point point, Action action)
        {
            return (action == Action.PressLeft)
                && (point.PosX - 1 >= 0);
        }

        private static bool IsCorrectActionDown(Point point, Action action)
        {
            return (action == Action.PressDown)
                || (point.PosY + 1 < Constant.MAX_HEIGHT);
        }

        private static bool IsCorrectActionUp(Point point, Action action)
        {
            return (action == Action.PressUp)
                || (point.PosY - 1 >= 0);
        }

        #endregion




        

        

    }
}
