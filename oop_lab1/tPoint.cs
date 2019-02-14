using System.Drawing;

namespace oop_lab2
{
    abstract class tShape
    {
        public int stepX { get; set; }
        public int stepY { get; set; }
        public abstract void Move();
        public abstract bool CheckRange(int width, int height);
        public abstract void Draw(Graphics gfx);
        public abstract void Hide(Graphics gfx, Color bg);

    }

    class tPoint : tShape
    {
        private Color _color = Color.Black;
        private int _x = 0;
        private int _y = 0;
        private int _size = 1;

        // конструкторы
        public tPoint() : this(0, 0, Color.Black,1) { }

        public tPoint(int x, int y, Color color, int size) // со всеми параметрами
        {
            _x = x;
            _y = y;
            _color = color;
            _size = size;
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

        public int getSize()
        {
            return _size;
        }

        public void setSize(int size)
        {
            if (size > 0) _size = size;
        }

        public override void Draw(Graphics gfx)
        {
            Pen pen = new Pen(getColor(), getSize());
            gfx.DrawLine(pen, getX(), getY(), getX(), getY());
        }

        public override void Hide(Graphics gfx, Color bg)
        {
            Pen pen = new Pen(bg, getSize());
            gfx.DrawLine(pen, getX(), getY(), getX(), getY());
        }

        public override void Move()
        {
            _x += stepX;
            _y += stepY;
        }

        public override bool CheckRange(int width, int height)
        {
            if( getX() + stepX > width || getX() + stepX < 0) return false;
            if (getY() + stepY > height || getY() + stepY < 0) return false;
            return true;
        }
        

    }


    //Отрезок
    class tLine: tPoint
    {
        private int _x2 = 0;
        private int _y2 = 0;    // конец отрезка

        // конструкторы
        public tLine(int x, int y, int x2, int y2, Color color, int size) : base(x, y, color, size)
        {
            _x2 = x2;
            _y2 = y2;
        }

        public tLine(): base (0,0,Color.Black, 1){ }

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

        //Метод рисования линии
        public override void Draw(Graphics gfx)
        {
            Pen pen = new Pen(getColor(), getSize());
            gfx.DrawLine(pen, getX(), getY(), getX2(), getY2());
        }

        // Метод стиания линии
        public override void Hide(Graphics gfx, Color bg)
        {
            Pen pen = new Pen(bg, getSize());
            gfx.DrawLine(pen, getX(), getY(), getX2(), getY2());
        }

        // движение отрезка
        public override void  Move()
        {
            setX(getX() + stepX);
            setY(getY() + stepY);
            setX2(getX2() + stepX);
            setY2(getY2() + stepY);         
        }

        public override bool CheckRange(int width, int height)
        {
            if (getX() + stepX >= width || getX() + stepX <= 0 || getX2() + stepX <= 0 || getX2() + stepX >= width) return false;
            if (getY() + stepY >= height || getY() + stepY <= 0 || getY2() + stepY <= 0 || getY2() + stepY >= height) return false;
            return true;
        }

    }


    //Треугольник
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

        public override void Draw(Graphics gfx)
        {
            Pen pen = new Pen(getColor(), getSize());
            for( int i = 0; i < 3; i++)
            {
                gfx.DrawLine(pen, getX(), getY(), getX2(), getY2());
                gfx.DrawLine(pen, getX(), getY(), getX3(), getY3());
                gfx.DrawLine(pen, getX2(), getY2(), getX3(), getY3());
            }
        }

        public override void Hide(Graphics gfx, Color bg)
        {
            Pen pen = new Pen(bg, getSize());
            for (int i = 0; i < 3; i++)
            {
                gfx.DrawLine(pen, getX(), getY(), getX2(), getY2());
                gfx.DrawLine(pen, getX(), getY(), getX3(), getY3());
                gfx.DrawLine(pen, getX2(), getY2(), getX3(), getY3());
            }
        }

        public override void Move()
        {
            setX(getX() + stepX);
            setY(getY() + stepY);
            setX2(getX2() + stepX);
            setY2(getY2() + stepY);
            setX3(getX3() + stepX);
            setY3(getY3() + stepY);
        }

        public override bool CheckRange(int width, int height)
        {
            if (getX() + stepX >= width || getX2() + stepX >= width || getX3() + stepX >= width
                                    || getX() + stepX <= 0 || getX2() + stepX <= 0 || getX3() + stepX <= 0) return false;

            if (getY() + stepY >= height || getY2() + stepY >= height || getY3() + stepY >= height
                || getY() + stepY <= 0 || getY2() + stepY <= 0 || getY3() + stepY <= 0) return false;
            return true;

        }

    }


