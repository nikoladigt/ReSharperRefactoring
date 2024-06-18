using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class MoveRefactoring
    {
        class Shape
        {
            private Point pivot;

            public Point Pivot
            {
                set { pivot = value; }
                get { return pivot; }
            }
        }
        class Logger
        {
            public void Log(string msg)
            {
                // log the message
            }

            private void LogDrawing(Shape shape)
            {
                var msg = $"Shape is drawn at {shape.Pivot.X}, {shape.Pivot.Y}";
                this.Log(msg);
            }
        }
    }
}
