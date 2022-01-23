using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_CW_05._12._21
{
    class Foo
    {
        private int bar;

        public Foo()
        {
            bar = 0;
        }
        public Foo(int bar)
        {
            this.bar = bar;
        }

        //свойства класса
        public int Bar {get; set;}

        //статические члены класса Bar
        //статическое поле
        private static int static_bar = 10;

        //статические методы
        public static void StaticBarSpam()
        {
            for (int i = 0;i<static_bar; i++)
            {
                Console.WriteLine("BAR!");
            }
        }
        public static int StaticBar
        {
            set { static_bar = value; }
        }
        //статический конструктор
    static Foo()
    {
            static_bar = 3;

    }
    }
}
