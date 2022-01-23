using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_CW_05._12._21
{
    //класс-наследник фигуры - прямоугольника
    class Rectangle : Shape, IDrawable
    {
        private double a, b; //стороны прямоугольника

        //конструктор
        public Rectangle():base()
        {
            a = b = 0;
        }

        public Rectangle(string name, double a, double b) : base (name, (a+b)*2,a*b)
        {
            this.a=a;
            this.b = b;
        }

        //метод ToString

        public override string ToString()
        {
            return base.ToString() + $", a = {a}, b = {b}";
        }

        //метод печати на консоли псевдографикой
        public void Draw()
        {
            for (int i = 0; i<b; i++)
            {
                for (int j =0;j<a;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        //метод вывода Tostring 
        public void Print()
        {
            Console.WriteLine(ToString());
        }
        //метод получения диагонали

        public double GetDiagonal () { return Math.Sqrt(a * a + b * b); }

        //абстракный метод
        public override void updatePS()
        {
            p = (a + b) * 2;
            s = a * b;
        }
    }
}