    //Прямоугольник
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
        public tRectangle(int x1, int y1, int x2, int y2, int x3, int y3, Color color, int size) : base(x1, y1, x2, y2, color, size)
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


        public override void Hide(Graphics gfx, Color bg)
        {
            Pen pen = new Pen(bg, getSize());
            for (int i = 0; i < 3; i++)
            {
                gfx.DrawLine(pen, getX(), getY(), getX2(), getY2());
                gfx.DrawLine(pen, getX(), getY(), getX4(), getY4());
                gfx.DrawLine(pen, getX2(), getY2(), getX3(), getY3());
                gfx.DrawLine(pen, getX4(), getY4(), getX3(), getY3());
            }
        }

        public override void Draw(Graphics gfx)
        {
            Pen pen = new Pen(getColor(), getSize());
            for (int i = 0; i < 3; i++)
            {
                gfx.DrawLine(pen, getX(), getY(), getX2(), getY2());
                gfx.DrawLine(pen, getX(), getY(), getX4(), getY4());
                gfx.DrawLine(pen, getX2(), getY2(), getX3(), getY3());
                gfx.DrawLine(pen, getX4(), getY4(), getX3(), getY3());
            }
        }

        public override void Move()
        {
            setX(getX() + stepX);
            setY(getY() + stepY);
            setX2(getX2() + stepX);
            setY2(getY2() + stepY);
            setX3(getX3() + stepX);
            setY3(getY3() + stepY);
            setX4(getX4() + stepX);
            setY4(getY4() + stepY);
        }

        public override bool CheckRange(int width, int height)
        {
            if (getX()+stepX >= width || getX2() + stepX >= width || getX3() + stepX >= width || getX4() + stepX >= width
                                    || getX() + stepX <= 0 || getX2() + stepX <= 0 || getX3() + stepX <= 0 || getX4() + stepX <= 0) return false;

            if (getY() + stepY >= height || getY2() + stepY >= height || getY3() + stepY >= height || getY4() + stepY >= height
                || getY() + stepY <= 0 || getY2() + stepY <= 0 || getY3() + stepY <= 0 || getY4() + stepY <= 0) return false;
            return true;

        }


    }


    //Окружность
    class tCircle: tPoint
    {
        private int _r = 0;

        public tCircle() : base(0,0,Color.Black, 1) {}

        public tCircle( int x, int y, int r, Color color, int size): base(x, y, color, size)
        {
            _r = r;
        }

        public int getR()
        {
            return _r;
        }
        public void setR(int r)
        {
            if (r > 0) _r = r;
        }

        public override void Draw(Graphics gfx)
        {
            Pen pen = new Pen(getColor(), getSize());
            gfx.DrawEllipse(pen, getX(), getY(), getR(), getR());
        }

        public override void Hide(Graphics gfx, Color bg)
        {
            Pen pen = new Pen(Color.White, getSize());
            gfx.DrawEllipse(pen, getX(), getY(), getR(), getR());
        }

        public override void Move()
        {
            setX(getX() + stepX);
            setY(getY() + stepY);
        }

        public override bool CheckRange(int width, int height)
        {
            if (getX()+stepX + getR() >= width || getX()+stepX <= 0) return false;

            if (getY()+stepY + getR() >= height || getY()+stepY <= 0) return false;
            return true;

        }

    }


    //Эллипс
    class tEllipse: tCircle
    {
        private int _r2 = 0;

        public tEllipse() : base() { }
        public tEllipse(int x, int y, int r, int r2, Color color, int size) : base(x, y, r, color, size)
        {
            _r2 = r2;
        }

        public int getR2()
        {
            return _r2;
        }
        public void setR2(int r2)
        {
            _r2 = r2;
        }

        public override void Draw(Graphics gfx)
        {
            Pen pen = new Pen(getColor(), getSize());
            gfx.DrawEllipse(pen, getX(), getY(), getR(), getR2());
        }

        public override void Hide(Graphics gfx, Color bg)
        {
            Pen pen = new Pen(Color.White, getSize());
            gfx.DrawEllipse(pen, getX(), getY(), getR(), getR2());
        }

        public override bool CheckRange(int width, int height)
        {
            if (getX() + stepX + getR() >= width || getX() + stepX <= 0) return false;

            if (getY() + stepY + getR2() >= height || getY() + stepY <= 0) return false;
            return true;

        }

    }
   
}


