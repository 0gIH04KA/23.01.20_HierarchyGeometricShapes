using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._01._20_HierarchyGeometricShapes
{
    [Serializable()]
    public class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
        }
    }
}
