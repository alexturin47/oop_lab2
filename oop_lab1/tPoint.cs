using System.Drawing;
using System.Windows.Forms;
using System;
using System.Threading;

namespace oop_lab1
{
    class tPoint
    {
        private Color _color;
        private int _x;
        private int _y;

        // конструкторы
        public tPoint()
        {
            _x = 0;
            _y = 0;
            _color = Color.Black;
        } 
        // по умолчанию
        public tPoint(int x, int y, Color color) // со всеми параметрами
        {
            _x = x;
            _y = y;
            _color = color;

        }

        public tPoint(int x, int y)
        {
            _x = x;
            _y = y;
            _color = Color.Black;

        }

        public int getX()
        {
            return _x;
        }
        public void setX(int x)
        {
            _x = x;
        }

        public int getY()
        {
            return _y;
        }
        public void setY(int y)
        {
            _y = y;
        }


        public Color getColor()
        {
            return _color;
        }
        public void setColor(Color color)
        {
            _color = color;
        }

        //медот отрисовки точки
        protected void Draw(Graphics gfx)
        {
            Brush brush = new SolidBrush(_color);
            gfx.FillRectangle(brush, _x, _y, 1, 1);
        }

        protected void Clean(Graphics gfx)
        {
            Brush brush = new SolidBrush(_color);
            gfx.FillRectangle(brush, _x, _y, 1, 1);
        }

        public void Move(int stepX, int stepY)
        {
            _x += stepX;
            _y += stepY;
        }

        protected void MoveRnd(int StepX, int StepY, int wScreen, int hScreen, Graphics gfx)
        {
            Clean(gfx);

            if (StepX < 0)
            {
                if (_x >= 0) _x = _x + StepX;
                if (_x < 0) _x = _x + wScreen;
            }
            else
            {
                if (_x <= wScreen) _x = _x + StepX;
                if (_x >= wScreen) _x = _x - wScreen;
            }

            if (StepY < 0)
            {
                if (_y >= 0) _y = _y + StepY;
                if (_y < 0) _y = _y + hScreen;
            }
            else
            {
                if (_y <= hScreen) _y = _y + StepY;
                if (_y >= hScreen) _y = _y - hScreen;
            }
            Draw(gfx);

        }

        protected void MoveTo(Keys dir, int sizeH, int sizeW, Graphics gfx)
        {
            const int h = 5; // скорость движения
            Clean(gfx);
            switch (dir)
            {
                case Keys.Up:
                    {
                        _y = _y - h;
                        if (_y < 0) _y = _y + sizeH;
                        break;
                    }
                case Keys.Down:
                    {
                        _y = _y + h;
                        if (_y > sizeH) _y = _y - sizeH;
                        break;
                    }
                case Keys.Left:
                    {
                        _x = _x - h;
                        if (_x < 0) _x = _x + sizeW;
                        break;
                    }
                case Keys.Right:
                    {
                        _x = _x + h;
                        if (_x > sizeW) _x = _x - sizeW;
                        break;
                    }
            }
            Draw(gfx);

        }
    }


    // Отрезок
    class tLine: tPoint
    {
        private int _x2;
        private int _y2;    // конец отрезка
        private int _width;    // толщина линии
        private bool _stop;

        // конструкторы
        public tLine( int x, int y, int x2, int y2, Color color, int width) : base (x,y,color)
        {
            _x2 = x2;
            _y2 = y2;
            _width = width;
        }

        public tLine(): base (0,0,Color.Black)
        {
            _x2 = 0;
            _y2 = 0;
            _width = 1;
        }

        // методы установки и получения параметров 

        public int getX2()
        {
            return _x2;
        }
        public void setX2(int x)
        {
            _x2 = x;
        }

        public int getY2()
        {
            return _y2;
        }
        public void setY2(int y)
        {
            _y2 = y;
        }

        public void setWidth( int width)
        {
            if (width >= 0) _width = width;
        }
        public int getWidth()
        {
            return _width;
        }

        public void setStop(bool stop)
        {
            _stop = stop;
        }
        public bool getStop()
        {
            return _stop;
        }

