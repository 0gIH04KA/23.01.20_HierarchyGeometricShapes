using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._01._20_HierarchyGeometricShapes
{
    [Flags]
    public enum Action
    {
        NoAction = 0x00,

        PressRight = 0x01,
        PressLeft = 0x02,
        PressUp = 0x04,
        PressDown = 0x08,

        PressExit = 0xFFFF,

        MoveAction = PressRight | PressLeft | PressUp | PressDown,
    }
}
