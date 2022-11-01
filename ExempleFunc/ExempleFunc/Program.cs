using ExempleAction.Entities;

namespace ExempleFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Func<Product, string> func = NameUpper;

            // List<string> result = list.Select(p => p.Name.ToUpper()).ToList(); --Metodo Lambda
            List<string> result = list.Select(func).ToList();


            foreach (string product in result)
            {
                Console.WriteLine(product);
            }
        }

        static string NameUpper(Product product)
        {
            return product.Name.ToUpper();
        }
    }
}