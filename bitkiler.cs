using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismVeSealed_class
{
    class bitkiler:canlilar
    {
        public override void uyaranlaraTepki()
        {
            base.uyaranlaraTepki();
            Console.WriteLine("bitkiler gunese tepki verir.");
        }
    }

}
