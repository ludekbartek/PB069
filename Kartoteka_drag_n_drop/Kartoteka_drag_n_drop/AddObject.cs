using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartoteka_drag_n_drop
{
    public partial class AddObject : Form
    {
        public GraphicalObject Value { get; set; }

        public AddObject()
        {
            InitializeComponent();
            for(ObjectType obj = ObjectType.LINE;obj<=ObjectType.CIRCLE; obj++)
            {
                comboBox1.Items.Add(obj);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex<0)
            {
                comboBox1.Focus();
                DialogResult = DialogResult.None;
                return;
            }
            Value = new GraphicalObject();
            Value.type = (ObjectType)comboBox1.SelectedItem;
            Value.dx = (int)dxUpDown.Value;
            Value.dy = (int)dyUpDown.Value;
        }
    }
}
