using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_CW_05._12._21
{
    class Program
    {
        interface IDiggingCapable
        {
            //описание методов, которые нужно реализовать в наследниках
            void dig();
        }
        // имплементация интерфейса-должен реализовывать все методы интерфейса
        class Man: IDiggingCapable
        {
            public void dig()
            {
                Console.WriteLine("Man is digging");
            }
        }
        class Tractor :IDiggingCapable
        {
            public void dig()
            {
                Console.WriteLine("Tractor is digging with scoop");
            }
        }

        static void DigBigCrater (IDiggingCapable[] resources)
        {
            foreach (IDiggingCapable resource in resources)
                resource.dig();
        }
        static void Task1()
        {
            Foo foo = new Foo();
            foo.Bar = 10;
            Console.WriteLine(foo.Bar);
            Foo.StaticBar = 3;
            Foo.StaticBarSpam();
        }
        static void Task2()
        {
            
            Rectangle rect = new Rectangle("Test", 2,3);
            //Console.WriteLine(rect.GetDiagonal());
            //rect.Draw();
            //Console.WriteLine(rect.ToString());
            //приведение наследник к базовому классу
            //figure = rect;
            //figure.Name = "Key";
            //Console.WriteLine(rect.Name);
            //Shape figure = rect;
            //figure.Draw();
            ConsoleDraw(rect);

        }
        static void Task3()
        {
            Man man = new Man();
            //man.dig();
            Tractor tractor = new Tractor();
            //tractor.dig();

            IDiggingCapable[] digCrew = new IDiggingCapable[2] { man, tractor };
            DigBigCrater(digCrew);
        }
         
        static void ConsoleDraw(IDrawable drawable)

        {
            drawable.Draw();
            drawable.Print();
        }
        static void Main(string[] args)
        {
            Task2();
        }
    }
}
