using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_CW_05._12._21
{
    //базовый класс фигуры
    abstract class Shape
    {
        protected string name;
        protected double p; //периметр
        protected double s; //площадь

        public double P { get { return p; } }
        public double S { get { return s; } }
        public string Name { get; set; }
        //конструкторы
        public Shape ()
        {
            name = "Empty";
            p = s = 0;
        }
        public Shape (string name, double p, double s)
        {
            Name = name;
            this.p = p;
            this.s = s;
        }

        //методы

        public override string ToString()
        {
            return Name + ": P = " + P.ToString() +", S= " + S.ToString();
        }

        //public void Draw()
        //{
        //    Console.WriteLine($"Can't draw : {ToString()}");
        //}

        //абстракный метод
        public abstract void updatePS();

    }
}
