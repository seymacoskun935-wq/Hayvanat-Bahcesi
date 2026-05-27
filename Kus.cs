using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Kus: Hayvan,IUcabilenCanlilar 
    {
        public Kus(string ad, string ses) : base(ad, ses)
        {
        }
        public void Ucan()
        {
            Console.WriteLine($"{Ad} uçuyor");
        }
    }
}
