using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsAppGame
{
    class GameObject
    {
        private Point position;
        private Size size;
        private Brush color;

        public Point Position { get => position; set => position = value; }
        public Size Size { get => size; set => size = value; }
        public Brush Color { get => color; set => color = value; }

        GameObject(Point position, Size size){
            this.position = position;
            this.size = size;
        }

        public void update()
        {

        }
        public void render(Graphics graphics){
            graphics.FillRectangle(Brushes.Black, new Rectangle(position,size));
        }
    }
}
