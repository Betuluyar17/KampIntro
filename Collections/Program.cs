using System;
using System.Collections.Generic;
using System.Threading;


//10.02.2025

namespace Collections
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //stack            = heap
            //string[] isimler = new string[] { "Betül", "Ali", "Fatma", "Songül" };
            
            //foreach (string s in isimler) 
            //{
            //    Console.WriteLine(s);
            //}

            //1. yazım şekli
            //List<string> isimler2 = new List<string>();
            //isimler2.Add("Betül");
            //isimler2.Add("Ali");

            //2. yazım şekli
            List<string> list = new List<string> { "Betül", "Ali" };
            list.Add("Fatma");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadLine();
        }
    }
}