        //Инициализация параметров
        public void Init(int x1, int y1, int x2, int y2, Color color, int width)
        {
            setX(x1);
            setY(y1);
            setX2(x2);
            setY2(y2);
            setWidth(width);
            setColor(color);
        }

        //Метод рисования линии
        public void DrawLine(Graphics gfx)
        {
            Pen pen = new Pen(getColor(), _width);
            gfx.DrawLine(pen, getX(), getY(), getX2(), getY2());
        }

        // Метод стиания линии
        public void Hide(Graphics gfx)
        {
            Pen pen = new Pen(Color.White, _width);
            gfx.DrawLine(pen, getX(), getY(), getX2(), getY2());
        }

        public void  MoveLine(int stepX, int stepY)
        {
            setX(getX()+stepX);
            setY(getY() + stepY);
            setX2(getX2() + stepX);
            setY2(getY2() + stepY);         
        }

        public void MoveKeys(Keys key, int width, int height, Graphics gfx)
        {
            const int h = 5; // скорость движения
            Hide(gfx);
            switch (key)
            {
                case Keys.Up:
                    {
                        if (getY() - h <= 0 || _y2 - h <= 0)
                        {
                            break;
                        } else
                        {
                            setY(getY() - h);
                            _y2 -= h;
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        if (getY() + h >= height || _y2 + h >= height)
                        {
                            break;
                        }
                        else
                        {
                            setY(getY() + h);
                            _y2 += h;
                        }
                        break;
                    }
                case Keys.Left:
                    {
                        if (getX() - h <= 0 || _x2 - h <= 0)
                        {
                            break;
                        }
                        else
                        {
                            setX(getX() - h);
                            _x2 -= h;
                        }
                        break;
                    }
                case Keys.Right:
                    {
                        if(getX() + h >= width || _x2 + h >= width)
                        {
                            break;
                        }
                        else
                        {
                            setX(getX() + h);
                            _x2 += h;
                        }
                        break;
                    }
            }
            Draw(gfx);
        }

        public void MoveRnd(Graphics gfx, int width, int height)
        {
            Random rnd = new Random();
            int stepX = rnd.Next(-2, 2);
            int stepY = rnd.Next(-2, 2);

            while (!_stop)
            {
                Hide(gfx);

                if ((getX() + stepX) >= width || (getX() + stepX) <= 0 || (getX2() + stepX) <= 0 || (getX2() + stepX) >= width)
                {
                    stepX = -stepX;
                }

                if ((getY() + stepY) >= height || (getY() + stepY) <= 0 || (getY2() + stepY) <= 0 || (getY2() + stepY) >= height)
                {
                    stepY = -stepY;
                }
                MoveLine(stepX, stepY);
                DrawLine(gfx);
                Application.DoEvents();
                Thread.Sleep(3);
            }
        }
    }


    //Класс описывающий треугольник
    class tTriangle : tLine
    {
        private int _x3;
        private int _y3;

        // Конструторы

        public tTriangle() : base(0, 0, 0, 0, Color.Black,0)
        {
            _x3 = 0;
            _y3 = 0;
        }

        public tTriangle(int x1, int y1, int x2, int y2, int x3, int y3, Color color, int width) : base(x1, y1, x2, y2, color, width)
        {
            _x3 = x3;
            _y3 = y3;
        }

        // методы установки.получения параметров
        public int getX3()
        {
            return _x3;
        }
        public void setX3(int x)
        {
            _x3 = x;
        }

        public int getY3()
        {
            return _y3;
        }
        public void setY3(int y)
        {
            _y3 = y;
        }

        public void DrawTriangle(Graphics gfx)
        {
            Pen pen = new Pen(getColor(), getWidth());
            for( int i = 0; i < 3; i++)
            {
                gfx.DrawLine(pen, getX(), getY(), getX2(), getY2());
                gfx.DrawLine(pen, getX(), getY(), getX3(), getY3());
                gfx.DrawLine(pen, getX2(), getY2(), getX3(), getY3());
            }
        }

        public void HideTriangle(Graphics gfx)
        {
            Pen pen = new Pen(Color.White, getWidth());
            for (int i = 0; i < 3; i++)
            {
                gfx.DrawLine(pen, getX(), getY(), getX2(), getY2());
                gfx.DrawLine(pen, getX(), getY(), getX3(), getY3());
                gfx.DrawLine(pen, getX2(), getY2(), getX3(), getY3());
            }
        }

