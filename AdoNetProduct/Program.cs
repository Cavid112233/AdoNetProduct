using AdoNetProduct.Controllers;

namespace AdoNetProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductController productController = new ProductController();
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("Secim edin:");
                Console.WriteLine("1. Product elave edin");
                Console.WriteLine("2. Productlari gosder");
                Console.WriteLine("3. Productda guncelleme et");
                Console.WriteLine("3. Proqramdan çıx");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        productController.AddProduct();
                        break;
                    case "2":
                        productController.GetAllProducts();
                        break;
                    case "3":
                        productController.UpdateProduct();
                        break;
                    default:
                        Console.WriteLine("Duzgun secim edin!");
                        break;
                }
            }
        }
    }
}
