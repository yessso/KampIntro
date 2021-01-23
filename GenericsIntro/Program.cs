using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

            MyList<int> yaslar = new MyList<int>();
            yaslar.Add(10);
        }
    }
}
