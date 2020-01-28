using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._01._20_HierarchyGeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Constant.MAX_WIDTH, Constant.MAX_HEIGHT);
            Action action = Action.NoAction;

            Container c1 = new Container();

            do
            {
                action = Container.GetActionPlayer(Console.ReadKey(true).Key);

                Point point = new Point(1, 1);

                c1.AddFigure(point);
                c1.Show();

                point.Move(action);






            } while (action != Action.PressExit);

            

            Square square2 = NewSquareOnPointEndDiagonal();
            Square square1 = NewSquareOnTwoPoint();
            Square square = NewSquare();

            



           


            Console.ReadKey();



        }

        

        private static Square NewSquareOnPointEndDiagonal()
        {
            Point p1 = new Point(1, 1);
            Line diagonal = new Line(p1, 3, 3);

            Square square2 = new Square(p1, diagonal);

            return square2;
        }

        private static Square NewSquareOnTwoPoint()
        {
            Point p1 = new Point(3, 4);
            Point p2 = new Point(7, 1);

            Square square1 = new Square(p1, p2);

            return square1;
        }

        private static Square NewSquare()
        {
            Point p1 = new Point(2, 7);
            Point p2 = new Point(8, 7);
            Point p3 = new Point(8, 1);
            Point p4 = new Point(2, 1);

            Square square = new Square(p1, p2, p3, p4);

            return square;
        }
    }
}
