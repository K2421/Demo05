using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class CD
    {
            private List<Biisi> cd;

            public string Artist { get; set; }
            public string CDName { get; set; }

     
        public CD()
        {
            cd = new List<Biisi>();
        }

        public void AddBiisi(Biisi biisi)
        {
            cd.Add(biisi);
        }

  
    

        public void PrintData()
        {
            Console.WriteLine(" CD DATA: ");
            Console.WriteLine();
            Console.WriteLine(Artist + " - " + CDName);

            foreach (Biisi biisi in cd)
            {
                Console.WriteLine(biisi.ToString());
            }
        }
    }
}

