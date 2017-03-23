using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionsDrawing
{
    public partial class AddFunction : Form
    {

        public Function function { get; set; }

        public AddFunction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                DialogResult = DialogResult.None;
                comboBox1.Focus();
                return;
            }
            if(aUpDown1.Value == 0)
            {
                DialogResult = DialogResult.None;
                aUpDown1.Focus();
                return;
            }
            if(fUpDown.Value == 0)
            {
                DialogResult = DialogResult.None;
                fUpDown.Focus();
                return;
            }
            function = new Function();
            function.a = (int)aUpDown1.Value;
            function.function = (Kind)comboBox1.SelectedIndex;
            function.f = (int)fUpDown.Value;
        }
    }
}
