using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoang_815
{
    public partial class frm2 : Form
    {
        Rectangle recLoc = new Rectangle(0, 0, 50, 50);
        Point choosingPoint = new Point();
        Point lastPoint = new Point();
        bool WorkAble = false;
        Image image = Image.FromFile(@"C:\\Users\\truon\\Downloads\\round.png");
        public frm2()
        {
            InitializeComponent();
        }

        private void pictureB_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, recLoc);
        }

        private void pictureB_MouseDown(object sender, MouseEventArgs e)
        {
            WorkAble = true;
            choosingPoint.X = e.X;
            choosingPoint.Y = e.Y;
            lastPoint.X = e.X;
            lastPoint.Y = e.Y;
        }

        private void pictureB_MouseUp(object sender, MouseEventArgs e)
        {
            WorkAble = false;
            lastPoint.X = e.X;
            lastPoint.Y = e.Y;  
        }

        private void pictureB_MouseMove(object sender, MouseEventArgs e)
        {
            if (WorkAble)
            {
                recLoc.X = recLoc.X + e.X - choosingPoint.X;
                recLoc.Y = recLoc.Y + e.Y - choosingPoint.Y;
                choosingPoint = e.Location;
                pictureB.Invalidate();
            }
        }
    }
}
