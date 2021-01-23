using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class ProductManager
    {
        //encapsulation
        //void - 
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }


        public void Update(Product product) 
        {

            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        // int çıkan sonucu kodun devamında da kullanmana olanak verir
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;

        }
        //void yapar bitirir
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);

        }


    }
}
