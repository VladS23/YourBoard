using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace YourBoard
{
    public abstract class DashBoardElement
    {
        public abstract void CreateView(string imageAdr, double X, double Y);
        public abstract void Delete();
        public abstract void Move(Point curpos, Point pressedpos);
    }
}
