using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._01._20_HierarchyGeometricShapes
{
    class UI
    {
        #region ---===   Draw_Point   ===---

        public static void PrintPoint(Point point)
        {
            Console.CursorVisible = false;

            Console.SetCursorPosition(point.PosX, point.PosY);
            Console.ForegroundColor = point.Color;
            Console.Write(point.Symbol);
        }

        public static void PrintPoint(Point point, ConsoleColor color = ConsoleColor.White)
        {
            Console.CursorVisible = false;

            Console.SetCursorPosition(point.PosX, point.PosY);
            Console.ForegroundColor = color;
            Console.Write(point.Symbol);
        }

        #endregion

        #region ---===   Draw_Line   ===---

        public static void PrintLine(Line line)
        {
            PrintPoint(line.Begin);
            PrintPoint(line.End);
        }

        public static void PrintLine(Line line, ConsoleColor color = ConsoleColor.White)
        {
            PrintPoint(line.Begin, color);
            PrintPoint(line.End, color);
        }

        #endregion

        #region ---===   Draw_Squaree   ===---

        public static void PrintSquaree(Square square)
        {
            PrintLine(square.FirstLine);
            PrintLine(square.SecondLine);
            PrintLine(square.ThirdLine);
            PrintLine(square.FourthLine);
        }

        public static void PrintSquaree(Square square, ConsoleColor color = ConsoleColor.White)
        {
            PrintLine(square.FirstLine, color);
            PrintLine(square.SecondLine, color);
            PrintLine(square.ThirdLine, color);
            PrintLine(square.FourthLine, color);
        }

        #endregion


    }
}
