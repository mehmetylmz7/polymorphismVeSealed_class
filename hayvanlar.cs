using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismVeSealed_class
{
    class hayvanlar:canlilar
    {
        public override void uyaranlaraTepki()
        {
            base.uyaranlaraTepki();
            Console.WriteLine("hayvanlar temasa tepki verir.");
        }
    }
}
