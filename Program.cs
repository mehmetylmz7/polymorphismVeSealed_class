using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismVeSealed_class
{
    class Program
    {
        static void Main(string[] args)
        {
            hayvanlar kopek = new hayvanlar();
            kopek.uyaranlaraTepki();
            Console.WriteLine("**************");
            bitkiler cicek = new bitkiler();
            cicek.uyaranlaraTepki();

            // sealed : bir sinifin alt siniflara kalitim vermesini engeller
            // ornek kullanim
            // public sealed class canlilar 


            Console.ReadLine();
        }
    }
}
