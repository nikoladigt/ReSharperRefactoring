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
            private void LogDrawing(Logger logger)
            {
                var msg = $"Shape is drawn at {pivot.X}, {pivot.Y}";
                logger.Log(msg);
            }
        }
        class Logger
        {
            public void Log(string msg)
            {
                // log the message
            }
        }
    }
}
