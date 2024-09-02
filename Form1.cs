using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void renderShapeButton_Click(object sender, EventArgs e)
        {
            SelectShape sh = new SelectShape();
            Dimensions di = new Dimensions();
            di.thisdimensionX = decimal.Parse(textBoxX.Text); ;
            di.thisdimensionY = decimal.Parse(textBoxY.Text); ;
            di.thisdimensionZ = decimal.Parse(textBoxZ.Text); ;
            var convertintX = Math.Abs(Convert.ToInt16(di.thisdimensionX));
            var convertintY = Math.Abs(Convert.ToInt16(di.thisdimensionY));
            var convertintZ = Math.Abs(Convert.ToInt16(di.thisdimensionZ));
            sh.thisshape = comboBoxSelectShape.Text;
            string first = sh.thisshape.Substring(0, 2);
            if (first == "Sq")
            {
                textBoxOutput.Clear();
                pictureBox1.Image = null;
                pictureBox1.Update();
                Rectangle ee = new Rectangle(10, 10, convertintX, convertintY);
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    System.Drawing.Graphics graphicsObj;

                    graphicsObj = pictureBox1.CreateGraphics();
                    graphicsObj.DrawRectangle(pen, ee);
                }
            }
            else if (first == "Ci")
            {
                textBoxOutput.Clear();
                pictureBox1.Image = null;
                pictureBox1.Update();
                Rectangle ee = new Rectangle(0, 0, convertintX, convertintY);
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    System.Drawing.Graphics graphicsObj;

                    graphicsObj = pictureBox1.CreateGraphics();
                    graphicsObj.DrawEllipse(pen, ee);
                }
            }
            else if(first == "Tr")
            {
                textBoxOutput.Clear();
                pictureBox1.Image = null;
                pictureBox1.Update();
                Pen blackPen = new Pen(Color.Black, 3);
                Point[] points = { new Point(convertintX, convertintY), new Point(convertintX, convertintY + convertintY), new Point(convertintY +convertintY, convertintZ) };

                // Draw polygon to screen.
                System.Drawing.Graphics graphicsObj;

                graphicsObj = pictureBox1.CreateGraphics();
                graphicsObj.DrawPolygon(blackPen, points);
            }
            else if (first == "Sp")
            {
                textBoxOutput.Clear();
                pictureBox1.Image = null;
                pictureBox1.Update();
                Rectangle ee = new Rectangle(10, 10, convertintX, convertintY);
                using (SolidBrush redBrush = new SolidBrush(Color.Red))
                {
                    System.Drawing.Graphics graphicsObj;

                    graphicsObj = pictureBox1.CreateGraphics();
                    graphicsObj.FillEllipse(redBrush, ee);
                }
            }
            else if (first == "Py")
            {
                textBoxOutput.Clear();
                pictureBox1.Image = null;
                pictureBox1.Update();
                Pen pencil = new Pen(Color.Blue, 1f);
                PointF[] p = new PointF[3];
                p[0].X = convertintX;
                float angle = 0;
                p[0].Y = convertintY;

                p[1].Y = (float)(convertintX + convertintZ * Math.Cos(angle + Math.PI / 3));

                p[1].X = (float)(convertintY + convertintZ * Math.Sin(angle + Math.PI / 3));

                p[2].Y = (float)(convertintX + convertintZ * Math.Cos(angle - Math.PI / 3));

                p[2].X = (float)(convertintY + convertintZ * Math.Sin(angle - Math.PI / 3));
                // Draw polygon to screen.
                System.Drawing.Graphics graphicsObj;

                graphicsObj = pictureBox1.CreateGraphics();
                graphicsObj.DrawPolygon(pencil, p);
                graphicsObj.DrawLine(pencil, convertintX, convertintY, (p[2].X + p[1].X) / 2, (p[2].Y + p[1].Y) / 2 );

            }
            if (first == "Cu")
            {
                textBoxOutput.Clear();
                pictureBox1.Image = null;
                pictureBox1.Update();
                Point Org = new Point(convertintX, convertintX);
                Pen pencil = new Pen(Color.Blue, 1f);
                Rectangle R = new Rectangle(Org.X, Org.Y, convertintX, convertintY);
                System.Drawing.Graphics graphicsObj;

                graphicsObj = pictureBox1.CreateGraphics();
                graphicsObj.DrawRectangle(pencil, R);
                graphicsObj.DrawLine(pencil, Org.X, Org.Y, Org.X + convertintZ, Org.Y - convertintZ);
                graphicsObj.DrawLine(pencil, Org.X + convertintZ, Org.Y - convertintZ, Org.X + convertintX + convertintZ, Org.Y - convertintZ);
                graphicsObj.DrawLine(pencil, Org.X + Org.X, Org.Y, Org.X + convertintX + convertintZ, Org.Y - convertintZ);
                graphicsObj.DrawLine(pencil, Org.X, Org.Y + convertintY, Org.X + convertintZ, Org.Y + convertintY - convertintZ);
                graphicsObj.DrawLine(pencil, Org.X + convertintZ, Org.Y + convertintY - convertintZ, Org.X + convertintX + convertintZ, Org.Y + convertintY - convertintZ);
                graphicsObj.DrawLine(pencil, Org.X + Org.X, Org.Y + convertintY, Org.X + convertintX + convertintZ, Org.Y + convertintY - convertintZ);
                graphicsObj.DrawLine(pencil, Org.X + convertintX + convertintZ, Org.Y - convertintZ, Org.X + convertintX + convertintZ, Org.Y + convertintY - convertintZ);
                graphicsObj.DrawLine(pencil, Org.X + convertintZ, Org.Y - convertintZ, Org.X + convertintZ, Org.Y + convertintY - convertintZ);

            }


        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal PI = 3.14M;
            SelectShape sh = new SelectShape();
            Dimensions di = new Dimensions();
            Calculate ca = new Calculate();
            di.thisdimensionX = decimal.Parse(textBoxX.Text); ;
            di.thisdimensionY = decimal.Parse(textBoxY.Text); ;
            di.thisdimensionZ = decimal.Parse(textBoxZ.Text); ;
            float convertintX = (float)di.thisdimensionX;
            float convertintY = (float)di.thisdimensionY;
            float convertintZ = (float)di.thisdimensionZ;
            decimal radius =((decimal)Math.Sqrt((convertintX - 0)*(convertintX - 0) + (convertintY - 0)*(convertintY - 0)));
            sh.thisshape = comboBoxSelectShape.Text;
            string first = sh.thisshape.Substring(0, 2);
            ca.thiscalculation = comboBoxFunction.Text;
            string second = ca.thiscalculation.Substring(0, 2);
            if (first == "Sq")
            {
                if (second == "Vo")
                {
                    textBoxOutput.Clear();
                    ca.thisvolume = 0;
                    textBoxOutput.Text = "Volume = " + ca.thisvolume;
                }
                else if (second == "Su")
                {
                    textBoxOutput.Clear();
                    ca.thissurfaceArea = di.thisdimensionX * di.thisdimensionY;
                    textBoxOutput.Text = "Surface Area = " + ca.thissurfaceArea;
                }
                else if (second == "Ci")
                {
                    textBoxOutput.Clear();
                    ca.thiscircumference = 2*di.thisdimensionX + 2*di.thisdimensionY;
                    textBoxOutput.Text = "Circumference = " + ca.thiscircumference;
                }
            }
            else if (first == "Ci")
            {
                if (second == "Vo")
                {
                    textBoxOutput.Clear();
                    ca.thisvolume = 0;
                    textBoxOutput.Text = "Volume = " + ca.thisvolume;
                }
                else if (second == "Su")
                {
                    textBoxOutput.Clear();
                    ca.thissurfaceArea = PI * radius *radius;
                    textBoxOutput.Text = "Surface Area = " + ca.thissurfaceArea;
                }
                else if (second == "Ci")
                {
                    textBoxOutput.Clear();
                    ca.thiscircumference = 2 * PI * radius;
                    textBoxOutput.Text = "Circumference = " + ca.thiscircumference;
                }

            }
            else if (first == "Tr")
            {
                if (second == "Vo")
                {
                    textBoxOutput.Clear();
                    ca.thisvolume = 0;
                    textBoxOutput.Text = "Volume = " + ca.thisvolume;
                }
                else if (second == "Su")
                {
                    textBoxOutput.Clear();
                    var s = (float)(di.thisdimensionX + di.thisdimensionY + di.thisdimensionZ) / 2;
                    ca.thissurfaceArea = (decimal)Math.Sqrt(s*(s - convertintX ) * (s - convertintY ) * (s - convertintZ ) );
                    textBoxOutput.Text = "Surface Area = " + ca.thissurfaceArea;
                }
                else if (second == "Ci")
                {
                    textBoxOutput.Clear();
                    ca.thiscircumference = di.thisdimensionX+ di.thisdimensionY+ di.thisdimensionZ;
                    textBoxOutput.Text = "Circumference = " + ca.thiscircumference;
                }

            }
            else if (first == "Sp")
            {
                if (second == "Vo")
                {
                    decimal number = 4 / 3M;
                    textBoxOutput.Clear();
                    ca.thisvolume = number * PI * radius * radius * radius;
                    textBoxOutput.Text = "Volume = " + ca.thisvolume;
                }
                else if (second == "Su")
                {
                    textBoxOutput.Clear();
                    ca.thissurfaceArea =4 * PI * radius * radius;
                    textBoxOutput.Text = "Surface Area = " + ca.thissurfaceArea;
                }
                else if (second == "Ci")
                {
                    textBoxOutput.Clear();
                    ca.thiscircumference = 2 * PI * radius ;
                    textBoxOutput.Text = "Circumference = " + ca.thiscircumference;
                }

            }
            else if (first == "Cu")
            {
                if (second == "Vo")
                {
                    textBoxOutput.Clear();
                    ca.thisvolume = di.thisdimensionX * di.thisdimensionY * di.thisdimensionZ;
                    textBoxOutput.Text = "Volume = " + ca.thisvolume;
                }
                else if (second == "Su")
                {
                    textBoxOutput.Clear();
                    ca.thissurfaceArea = 2 *(di.thisdimensionX * di.thisdimensionY + di.thisdimensionY * di.thisdimensionZ + di.thisdimensionX * di.thisdimensionZ);
                    textBoxOutput.Text = "Surface Area = " + ca.thissurfaceArea;
                }
                else if (second == "Ci")
                {
                    textBoxOutput.Clear();
                    ca.thiscircumference = 2 * di.thisdimensionX + 2 * di.thisdimensionY;
                    textBoxOutput.Text = "Circumference = " + ca.thiscircumference;
                }


            }
            else if (first == "Py")
            {
                if (second == "Vo")
                {
                    decimal number = 1 / 3M;
                    textBoxOutput.Clear();
                    ca.thisvolume = number * di.thisdimensionX * di.thisdimensionY * di.thisdimensionZ;
                    textBoxOutput.Text = "Volume = " + ca.thisvolume;
                }
                else if (second == "Su")
                {
                    textBoxOutput.Clear();
                    var surface1 = (double)(convertintX * convertintY);
                    var surface2 = (double)((convertintY/2) * (convertintX / 2));
                    var surface3 = (double)((convertintX / 2) * (convertintX / 2));
                    var surface4 = (double)Math.Sqrt(surface2 + convertintZ * convertintZ);
                    var surface5 = (double)Math.Sqrt(surface3 + convertintZ * convertintZ);
                    ca.thissurfaceArea = (decimal)(surface1 + convertintX *surface4 + convertintY * surface5);
                    textBoxOutput.Text = "Surface Area = " + ca.thissurfaceArea;
                }
                else if (second == "Ci")
                {
                    textBoxOutput.Clear();
                    ca.thiscircumference = 2 * di.thisdimensionX + 2 * di.thisdimensionY;
                    textBoxOutput.Text = "Circumference = " + ca.thiscircumference;
                }


            }



        }

        private void comboBoxFunction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }

   
}
