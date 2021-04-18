using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kertesius
{
    public partial class Kartesius : Form
    {
        Bitmap gridImg;
        Bitmap graphImg;
        Graphics Graph;
        public Kartesius()
        {
            InitializeComponent();
            gridImg = new Bitmap(grid.Width, grid.Height);
            Graph = Graphics.FromImage(gridImg);

            //grid
            Pen pen = new Pen(Color.FromArgb(100, 100, 100));//grey
            pen.Width = 1;
            for (int i = 50; i < grid.Width; i +=50)
            {
                Graph.DrawLine(pen, i, grid.Height, i, 0);
            }

            for (int i = 50; i < grid.Height; i += 50)
            {
                Graph.DrawLine(pen, grid.Width, i, 0, i);
            }

            //xy axis
            pen = new Pen(Color.FromArgb(0, 0, 100));//dark blue
            pen.Width = 5;

            Graph.DrawLine(pen, grid.Width / 2, grid.Height, grid.Width / 2, 0);
            Graph.DrawLine(pen, grid.Width, grid.Height / 2, 0, grid.Height / 2);

            grid.Image = gridImg;

            graphImg = (Bitmap)gridImg.Clone();
            Graph = Graphics.FromImage(graphImg);
            //gambar grid disimpan terpisah untuk function clear
        }

        private Point from_kartesius(int x, int y)
        {//terjemahkan koordinat kartesius ke koordinat pictureBox
            y = (y * -1) + grid.Height/2;
            x = x + grid.Width/2;

            Point point = new Point(x, y);
            return point;
        }
        //value NumericUpDown (decimal) tidak bisa jadi constructor untuk Point 
        //jadi harus convert ke int
        //WHAT A JOKE
        //Decimal.ToInt32(x1.Value)



        private void dr_line_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0)); //RED
            pen.Width = 5;


            //cek isi radio  button
            if (radioButton1.Checked)
            {
                int X0 = Decimal.ToInt32(x1.Value);
                int Y0 = Decimal.ToInt32(y1.Value);

                int X1 = Decimal.ToInt32(x2.Value);
                int Y1 = Decimal.ToInt32(y2.Value);

                //gradient
                float m;
                try
                {
                    m = (float)(Y1 - Y0) / (X1 - X0);
                }
                catch (DivideByZeroException)
                {//pembagian nol
                    m = 0;
                }


                //if(Math.Abs(m) > 1)
                //{
                //    MessageBox.Show("masih bug", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    if (X1 < X0)
                //    {
                //        X0 = Decimal.ToInt32(x2.Value);
                //        Y0 = Decimal.ToInt32(y2.Value);
                //        X1 = Decimal.ToInt32(x1.Value);
                //        Y1 = Decimal.ToInt32(y1.Value);

                //        //garis harus di-render dari bawah ke atas
                //        //(kiri ke kanan untuk axis x)
                //        //better solution needed
                //    }

                //    Point prev = from_kartesius(X0, Y0);

                //    for (int x = X0; x <= X1; x++)
                //    {
                //        float y = Y0 + m * (x - X0);
                //        Point point = from_kartesius(x, (int)y);
                //        Graph.DrawLine(pen, prev, point);
                //        prev = point;
                //    }
                //for (int y = Y0; y <= Y1; y++)
                //{
                //    //NASTY BUG: (0,150) (20,0) 
                //    //m = -0.5f; yang didapat -7.5

                //    float x = X0 + m * (y - Y0);
                //    Point point = from_kartesius((int)x, y);
                //    Graph.DrawLine(pen, prev, point);
                //    prev = point;
                //}


                //}
                //else
                //{
                if (X1 < X0)
                    {
                        X0 = Decimal.ToInt32(x2.Value);
                        Y0 = Decimal.ToInt32(y2.Value);
                        X1 = Decimal.ToInt32(x1.Value);
                        Y1 = Decimal.ToInt32(y1.Value);

                    }
                    Point prev = from_kartesius(X0, Y0);
                    for (int x = X0; x <= X1; x ++)
                    {
                        float y = Y0 + m * (x - X0);
                        Point point = from_kartesius(x, (int)Math.Round(y, 0));
                        Graph.DrawLine(pen, prev, point);
                        prev = point;
                    }
                //}

            }
            else if (radioButton2.Checked)
            {
                int X0 = Decimal.ToInt32(x1.Value);
                int Y0 = Decimal.ToInt32(y1.Value);

                int X1 = Decimal.ToInt32(x2.Value);
                int Y1 = Decimal.ToInt32(y2.Value);

                //gradient
                float m;
                try
                {
                    m = (float)(Y1 - Y0) / (X1 - X0);
                }
                catch (DivideByZeroException)
                {//pembagian nol
                    m = 0;
                }

                if (X1 < X0)
                {
                    X0 = Decimal.ToInt32(x2.Value);
                    Y0 = Decimal.ToInt32(y2.Value);
                    X1 = Decimal.ToInt32(x1.Value);
                    Y1 = Decimal.ToInt32(y1.Value);

                }
                Point prev = from_kartesius(X0, Y0);
                float y = Y0;
                for (int x = X0; x < X1; x++)
                {
                    y = y + m;
                    Point point = from_kartesius(x, (int)Math.Round(y,0));
                    Graph.DrawLine(pen, prev, point);
                    prev = point;
                }

            }
            else if (radioButton3.Checked)
            {

                /* pseudocode wikipedia: https://en.wikipedia.org/wiki/Bresenham%27s_line_algorithm
                    function line(x0, y0, x1, y1)
                    real deltax := x1 - x0
                    real deltay := y1 - y0
                    real deltaerr := abs(deltay / deltax)    // Assume deltax != 0 (line is not vertical),
                        // note that this division needs to be done in a way that preserves the fractional part
                    real error := 0.0 // No error at start
                    int y := y0
                    for x from x0 to x1 
                        plot(x, y)
                        error := error + deltaerr
                        if error ≥ 0.5 then
                            y := y + sign(deltay)
                            error := error - 1.0
                 */
                int X0 = Decimal.ToInt32(x1.Value);
                int Y0 = Decimal.ToInt32(y1.Value);

                int X1 = Decimal.ToInt32(x2.Value);
                int Y1 = Decimal.ToInt32(y2.Value);

                if (Math.Abs(Y1 - Y0) < Math.Abs(X1 - X0))
                {
                    if (X0 > X1)
                    {
                        Bresenham_low(X1, Y1, X0, Y0, pen);
                    }
                    else
                    {
                        Bresenham_low(X0, Y0, X1, Y1, pen);
                    }
                }
                else
                {
                    if (Y0 > Y1)
                    {
                        Bresenham_high(X1, Y1, X0, Y0, pen);
                    }
                    else
                    {

                        Bresenham_high(X0, Y0, X1, Y1, pen);
                     }
                }



            }
            else
            {   //TEST ALGORITMA DISINI !!!

                
                Point A = from_kartesius(Decimal.ToInt32(x1.Value), Decimal.ToInt32(y1.Value));
                Point B = from_kartesius(Decimal.ToInt32(x2.Value), Decimal.ToInt32(y2.Value));
                Graph.DrawLine(pen, A, B);

            }

            grid.Image = graphImg;

        }

        private void Bresenham_low(int x0, int y0, int x1, int y1, Pen pen)
        {
            int deltaX = x1 - x0;
            int deltaY = y1 - y0;
            int yi = 1;
            if (deltaY < 0)
            {
                yi = -1;
                deltaY -= 2 * deltaY;
            }

            int delta= (2 * deltaY) - deltaX;
            int y = y0;

            Point prev = from_kartesius(x0, y0);
            for  (int x = x0; x <= x1; x++)
            {
                Point point = from_kartesius(x, y);
                Graph.DrawLine(pen, prev, point);
                prev = point;
                if (delta > 0)
                {
                    y = y + yi;
                   delta = delta+ (2 * (deltaY - deltaX));
                }
                else
                {
                   delta = delta+ 2 * deltaY;
                }
            }

        }
        private void Bresenham_high(int x0, int y0, int x1, int y1, Pen pen)
        {
            int deltaX = x1 - x0;
            int deltaY = y1 - y0;
            int xi = 1;
            if (deltaX < 0)
            {
                xi = -1;
                deltaX -= 2 * deltaX;
            }

            int delta = (2 * deltaX) - deltaY;
            int x = x0;

            Point prev = from_kartesius(x0, y0);
            for (int y = y0; y <= y1; y++)
            {
                Point point = from_kartesius(x, y);
                Graph.DrawLine(pen, prev, point);
                prev = point;
                if (delta > 0)
                {
                    x = x + xi;
                    delta = delta + (2 * (deltaX - deltaY));
                }
                else
                {
                    delta = delta + 2 * deltaX;
                }
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            grid.Image = gridImg;
            graphImg = (Bitmap)gridImg.Clone();
            Graph = Graphics.FromImage(graphImg);

        }
    }
}
