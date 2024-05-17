using ContosoPizza.Data;
using ContosoPizza.Models;

using ContosoPizzaContext context = new ContosoPizzaContext();

var meatPizza = context.Products
                       .Where(p => p.Id == 4)
                       .FirstOrDefault();

if (meatPizza is Product)
{
   Console.WriteLine($"pizza: {meatPizza.Id}");
   context.Remove(meatPizza);
}

var products = context.Products
                    .Where(p => p.Price > 10.00M)
                    .OrderBy(p => p.Name);

foreach (Product p in products)
{
   Console.WriteLine($"Id:    {p.Id}");
   Console.WriteLine($"Name:  {p.Name}");
   Console.WriteLine($"Price: {p.Price}");
   Console.WriteLine(new string('-', 20));
}

context.SaveChanges();