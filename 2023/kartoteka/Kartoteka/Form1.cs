using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartoteka {
    public partial class Form1 : Form {
        private string fileName;
        private List<Model> models = new List<Model>();
        private decimal totalPrice = 0;
        public Form1() {
            InitializeComponent();
        }

        private void novyToolStripMenuItem_Click(object sender, EventArgs e) {
            models.Clear();
            UpdateUI();
        }

        private void UpdateUI() {
            modelList.Items.Clear();
            foreach(Model model in models) {
                modelList.Items.Add(model);
            }
            priceLabel.Text = totalPrice.ToString();
            countStatusLabel.Text = models.Count.ToString();
        }

        private void pridatToolStripMenuItem_Click(object sender, EventArgs e) {
            AddModelDialog dialog = new AddModelDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {
                models.Add(dialog.model);
                totalPrice += dialog.model.price;
                UpdateUI();
            }
        }

        private void odebratToolStripMenuItem_Click(object sender, EventArgs e) {
            if (modelList.SelectedIndex < 0) {
                MessageBox.Show("Nutno vybrat odstranovanou polozku.");
                return;
            }
            var model = modelList.Items[modelList.SelectedIndex];
            totalPrice -= (model as Model).price;
            models.RemoveAt(modelList.SelectedIndex);
            
            UpdateUI();
        }

        private void ulozitToolStripMenuItem_Click(object sender, EventArgs e) {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK) {
                fileName= saveFileDialog1.FileName;
                saveData(saveFileDialog1.FileName);
            }
        }

        private void saveData(string fileName) {
            using(StreamWriter writer = new StreamWriter(fileName)) {
                foreach(Model model in models) {
                    writer.WriteLine(model);
                }
            }
        }

        private void otevritToolStripMenuItem_Click(object sender, EventArgs e) {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                fileName= openFileDialog1.FileName;
                models.Clear();
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName)) {
                    String line;
                    while((line = reader.ReadLine())!=null) 
                    {
                        models.Add(Model.Parse(line));
                    }
                    UpdateUI();

                }
            }
            
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
