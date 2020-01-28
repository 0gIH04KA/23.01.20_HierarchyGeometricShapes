using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._01._20_HierarchyGeometricShapes
{
    class Container
    {
        private Figure[] _figures;

        private int _itemsCount;
        private int _currentItemIndex;
        Action action = Action.NoAction;


        public Container()
        {
            _figures = new Figure[Constant.MAXIMUM_FIGURES];
            _itemsCount = 0;
            _currentItemIndex = 0;
        }

        public static Action GetActionPlayer(ConsoleKey pressKey)
        {
            Action pressPlayer;

            switch (pressKey)
            {
                case ConsoleKey.LeftArrow:
                    pressPlayer = Action.PressLeft;
                    break;

                case ConsoleKey.UpArrow:
                    pressPlayer = Action.PressUp;
                    break;

                case ConsoleKey.RightArrow:
                    pressPlayer = Action.PressRight;
                    break;

                case ConsoleKey.DownArrow:
                    pressPlayer = Action.PressDown;
                    break;

                case ConsoleKey.Escape:
                    pressPlayer = Action.PressExit;
                    break;

                default:
                    pressPlayer = Action.NoAction;
                    break;
            }

            return pressPlayer;
        }

        public void AddFigure(Figure figure)
        {
            _figures[_itemsCount] = figure;
            ++_itemsCount;
        }

        public void DeleteFigure(int position)
        {
            if (position < 0 || position > _figures.Length)
            {
                throw new MyException("Position not correctly");
            }

            _figures[position].Hide();
            _figures[position] = null;
            --_itemsCount;
        }

        public void DeleteLastFigire()
        {
            --_itemsCount;
            _figures[_itemsCount].Hide();

            _figures[_itemsCount] = null; 
        }


        public void Show()
        {
            for (int i = 0; i < _itemsCount; i++)
            {
               _figures[i].Show();
            }
        }

        public void Move()
        {
            for (int i = 0; i < _itemsCount; i++)
            {
                _figures[i].Move(action);
                Show();
            }
        }
    }
}
