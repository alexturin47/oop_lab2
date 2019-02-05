using System;
using System.Drawing;
using System.Windows.Forms;

namespace oop_lab1
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
        

        public mainform()
        {
            InitializeComponent();           
        }

        private void mainform_Shown(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            //g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void mainform_KeyDown(object sender, KeyEventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Отрезок":
                    {
                        if (line == null) return;
                        line.MoveKeys(e.KeyCode,pictureBox1.Width, pictureBox1.Height, g);
                        break;
                    }
                case "Треугольник":
                    {
                        if (triangle == null) return;
                        triangle.MoveKeysTriangle(e.KeyCode, pictureBox1.Width, pictureBox1.Height, g);
                        break;
                    }
                case "Прямоугольник":
                    {
                        if (rectangle == null) return;
                        rectangle.MoveKeysRectangle(e.KeyCode, pictureBox1.Width, pictureBox1.Height, g);
                        break;
                    }
                case "Окружность":
                    {
                        if (circle == null) return;
                        circle.MoveKeysCircle(e.KeyCode, pictureBox1.Width, pictureBox1.Height, g);
                        break;
                    }
                case "Эллипс":
                    {
                        if (ellips == null) return;
                        ellips.MoveKeysEllipse(e.KeyCode, pictureBox1.Width, pictureBox1.Height, g);
                        break;
                    }
            }
            
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();          
        }

        private void comboBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                e.IsInputKey = true;
        }

        private void buttonDraw_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                e.IsInputKey = true;
        }

        private void buttonRandomMove_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                e.IsInputKey = true;
        }

        private void buttonArrowMove_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                e.IsInputKey = true;
        }

        private void buttonClose_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                e.IsInputKey = true;
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выбериет фигуру для рисования");
                return;
            }

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Отрезок":
                    {
                        line = new tLine(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text), 
                            Int32.Parse(textBox4.Text), panel1.BackColor, Convert.ToInt32(lineWidth.Value));
                        g.Clear(bgColor);
                        line.DrawLine(g);                     
                        break;
                    }
                case "Треугольник":
                    {
                        triangle = new tTriangle(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text),
                            Int32.Parse(textBox4.Text), Int32.Parse(textBox5.Text), Int32.Parse(textBox6.Text), 
                            panel1.BackColor, Convert.ToInt32(lineWidth.Value));
                        g.Clear(bgColor);
                        triangle.DrawTriangle(g);
                        break;
                    }
                case "Прямоугольник":
                    {
                        rectangle = new tRectangle(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text),
                            Int32.Parse(textBox4.Text), Int32.Parse(textBox5.Text), Int32.Parse(textBox6.Text),
                            panel1.BackColor, Convert.ToInt32(lineWidth.Value));
                        g.Clear(bgColor);
                        rectangle.DrawRectangle(g);
                        break;
                    }
                case "Окружность":
                    {
                        int r = Int32.Parse(textBox3.Text);
                        int x = Int32.Parse(textBox1.Text);
                        int y = Int32.Parse(textBox2.Text);
                        int width = pictureBox1.Width;
                        if (x + r > width) r = width - x;
                        if (x - r < 0) r = x;
                        if (y + r > pictureBox1.Height) r = pictureBox1.Height - y;
                        if (y + r < 0) r = y;
                        textBox3.Text = r.ToString();
                        circle = new tCircle((Int32.Parse(textBox1.Text) - Int32.Parse(textBox3.Text)), 
                            (Int32.Parse(textBox2.Text) - Int32.Parse(textBox3.Text)),
                            Int32.Parse(textBox3.Text), panel1.BackColor, Convert.ToInt32(lineWidth.Value));
                        g.Clear(bgColor);
                        circle.DrawCircle(g);
                        break;
                    }
                case "Эллипс":
                    {
                        ellips = new tEllipse((Int32.Parse(textBox1.Text) - Int32.Parse(textBox3.Text)), 
                            (Int32.Parse(textBox2.Text) - Int32.Parse(textBox4.Text)),
                            Int32.Parse(textBox3.Text), Int32.Parse(textBox4.Text), panel1.BackColor, Convert.ToInt32(lineWidth.Value));
                        g.Clear(bgColor);
                        ellips.DrawEllipse(g);
                        break;
                    }
                
            }
            
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
            labelDop.Visible = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Отрезок":
                    {
                        labelStart.Text = "Начало";
                        labelEnd.Text = "Конец";
                        break;
                    }
                case "Окружность":
                    {
                        labelStart.Text = "Центр окружности";
                        labelEnd.Text = "Радиус";
                        textBox4.Visible = false;
                        label6.Visible = false;
                        label5.Text = "R";
                        break;
                    }
                case "Эллипс":
                    {
                        labelStart.Text = "Фокус эллипса";
                        labelEnd.Text = "Радиусы";
                        labelDop.Visible = false;
                        labelDop.Visible = true;
                        textBox4.Visible = true;
                        label5.Text = "R1";
                        label6.Visible = true;
                        label6.Text = "R2";
                        textBox5.Enabled = false;
                        textBox6.Enabled = false;
                        break;
                    }
                case "Треугольник":
                    {
                        labelStart.Text = "Первая вершина";
                        labelEnd.Text = "Вторая вершина";
                        labelDop.Text = "Третья вершина";
                        labelDop.Visible = true;
                        textBox5.Enabled = true;
                        textBox6.Enabled = true;
                        break;
                    }
                case "Прямоугольник":
                    {
                        labelStart.Text = "Первая вершина";
                        labelEnd.Text = "Вторая вершина";
                        labelDop.Text = "Третья вершина";
                        labelDop.Visible = true;
                        textBox5.Enabled = true;
                        textBox6.Enabled = true;
                        textBox3.Text = "600";
                        textBox4.Text = "200";
                        textBox5.Text = "600";
                        textBox6.Text = "350";
                        break;
                    }
            }
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            bgColor = Color.White;
            textBox1.Text = (pictureBox1.Width / 2).ToString();
            textBox2.Text = (pictureBox1.Height / 2).ToString();
        }

        private void buttonStopMove_Click(object sender, EventArgs e)
        {
            if (line != null) line.setStop(true);
            if (triangle != null) triangle.setStop(true);
            if (rectangle != null) rectangle.setStop(true);
            if (circle != null) circle.setStop(true);
            if (ellips != null) ellips.setStop(true);
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
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Отрезок":
                    {
                        if (line != null)
                        {
                            line.setStop(false);
                            line.MoveRnd(g, pictureBox1.Width, pictureBox1.Height);
                        }
                        break;
                    }
                case "Треугольник":
                    {
                        if (triangle != null)
                        {
                            triangle.setStop(false);
                            triangle.MoveRndTriangle(g, pictureBox1.Width, pictureBox1.Height);
                        }
                        break;
                    }
                case "Прямоугольник":
                    {
                        if (rectangle != null)
                        {
                            rectangle.setStop(false);
                            rectangle.MoveRndRectangle(g, pictureBox1.Width, pictureBox1.Height);
                        }
                        break;
                    }
                case "Окружность":
                    {
                        if (circle != null)
                        {
                            circle.setStop(false);
                            circle.MoveRndCircle(pictureBox1.Width, pictureBox1.Height, g);
                        }
                        break;
                    }
                case "Эллипс":
                    {
                        if (ellips != null)
                        {
                            ellips.setStop(false);
                            ellips.MoveRndEllipse(pictureBox1.Width, pictureBox1.Height, g);
                        }
                        break;
                    }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = bitmap;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ValidatePoint();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ValidatePoint();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ValidatePoint();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            ValidatePoint();
        }

        private void ValidatePoint()
        {
            if (comboBox1.SelectedIndex == -1) return;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Прямоугольник":
                    {
                        textBox4.Text = textBox2.Text;
                        textBox2.Text = textBox4.Text;
                        textBox5.Text = textBox3.Text;
                        textBox3.Text = textBox5.Text;
                        break;
                    }
                default: break;
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int cursorX = Cursor.Position.X;
            int cursorY = Cursor.Position.Y - 77;
            labelCursor.Text = "Позиция курсора: X = " + cursorX + "; Y = " + cursorY;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            coordX = e.X;
            coordY = e.Y;
        }
    }
}
