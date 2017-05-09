using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//namespace for working with files
using System.IO;
using System.Drawing.Drawing2D;
//namespace for using a regular expressions
using System.Text.RegularExpressions;

namespace Task2N
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Image mainImage = new Bitmap(1200, 1200);
        //we will copy pictures on this image
        Image bufferImage;
        //list of points. List<> - it's a colection for working with single-type data sets
        List<Point> points = new List<Point>();
        Color maincolor = Color.Black;
        //Show readiness for a some  action
        bool isReadyToMoving = false;
        bool isReadyToCutting = false;
        bool isReadyToScaling = false;
        bool isReadyToRotation = false;
        bool isReadyToMirroring = false;
        bool isReadytToDraw = false;

        //parameters
        float scale = 1;
        float angle = 0;
        float thickness = 1;

        //It is used for driving. It's differents between old  point and new point
        int deltaX = 0, deltaY = 0;



        public Form1()
        {
            InitializeComponent();
            //initialize some start parameters;
            pictureBox2.Image = mainImage;
            graphics = Graphics.FromImage(mainImage);
            axisBox.Items.Add("OX");
            axisBox.Items.Add("OY");
            Components(false);
        }

        //enable or disable  radiobuttons
        private void Components(bool v)
        {
            movingRadio.Enabled = v;
            cuttingRadio.Enabled = v;
            scalingRadio.Enabled = v;
            rotationRadio.Enabled = v;
            mirrorRadio.Enabled = v;

        }

        //loading file
        private void loadBtn_Click(object sender, EventArgs e)
        {
            //pattern of regular expressin. He is responsible for the correct introduction of data from the file
            //[0-9] some number
            // \( \) \,  finds ),(
            //{1,3} Need from 1 to 3 elements
            // \d number
            //B R it's only  letters
            // | One of the. Logical OR
            string pattern = @"\([0-9]{1,3}\,[0-9]{1,3}\,[\d|B|R]{0,3}\,[\d|B]{0,3}\)";
            //filter of files. Only .txt files and folders
            openFileDialog1.Filter = @"Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string a;
                int counter = 0;
                //count lines in file 
                int length = File.ReadAllLines(openFileDialog1.FileName).Length;
                //count of poins. length * 4 because in  one line 4 points 
                string[] array = new string[4 * length];
                string[] path = new string[4];

                //file  streame for open file
                FileStream file = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                //stream for reading from file
                StreamReader reader = new StreamReader(file);

                for (int i = 0; i < length; i++)
                {
                    a = reader.ReadLine();
                    //Checks the string by pattern
                    if (Regex.IsMatch(a, pattern, RegexOptions.IgnorePatternWhitespace))
                    {
                        //spliting  line
                        path = a.Split('(', ')', ',');
                        foreach (var item in path)
                        {
                            //Split return "". Check that they were not
                            if (item != "")
                            {
                                array[counter] = item;
                                counter++;
                            }
                        }
                    }
                    else
                    {
                        //If the file is not valid then it clears the array and closes the stream
                        array = null;
                        reader.Close();
                        MessageBox.Show("The input string had the wrong format", "Error");
                        break;
                    }


                }
                reader.Close();
                
                if (array != null)
                {
                    //changing field for drawing. Turns it over and draws it from the bottom left
                    graphics.Transform = new Matrix(1, 0, 0, -1, 0, pictureBox2.Height);
                    //draw picture 
                    DrawPicture(length * 2, array);
                }

            }
            Components(true);
            pictureBox2.Image = mainImage;
        }

        private void DrawPicture(int length, string[] array)
        {
            Point[] bezier = new Point[4];
            Point[] point = new Point[length];
            int counter = 0;
            int result = 0;
            int bezierCount = 0;
            for (int i = 0; i < length * 2; i++)
            {
                //if it's number
                if (int.TryParse(array[i], out result))
                {
                    //if i's X
                    if ((i % 2 == 0))
                    {
                        point[counter].X = result;
                        counter--;
                    }
                    else
                        point[counter].Y = result;
                    //stoping adding
                    if (counter < (length - 1))
                        counter++;
                }
                else
                {
                    //is it's circle
                    if (array[i] == "R")
                    {
                        graphics.DrawEllipse(new Pen(maincolor, thickness), new Rectangle(point[counter - 1].X - int.Parse(array[i + 1]), point[counter - 1].Y - int.Parse(array[i + 1]), int.Parse(array[i + 1]) * 2, int.Parse(array[i + 1]) * 2));
                        //It is done so that the coordinates are not recorded with a radius or symbol
                        counter -= 1;
                        i++;
                    }
                    //if it's bezier curve 
                    if (array[i] == "B")
                    {
                        bezier[bezierCount].X = Convert.ToInt32(array[i - 2]);
                        bezier[bezierCount].Y = Convert.ToInt32(array[i - 1]);
                        bezierCount++;
                        counter -= 1;
                        i++;
                        if (bezierCount > 3)
                            graphics.DrawBeziers(new Pen(maincolor, thickness), bezier);
                    }
                }

                if (counter % 2 == 0 && i != 0)
                {
                    graphics.DrawLine(new Pen(maincolor, thickness), point[counter - 2], point[counter - 1]);
                }
            }
            counter = 0;
            bezierCount = 0;

        }


        //changing color
        private void panel2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                maincolor = colorDialog1.Color;
                panel2.BackColor = maincolor;
            }
        }

        //rectangle for choosing some area
        private void FocusRect(Point Pt1, Point Pt2)
        {
            Point p1 = pictureBox2.PointToScreen(points[0]),
                  p2 = pictureBox2.PointToScreen(points[1]);

            ControlPaint.DrawReversibleFrame(GetRectangle(p1, p2),
                            Color.Black, 0);

            p1 = pictureBox2.PointToScreen(Pt1);
            p2 = pictureBox2.PointToScreen(Pt2);

            //Old rectangle was cleared by new rectangle
            ControlPaint.DrawReversibleFrame(GetRectangle(p1, p2),
                   Color.Black, 0);
        }

        //create rectangle by coordinats
        private Rectangle GetRectangle(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X),
                y = Math.Min(p1.Y, p2.Y),
                w = Math.Abs(p2.X - p1.X),
                h = Math.Abs(p2.Y - p1.Y);
            return new Rectangle(x, y, w, h);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            //writing coordinats. {0} = e.X {1} = e.Y
            xyLable.Text = string.Format("X: {0} Y: {1}", e.X, e.Y);

            //It's draw  rectangle and add new point
            if (isReadytToDraw && (movingRadio.Checked || cuttingRadio.Checked || scalingRadio.Checked || rotationRadio.Checked || mirrorRadio.Checked))
            {
                FocusRect(points[0], e.Location);
                points[1] = e.Location;
            }

            if (isReadyToMoving)
            {
                //cleare all pictureBox
                graphics.Clear(pictureBox2.BackColor);
                //transforming  field for new coordinates of picture
                graphics.Transform = new Matrix(1, 0, 0, 1, GetRectangle(points[0], points[1]).X, GetRectangle(points[0], points[1]).Y);
                graphics.DrawImage(bufferImage, new Point(e.X - deltaX, e.Y - deltaY));
                // Redrawing picturebox
                pictureBox2.Invalidate();
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            //Clearing all values
            if (isReadyToMoving || isReadyToCutting || isReadyToScaling || isReadyToRotation || isReadyToMirroring)
            {
                bufferImage = null;
                points.Clear();
                isReadyToMoving = false;
                isReadyToCutting = false;
                movingRadio.Checked = false;
                scalingRadio.Checked = false;
                isReadyToScaling = false;
                isReadyToRotation = false;
                rotationRadio.Checked = false;
                isReadyToMirroring = false;
                mirrorRadio.Checked = false;

            }

            if (bufferImage == null && (movingRadio.Checked || cuttingRadio.Checked || scalingRadio.Checked || rotationRadio.Checked || mirrorRadio.Checked))
            {
                isReadytToDraw = false;
                var rectangle = GetRectangle(points[0], points[1]);
                //copy image to buffer 
                if (rectangle.Width > 0 && rectangle.Height > 0)
                    bufferImage = CopyBitmap((Bitmap)mainImage, GetRectangle(points[0], points[1]));
                pictureBox2.Image = mainImage;
            }


        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            // if buffer is not empty
            if (bufferImage != null)
            {
                if (movingRadio.Checked)
                {
                    //calculating new coordinates  for moving
                    //if cursor in rectangle
                    if (e.X < GetRectangle(points[0], points[1]).X + GetRectangle(points[0], points[1]).Width && e.X > GetRectangle(points[0], points[1]).X)
                        if (e.Y < GetRectangle(points[0], points[1]).Y + GetRectangle(points[0], points[1]).Height && e.Y > GetRectangle(points[0], points[1]).Y)
                        {
                            deltaX = e.X - 1;
                            deltaY = e.Y - 1;
                            isReadyToMoving = true;
                        }
                }
                if (cuttingRadio.Checked)
                {
                    isReadyToCutting = true;
                    PasteImg(e.Location);
                }
                if (scalingRadio.Checked)
                {
                    isReadyToScaling = true;
                    ScalingImage(e.Location);
                }
                if (rotationRadio.Checked)
                {
                    isReadyToRotation = true;
                    RotationThroughAPoint(e.Location);
                }
                if (mirrorRadio.Checked)
                {
                    isReadyToMirroring = true;
                    MirroringThroughAnAxis(axisBox.Text, e.Location);
                }
                }
                else
                {
                //if buffer is empt
                    if (movingRadio.Checked || cuttingRadio.Checked || scalingRadio.Checked || rotationRadio.Checked || mirrorRadio.Checked)
                    {
                    //clear old points
                        points.Clear();
                    //add new points
                        points.Add(e.Location);
                        points.Add(e.Location);
                        isReadytToDraw = true;
                    }

                }
            }

        //miroring the  image in buffer
        private void MirroringThroughAnAxis(string text, Point location)
        {
            Brush brush = new SolidBrush(pictureBox2.BackColor);
            var rectangle = GetRectangle(points[0], points[1]);
            
            if (text == "OX")
                bufferImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
            else
                bufferImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            //changing matrix for transforming
            graphics.Transform = new Matrix(1, 0, 0, 1, 0, 0);
            graphics.FillRectangle(brush, rectangle);
            graphics.DrawImage(bufferImage, location);
            pictureBox2.Image = mainImage;

        }
 
        //rotaing rhro the  point Location. 
        private void RotationThroughAPoint(Point location)
        {
            Brush brush = new SolidBrush(pictureBox2.BackColor);
            var rectangle = GetRectangle(points[0], points[1]);
            Matrix matrix = new Matrix(1, 0, 0, 1, 1, 1);
            graphics.Transform = matrix;
            graphics.FillRectangle(brush, rectangle);
            matrix.RotateAt(angle,location);
            graphics.Transform = matrix;
            graphics.DrawImage(bufferImage,location);
            
            pictureBox2.Image = mainImage;

        }

        //scaling image  using ScaleNumerical.Value
        private void ScalingImage(Point location)
        {
            Brush brush = new SolidBrush(pictureBox2.BackColor);
            var rectangle = GetRectangle(points[0], points[1]);
            graphics.Transform = new Matrix(1, 0, 0, 1,1, 1);
            graphics.FillRectangle(brush, rectangle);
            graphics.DrawImage(bufferImage, new RectangleF(location.X, location.Y, rectangle.Width * scale, rectangle.Height  * scale)); 
            pictureBox2.Image = mainImage;
        }


        //copy oe image to other 
        private Bitmap CopyBitmap(Bitmap source, Rectangle part)
        {
            Bitmap bmp = new Bitmap(part.Width, part.Height);
            Graphics gc = Graphics.FromImage(bmp);

            gc.DrawImage(source, 0, 0, part, GraphicsUnit.Pixel);
            gc.Dispose();
            return bmp;
        }

        //paste image from buffer to new area 
        private void PasteImg(Point p)
        {
            graphics = Graphics.FromImage(mainImage);
            if (cuttingRadio.Checked)
            {
                Brush brush = new SolidBrush(pictureBox2.BackColor);
                var rectangle = GetRectangle(points[0], points[1]);
                graphics.FillRectangle(brush, rectangle);
                graphics.DrawImage(bufferImage,  p);
                cuttingRadio.Checked = false;
            }
            
            graphics = Graphics.FromImage(mainImage);
            pictureBox2.Image = mainImage;
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            scale = (float)scaleNumeric.Value/100;
        }

        private void angleNumerical_ValueChanged(object sender, EventArgs e)
        {
            angle = (float)angleNumerical.Value;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            graphics.Clear(pictureBox2.BackColor);
            pictureBox2.Image = mainImage;
        }

        private void thicknessNumerical_ValueChanged(object sender, EventArgs e)
        {
            thickness = (int)thicknessNumerical.Value;
        }

    }
}
