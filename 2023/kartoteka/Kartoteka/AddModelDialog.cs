using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartoteka {
    public partial class AddModelDialog : Form {
        public Model model { get; }
        public AddModelDialog() {
            InitializeComponent();
            model = new Model();
        }

        private void AddModelDialog_Load(object sender, EventArgs e) {
            foreach (string  i in Enum.GetNames(typeof(ModelType))){
                modelTypeBox.Items.Add(i.ToLower());
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (modelTypeBox.SelectedIndex >= 0 && nameBox.Text != "") {
                model.Name = nameBox.Text;
                model.kind = (ModelType)modelTypeBox.SelectedIndex;
                model.price = priceUpDown.Value;
            }
            else {
                DialogResult = DialogResult.None;
            }

        }
    }
}
