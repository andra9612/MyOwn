using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Drawing.Drawing2D;

namespace Painter_2D
{
    public partial class Form1 : Form
    {
        Color color = new Color();
        int iterationNumber = 0;
        Point p1 = new Point();
        Point p2 = new Point();

        int sizeBrush = 1;

        bool isReady = false;

        public Form1()
        {
            color = Color.Black;
            InitializeComponent();
        }

        private void ChoseColor(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColorPanel.BackColor = colorDialog1.Color;
                color = colorDialog1.Color;
            }
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {

            CoordinatsLable.Text ="X: "  + e.X.ToString()  + " Y: " +e.Y.ToString();

            //if(iterationNumber == 1 && CircleRadio.Checked)
            //{
            //    Pen pen = new Pen(Color.Gray, 2);
            //    pen.DashStyle = DashStyle.Dot;
            //    Graphics g = pictureBox1.CreateGraphics();
            //    g.DrawLine(pen,p1, new Point(p1.X + e.X, p1.Y + e.Y) );
            //}
            
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            //PictureBox p = sender as PictureBox;
            //p.CreateGraphics().DrawEllipse(new Pen(Color.Black), e.X-50, e.Y-50, 100, 100);

            if (iterationNumber == 0)
            {
                p1 = new Point(e.X, e.Y);
                g.FillRectangle(new Pen(color, 2).Brush, p1.X, p1.Y, 2, 2);
                iterationNumber++;
            }   
            else
            {
                p2 = new Point(e.X, e.Y);
                iterationNumber++;
            }
                
            if(iterationNumber == 2)
            {
                if (LineRadio.Checked)
                    MyLine(g);
                if (CircleRadio.Checked)
                    MyCircle(g);
            }

        }

        private void MyCircle( Graphics g)
        {
            int X, Y;
            float width = 0;
            int  halfWith = 0;
            X = p2.X - p1.X;
            Y = p2.Y - p1.Y;



            width = (float)Math.Sqrt(X*X + Y*Y);
            width *= 2;
            halfWith = (int)(width / 2);
            g.FillRectangle(new Pen(color, 1).Brush, p1.X, p1.Y, 1, 1);
            g.DrawEllipse(new Pen(color, sizeBrush),p1.X - halfWith, p1.Y - halfWith, width,width);

            iterationNumber = 0;
        }

        private void MyLine(Graphics g)
        {

            g.DrawLine(new Pen(color, sizeBrush), p1, p2);

            iterationNumber = 0;
        }

        private void GetBrushSize(object sender, EventArgs e)
        {
            sizeBrush = (int)brushSize.Value;
        }

        private Rectangle GetRectangle(Point p1, Point p2)
        {
            int x = p1.X,
                y = p1.Y,
                w = Math.Abs(p2.X - p1.X),
                h = Math.Abs(p2.Y - p1.Y);
            return new Rectangle(w, h, w, w);
        }
    }
}
