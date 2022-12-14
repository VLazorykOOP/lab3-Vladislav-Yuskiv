using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Corvette : Ship
    {
        public IEnumerable<string> Weapons { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Weapons: ");
            foreach (string weapon in Weapons)
                Console.WriteLine(weapon);
        }
    }
}
