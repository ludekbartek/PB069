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

namespace Kartoteka_drag_n_drop
{
    public partial class Form1 : Form
    {
        private List<GraphicalObject> objects = new List<GraphicalObject>();
        public Form1()
        {
            InitializeComponent();
            ObjectDisplay display = new ObjectDisplay();
            display.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearData();
        }

       
        private void ClearData()
        {
            listBox1.Items.Clear();
            objects.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                loadData(openFileDialog1.FileName);
            }
        }

        private void loadData(string fileName)
        {
            ClearData();   
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while((line = reader.ReadLine())!= null)
                {
                    GraphicalObject obj = LineToGraphicalObject(line);
                    AddData(obj);
                }
            }
        }

        private void AddData(GraphicalObject obj)
        {
            objects.Add(obj);
            listBox1.Items.Add(obj);
            objectCountLabel.Text = objects.Capacity.ToString();
        }

        private GraphicalObject LineToGraphicalObject(string line)
        {
            string[] parts = line.Split(',');
            if (parts.Length != 3)
            {
                throw new InvalidDataException("Line format incorrect.");
            }
            GraphicalObject obj = new GraphicalObject();
            obj.type = (ObjectType)Int16.Parse(parts[0]);
            obj.dx = Int32.Parse(parts[1]);
            obj.dy = Int32.Parse(parts[2]);
            return obj;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                SaveData(saveFileDialog1.FileName);
            }
        }

        private void SaveData(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach(GraphicalObject obj in objects)
                {
                    writer.WriteLine((int)obj.type + ","+ obj.dx+","+ obj.dy);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddObject dialog = new AddObject();
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                AddData(dialog.Value);

            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex<0)
            {
                MessageBox.Show("Neni vybran objekt k odebrani.");
                return;
            }
            RemoveObject(listBox1.SelectedIndex);
        }

        private void RemoveObject(int selectedIndex)
        {
            listBox1.Items.RemoveAt(selectedIndex);
            objects.RemoveAt(selectedIndex);
            objectCountLabel.Text = objects.Capacity.ToString();
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void listBox1_DragLeave(object sender, EventArgs e)
        {

        }

        private void listBox1_DragOver(object sender, DragEventArgs e)
        {

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.DoDragDrop((GraphicalObject)listBox1.SelectedItem, DragDropEffects.Copy);
        }
    }
}
