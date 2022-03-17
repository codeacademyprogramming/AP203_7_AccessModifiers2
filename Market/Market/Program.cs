using Classes;
using System;

namespace Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1Str = Console.ReadLine();
            int num1 = Convert.ToInt32(num1Str);

            string num2Str = Console.ReadLine();
            int num2 = Convert.ToInt32(num2Str);

            //if (num2 == 0)
            //    throw new Exception("Qaqa, 0-a bolme yoxdur!");

            try
            {
                int resul = num1 / num2;
                Console.WriteLine(resul);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Xeta mesaji: {ex.Message}");
                Console.WriteLine("Evvelki prosesde xeta bas verdi, diger prosesler davam edir...");
            }
            finally
            {
                Console.WriteLine("Try-catch bolku bitdi!");
            }







            Product product1 = new Product
            {
                Category = "Bakery",
                Name = "Corek",
                Price = -1
            };

            Product product2 = new Product
            {
                Category = "Un mehsullari",
                Name = "Torm",
                Price = 12
            };

            Product product3 = new Product
            {
                Category = "Ickiler",
                Name = "CocaCola 1L",
                Price = 1.1
            };

            Product product4 = new Product
            {
                Category = "Et ve et mehsullari",
                Name = "Quzu 1kg",
                Price = 17
            };

            Product product5 = new Product
            {
                Category = "Et ve et mehsullari",
                Name = "Mal eti 1kg",
                Price = 14
            };

            Store elovsetMarket = new Store(4);
            elovsetMarket.Name = "Elovset Super Market";
            elovsetMarket.WorkerCount = 2;


            try
            {
                elovsetMarket.AddProduct(product1);
                elovsetMarket.AddProduct(product2);
                elovsetMarket.AddProduct(product3);
                elovsetMarket.AddProduct(product4);
                elovsetMarket.AddProduct(product5);
            }
            catch (Exception)
            {
                Console.WriteLine("Mehsul limit doldu, yeni product elave ede bilmezsiniz!");
            }
         



            Console.WriteLine("Bizim mehsullar:");
            foreach (var item in elovsetMarket.Products)
            {
                Console.WriteLine($"Mehsul: {item.Name} - Kateqoriya: {item.Category} - Qiymet: {item.Price}");
            }

        }
    }
}
