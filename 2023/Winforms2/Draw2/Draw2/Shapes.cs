using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Draw2 {
    internal interface Shape {
        void Draw(Graphics g,Pen p);
    }

    internal abstract class AbstractShape:Shape{
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        
        public abstract void Draw(Graphics  g,Pen p);

    }
    internal class Line : AbstractShape {
        
        public override void Draw(Graphics g, Pen p) {
            g.DrawLine(p, X - Width / 2, Y - Height / 2, X + Width / 2, Y + Width / 2);
        }

    }

    internal class Rectangle : AbstractShape {
        

        public override void Draw(Graphics g, Pen p) {
            g.DrawRectangle(Pens.Black,X-Width/2,Y-Height/2, Width, Height);
        }
    }
    internal class Circle : AbstractShape {
        
        public override void Draw(Graphics g, Pen p) {
            g.DrawArc(Pens.Black, X - Width / 2, Y - Height / 2, Width, Height, 0, 360);
        }
    }
}
