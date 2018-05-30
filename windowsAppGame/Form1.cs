using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsAppGame
{
    public partial class Form1 : Form
    {
        Point[] Positions = {
            new Point(1,1), new Point(10,10),
            new Point(20,10), new Point(50,10),new Point(60,20)
        };
        private int x;
        private int y;
        public Form1()
        {
            InitializeComponent();

            x = 50;
            y = 50;
        }
        public void gamePaint(object sender, PaintEventArgs e){
            e.Graphics.FillEllipse(Brushes.AliceBlue, new Rectangle(new Point(x,y),new Size(50,50)));
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            y++;
            Invalidate();
        }
    }
}
