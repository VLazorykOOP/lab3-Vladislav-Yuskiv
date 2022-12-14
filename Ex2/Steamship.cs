using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Lab2
{
    internal class Steamship : Ship
    {
        public int SeatsCount { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Seats count: {SeatsCount}");
        }
    }
}
