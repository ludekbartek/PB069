using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartoteka {
    public enum ModelType { CAR, SHIP, PLANE }
    public class Model {
        public string Name { get; set; }
        public ModelType kind {get; set;}
        public Decimal price { get; set;}

        internal static Model Parse(string line) {
            string[] parts = line.Split(',');
            Model model = new Model();
            model.Name = parts[0];
            model.kind = (ModelType)(int.Parse(parts[1]));
            model.price = Decimal.Parse(parts[2]);
            return model;
        }

        public override string ToString() {
            return Name+","+(int)kind+","+price;
        }
    }
}