        public void MoveRndTriangle(Graphics gfx, int Width, int Height)
        {
            Random rnd = new Random();
            int stepX = rnd.Next(-2, 2);
            int stepY = rnd.Next(-2, 2);

            while (!getStop())
            {
                HideTriangle(gfx);

                if ( (getX() > Width) || (getX2() > Width) || (getX3() > Width) || (getX() < 0) || (getX2() < 0) || (getX3() < 0))
                {
                    stepX = -stepX;
                }

                if ((getY() > Height) || (getY2() > Height) || (getY3() > Height) || (getY() < 0) || (getY2() < 0) || (getY3() < 0))
                {
                    stepY = -stepY;
                }
                //MoveTriangle(stepX, stepY);
                setX(getX() + stepX);
                setY(getY() + stepY);
                setX2(getX2() + stepX);
                setY2(getY2() + stepY);
                setX3(getX3() + stepX);
                setY3(getY3() + stepY);

                DrawTriangle(gfx);
                Application.DoEvents();
                Thread.Sleep(3);
            }
        }

        public void MoveKeysTriangle(Keys key, int width, int height, Graphics gfx)
        {
            const int h = 5; // скорость движения
            HideTriangle(gfx);
            switch (key)
            {
                case Keys.Up:
                    {
                        if (getY() - h <= 0 ||  getY2() - h <=0 || _y3 - h <= 0)
                        {
                            break;
                        }
                        else
                        {
                            setY(getY() - h);
                            setY2(getY2() - h);
                            _y3 -= h;
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        if (getY() + h >= height || getY2() + h >= height || _y3 + h >= height)
                        {
                            break;
                        }
                        else
                        {
                            setY(getY() + h);
                            setY2(getY2() + h);
                            _y3 += h;
                        }
                        break;
                    }
                case Keys.Left:
                    {
                        if (getX() - h <= 0 || getX2() <= 0 || _x3 - h <= 0)
                        {
                            break;
                        }
                        else
                        {
                            setX(getX() - h);
                            setX2(getX2() - h);
                            _x3 -= h;
                        }
                        break;
                    }
                case Keys.Right:
                    {
                        if (getX() + h >= width || getX2() >= width || _x3 + h >= width)
                        {
                            break;
                        }
                        else
                        {
                            setX(getX() + h);
                            setX2(getX2() + h);
                            _x3 += h;
                        }
                        break;
                    }
            }
            DrawTriangle(gfx);
        }

    }




    // класс Прямоугольника
    class tRectangle: tLine
    {
        private int _x3;
        private int _y3;
        private int _x4;
        private int _y4;
        public tRectangle() : base(0, 0, 0, 0, Color.Black, 0)
        {
            _x3 = 0;
            _y3 = 0;
            _x4 = 0;
            _y4 = 0;
        }
        public tRectangle(int x1, int y1, int x2, int y2, int x3, int y3, Color color, int width) : base(x1, y1, x2, y2, color, width)
        {
            _x3 = x3;
            _y3 = y3;
            _x4 = x1;
            _y4 = y3;
        }

        public void setX3( int x)
        {
            _x3 = x;
        }
        public int getX3()
        {
            return _x3;
        }

        public void setY3( int y)
        {
            _y3 = y;
        }
        public int getY3()
        {
            return _y3;
        }

        public int getX4()
        {
            return _x4;
        }
        private void setX4( int x)
        {
            _x4 = x;
        }
        public int getY4()
        {
            return _y4;
        }
        private void setY4(int y)
        {
            _y4 = y;
        }


        public void HideRectangle(Graphics gfx)
        {
            Pen pen = new Pen(Color.White, getWidth());
            for (int i = 0; i < 3; i++)
            {
                gfx.DrawLine(pen, getX(), getY(), getX2(), getY2());
                gfx.DrawLine(pen, getX(), getY(), getX4(), getY4());
                gfx.DrawLine(pen, getX2(), getY2(), getX3(), getY3());
                gfx.DrawLine(pen, getX4(), getY4(), getX3(), getY3());
            }
        }

