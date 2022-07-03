using System;
using Bakery.Models;


public class Customer
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("---------------------------");
    Console.WriteLine("We have bread and pastries for sale today.");
    Console.WriteLine("Today our bread is $5 or you can buy 2 and get 1 free!");
    Console.WriteLine("And for today only, if you order 25 loaves or more they are only $1 each!");
    Console.WriteLine("Our pastries today are $2, or 3 for $5.");
    Console.WriteLine("How many loaves of bread would you like today?");
    int loaves = int.Parse(Console.ReadLine());
    Console.WriteLine($"{loaves} loaves? How many pastries would you like to add to your order today?");
    int sweets = int.Parse(Console.ReadLine());

    Bread loafOrder = new Bread(loaves);
    Pastry sweetOrder = new Pastry(sweets);

    Console.WriteLine($"Ok that's {loaves} loaves of bread, and {sweets} pastries");
    Console.WriteLine($"Your order total is ${loafOrder.OrderTotal() + sweetOrder.OrderTotal()}");
  }
}