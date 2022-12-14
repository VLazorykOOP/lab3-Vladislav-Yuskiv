using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    enum SailBoatType
    {
        Cutter = 0,
        Catboat,
        Dinghy,
        Ketch,
        Schooner,
        Sloop,
        Yawl
    };

    internal class Sailboat : Ship
    {
        public SailBoatType SailBoatType { get; set; }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Sailboat type: {SailBoatType}");
        }
    }
}
