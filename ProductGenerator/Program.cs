using ProductGenerator.Entities;

namespace ProductGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
                List<Product> productList = new List<Product>();

                Console.Write("Enter the number of products: ");
                int numberOfProducts = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numberOfProducts; i++)
                {
                    Console.WriteLine($"Product #{i} data: ");

                    Console.Write("Common, used or imported (c/u/i)? ");
                    char response = char.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    string productName = Console.ReadLine();
                    Console.Write("Price: ");
                    double productPrice = double.Parse(Console.ReadLine());

                    if (response == 'c')
                    {
                        productList.Add(new Product(productName, productPrice));
                    }
                    else if (response == 'u')
                    {
                        Console.Write("Manufacture date (MM/DD/YYYY): ");
                        DateTime dateTime = DateTime.Parse(Console.ReadLine());

                        productList.Add(new UsedProduct(productName, productPrice, dateTime));
                    }
                    else
                    {
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine());

                        productList.Add(new ImportedProduct(productName, productPrice, customsFee));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Price tags: ");

                foreach (Product prod in productList)
                {
                    Console.WriteLine($"{prod.Name} ${prod.PriceTag()}");
                }
        }
    }
}
