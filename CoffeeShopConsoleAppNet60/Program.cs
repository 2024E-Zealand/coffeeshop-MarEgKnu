// See https://aka.ms/new-console-template for more information

using CoffeeShopConsoleAppNet60;

List<Coffee> coffeeList = new List<Coffee>
{
    new BlackCoffee(1),
    new Cortado(2),
    new Cortado(3),
    new Latte(20)
};

foreach (Coffee coffee in coffeeList)
{
    Console.WriteLine(coffee.Strength());
    Console.WriteLine(coffee.Price());
}

List<IMilk> milkCoffeeList = new List<IMilk>
{
    new Cortado(2),
    new Cortado(3),
    new Latte(20)
};
