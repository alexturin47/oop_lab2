using System.Drawing;
using System.Collections.Generic;

namespace oop_lab2
{   
    abstract class tFigure
    {
        private Color _color;
        private int _width;

        public tFigure()
        {
            Color = Color.Black;
            Width = 0;
        }

        public tFigure(Color clr, int width)
        {
            Color = clr;
            Width = width;
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public int Width
        {
            get { return _width; }
            set { if (value >= 0) _width = value; }
        }

        public abstract void Draw(Graphics gfx);
        public abstract void Hide(Graphics gfx, Color bg);
        public abstract void Move(int stepX, int stepY);

    }

    class tPoint : tFigure
    {
        private int _x = 0;
        private int _y = 0;

        // конструкторы
        public tPoint() { }

        public tPoint(int x, int y) 
        {
            X = x;
            Y = y;
        }
        
        public int X
        {
            get { return _x; }
            set {
                if (value >= 0) _x = value;
            }
        }
        public int Y
        {
            get { return _y; }
            set
            {
                if (value >= 0) _y = value;
            }
        }
        

        public override void Draw(Graphics gfx)
        {
            throw new System.NotImplementedException();
        }
        public override void Hide(Graphics gfx, Color bg)
        {
            throw new System.NotImplementedException();
        }
        public override void Move(int stepX, int stepY)
        {
            X += stepX;
            Y += stepY;
        }

    }


    //Отрезок
    class tLine: tFigure
    {
        public tPoint A { get; set; }
        public tPoint B { get; set; }

        // конструкторы
        public tLine(int x1, int y1, int x2, int y2, Color color, int size) : base(color,size)
        {
            A = new tPoint(x1, y1);
            B = new tPoint(x2, y2);
        }

        public tLine() : base()
        {
            A = new tPoint(0,0);
            B = new tPoint(0,0);
        }

       /* public int x1
        {
            get { return _a.X; }
            set { _a.X = value; }
        }

        public int y1
        {
            get { return _a.Y; }
            set { _a.Y = value; }
        }

        public int x2
        {
            get { return _a.X; }
            set { _a.X = value; }
        }

        public int y2
        {
            get { return _b.Y; }
            set { _b.Y = value; }
        }
        */
        // методы установки и получения параметров 

        /*public int getX2()
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
        */

        //Метод рисования линии
        public override void Draw(Graphics gfx)
        {
            Pen pen = new Pen(Color, Width);
            gfx.DrawLine(pen,A.X ,A.Y, B.X, B.Y);
        }

        // Метод стиания линии
        public override void Hide(Graphics gfx, Color bg)
        {
            Pen pen = new Pen(bg, Width);
            gfx.DrawLine(pen, A.X, A.Y, B.X, B.Y);
        }

        public override void Move(int stepX, int stepY)
        {
            A.Move(stepX, stepY);
            B.Move(stepX, stepY);
         
        }

    }


    //Треугольник
    class tTriangle : tLine
    {
        //private int _x3;
        //private int _y3;

        // Конструторы

        public tTriangle() : base(0, 0, 0, 0, Color.Black,0)
        {
            setPoint(0, 0);
            //_x3 = 0;
            //_y3 = 0;
        }

        public tTriangle(int x1, int y1, int x2, int y2, int x3, int y3, Color color, int width) : base(x1, y1, x2, y2, color, width)
        {
            setPoint(x3, y3);
            //_x3 = x3;
            //_y3 = y3;
        }

        // методы установки.получения параметров
    /*    public int getX3()
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
    */
        public void DrawTriangle(Graphics gfx)
        {
            Pen pen = new Pen(getColor(), getSize());
            for( int i = 0; i < 3; i++)
            {
                gfx.DrawLine(pen, getX(0), getY(0), getX(1), getY(1));
                gfx.DrawLine(pen, getX(0), getY(0), getX(2), getY(2));
                gfx.DrawLine(pen, getX(1), getY(1), getX(2), getY(2));
            }
        }

        public void HideTriangle(Graphics gfx)
        {
            Pen pen = new Pen(Color.White, getSize());
            for (int i = 0; i < 3; i++)
            {
                gfx.DrawLine(pen, getX(0), getY(0), getX(1), getY(1));
                gfx.DrawLine(pen, getX(0), getY(0), getX(2), getY(2));
                gfx.DrawLine(pen, getX(1), getY(1), getX(2), getY(2));
            }
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
            setPoint(0, 0);
            setPoint(0, 0); 
           // _x3 = 0;
           // _y3 = 0;
           // _x4 = 0;
           // _y4 = 0;
        }
        public tRectangle(int x1, int y1, int x2, int y2, int x3, int y3, Color color, int size) : base(x1, y1, x2, y2, color, size)
        {
            setPoint(x3, y3);
            setPoint(x1, y3);
            //_x3 = x3;
            //_y3 = y3;
           // _x4 = x1;
            //_y4 = y3;
        }

     /*   public void setX3( int x)
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
    */

        public void HideRectangle(Graphics gfx)
        {
            Pen pen = new Pen(Color.White, getSize());
            for (int i = 0; i < 3; i++)
            {
                gfx.DrawLine(pen, getX(0), getY(0), getX(1), getY(1));
                gfx.DrawLine(pen, getX(0), getY(0), getX(3), getY(3));
                gfx.DrawLine(pen, getX(1), getY(1), getX(2), getY(2));
                gfx.DrawLine(pen, getX(3), getY(3), getX(2), getY(2));
            }
        }

        public void DrawRectangle(Graphics gfx)
        {
            Pen pen = new Pen(getColor(), getSize());
            for (int i = 0; i < 3; i++)
            {
                gfx.DrawLine(pen, getX(0), getY(0), getX(1), getY(1));
                gfx.DrawLine(pen, getX(0), getY(0), getX(3), getY(3));
                gfx.DrawLine(pen, getX(1), getY(1), getX(2), getY(2));
                gfx.DrawLine(pen, getX(3), getY(3), getX(2), getY(2));
            }
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

        public void DrawCircle(Graphics gfx)
        {
            Pen pen = new Pen(getColor(), getSize());
            gfx.DrawEllipse(pen, getX(0), getY(0), getR(), getR());
        }

        public void HideCircle(Graphics gfx)
        {
            Pen pen = new Pen(Color.White, getSize());
            gfx.DrawEllipse(pen, getX(0), getY(0), getR(), getR());
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

        public void DrawEllipse(Graphics gfx)
        {
            Pen pen = new Pen(getColor(), getSize());
            gfx.DrawEllipse(pen, getX(0), getY(0), getR(), getR2());
        }

        public void HideEllipse(Graphics gfx)
        {
            Pen pen = new Pen(Color.White, getSize());
            gfx.DrawEllipse(pen, getX(0), getY(0), getR(), getR2());
        }

 
    }
   
}


