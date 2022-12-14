namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // better use initializer list for this
            Money money = new(nominal: 50, amount: 3);

            Console.WriteLine(money.GetInfo());
            Console.WriteLine(money.Sum);
            Console.WriteLine(money.IsEnoughToBuy(30));
            Console.WriteLine(money.IsEnoughToBuy(300));
            Console.WriteLine(money.HowManyIsPossibleToBuy(40));
        }
    }
}