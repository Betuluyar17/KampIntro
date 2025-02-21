using System;

//10.02.2025

namespace OOP1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { 
                Id = 2, 
                CategoryId = 5,
                ProductName = "Kalem",
                UnitPrice = 35,
                UnitInStock = 5 
                };
            
            //NOTES

            //PascalCase : ProductManager class gibi kullandığımız sınıfların genel tabiridir.
            //camelCase : Bir sınıftan bir değişken oluşturulduğunda kullanılan tabirdir. (Örn: productManager)
            //case Sensitive : Bir class oluşturulurken isimlendirilmelerinin büyük küçük harf duyarlılığına uygun oluşturulması kavramıdır.
            //Bir class'ın stack'ta oluşan referans değerinin içeriğinin heap'te oluşabilmesi için o class new'lenmelidir. (Örn: ProductManager productManager = new ProductManager();) 
            
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            
            //int sayi = 100;
            //productManager.BirSeyYap(sayi);
            //Console.WriteLine(sayi);
            //Console.WriteLine(product1.ProductName);

            //int toplama = productManager.Topla(3, 4);
            //Console.WriteLine("topla metodu {0}", toplama);

            Console.ReadLine();
        }
    }
}
