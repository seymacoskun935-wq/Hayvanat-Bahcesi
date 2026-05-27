using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Hayvan
    {
        public    string Ad { get; set; }
        public   string Ses { get; set; }
        public   bool AcMi = true;


        public Hayvan(string ad, string ses)
        {
            Ad = ad;
            Ses = ses;
        }
        public virtual void SesCikar()
        {
            Console.WriteLine(Ses);
        }
    }
}
