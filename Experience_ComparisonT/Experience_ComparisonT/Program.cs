using Experience_ComparisonT.Entities;

namespace Experience_ComparisonT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
            // (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()) Expressão Lambda

            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }
        }
    }
}