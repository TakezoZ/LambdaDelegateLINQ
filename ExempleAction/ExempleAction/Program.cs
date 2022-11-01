using ExempleAction.Entities;

namespace ExempleAction
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

            Action<Product> act = p => { p.Price += p.Price * 0.10; }; //Quando a função possui corpo mas não retorna nada. Void

            list.ForEach(act);
            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }

        }

        static void UpdatePrice(Product product)
        {
            product.Price += product.Price * 0.10;
        }
    }
}