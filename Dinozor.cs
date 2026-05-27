using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static OOP.Program;

namespace ConsoleApp7
{
   internal  class Dinozor : Hayvan
    {
        public Dinozor(string ad, string ses) : base(ad, ses)
        {
        }

        public override void SesCikar()
        {
         
            Console.WriteLine(Ses);
             

        }

    }
}
