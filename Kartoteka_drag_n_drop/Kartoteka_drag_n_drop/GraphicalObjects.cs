using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartoteka_drag_n_drop
{
    public enum ObjectType
    {
        [Description("Nedefinovaný")]UNDEF,
        [Description("Úsečka")]LINE,
        [Description("Obdélník")]RECTANGLE,
        [Description("Kruh")] CIRCLE
    };

    public class GraphicalObject : DataObject
    {
        public ObjectType type { get; set; }
        public int dx { get; set; }
        public int dy { get; set; }
        public override string ToString()
        {
            return type + "," + dx + "," + dy;
        }

    }
}
