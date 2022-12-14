using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Ship : IComparable<Ship>
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }

        public int CompareTo(Ship? other)
        {
            return this.GetType().ToString().CompareTo(other.GetType().ToString());
        }

        public virtual void Show()
        {
            Console.WriteLine($"this is a {this.GetType()} {Name} with max speed of {MaxSpeed} knots/h");
        }
    }
}
