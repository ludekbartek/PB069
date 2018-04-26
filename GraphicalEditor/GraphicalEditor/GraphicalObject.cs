using System;

namespace GraphicalEditor
{
    public enum ObjectType { Line, Rectangle, Ellipse}
    public class GraphicalObject
    {
        public ObjectType type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int dx { get; set; }
        public int dy { get; set; }

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4}",(int)type,X,Y,dx,dy);
        }

        public static GraphicalObject ParseObject(string line)
        {
            GraphicalObject obj = new GraphicalObject();
            string[] parts = line.Split(';');
            if (parts.Length != 5)
            {
                throw new FormatException("Invalid line format");
            }
            obj.type = (ObjectType)int.Parse(parts[0]);
            obj.X = int.Parse(parts[1]);
            obj.Y = int.Parse(parts[2]);
            obj.dx = int.Parse(parts[3]);
            obj.dy = int.Parse(parts[4]);
            return obj;
        }
    }
}