using System.Collections.Immutable;
using System.Security.Cryptography;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ship> ships = CreateSomeShips().ToList();

            ships.Sort();

            foreach (Ship ship in ships)
            {
                ship.Show();
                Console.WriteLine();
            }
        }

        private static IEnumerable<Ship> CreateSomeShips()
        {
            return new List<Ship>()
            {
                new Sailboat ()
                {
                    Name = "MySailboat",
                    MaxSpeed = 50,
                    SailBoatType = SailBoatType.Cutter
                },
                new Steamship ()
                {
                    Name = "MySteamship",
                    MaxSpeed = 15,
                    SeatsCount = 1500
                },
                new Corvette()
                {
                    Name = "MyCorvette",
                    MaxSpeed = 25,
                    Weapons = new List<string>() { "MG-42", "Grad-M" }
                },
            };
        }
    }
}