        public void DrawRectangle(Graphics gfx)
        {
            Pen pen = new Pen(getColor(), getWidth());
            for (int i = 0; i < 3; i++)
            {
                gfx.DrawLine(pen, getX(), getY(), getX2(), getY2());
                gfx.DrawLine(pen, getX(), getY(), getX4(), getY4());
                gfx.DrawLine(pen, getX2(), getY2(), getX3(), getY3());
                gfx.DrawLine(pen, getX4(), getY4(), getX3(), getY3());
            }
        }

        public void MoveRndRectangle(Graphics gfx, int Width, int Height)
        {
            Random rnd = new Random();
            int stepX = rnd.Next(-2, 2);
            int stepY = rnd.Next(-2, 2);

            while (!getStop())
            {
                HideRectangle(gfx);

                if ((getX() > Width) || (getX2() > Width) || (getX3() > Width) || (getX4() > Width) || (getX() < 0) || (getX2() < 0) || (getX3() < 0) || (getX4() < 0))
                {
                    stepX = -stepX;
                }

                if ((getY() > Height) || (getY2() > Height) || (getY3() > Height) || (getY4() > Height) || (getY() < 0) || (getY2() < 0) || (getY3() < 0) || (getY4() < 0))
                {
                    stepY = -stepY;
                }
                //MoveTriangle(stepX, stepY);
                setX(getX() + stepX);
                setY(getY() + stepY);
                setX2(getX2() + stepX);
                setY2(getY2() + stepY);
                setX3(getX3() + stepX);
                setY3(getY3() + stepY);
                setX4(getX4() + stepX);
                setY4(getY4() + stepY);

                DrawRectangle(gfx);
                Application.DoEvents();
                Thread.Sleep(3);
            }
        }

        public void MoveKeysRectangle(Keys key, int width, int height, Graphics gfx)
        {
            const int h = 5; // скорость движения
            HideRectangle(gfx);
            switch (key)
            {
                case Keys.Up:
                    {
                        if (getY() - h <= 0 || getY2() - h <= 0 || getY3() - h <= 0 || _y4 - h <= 0)
                        {
                            break;
                        }
                        else
                        {
                            setY(getY() - h);
                            setY2(getY2() - h);
                            setY3(getY3() - h);
                            _y4 -= h;
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        if (getY() + h >= height || getY2() + h >= height || getY3() + h >= height || _y4 + h >= height)
                        {
                            break;
                        }
                        else
                        {
                            setY(getY() + h);
                            setY2(getY2() + h);
                            setY3(getY3() + h);
                            _y4 += h;
                        }
                        break;
                    }
                case Keys.Left:
                    {
                        if (getX() - h <= 0 || getX2() <= 0 || getX3() <= 0 || _x4 - h <= 0)
                        {
                            break;
                        }
                        else
                        {
                            setX(getX() - h);
                            setX2(getX2() - h);
                            setX3(getX3() - h);
                            _x4 -= h;
                        }
                        break;
                    }
                case Keys.Right:
                    {
                        if (getX() + h >= width || getX2() >= width || getX3() >= width || _x4 + h >= width)
                        {
                            break;
                        }
                        else
                        {
                            setX(getX() + h);
                            setX2(getX2() + h);
                            setX3(getX3() + h);
                            _x4 += h;
                        }
                        break;
                    }
            }
            DrawRectangle(gfx);
        }


    }


    //Окружность
    class tCircle: tPoint
    {
        private int _r;
        private int _width;

        public tCircle() : base(0,0,Color.Black)
        {
            _r = 0;
            _width = 0;
        }

        public tCircle( int x, int y, int r, Color color, int width): base(x, y, color)
        {
            _r = r;
            _width = width;
        }

        public int getR()
        {
            return _r;
        }
        public void setR(int r)
        {
            if (r > 0) _r = r;
        }

        public int getWidth()
        {
            return _width;
        }
        public void setWidth( int width)
        {
            if (_width > 0) _width = width;
        }

        public void DrawCircle(Graphics gfx)
        {
            Pen pen = new Pen ()
        }
    }
   
}


