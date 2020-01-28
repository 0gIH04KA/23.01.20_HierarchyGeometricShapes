using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._01._20_HierarchyGeometricShapes
{
    abstract class Figure
    {
        #region ---===    Protected    ===---

        protected char _symbol;
        protected ConsoleColor _color;

        #endregion

        #region ---===    Get / Set    ===---

        public char Symbol
        {
            get
            {
                return _symbol;
            }
            set
            {
                _symbol = value;
            }
        }

        public ConsoleColor Color
        {
            get 
            {
                return _color;
            }
            set 
            {
                _color = value;
            }
        }

        #endregion

        #region ---===    Constructor    ===---

        public Figure(char symbol, 
                ConsoleColor _color = ConsoleColor.White)
            : this(_color)
        {
            Symbol = symbol;
        }

        public Figure(ConsoleColor _color)
        {
            Color = _color;
        }

        #endregion

        #region ---===    Metods    ===---

        public abstract void Move(Action action);
       
        public abstract void Show();

        public abstract void Hide();

        #endregion

    }
}
