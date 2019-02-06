using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace oop_lab2
{
    
    public partial class mainform : Form
    {
        private Graphics g;
        private Bitmap bitmap;
        private int coordX = 0;
        private int coordY = 0;
        private tLine line;
        private tTriangle triangle;
        private tRectangle rectangle;
        private tCircle circle;
        private tEllipse ellips;
        public Color bgColor;
        private bool stop = true;

        private const int FG_LENGTH = 400;
        private const int FG_HEIGHT = 200;
        private const int h = 5; // скорость перемещения стрелками
        
        public mainform()
        {
            InitializeComponent();           
        }


        private void mainform_Load(object sender, EventArgs e)
        {
            bgColor = Color.White;
        }

        private void mainform_Shown(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);          
        }

        private void mainform_KeyDown(object sender, KeyEventArgs e)
        {
            int stepX = 0;
            int stepY = 0;

            if (comboBox1.SelectedIndex == -1) return;

            switch (e.KeyCode)
            {
                case Keys.Up: { stepY = -h; break; }
                case Keys.Down: { stepY = h; break; }
                case Keys.Left: { stepX = -h; break; }
                case Keys.Right: { stepX = h; break; }
            }

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Отрезок":
                    {
                        line.HideLine(g, pictureBox1.BackColor);
                        line.MoveLine(stepX, stepY);
                        line.DrawLine(g);
                        break;
                    }
                case "Треугольник":
                    {
                        triangle.HideTriangle(g);
                        triangle.MoveTriangle(stepX, stepY);
                        triangle.DrawTriangle(g);
                        break;
                    }
                case "Прямоугольник":
                    {
                        rectangle.HideRectangle(g);
                        rectangle.MoveRectangle(stepX, stepY);
                        rectangle.DrawRectangle(g);
                        break;
                    }
                case "Окружность":
                    {
                        circle.HideCircle(g);
                        circle.MoveCircle(stepX, stepY);
                        circle.DrawCircle(g);
                        break;
                    }
                case "Эллипс":
                    {
                        ellips.HideEllipse(g);
                        ellips.MoveCircle(stepX, stepY);
                        ellips.DrawEllipse(g);
                        break;
                    }
            }
            
            
        }

        private void comboBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                e.IsInputKey = true;
        }

        private void buttonRandomMove_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                e.IsInputKey = true;
        }

        private void buttonStopMove_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                e.IsInputKey = true;
        }

        private void buttonClose_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                e.IsInputKey = true;
        }

        private void lineWidth_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                e.IsInputKey = true;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            ColorDialog clrDlg = new ColorDialog();
            if ( clrDlg.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = clrDlg.Color;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel1_Click(sender, e);
        }


        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ( panel1.BackColor == pictureBox1.BackColor)
            {
                MessageBox.Show("Сначала выберите цвет фигуры и толщину линии");
                comboBox1.SelectedIndex = -1;
                return;
            }
            int halfWidth = pictureBox1.Width / 2;
            int halfHeight = pictureBox1.Height / 2;

            g.Clear(bgColor);
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Отрезок":
                    {
                        line = new tLine(halfWidth - FG_LENGTH / 2, halfHeight, halfWidth + FG_LENGTH / 2, halfHeight, 
                            panel1.BackColor, Convert.ToInt32(lineWidth.Value));
                        line.DrawLine(g);
                        break;
                    }

                case "Треугольник":
                    {
                        triangle = new tTriangle(halfWidth - FG_LENGTH /2 , halfHeight, halfWidth, halfHeight - FG_HEIGHT, 
                            halfWidth + FG_LENGTH /2, halfHeight, panel1.BackColor, Convert.ToInt32(lineWidth.Value));
                        triangle.DrawTriangle(g);
                        break;
                    }
                case "Прямоугольник":
                    {
                        rectangle = new tRectangle(halfWidth - FG_LENGTH / 2, halfHeight - FG_HEIGHT / 2 , 
                                                    halfWidth + FG_LENGTH / 2, halfHeight - FG_HEIGHT /2,
                                                    halfWidth + FG_LENGTH / 2, halfHeight + FG_HEIGHT / 2,
                                                    panel1.BackColor, Convert.ToInt32(lineWidth.Value));
                        rectangle.DrawRectangle(g);
                        break;
                    }
                case "Окружность":
                    {
                        circle = new tCircle(halfWidth - FG_HEIGHT / 2, halfHeight - FG_HEIGHT / 2, FG_HEIGHT,  
                                                panel1.BackColor, Convert.ToInt32(lineWidth.Value));
                        circle.DrawCircle(g);
                        break;
                    }
                case "Эллипс":
                    {
                        ellips = new tEllipse(halfWidth - FG_LENGTH / 2, halfHeight - FG_HEIGHT / 2, 
                                                FG_LENGTH, FG_HEIGHT, panel1.BackColor, Convert.ToInt32(lineWidth.Value));
                        ellips.DrawEllipse(g);
                        break;
                    }
                    
            }
            pictureBox1.Focus();
        }



        private void buttonStopMove_Click(object sender, EventArgs e)
        {
            stop = true;
            buttonRandomMove.Text = "Случайное перемещение";
            buttonStopMove.Enabled = false;
        }

        private void buttonRandomMove_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала надо нарисовать фигуру");
                return;
            }

            buttonRandomMove.Text = "Сменить направление";
            buttonStopMove.Enabled = true;

            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            Random rnd = new Random();
            int stepX = rnd.Next(-3, 3);
            int stepY = rnd.Next(-3, 3);

            stop = false;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Отрезок":
                    {
                        while (!stop)
                        {
                            if ((line.getX() + stepX) >= width || (line.getX() + stepX) <= 0 || (line.getX2() + stepX) <= 0 || (line.getX2() + stepX) >= width)
                            {
                                stepX = -stepX;
                            }

                            if ((line.getY() + stepY) >= height || (line.getY() + stepY) <= 0 || (line.getY2() + stepY) <= 0 || (line.getY2() + stepY) >= height)
                            {
                                stepY = -stepY;
                            }

                            line.HideLine(g, pictureBox1.BackColor);
                            line.MoveLine(stepX, stepY);
                            line.DrawLine(g);
                            Application.DoEvents();
                            Thread.Sleep(1);
                        }

                        break;
                    }
                case "Треугольник":
                    {

                        while (!stop)
                        {
                            if ((triangle.getX() > Width) || (triangle.getX2() > Width) || (triangle.getX3() > Width)
                                    || (triangle.getX() < 0) || (triangle.getX2() < 0) || (triangle.getX3() < 0))
                            {
                                stepX = -stepX;
                            }

                            if ((triangle.getY() > Height) || (triangle.getY2() > Height) || (triangle.getY3() > Height) 
                                || (triangle.getY() < 0) || (triangle.getY2() < 0) || (triangle.getY3() < 0))
                            {
                                stepY = -stepY;
                            }
                            triangle.HideTriangle(g);
                            triangle.MoveTriangle(stepX, stepY);
                            triangle.DrawTriangle(g);
                            Application.DoEvents();
                            Thread.Sleep(1);
                        }

                        
                        break;
                    }
                case "Прямоугольник":
                    {
                        while (!stop)
                        {
                            if ((rectangle.getX() > Width) || (rectangle.getX2() > Width) || (rectangle.getX3() > Width) 
                                || (rectangle.getX4() > Width) || (rectangle.getX() < 0) || (rectangle.getX2() < 0) 
                                || (rectangle.getX3() < 0) || (rectangle.getX4() < 0))
                            {
                                stepX = -stepX;
                            }

                            if ((rectangle.getY() > Height) || (rectangle.getY2() > Height) || (rectangle.getY3() > Height) 
                                || (rectangle.getY4() > Height) || (rectangle.getY() < 0) || (rectangle.getY2() < 0) 
                                || (rectangle.getY3() < 0) || (rectangle.getY4() < 0))
                            {
                                stepY = -stepY;
                            }

                            rectangle.HideRectangle(g);
                            rectangle.MoveRectangle(stepX, stepY);
                            rectangle.DrawRectangle(g);
                            Application.DoEvents();
                            Thread.Sleep(1);
                        }
                        break;
                    }
                case "Окружность":
                    {
                        while(!stop)
                        {
                            if (((circle.getX() + circle.getR()) > width) || (circle.getX() < 0))
                            {
                                stepX = -stepX;
                            }

                            if (((circle.getY() + circle.getR()) > height) || (circle.getY() < 0))
                            {
                                stepY = -stepY;
                            }

                            circle.HideCircle(g);
                            circle.MoveCircle(stepX, stepY);
                            circle.DrawCircle(g);
                            Application.DoEvents();
                            Thread.Sleep(1);
                        }
                        break;
                    }
                case "Эллипс":
                    {
                        while (!stop)
                        {
                            if (((ellips.getX() + ellips.getR()) > width) || (ellips.getX() < 0))
                            {
                                stepX = -stepX;
                            }

                            if (((ellips.getY() + ellips.getR2()) > height) || (ellips.getY() < 0))
                            {
                                stepY = -stepY;
                            }
                            ellips.HideEllipse(g);
                            ellips.MoveCircle(stepX, stepY);
                            ellips.DrawEllipse(g);
                            Application.DoEvents();
                            Thread.Sleep(1);
                        }
                        break;
                    }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = bitmap;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
