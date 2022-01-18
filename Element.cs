using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFML.Graphics;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class Element
    {
        public RectangleShape rectangle;
        public float x { get; set; }
        public float size { get; set; }
        public float y { get; set; }


        public Element(float xPos, float yPos)
        {
            size = yPos;
            x = xPos;
            y = yPos;
            rectangle = new RectangleShape();
            rectangle.Origin = new SFML.System.Vector2f(0,-1000);
            rectangle.Position = new SFML.System.Vector2f(x, 0);
            rectangle.Size = new SFML.System.Vector2f(8, -y);
            rectangle.FillColor = new SFML.Graphics.Color(150, 250, 250);
        }
    }
}
