using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
            //product.ProductName = "Kamera";
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }




        //public void BirSeyYap(int sayi)
        //{
        //    sayi = 99;
        //    //Console.WriteLine("Metottan gelen sayı {0}", sayi);
        //}


        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
    }
}
