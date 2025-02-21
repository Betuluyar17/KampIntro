using System;

//10.02.2025

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Betül");
            isimler.Add("Ali");

            Console.WriteLine("MyList Length : "+ isimler.Length);
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
