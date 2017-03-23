using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsDrawing
{
    public enum Kind
    {
        sin, cos
    }

    public class Function
    {
        public Kind function { get; set; }
        public int a { get; set; }
        public int f { get; set; }

        public override string ToString()
        {
            return (int)function + ";" + a + ";" + f;
        }
    }
}
